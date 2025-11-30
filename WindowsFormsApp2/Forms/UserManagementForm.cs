using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp2.Models;
using Oracle.DataAccess.Client;
using System.Configuration;

using WindowsFormsApp2.Services;
using WindowsFormsApp2.Repositories;

namespace WindowsFormsApp2.Forms
{
    /// <summary>
    /// 유저 관리 폼
    /// </summary>
    public partial class UserManagementForm : Form
    {
        // DBClass 인스턴스
        DBClass db = new DBClass();

        // 수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다. (DB PK)
        private string SelectedUserId;

        public UserManagementForm()
        {
            InitializeComponent();
            DB_Open();
            LoadUserData();
            UpdateUserStats();
        }

        private void DB_Open()
        {
            try
            {
                string commandString = "select id, name, email, user_level, created_at, posts_count from users";
                db.DB_Open(commandString, "users");

                // PK 설정 (Find 메서드 사용을 위해)
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
        /// 유저 데이터 로드
        /// </summary>
        /// <summary>
        /// 유저 데이터 로드
        /// </summary>
        /// <summary>
        /// 유저 데이터 로드 (DB Fetch)
        /// </summary>
        /// <summary>
        /// 유저 데이터 로드 (DB Fetch)
        /// </summary>
        private void LoadUserData()
        {
            try
            {
                // Assuming DBClass.DB_Open already fills the data or DBClass has a LoadData method.
                // If DB_Open only sets up the adapter, then we need to explicitly fill here.
                // Based on the provided change, the original LoadUserData already used 'db' objects.
                // So, we just need to ensure db.ResultTable is correctly populated.
                // If db.DB_Open already fills, then these lines might be redundant or need adjustment based on DBClass implementation.
                // For now, keeping the original logic that uses db.DBAdapter and db.DS.
                db.DBAdapter.Fill(db.DS, "users");
                db.ResultTable = db.DS.Tables["users"];

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
        /// ListView 갱신 (DataTable DefaultView 기준)
        /// </summary>
        private void RefreshListView()
        {
            userListView.Items.Clear();
            foreach (DataRowView rowView in db.ResultTable.DefaultView)
            {
                DataRow row = rowView.Row;
                ListViewItem item = new ListViewItem(row["id"].ToString());
                item.SubItems.Add(row["name"].ToString());
                item.SubItems.Add(row["email"].ToString());
                item.SubItems.Add(row["user_level"].ToString());
                // DB Date handling might need check for DBNull
                DateTime date = row["created_at"] != DBNull.Value ? Convert.ToDateTime(row["created_at"]) : DateTime.MinValue;
                item.SubItems.Add(date.ToString("yyyy-MM-dd"));
                item.SubItems.Add(row["posts_count"].ToString());
                userListView.Items.Add(item);
            }
        }

        /// <summary>
        /// 유저 통계 업데이트
        /// </summary>
        private void UpdateUserStats()
        {
            if (db.ResultTable == null) return;

            lblTotalUsers.Text = db.ResultTable.Rows.Count.ToString();

            int adminCount = db.ResultTable.Select("user_level = '관리자'").Length;
            lblAdminCount.Text = adminCount.ToString();

            int moderatorCount = db.ResultTable.Select("user_level = '운영자'").Length;
            lblModeratorCount.Text = moderatorCount.ToString();

            int normalCount = db.ResultTable.Select("user_level = '일반'").Length;
            lblNormalCount.Text = normalCount.ToString();

            lblUserListCount.Text = $"유저 목록          총 {db.ResultTable.Rows.Count}건";
        }

        /// <summary>
        /// DataGridView 행 선택 시 상세 정보 표시
        /// </summary>
        /// <summary>
        /// ListView 행 선택 시 상세 정보 표시
        /// </summary>
        private void userListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (userListView.SelectedItems.Count > 0)
            {
                ListViewItem item = userListView.SelectedItems[0];
                try
                {
                    txtId.Text = item.SubItems[0].Text;
                    txtName.Text = item.SubItems[1].Text;
                    txtEmail.Text = item.SubItems[2].Text;

                    string role = item.SubItems[3].Text;
                    if (cmbRole.Items.Contains(role))
                        cmbRole.SelectedItem = role;
                    else
                        cmbRole.Text = role;

                    // db.SelectedKeyValue = Convert.ToInt32(item.SubItems[0].Text); // Use DBClass property if int, but ID is string in DB? Wait, ID is VARCHAR2.
                    // The user's DBClass has int SelectedKeyValue.
                    // But our ID is string. We might need to handle this.
                    // For now, let's assume we can parse it if it's numeric, or we might need to change DBClass.
                    // Actually, the user's DBClass has `private int selectedKeyValue`.
                    // But our ID is `u1`, `u2`... it's a string.
                    // We should probably change DBClass to object or string, OR just use a local variable for ID since DBClass is rigid.
                    // However, the user asked to use DBClass.
                    // I will use a local variable `SelectedUserId` (string) for now, as I can't put "u1" into an int.
                    // I will comment out the usage of db.SelectedKeyValue for ID if it's not compatible.
                    SelectedUserId = item.SubItems[0].Text;
                }
                catch (Exception)
                {
                    // 예외 무시
                }
            }
        }

        /// <summary>
        /// 검색 버튼 클릭
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            if (string.IsNullOrEmpty(searchText))
            {
                db.ResultTable.DefaultView.RowFilter = "";
            }
            if (!string.IsNullOrEmpty(searchText))
            {
                db.ResultTable.DefaultView.RowFilter = $"name LIKE '%{searchText}%' OR email LIKE '%{searchText}%'";
            }
            lblUserListCount.Text = $"유저 목록          총 {db.ResultTable.DefaultView.Count}건";
            RefreshListView(); // Refresh ListView with filtered data
        }

        /// <summary>
        /// 초기화 버튼 클릭
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            db.ResultTable.DefaultView.RowFilter = "";
            RefreshListView();
            UpdateUserStats();
        }

        /// <summary>
        /// 수정 버튼 클릭 (API 연동)
        /// </summary>
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("수정할 유저를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // API 호출
                var model = new UserApiModel
                {
                    IdString = txtId.Text,
                    Name = txtName.Text,
                    Email = txtEmail.Text,
                    Role = cmbRole.SelectedItem?.ToString() ?? "",
                    CreatedAt = DateTime.Now,
                    PostsCount = 0
                };

                ApiService apiService = new ApiService();
                // ID가 문자열이므로 URL에 그대로 사용
                await apiService.UpdateAsync($"/rest/v1/users?id=eq.{model.IdString}", model);

                DataRow currRow = db.ResultTable.Rows.Find(SelectedUserId);
                if (currRow != null)
                {
                    currRow.BeginEdit();
                    currRow["name"] = txtName.Text;
                    currRow["email"] = txtEmail.Text;
                    currRow["user_level"] = cmbRole.SelectedItem != null ? cmbRole.SelectedItem.ToString() : currRow["user_level"];
                    currRow.EndEdit();

                    db.DBAdapter.Update(db.DS, "users");
                    db.DS.AcceptChanges();

                    UpdateUserStats();
                    LoadUserData();
                    MessageBox.Show("유저 정보가 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"수정 실패: {ex.Message}");
            }
        }

        /// <summary>
        /// 삭제 버튼 클릭 (API 연동)
        /// </summary>
        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtId.Text))
                {
                    MessageBox.Show("삭제할 유저를 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("선택한 유저를 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // API 호출
                    ApiService apiService = new ApiService();
                    await apiService.DeleteAsync($"/rest/v1/users?id=eq.{txtId.Text}");

                    DataRow currRow = db.ResultTable.Rows.Find(SelectedUserId);
                    if (currRow != null)
                    {
                        currRow.Delete();

                        db.DBAdapter.Update(db.DS, "users");
                        db.DS.AcceptChanges();

                        UpdateUserStats();
                        LoadUserData();
                        ClearDetailForm();
                        MessageBox.Show("유저가 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"삭제 실패: {ex.Message}");
            }
        }

        /// <summary>
        /// API 조회 (새로고침) 버튼 클릭
        /// </summary>
        private async void btnLoadApi_Click(object sender, EventArgs e)
        {
            try
            {
                string endpoint = "/rest/v1/users?select=*";

                ApiService apiService = new ApiService();
                var users = await apiService.GetAllAsync<UserApiModel>(endpoint);

                if (users != null && users.Count > 0)
                {
                    LoadUserDataFromApi(users);
                    MessageBox.Show($"총 {users.Count}개의 데이터를 불러왔습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("불러올 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"조회 실패: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 로컬 백업 버튼 클릭
        /// </summary>
        private async void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                string endpoint = "/rest/v1/users?select=*";

                ApiService apiService = new ApiService();
                var users = await apiService.GetAllAsync<UserApiModel>(endpoint);

                if (users != null && users.Count > 0)
                {
                    UserRepository repository = new UserRepository();
                    repository.SaveUsers(users);

                    MessageBox.Show($"총 {users.Count}개의 데이터가 로컬 DB에 백업되었습니다.", "백업 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("백업할 데이터가 없습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"백업 실패: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadUserDataFromApi(List<UserApiModel> users)
        {
            userListView.Items.Clear();
            foreach (var user in users)
            {
                ListViewItem item = new ListViewItem(user.IdString);
                item.SubItems.Add(user.Name);
                item.SubItems.Add(user.Email);
                item.SubItems.Add(user.Role);
                item.SubItems.Add(user.CreatedAt.ToString("yyyy-MM-dd"));
                item.SubItems.Add(user.PostsCount.ToString());
                userListView.Items.Add(item);
            }

            lblTotalUsers.Text = users.Count.ToString();
        }

        /// <summary>
        /// 상세 정보 초기화 버튼 클릭
        /// </summary>
        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearDetailForm();
        }

        /// <summary>
        /// 상세 정보 폼 클리어
        /// </summary>
        private void ClearDetailForm()
        {
            txtId.Text = "";
            txtName.Text = "";
            txtEmail.Text = "";
            cmbRole.SelectedIndex = -1;
            SelectedUserId = "";
        }
    }
}
