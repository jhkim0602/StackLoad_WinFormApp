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
    /// 기술 스택 관리 폼
    /// </summary>
    public partial class TechStackManagementForm : Form
    {
        // DBClass 인스턴스
        DBClass db = new DBClass();

        // 수정하거나 삭제하기 위해 선택된 행의 인덱스를 저장한다. (DB PK)
        private int SelectedTechId;

        public TechStackManagementForm()
        {
            InitializeComponent();
            cmbSearchCategory.SelectedIndex = 0; // Default to '전체'
            DB_Open();
            LoadTechStackData();
            UpdateTechStats();
        }

        private void DB_Open()
        {
            try
            {
                // 필요한 컬럼만 선택. slug는 내부적으로 생성.
                string commandString = "select id, name, slug, category, description, popularity from techs";
                db.DB_Open(commandString, "techs");

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
        /// 기술 스택 데이터 로드
        /// </summary>
        /// <summary>
        /// 기술 스택 데이터 로드
        /// </summary>
        private void LoadTechStackData()
        {
            try
            {
                db.DBAdapter.Fill(db.DS, "techs");
                db.ResultTable = db.DS.Tables["techs"];

                techListView.Items.Clear();
                foreach (DataRow row in db.ResultTable.Rows)
                {
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["name"].ToString());
                    item.SubItems.Add(row["category"].ToString());
                    item.SubItems.Add(row["description"].ToString());
                    item.SubItems.Add(row["popularity"].ToString());
                    item.SubItems.Add(""); // Version
                    techListView.Items.Add(item);
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
        /// 기술 통계 업데이트
        /// </summary>
        private void UpdateTechStats()
        {
            if (db.ResultTable == null) return;

            lblTotalTechs.Text = db.ResultTable.Rows.Count.ToString();
            lblFrontendCount.Text = db.ResultTable.Select("category = 'Frontend'").Length.ToString();
            lblBackendCount.Text = db.ResultTable.Select("category = 'Backend'").Length.ToString();

            // popularity 합계 계산
            object sumObj = db.ResultTable.Compute("Sum(popularity)", "");
            lblTotalUserCount.Text = (sumObj != DBNull.Value) ? sumObj.ToString() : "0";

            lblTechListCount.Text = $"기술 목록          총 {db.ResultTable.Rows.Count}건";
        }

        /// <summary>
        /// DataGridView 행 선택 시 상세 정보 표시
        /// </summary>
        /// <summary>
        /// ListView 행 선택 시 상세 정보 표시
        /// </summary>
        private void techListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (techListView.SelectedItems.Count > 0)
            {
                ListViewItem item = techListView.SelectedItems[0];
                try
                {
                    txtId.Text = item.SubItems[0].Text;
                    txtDetailName.Text = item.SubItems[1].Text;
                    // Version 컬럼은 DB에 없으므로 제외하거나 빈값 처리
                    txtDetailVersion.Text = "";

                    string category = item.SubItems[2].Text;
                    if (cmbDetailCategory.Items.Contains(category))
                        cmbDetailCategory.SelectedItem = category;
                    else
                        cmbDetailCategory.Text = category;

                    txtDescription.Text = item.SubItems[3].Text;

                    db.SelectedKeyValue = Convert.ToInt32(item.SubItems[0].Text);
                    SelectedTechId = db.SelectedKeyValue;
                }
                catch (Exception)
                {
                    // 초기 로딩 등 예외 무시
                }
            }
        }

        /// <summary>
        /// 추가 버튼 클릭
        /// </summary>
        /// <summary>
        /// 검색 버튼 클릭
        /// </summary>
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string nameFilter = txtSearchName.Text.Trim();
                string categoryFilter = cmbSearchCategory.SelectedItem != null ? cmbSearchCategory.SelectedItem.ToString() : "전체";

                string filterExpression = "";
                List<string> filters = new List<string>();

                if (!string.IsNullOrEmpty(nameFilter))
                {
                    filters.Add($"name LIKE '%{nameFilter}%'");
                }

                if (categoryFilter != "전체")
                {
                    filters.Add($"category = '{categoryFilter}'");
                }

                if (filters.Count > 0)
                {
                    filterExpression = string.Join(" AND ", filters);
                }

                DataView dv = new DataView(db.ResultTable);
                dv.RowFilter = filterExpression;

                techListView.Items.Clear();
                foreach (DataRowView rowView in dv)
                {
                    DataRow row = rowView.Row;
                    ListViewItem item = new ListViewItem(row["id"].ToString());
                    item.SubItems.Add(row["name"].ToString());
                    item.SubItems.Add(row["category"].ToString());
                    item.SubItems.Add(row["description"].ToString());
                    item.SubItems.Add(row["popularity"].ToString());
                    item.SubItems.Add(""); // Version
                    techListView.Items.Add(item);
                }

                lblTechListCount.Text = $"기술 목록          검색 결과 {dv.Count}건";
            }
            catch (Exception ex)
            {
                MessageBox.Show("검색 중 오류 발생: " + ex.Message);
            }
        }

        /// <summary>
        /// 초기화 버튼 클릭
        /// </summary>
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtSearchName.Text = "";
            cmbSearchCategory.SelectedIndex = 0; // 전체
            LoadTechStackData();
            UpdateTechStats();
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
                    MessageBox.Show("수정할 기술을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // API 호출
                var model = new TechStackApiModel
                {
                    Id = int.Parse(txtId.Text),
                    Name = txtDetailName.Text,
                    Category = cmbDetailCategory.SelectedItem?.ToString() ?? "",
                    Description = txtDescription.Text,
                    // 기타 필드는 현재 UI에 없으므로 기존 값 유지하거나 기본값
                    // 실제로는 DB에서 읽어와서 채워야 함.
                    Popularity = 0,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                };

                ApiService apiService = new ApiService();
                await apiService.UpdateAsync($"/rest/v1/tech_stacks?id=eq.{model.Id}", model);

                // 로컬 DB 업데이트 (기존 로직 유지 또는 API 재동기화)
                // 여기서는 기존 로직 유지
                DataRow currRow = db.ResultTable.Rows.Find(SelectedTechId);
                if (currRow != null)
                {
                    currRow.BeginEdit();
                    currRow["name"] = txtDetailName.Text;
                    currRow["category"] = cmbDetailCategory.SelectedItem != null ? cmbDetailCategory.SelectedItem.ToString() : currRow["category"];
                    currRow["description"] = txtDescription.Text;
                    currRow.EndEdit();

                    db.DBAdapter.Update(db.DS, "techs");
                    db.DS.AcceptChanges();

                    UpdateTechStats();
                    LoadTechStackData();
                    MessageBox.Show("기술 정보가 수정되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("삭제할 기술을 선택해주세요.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = MessageBox.Show("선택한 기술을 삭제하시겠습니까?", "확인", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    // API 호출
                    ApiService apiService = new ApiService();
                    await apiService.DeleteAsync($"/rest/v1/tech_stacks?id=eq.{txtId.Text}");

                    // 로컬 DB 삭제
                    DataRow currRow = db.ResultTable.Rows.Find(SelectedTechId);
                    if (currRow != null)
                    {
                        currRow.Delete();

                        db.DBAdapter.Update(db.DS, "techs");
                        db.DS.AcceptChanges();

                        UpdateTechStats();
                        LoadTechStackData();
                        ClearDetailForm();
                        MessageBox.Show("기술이 삭제되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"삭제 실패: {ex.Message}");
            }
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
            txtDetailName.Text = "";
            txtDetailVersion.Text = "";
            cmbDetailCategory.SelectedIndex = -1;
            txtDescription.Text = "";
            SelectedTechId = -1;
        }

        /// <summary>
        /// API 조회 (새로고침) 버튼 클릭
        /// </summary>
        private async void btnLoadApi_Click(object sender, EventArgs e)
        {
            try
            {
                string endpoint = "/rest/v1/tech_stacks?select=*";

                ApiService apiService = new ApiService();
                var stacks = await apiService.GetAllAsync<TechStackApiModel>(endpoint);

                if (stacks != null && stacks.Count > 0)
                {
                    // UI에만 표시 (DB 저장 안함)
                    // 현재 구조상 ListView는 DB에서 읽어오는 구조임 (LoadTechStackData).
                    // 따라서 API 데이터를 ListView에 직접 바인딩해야 함.
                    // 기존 LoadTechStackData()는 DB를 읽으므로, LoadTechStackDataFromApi(stacks)를 새로 만듦.

                    LoadTechStackDataFromApi(stacks);
                    MessageBox.Show($"총 {stacks.Count}개의 데이터를 불러왔습니다.", "완료", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string endpoint = "/rest/v1/tech_stacks?select=*";

                ApiService apiService = new ApiService();
                var stacks = await apiService.GetAllAsync<TechStackApiModel>(endpoint);

                if (stacks != null && stacks.Count > 0)
                {
                    TechStackRepository repository = new TechStackRepository();
                    repository.SaveTechStacks(stacks);

                    MessageBox.Show($"총 {stacks.Count}개의 데이터가 로컬 DB에 백업되었습니다.", "백업 완료", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // 백업 후 로컬 DB 데이터로 다시 로드할지 여부는 선택.
                    // 여기서는 API 데이터가 우선이므로 UI는 그대로 둠.
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

        private void LoadTechStackDataFromApi(List<TechStackApiModel> stacks)
        {
            techListView.Items.Clear();
            foreach (var stack in stacks)
            {
                ListViewItem item = new ListViewItem(stack.Id.ToString());
                item.SubItems.Add(stack.Name);
                item.SubItems.Add(stack.Category);
                item.SubItems.Add(stack.Description);
                item.SubItems.Add(stack.Popularity.ToString());
                item.SubItems.Add(""); // Version (assuming it's the 6th column, as in btnSearch_Click)
                techListView.Items.Add(item);
            }

            // Update Stats Label if needed
            // Assuming lblTotalTechs is the label for total count, or update lblTechListCount
            lblTechListCount.Text = $"기술 목록          총 {stacks.Count}건";
            // If there's a separate label for total, update it here.
            // For now, using lblTechListCount as it's present in the context.
        }
    }
}
