using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.Models;
using Oracle.DataAccess.Client;
using System.Configuration;

namespace WindowsFormsApp2.Forms
{
    /// <summary>
    /// 커뮤니티 관리 폼
    /// </summary>
    public partial class CommunityManagementForm : Form
    {
        // DBClass 인스턴스
        DBClass db = new DBClass();

        // 수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다. (DB PK)
        private int SelectedPostId;

        public CommunityManagementForm()
        {
            InitializeComponent();
            cmbFilterCategory.SelectedIndex = 0; // 기본값을 "전체"로 설정
            DB_Open();
            LoadPostData();
            UpdateCommunityStats();
        }

        private void DB_Open()
        {
            try
            {
                string commandString = "select id, title, author_id, post_type, created_at, views_count, comments_count from posts";
                db.DB_Open(commandString, "posts");

                // PK 설정
                DataColumn[] PrimaryKey = new DataColumn[1];
                PrimaryKey[0] = db.ResultTable.Columns["id"];
                db.ResultTable.PrimaryKey = PrimaryKey;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// 게시글 데이터 로드
        /// </summary>
        /// <summary>
        /// 게시글 데이터 로드 (DB에서 가져오기)
        /// </summary>
        private void LoadPostData()
        {
            try
            {
                db.DBAdapter.Fill(db.DS, "posts");
                db.ResultTable = db.DS.Tables["posts"];

                RefreshListView();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        /// <summary>
        /// ListView 갱신 (DataTable의 DefaultView 기준)
        /// </summary>
        private void RefreshListView()
        {
            communityListView.Items.Clear();
            foreach (DataRowView rowView in db.ResultTable.DefaultView)
            {
                DataRow row = rowView.Row;
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["title"].ToString());
                item.SubItems.Add(row["author_id"].ToString());
                item.SubItems.Add(row["post_type"].ToString());
                DateTime date = row["created_at"] != DBNull.Value ? Convert.ToDateTime(row["created_at"]) : DateTime.MinValue;
                item.SubItems.Add(date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(row["views_count"].ToString());
                item.SubItems.Add(row["comments_count"].ToString());
                communityListView.Items.Add(item);
            }
        }

        /// <summary>
        /// 커뮤니티 통계 업데이트
        /// </summary>
        private void UpdateCommunityStats()
        {
            if (db.ResultTable == null) return;

            lblTotalPosts.Text = db.ResultTable.Rows.Count.ToString();
            
            object sumViews = db.ResultTable.Compute("Sum(views_count)", "");
            lblTotalViews.Text = (sumViews != DBNull.Value) ? sumViews.ToString() : "0";

            object sumComments = db.ResultTable.Compute("Sum(comments_count)", "");
            lblTotalComments.Text = (sumComments != DBNull.Value) ? sumComments.ToString() : "0";
            
            lblPostListCount.Text = $"게시글 목록          총 {db.ResultTable.Rows.Count}건";
        }

        /// <summary>
        /// DataGridView 행 선택 시 상세 정보 표시
        /// </summary>
        /// <summary>
        /// ListView 행 선택 시 상세 정보 표시
        /// </summary>
        private void communityListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (communityListView.SelectedItems.Count > 0)
            {
                ListViewItem item = communityListView.SelectedItems[0];
                try
                {
                    txtId.Text = item.SubItems[0].Text;
                    txtTitle.Text = item.SubItems[1].Text;
                    txtAuthor.Text = item.SubItems[2].Text;
                    
                    string category = item.SubItems[3].Text;
                    if (cmbCategory.Items.Contains(category))
                        cmbCategory.SelectedItem = category;
                    else
                        cmbCategory.Text = category;
                        
                    db.SelectedKeyValue = Convert.ToInt32(item.SubItems[0].Text);
                    SelectedPostId = db.SelectedKeyValue;
                }
                catch (Exception)
                {
                    // 초기 로딩 등 예외 무시
                }
            }
        }

        /// <summary>
        /// 검색 버튼 클릭
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearchTitle.Text.Trim();
            string selectedCategory = cmbFilterCategory.SelectedItem?.ToString();
            string filter = "";

            if (selectedCategory != null && selectedCategory != "전체")
            {
                filter = $"post_type = '{selectedCategory}'";
            }

            if (!string.IsNullOrEmpty(searchText))
            {
                if (filter.Length > 0) filter += " AND ";
                filter += $"title LIKE '%{searchText}%'";
            }

            db.ResultTable.DefaultView.RowFilter = filter;
            lblPostListCount.Text = $"게시글 목록          총 {db.ResultTable.DefaultView.Count}건";
            RefreshListView();
        }

        /// <summary>
        /// 초기화 버튼 클릭
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchTitle.Text = "";
            cmbFilterCategory.SelectedIndex = 0;
            db.ResultTable.DefaultView.RowFilter = "";
            RefreshListView();
            UpdateCommunityStats();
        }

        /// <summary>
        /// 수정 버튼 클릭
        /// </summary>
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("수정할 게시글을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DataRow currRow = db.ResultTable.Rows.Find(SelectedPostId);
                if (currRow != null)
                {
                    currRow.BeginEdit();
                    currRow["title"] = txtTitle.Text;
                    currRow["post_type"] = cmbCategory.SelectedItem != null ? cmbCategory.SelectedItem.ToString() : currRow["post_type"];
                    // Author 수정은 보통 관리자 권한이거나 본인만 가능하지만 여기선 생략
                    currRow.EndEdit();

                    db.DBAdapter.Update(db.DS, "posts");
                    db.DS.AcceptChanges();

                    UpdateCommunityStats();
                    LoadPostData(); // DB Reload and Refresh ListView
                    MessageBox.Show("게시글 정보가 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        /// <summary>
        /// 삭제 버튼 클릭
        /// </summary>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("삭제할 게시글을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("선택한 게시글을 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    DataRow currRow = db.ResultTable.Rows.Find(SelectedPostId);
                    if (currRow != null)
                    {
                        currRow.Delete();
                        
                        db.DBAdapter.Update(db.DS, "posts");
                        db.DS.AcceptChanges();

                        UpdateCommunityStats();
                        LoadPostData(); // DB Reload and Refresh ListView
                        ClearDetailForm();
                        MessageBox.Show("게시글이 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }

        /// <summary>
        /// 숨김 버튼 클릭
        /// </summary>
        private void btnHide_Click(object sender, EventArgs e)
        {
            MessageBox.Show("숨김 기능은 준비 중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 상세 정보 폼 클리어
        /// </summary>
        private void ClearDetailForm()
        {
            txtId.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";
            cmbCategory.SelectedIndex = -1;
            SelectedPostId = -1;
        }
    }
}
