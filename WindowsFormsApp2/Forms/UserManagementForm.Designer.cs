namespace WindowsFormsApp2.Forms
{
    partial class UserManagementForm
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
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearchLabel = new System.Windows.Forms.Label();
            this.grpUserStats = new System.Windows.Forms.GroupBox();
            this.lblNormalCount = new System.Windows.Forms.Label();
            this.lblNormalLabel = new System.Windows.Forms.Label();
            this.lblModeratorCount = new System.Windows.Forms.Label();
            this.lblModeratorLabel = new System.Windows.Forms.Label();
            this.lblAdminCount = new System.Windows.Forms.Label();
            this.lblAdminLabel = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblTotalUsersLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpUserList = new System.Windows.Forms.GroupBox();
            this.userListView = new System.Windows.Forms.ListView();
            this.columnHeaderId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderEmail = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderRole = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderJoinDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPosts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblUserListCount = new System.Windows.Forms.Label();
            this.grpUserDetail = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbRole = new System.Windows.Forms.ComboBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.btnSyncApi = new System.Windows.Forms.Button();
            this.leftPanel.SuspendLayout();
            this.grpSearch.SuspendLayout();
            this.grpUserStats.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpUserList.SuspendLayout();
            this.grpUserDetail.SuspendLayout();
            this.SuspendLayout();
            //
            // leftPanel
            //
            this.leftPanel.Controls.Add(this.grpUserStats);
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
            this.grpSearch.Controls.Add(this.txtSearch);
            this.grpSearch.Controls.Add(this.lblSearchLabel);
            this.grpSearch.Location = new System.Drawing.Point(8, 8);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(304, 120);
            this.grpSearch.TabIndex = 0;
            this.grpSearch.TabStop = false;
            this.grpSearch.Text = "검색";
            //
            // lblSearchLabel
            //
            this.lblSearchLabel.AutoSize = false;
            this.lblSearchLabel.Location = new System.Drawing.Point(12, 28);
            this.lblSearchLabel.Name = "lblSearchLabel";
            this.lblSearchLabel.Size = new System.Drawing.Size(80, 20);
            this.lblSearchLabel.TabIndex = 0;
            this.lblSearchLabel.Text = "이름/이메일";
            this.lblSearchLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtSearch
            //
            this.txtSearch.Location = new System.Drawing.Point(98, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(190, 21);
            this.txtSearch.TabIndex = 1;
            //
            // btnSearch
            //
            this.btnSearch.Location = new System.Drawing.Point(12, 60);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(138, 40);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "검색";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            //
            // btnReset
            //
            this.btnReset.Location = new System.Drawing.Point(156, 60);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(132, 40);
            this.btnReset.TabIndex = 3;
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
            // grpUserStats
            //
            this.grpUserStats.Controls.Add(this.lblNormalCount);
            this.grpUserStats.Controls.Add(this.lblNormalLabel);
            this.grpUserStats.Controls.Add(this.lblModeratorCount);
            this.grpUserStats.Controls.Add(this.lblModeratorLabel);
            this.grpUserStats.Controls.Add(this.lblAdminCount);
            this.grpUserStats.Controls.Add(this.lblAdminLabel);
            this.grpUserStats.Controls.Add(this.lblTotalUsers);
            this.grpUserStats.Controls.Add(this.lblTotalUsersLabel);
            this.grpUserStats.Location = new System.Drawing.Point(8, 140);
            this.grpUserStats.Name = "grpUserStats";
            this.grpUserStats.Size = new System.Drawing.Size(304, 160);
            this.grpUserStats.TabIndex = 1;
            this.grpUserStats.TabStop = false;
            this.grpUserStats.Text = "유저 현황";
            //
            // lblTotalUsersLabel
            //
            this.lblTotalUsersLabel.AutoSize = false;
            this.lblTotalUsersLabel.Location = new System.Drawing.Point(12, 28);
            this.lblTotalUsersLabel.Name = "lblTotalUsersLabel";
            this.lblTotalUsersLabel.Size = new System.Drawing.Size(100, 20);
            this.lblTotalUsersLabel.TabIndex = 0;
            this.lblTotalUsersLabel.Text = "전체 유저 수:";
            this.lblTotalUsersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblTotalUsers
            //
            this.lblTotalUsers.AutoSize = false;
            this.lblTotalUsers.Location = new System.Drawing.Point(118, 28);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(170, 20);
            this.lblTotalUsers.TabIndex = 1;
            this.lblTotalUsers.Text = "0";
            this.lblTotalUsers.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblAdminLabel
            //
            this.lblAdminLabel.AutoSize = false;
            this.lblAdminLabel.Location = new System.Drawing.Point(12, 58);
            this.lblAdminLabel.Name = "lblAdminLabel";
            this.lblAdminLabel.Size = new System.Drawing.Size(100, 20);
            this.lblAdminLabel.TabIndex = 2;
            this.lblAdminLabel.Text = "관리자:";
            this.lblAdminLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblAdminCount
            //
            this.lblAdminCount.AutoSize = false;
            this.lblAdminCount.Location = new System.Drawing.Point(118, 58);
            this.lblAdminCount.Name = "lblAdminCount";
            this.lblAdminCount.Size = new System.Drawing.Size(170, 20);
            this.lblAdminCount.TabIndex = 3;
            this.lblAdminCount.Text = "0";
            this.lblAdminCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblModeratorLabel
            //
            this.lblModeratorLabel.AutoSize = false;
            this.lblModeratorLabel.Location = new System.Drawing.Point(12, 88);
            this.lblModeratorLabel.Name = "lblModeratorLabel";
            this.lblModeratorLabel.Size = new System.Drawing.Size(100, 20);
            this.lblModeratorLabel.TabIndex = 4;
            this.lblModeratorLabel.Text = "운영자:";
            this.lblModeratorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblModeratorCount
            //
            this.lblModeratorCount.AutoSize = false;
            this.lblModeratorCount.Location = new System.Drawing.Point(118, 88);
            this.lblModeratorCount.Name = "lblModeratorCount";
            this.lblModeratorCount.Size = new System.Drawing.Size(170, 20);
            this.lblModeratorCount.TabIndex = 5;
            this.lblModeratorCount.Text = "0";
            this.lblModeratorCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblNormalLabel
            //
            this.lblNormalLabel.AutoSize = false;
            this.lblNormalLabel.Location = new System.Drawing.Point(12, 118);
            this.lblNormalLabel.Name = "lblNormalLabel";
            this.lblNormalLabel.Size = new System.Drawing.Size(100, 20);
            this.lblNormalLabel.TabIndex = 6;
            this.lblNormalLabel.Text = "일반 유저:";
            this.lblNormalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblNormalCount
            //
            this.lblNormalCount.AutoSize = false;
            this.lblNormalCount.Location = new System.Drawing.Point(118, 118);
            this.lblNormalCount.Name = "lblNormalCount";
            this.lblNormalCount.Size = new System.Drawing.Size(170, 20);
            this.lblNormalCount.TabIndex = 7;
            this.lblNormalCount.Text = "0";
            this.lblNormalCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.splitContainer1.Panel1.Controls.Add(this.grpUserList);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.grpUserDetail);
            this.splitContainer1.Size = new System.Drawing.Size(872, 745);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            //
            // grpUserList
            //
            this.grpUserList.Controls.Add(this.lblUserListCount);
            this.grpUserList.Controls.Add(this.userListView);
            this.grpUserList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUserList.Location = new System.Drawing.Point(0, 0);
            this.grpUserList.Name = "grpUserList";
            this.grpUserList.Size = new System.Drawing.Size(872, 500);
            this.grpUserList.TabIndex = 0;
            this.grpUserList.TabStop = false;
            this.grpUserList.Text = "유저 목록";
            //
            // lblUserListCount
            //
            this.lblUserListCount.AutoSize = true;
            this.lblUserListCount.Location = new System.Drawing.Point(8, 0);
            this.lblUserListCount.Name = "lblUserListCount";
            this.lblUserListCount.Size = new System.Drawing.Size(100, 12);
            this.lblUserListCount.TabIndex = 1;
            this.lblUserListCount.Text = "유저 목록";
            //
            // userListView
            //
            this.userListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderId,
            this.columnHeaderName,
            this.columnHeaderEmail,
            this.columnHeaderRole,
            this.columnHeaderJoinDate,
            this.columnHeaderPosts});
            this.userListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userListView.FullRowSelect = true;
            this.userListView.GridLines = true;
            this.userListView.HideSelection = false;
            this.userListView.Location = new System.Drawing.Point(3, 17);
            this.userListView.MultiSelect = false;
            this.userListView.Name = "userListView";
            this.userListView.Size = new System.Drawing.Size(866, 480);
            this.userListView.TabIndex = 0;
            this.userListView.UseCompatibleStateImageBehavior = false;
            this.userListView.View = System.Windows.Forms.View.Details;
            this.userListView.SelectedIndexChanged += new System.EventHandler(this.userListView_SelectedIndexChanged);
            //
            // columnHeaderId
            //
            this.columnHeaderId.Text = "ID";
            this.columnHeaderId.Width = 60;
            //
            // columnHeaderName
            //
            this.columnHeaderName.Text = "이름";
            this.columnHeaderName.Width = 100;
            //
            // columnHeaderEmail
            //
            this.columnHeaderEmail.Text = "이메일";
            this.columnHeaderEmail.Width = 150;
            //
            // columnHeaderRole
            //
            this.columnHeaderRole.Text = "역할";
            this.columnHeaderRole.Width = 80;
            //
            // columnHeaderJoinDate
            //
            this.columnHeaderJoinDate.Text = "가입일";
            this.columnHeaderJoinDate.Width = 100;
            //
            // columnHeaderPosts
            //
            this.columnHeaderPosts.Text = "게시글";
            this.columnHeaderPosts.Width = 60;
            //
            // grpUserDetail
            //
            this.grpUserDetail.Controls.Add(this.btnClear);
            this.grpUserDetail.Controls.Add(this.btnDelete);
            this.grpUserDetail.Controls.Add(this.btnUpdate);
            this.grpUserDetail.Controls.Add(this.cmbRole);
            this.grpUserDetail.Controls.Add(this.lblRole);
            this.grpUserDetail.Controls.Add(this.txtEmail);
            this.grpUserDetail.Controls.Add(this.lblEmail);
            this.grpUserDetail.Controls.Add(this.txtName);
            this.grpUserDetail.Controls.Add(this.lblName);
            this.grpUserDetail.Controls.Add(this.txtId);
            this.grpUserDetail.Controls.Add(this.lblId);
            this.grpUserDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpUserDetail.Location = new System.Drawing.Point(0, 0);
            this.grpUserDetail.Name = "grpUserDetail";
            this.grpUserDetail.Size = new System.Drawing.Size(872, 241);
            this.grpUserDetail.TabIndex = 0;
            this.grpUserDetail.TabStop = false;
            this.grpUserDetail.Text = "유저 상세 정보";
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
            //
            // txtId
            //
            this.txtId.Location = new System.Drawing.Point(78, 28);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(330, 21);
            this.txtId.TabIndex = 1;
            //
            // lblName
            //
            this.lblName.AutoSize = false;
            this.lblName.Location = new System.Drawing.Point(434, 28);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(60, 20);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "이름:";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtName
            //
            this.txtName.Location = new System.Drawing.Point(500, 28);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(354, 21);
            this.txtName.TabIndex = 3;
            //
            // lblEmail
            //
            this.lblEmail.AutoSize = false;
            this.lblEmail.Location = new System.Drawing.Point(12, 68);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "이메일:";
            this.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtEmail
            //
            this.txtEmail.Location = new System.Drawing.Point(78, 68);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(330, 21);
            this.txtEmail.TabIndex = 5;
            //
            // lblRole
            //
            this.lblRole.AutoSize = false;
            this.lblRole.Location = new System.Drawing.Point(434, 68);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(60, 20);
            this.lblRole.TabIndex = 6;
            this.lblRole.Text = "역할:";
            this.lblRole.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // cmbRole
            //
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "관리자",
            "운영자",
            "일반"});
            this.cmbRole.Location = new System.Drawing.Point(500, 68);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.Size = new System.Drawing.Size(354, 20);
            this.cmbRole.TabIndex = 7;
            //
            // btnUpdate
            //
            this.btnUpdate.Location = new System.Drawing.Point(12, 110);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(277, 40);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "수정";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            //
            // btnDelete
            //
            this.btnDelete.Location = new System.Drawing.Point(295, 110);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(277, 40);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "삭제";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            //
            // btnClear
            //
            this.btnClear.Location = new System.Drawing.Point(578, 110);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(276, 40);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            //
            // UserManagementForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 761);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Text = "UserManagementForm";
            this.leftPanel.ResumeLayout(false);
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.grpUserStats.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpUserList.ResumeLayout(false);
            this.grpUserList.PerformLayout();
            this.grpUserDetail.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.Label lblSearchLabel;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnLoadApi;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.GroupBox grpUserStats;
        private System.Windows.Forms.Label lblTotalUsersLabel;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label lblAdminLabel;
        private System.Windows.Forms.Label lblAdminCount;
        private System.Windows.Forms.Label lblModeratorLabel;
        private System.Windows.Forms.Label lblModeratorCount;
        private System.Windows.Forms.Label lblNormalLabel;
        private System.Windows.Forms.Label lblNormalCount;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpUserList;
        private System.Windows.Forms.Label lblUserListCount;
        private System.Windows.Forms.ListView userListView;
        private System.Windows.Forms.ColumnHeader columnHeaderId;
        private System.Windows.Forms.ColumnHeader columnHeaderName;
        private System.Windows.Forms.ColumnHeader columnHeaderEmail;
        private System.Windows.Forms.ColumnHeader columnHeaderRole;
        private System.Windows.Forms.ColumnHeader columnHeaderJoinDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPosts;
        private System.Windows.Forms.GroupBox grpUserDetail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.ComboBox cmbRole;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
    }
}
