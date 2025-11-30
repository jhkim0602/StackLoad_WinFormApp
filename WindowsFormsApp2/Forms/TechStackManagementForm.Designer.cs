namespace WindowsFormsApp2.Forms
{
    partial class TechStackManagementForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.leftPanel = new System.Windows.Forms.Panel();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLoadApi = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.cmbSearchCategory = new System.Windows.Forms.ComboBox();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.lblSearchName = new System.Windows.Forms.Label();
            this.grpTechStats = new System.Windows.Forms.GroupBox();
            this.lblTotalUserCount = new System.Windows.Forms.Label();
            this.lblTotalUserCountLabel = new System.Windows.Forms.Label();
            this.lblBackendCount = new System.Windows.Forms.Label();
            this.lblBackendLabel = new System.Windows.Forms.Label();
            this.lblFrontendCount = new System.Windows.Forms.Label();
            this.lblFrontendLabel = new System.Windows.Forms.Label();
            this.lblTotalTechs = new System.Windows.Forms.Label();
            this.lblTotalTechsLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpTechList = new System.Windows.Forms.GroupBox();
            this.techListView = new System.Windows.Forms.ListView();
            this.columnHeaderTechId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTechName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTechCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTechDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTechUserCount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTechVersion = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTechListCount = new System.Windows.Forms.Label();
            this.grpTechDetail = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.cmbDetailCategory = new System.Windows.Forms.ComboBox();
            this.lblDetailCategory = new System.Windows.Forms.Label();
            this.txtDetailVersion = new System.Windows.Forms.TextBox();
            this.lblDetailVersion = new System.Windows.Forms.Label();
            this.txtDetailName = new System.Windows.Forms.TextBox();
            this.lblDetailName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpTechStats.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpTechList.SuspendLayout();
            this.grpTechList.SuspendLayout();
            this.grpTechDetail.SuspendLayout();
            this.grpTechDetail.SuspendLayout();
            this.SuspendLayout();
            //
            // leftPanel
            //
            this.leftPanel.Controls.Add(this.grpTechStats);
            this.leftPanel.Controls.Add(this.grpSearch);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.leftPanel.Size = new System.Drawing.Size(320, 761);
            this.leftPanel.TabIndex = 0;
            //
            // grpSearch
            //
            this.grpSearch.Controls.Add(this.btnSearch);
            this.grpSearch.Controls.Add(this.btnReset);
            this.grpSearch.Controls.Add(this.btnLoadApi);
            this.grpSearch.Controls.Add(this.btnBackup);
            this.grpSearch.Controls.Add(this.cmbSearchCategory);
            this.grpSearch.Controls.Add(this.lblSearchCategory);
            this.grpSearch.Controls.Add(this.txtSearchName);
            this.grpSearch.Controls.Add(this.lblSearchName);
            this.grpSearch.Location = new System.Drawing.Point(8, 8);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(304, 180);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "기술 검색";
            //
            // lblSearchName
            //
            this.lblSearchName.AutoSize = false;
            this.lblSearchName.Location = new System.Drawing.Point(12, 28);
            this.lblSearchName.Name = "lblSearchName";
            this.lblSearchName.Size = new System.Drawing.Size(80, 20);
            this.lblSearchName.TabIndex = 0;
            this.lblSearchName.Text = "기술명";
            this.lblSearchName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtSearchName
            //
            this.txtSearchName.Location = new System.Drawing.Point(98, 28);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(190, 21);
            this.txtSearchName.TabIndex = 1;
            //
            // lblSearchCategory
            //
            this.lblSearchCategory.AutoSize = false;
            this.lblSearchCategory.Location = new System.Drawing.Point(12, 58);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(80, 20);
            this.lblSearchCategory.TabIndex = 2;
            this.lblSearchCategory.Text = "카테고리";
            this.lblSearchCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // cmbSearchCategory
            //
            this.cmbSearchCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchCategory.FormattingEnabled = true;
            this.cmbSearchCategory.Items.AddRange(new object[] {
            "전체",
            "Frontend",
            "Backend",
            "Database",
            "DevOps",
            "Language",
            "Cloud"});
            this.cmbSearchCategory.Location = new System.Drawing.Point(98, 58);
            this.cmbSearchCategory.Name = "cmbSearchCategory";
            this.cmbSearchCategory.Size = new System.Drawing.Size(190, 20);
            this.cmbSearchCategory.TabIndex = 3;
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(12, 95);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 40);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // btnReset
            //
            this.btnReset.Location = new System.Drawing.Point(156, 95);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 40);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "초기화";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            //
            // btnLoadApi
            //
            this.btnLoadApi.Location = new System.Drawing.Point(12, 140);
            this.btnLoadApi.Name = "btnLoadApi";
            this.btnLoadApi.Size = new System.Drawing.Size(135, 40);
            this.btnLoadApi.TabIndex = 6;
            this.btnLoadApi.Text = "API 조회 (새로고침)";
            this.btnLoadApi.UseVisualStyleBackColor = true;
            this.btnLoadApi.Click += new System.EventHandler(this.btnLoadApi_Click);
            //
            // btnBackup
            //
            this.btnBackup.Location = new System.Drawing.Point(153, 140);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(135, 40);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "로컬 백업";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            //
            // grpTechStats
            //
            this.grpTechStats.Controls.Add(this.lblTotalUserCount);
            this.grpTechStats.Controls.Add(this.lblTotalUserCountLabel);
            this.grpTechStats.Controls.Add(this.lblBackendCount);
            this.grpTechStats.Controls.Add(this.lblBackendLabel);
            this.grpTechStats.Controls.Add(this.lblFrontendCount);
            this.grpTechStats.Controls.Add(this.lblFrontendLabel);
            this.grpTechStats.Controls.Add(this.lblTotalTechs);
            this.grpTechStats.Controls.Add(this.lblTotalTechsLabel);
            this.grpTechStats.Location = new System.Drawing.Point(8, 200);
            this.grpTechStats.Name = "grpTechStats";
            this.grpTechStats.Size = new System.Drawing.Size(304, 160);
            this.grpTechStats.TabIndex = 1;
            this.grpTechStats.TabStop = false;
            this.grpTechStats.Text = "기술 현황";
            //
            // lblTotalTechsLabel
            //
            this.lblTotalTechsLabel.AutoSize = false;
            this.lblTotalTechsLabel.Location = new System.Drawing.Point(12, 28);
            this.lblTotalTechsLabel.Name = "lblTotalTechsLabel";
            this.lblTotalTechsLabel.Size = new System.Drawing.Size(100, 20);
            this.lblTotalTechsLabel.TabIndex = 0;
            this.lblTotalTechsLabel.Text = "전체 기술:";
            this.lblTotalTechsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblTotalTechs
            //
            this.lblTotalTechs.AutoSize = false;
            this.lblTotalTechs.Location = new System.Drawing.Point(118, 28);
            this.lblTotalTechs.Name = "lblTotalTechs";
            this.lblTotalTechs.Size = new System.Drawing.Size(170, 20);
            this.lblTotalTechs.TabIndex = 1;
            this.lblTotalTechs.Text = "0";
            this.lblTotalTechs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblFrontendLabel
            //
            this.lblFrontendLabel.AutoSize = false;
            this.lblFrontendLabel.Location = new System.Drawing.Point(12, 58);
            this.lblFrontendLabel.Name = "lblFrontendLabel";
            this.lblFrontendLabel.Size = new System.Drawing.Size(100, 20);
            this.lblFrontendLabel.TabIndex = 2;
            this.lblFrontendLabel.Text = "Frontend:";
            this.lblFrontendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblFrontendCount
            //
            this.lblFrontendCount.AutoSize = false;
            this.lblFrontendCount.Location = new System.Drawing.Point(118, 58);
            this.lblFrontendCount.Name = "lblFrontendCount";
            this.lblFrontendCount.Size = new System.Drawing.Size(170, 20);
            this.lblFrontendCount.TabIndex = 3;
            this.lblFrontendCount.Text = "0";
            this.lblFrontendCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblBackendLabel
            //
            this.lblBackendLabel.AutoSize = false;
            this.lblBackendLabel.Location = new System.Drawing.Point(12, 88);
            this.lblBackendLabel.Name = "lblBackendLabel";
            this.lblBackendLabel.Size = new System.Drawing.Size(100, 20);
            this.lblBackendLabel.TabIndex = 4;
            this.lblBackendLabel.Text = "Backend:";
            this.lblBackendLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblBackendCount
            //
            this.lblBackendCount.AutoSize = false;
            this.lblBackendCount.Location = new System.Drawing.Point(118, 88);
            this.lblBackendCount.Name = "lblBackendCount";
            this.lblBackendCount.Size = new System.Drawing.Size(170, 20);
            this.lblBackendCount.TabIndex = 5;
            this.lblBackendCount.Text = "0";
            this.lblBackendCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblTotalUserCountLabel
            //
            this.lblTotalUserCountLabel.AutoSize = false;
            this.lblTotalUserCountLabel.Location = new System.Drawing.Point(12, 118);
            this.lblTotalUserCountLabel.Name = "lblTotalUserCountLabel";
            this.lblTotalUserCountLabel.Size = new System.Drawing.Size(100, 20);
            this.lblTotalUserCountLabel.TabIndex = 6;
            this.lblTotalUserCountLabel.Text = "총 사용자:";
            this.lblTotalUserCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblTotalUserCount
            //
            this.lblTotalUserCount.AutoSize = false;
            this.lblTotalUserCount.Location = new System.Drawing.Point(118, 118);
            this.lblTotalUserCount.Name = "lblTotalUserCount";
            this.lblTotalUserCount.Size = new System.Drawing.Size(170, 20);
            this.lblTotalUserCount.TabIndex = 7;
            this.lblTotalUserCount.Text = "0";
            this.lblTotalUserCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // rightPanel
            //
            this.rightPanel.Controls.Add(this.splitContainer1);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rightPanel.Location = new System.Drawing.Point(320, 0);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Padding = new System.Windows.Forms.Padding(0, 8, 8, 8);
            this.rightPanel.Size = new System.Drawing.Size(880, 761);
            this.rightPanel.TabIndex = 1;
            //
            // splitContainer1
            //
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 8);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            //
            // splitContainer1.Panel1
            //
            this.splitContainer1.Panel1.Controls.Add(this.grpTechList);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.grpTechDetail);
            this.splitContainer1.Size = new System.Drawing.Size(872, 745);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            //
            // grpTechList
            //
            this.grpTechList.Controls.Add(this.lblTechListCount);
            this.grpTechList.Controls.Add(this.techListView);
            this.grpTechList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTechList.Location = new System.Drawing.Point(0, 0);
            this.grpTechList.Name = "grpTechList";
            this.grpTechList.Size = new System.Drawing.Size(872, 500);
            this.grpTechList.TabIndex = 0;
            this.grpTechList.TabStop = false;
            this.grpTechList.Text = "기술 목록";
            //
            // lblTechListCount
            //
            this.lblTechListCount.AutoSize = true;
            this.lblTechListCount.Location = new System.Drawing.Point(8, 0);
            this.lblTechListCount.Name = "lblTechListCount";
            this.lblTechListCount.Size = new System.Drawing.Size(100, 12);
            this.lblTechListCount.TabIndex = 1;
            this.lblTechListCount.Text = "기술 목록";
            //
            // techListView
            //
            this.techListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderTechId,
            this.columnHeaderTechName,
            this.columnHeaderTechCategory,
            this.columnHeaderTechDescription,
            this.columnHeaderTechUserCount,
            this.columnHeaderTechVersion});
            this.techListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.techListView.FullRowSelect = true;
            this.techListView.GridLines = true;
            this.techListView.HideSelection = false;
            this.techListView.Location = new System.Drawing.Point(3, 17);
            this.techListView.MultiSelect = false;
            this.techListView.Name = "techListView";
            this.techListView.Size = new System.Drawing.Size(866, 480);
            this.techListView.TabIndex = 0;
            this.techListView.UseCompatibleStateImageBehavior = false;
            this.techListView.View = System.Windows.Forms.View.Details;
            this.techListView.SelectedIndexChanged += new System.EventHandler(this.techListView_SelectedIndexChanged);
            //
            // columnHeaderTechId
            //
            this.columnHeaderTechId.Text = "ID";
            this.columnHeaderTechId.Width = 60;
            //
            // columnHeaderTechName
            //
            this.columnHeaderTechName.Text = "기술명";
            this.columnHeaderTechName.Width = 150;
            //
            // columnHeaderTechCategory
            //
            this.columnHeaderTechCategory.Text = "카테고리";
            this.columnHeaderTechCategory.Width = 120;
            //
            // columnHeaderTechDescription
            //
            this.columnHeaderTechDescription.Text = "설명";
            this.columnHeaderTechDescription.Width = 200;
            //
            // columnHeaderTechUserCount
            //
            this.columnHeaderTechUserCount.Text = "사용자 수";
            this.columnHeaderTechUserCount.Width = 100;
            //
            // columnHeaderTechVersion
            //
            this.columnHeaderTechVersion.Text = "버전";
            this.columnHeaderTechVersion.Width = 100;
            //
            // grpTechDetail
            //
            this.grpTechDetail.Controls.Add(this.btnClear);
            this.grpTechDetail.Controls.Add(this.btnDelete);
            this.grpTechDetail.Controls.Add(this.btnUpdate);
            this.grpTechDetail.Controls.Add(this.txtDescription);
            this.grpTechDetail.Controls.Add(this.lblDescription);
            this.grpTechDetail.Controls.Add(this.cmbDetailCategory);
            this.grpTechDetail.Controls.Add(this.lblDetailCategory);
            this.grpTechDetail.Controls.Add(this.txtDetailVersion);
            this.grpTechDetail.Controls.Add(this.lblDetailVersion);
            this.grpTechDetail.Controls.Add(this.txtDetailName);
            this.grpTechDetail.Controls.Add(this.lblDetailName);
            this.grpTechDetail.Controls.Add(this.txtId);
            this.grpTechDetail.Controls.Add(this.lblId);
            this.grpTechDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpTechDetail.Location = new System.Drawing.Point(0, 0);
            this.grpTechDetail.Name = "grpTechDetail";
            this.grpTechDetail.Size = new System.Drawing.Size(872, 241);
            this.grpTechDetail.TabIndex = 0;
            this.grpTechDetail.TabStop = false;
            this.grpTechDetail.Text = "기술 상세";
            //
            // lblId
            //
            this.lblId.AutoSize = false;
            this.lblId.Location = new System.Drawing.Point(12, 28);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(60, 20);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "ID:";
            this.lblId.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblId.Visible = false;
            //
            // txtId
            //
            this.txtId.Location = new System.Drawing.Point(78, 28);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(100, 21);
            this.txtId.TabIndex = 1;
            this.txtId.Visible = false;
            //
            // lblDetailName
            //
            this.lblDetailName.AutoSize = false;
            this.lblDetailName.Location = new System.Drawing.Point(12, 28);
            this.lblDetailName.Name = "lblDetailName";
            this.lblDetailName.Size = new System.Drawing.Size(60, 20);
            this.lblDetailName.TabIndex = 2;
            this.lblDetailName.Text = "기술명:";
            this.lblDetailName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtDetailName
            //
            this.txtDetailName.Location = new System.Drawing.Point(78, 28);
            this.txtDetailName.Name = "txtDetailName";
            this.txtDetailName.Size = new System.Drawing.Size(354, 21);
            this.txtDetailName.TabIndex = 3;
            //
            // lblDetailVersion
            //
            this.lblDetailVersion.AutoSize = false;
            this.lblDetailVersion.Location = new System.Drawing.Point(438, 28);
            this.lblDetailVersion.Name = "lblDetailVersion";
            this.lblDetailVersion.Size = new System.Drawing.Size(60, 20);
            this.lblDetailVersion.TabIndex = 4;
            this.lblDetailVersion.Text = "버전:";
            this.lblDetailVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtDetailVersion
            //
            this.txtDetailVersion.Location = new System.Drawing.Point(504, 28);
            this.txtDetailVersion.Name = "txtDetailVersion";
            this.txtDetailVersion.Size = new System.Drawing.Size(350, 21);
            this.txtDetailVersion.TabIndex = 5;
            //
            // lblDetailCategory
            //
            this.lblDetailCategory.AutoSize = false;
            this.lblDetailCategory.Location = new System.Drawing.Point(12, 68);
            this.lblDetailCategory.Name = "lblDetailCategory";
            this.lblDetailCategory.Size = new System.Drawing.Size(60, 20);
            this.lblDetailCategory.TabIndex = 6;
            this.lblDetailCategory.Text = "카테고리:";
            this.lblDetailCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // cmbDetailCategory
            //
            this.cmbDetailCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDetailCategory.FormattingEnabled = true;
            this.cmbDetailCategory.Items.AddRange(new object[] {
            "Frontend",
            "Backend",
            "Database",
            "DevOps",
            "Language",
            "Cloud"});
            this.cmbDetailCategory.Location = new System.Drawing.Point(78, 68);
            this.cmbDetailCategory.Name = "cmbDetailCategory";
            this.cmbDetailCategory.Size = new System.Drawing.Size(776, 20);
            this.cmbDetailCategory.TabIndex = 7;
            //
            // lblDescription
            //
            this.lblDescription.AutoSize = false;
            this.lblDescription.Location = new System.Drawing.Point(12, 108);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(60, 20);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "설명:";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtDescription
            //
            this.txtDescription.Location = new System.Drawing.Point(78, 108);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(776, 21);
            this.txtDescription.TabIndex = 9;
            //
            // btnUpdate
            //
            this.btnUpdate.Location = new System.Drawing.Point(12, 150);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(277, 40);
            this.btnUpdate.TabIndex = 10;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(295, 150);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(277, 40);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(578, 150);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(276, 40);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // TechStackManagementForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 761);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TechStackManagementForm";
            this.Text = "TechStackManagementForm";
            this.leftPanel.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpTechStats.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpTechList.ResumeLayout(false);
            this.grpTechList.PerformLayout();
            this.grpTechDetail.ResumeLayout(false);
            this.grpTechDetail.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label lblSearchCategory;
        private System.Windows.Forms.ComboBox cmbSearchCategory;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoadApi;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox grpTechStats;
        private System.Windows.Forms.Label lblTotalTechsLabel;
        private System.Windows.Forms.Label lblTotalTechs;
        private System.Windows.Forms.Label lblFrontendLabel;
        private System.Windows.Forms.Label lblFrontendCount;
        private System.Windows.Forms.Label lblBackendLabel;
        private System.Windows.Forms.Label lblBackendCount;
        private System.Windows.Forms.Label lblTotalUserCountLabel;
        private System.Windows.Forms.Label lblTotalUserCount;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpTechList;
        private System.Windows.Forms.Label lblTechListCount;
        private System.Windows.Forms.ListView techListView;
        private System.Windows.Forms.ColumnHeader columnHeaderTechId;
        private System.Windows.Forms.ColumnHeader columnHeaderTechName;
        private System.Windows.Forms.ColumnHeader columnHeaderTechCategory;
        private System.Windows.Forms.ColumnHeader columnHeaderTechDescription;
        private System.Windows.Forms.ColumnHeader columnHeaderTechUserCount;
        private System.Windows.Forms.ColumnHeader columnHeaderTechVersion;
        private System.Windows.Forms.GroupBox grpTechDetail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDetailName;
        private System.Windows.Forms.TextBox txtDetailName;
        private System.Windows.Forms.Label lblDetailVersion;
        private System.Windows.Forms.TextBox txtDetailVersion;
        private System.Windows.Forms.Label lblDetailCategory;
        private System.Windows.Forms.ComboBox cmbDetailCategory;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}
