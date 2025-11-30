namespace WindowsFormsApp2.Forms
{
    partial class CommunityManagementForm
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
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchTitle = new System.Windows.Forms.TextBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.cmbFilterCategory = new System.Windows.Forms.ComboBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.grpCommunityStats = new System.Windows.Forms.GroupBox();
            this.lblTotalComments = new System.Windows.Forms.Label();
            this.lblTotalCommentsLabel = new System.Windows.Forms.Label();
            this.lblTotalViews = new System.Windows.Forms.Label();
            this.lblTotalViewsLabel = new System.Windows.Forms.Label();
            this.lblTotalPosts = new System.Windows.Forms.Label();
            this.lblTotalPostsLabel = new System.Windows.Forms.Label();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.grpPostList = new System.Windows.Forms.GroupBox();
            this.communityListView = new System.Windows.Forms.ListView();
            this.columnHeaderPostId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostAuthor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostViews = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderPostComments = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblPostListCount = new System.Windows.Forms.Label();
            this.grpPostDetail = new System.Windows.Forms.GroupBox();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.lblDetailCategory = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblDetailTitle = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.lblId = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.grpFilter.SuspendLayout();
            this.grpCommunityStats.SuspendLayout();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.grpPostList.SuspendLayout();
            this.grpPostList.SuspendLayout();
            this.grpPostDetail.SuspendLayout();
            this.grpPostDetail.SuspendLayout();
            this.SuspendLayout();
            //
            // leftPanel
            //
            this.leftPanel.Controls.Add(this.grpCommunityStats);
            this.leftPanel.Controls.Add(this.grpFilter);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Padding = new System.Windows.Forms.Padding(8, 8, 8, 8);
            this.leftPanel.Size = new System.Drawing.Size(320, 761);
            this.leftPanel.TabIndex = 0;
            //
            // grpFilter
            //
            this.grpFilter.Controls.Add(this.btnReset);
            this.grpFilter.Controls.Add(this.btnSearch);
            this.grpFilter.Controls.Add(this.txtSearchTitle);
            this.grpFilter.Controls.Add(this.lblTitle);
            this.grpFilter.Controls.Add(this.cmbFilterCategory);
            this.grpFilter.Controls.Add(this.lblCategory);
            this.grpFilter.Location = new System.Drawing.Point(8, 8);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(304, 160);
            this.grpFilter.TabIndex = 0;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "필터";
            //
            // lblCategory
            //
            this.lblCategory.AutoSize = false;
            this.lblCategory.Location = new System.Drawing.Point(12, 28);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(80, 20);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.Text = "카테고리";
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // cmbFilterCategory
            //
            this.cmbFilterCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFilterCategory.FormattingEnabled = true;
            this.cmbFilterCategory.Items.AddRange(new object[] {
            "전체",
            "project",
            "study",
            "question",
            "chat"});
            this.cmbFilterCategory.Location = new System.Drawing.Point(98, 28);
            this.cmbFilterCategory.Name = "cmbFilterCategory";
            this.cmbFilterCategory.Size = new System.Drawing.Size(190, 20);
            this.cmbFilterCategory.TabIndex = 1;
            //
            // lblTitle
            //
            this.lblTitle.AutoSize = false;
            this.lblTitle.Location = new System.Drawing.Point(12, 58);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(80, 20);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "제목";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtSearchTitle
            //
            this.txtSearchTitle.Location = new System.Drawing.Point(98, 58);
            this.txtSearchTitle.Name = "txtSearchTitle";
            this.txtSearchTitle.Size = new System.Drawing.Size(190, 21);
            this.txtSearchTitle.TabIndex = 3;
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
            // grpCommunityStats
            //
            this.grpCommunityStats.Controls.Add(this.lblTotalComments);
            this.grpCommunityStats.Controls.Add(this.lblTotalCommentsLabel);
            this.grpCommunityStats.Controls.Add(this.lblTotalViews);
            this.grpCommunityStats.Controls.Add(this.lblTotalViewsLabel);
            this.grpCommunityStats.Controls.Add(this.lblTotalPosts);
            this.grpCommunityStats.Controls.Add(this.lblTotalPostsLabel);
            this.grpCommunityStats.Location = new System.Drawing.Point(8, 180);
            this.grpCommunityStats.Name = "grpCommunityStats";
            this.grpCommunityStats.Size = new System.Drawing.Size(304, 140);
            this.grpCommunityStats.TabIndex = 1;
            this.grpCommunityStats.TabStop = false;
            this.grpCommunityStats.Text = "커뮤니티 현황";
            //
            // lblTotalPostsLabel
            //
            this.lblTotalPostsLabel.AutoSize = false;
            this.lblTotalPostsLabel.Location = new System.Drawing.Point(12, 28);
            this.lblTotalPostsLabel.Name = "lblTotalPostsLabel";
            this.lblTotalPostsLabel.Size = new System.Drawing.Size(100, 20);
            this.lblTotalPostsLabel.TabIndex = 0;
            this.lblTotalPostsLabel.Text = "전체 게시글:";
            this.lblTotalPostsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblTotalPosts
            //
            this.lblTotalPosts.AutoSize = false;
            this.lblTotalPosts.Location = new System.Drawing.Point(118, 28);
            this.lblTotalPosts.Name = "lblTotalPosts";
            this.lblTotalPosts.Size = new System.Drawing.Size(170, 20);
            this.lblTotalPosts.TabIndex = 1;
            this.lblTotalPosts.Text = "0";
            this.lblTotalPosts.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblTotalViewsLabel
            //
            this.lblTotalViewsLabel.AutoSize = false;
            this.lblTotalViewsLabel.Location = new System.Drawing.Point(12, 58);
            this.lblTotalViewsLabel.Name = "lblTotalViewsLabel";
            this.lblTotalViewsLabel.Size = new System.Drawing.Size(100, 20);
            this.lblTotalViewsLabel.TabIndex = 2;
            this.lblTotalViewsLabel.Text = "총 조회수:";
            this.lblTotalViewsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblTotalViews
            //
            this.lblTotalViews.AutoSize = false;
            this.lblTotalViews.Location = new System.Drawing.Point(118, 58);
            this.lblTotalViews.Name = "lblTotalViews";
            this.lblTotalViews.Size = new System.Drawing.Size(170, 20);
            this.lblTotalViews.TabIndex = 3;
            this.lblTotalViews.Text = "0";
            this.lblTotalViews.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblTotalCommentsLabel
            //
            this.lblTotalCommentsLabel.AutoSize = false;
            this.lblTotalCommentsLabel.Location = new System.Drawing.Point(12, 88);
            this.lblTotalCommentsLabel.Name = "lblTotalCommentsLabel";
            this.lblTotalCommentsLabel.Size = new System.Drawing.Size(100, 20);
            this.lblTotalCommentsLabel.TabIndex = 4;
            this.lblTotalCommentsLabel.Text = "총 댓글:";
            this.lblTotalCommentsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // lblTotalComments
            //
            this.lblTotalComments.AutoSize = false;
            this.lblTotalComments.Location = new System.Drawing.Point(118, 88);
            this.lblTotalComments.Name = "lblTotalComments";
            this.lblTotalComments.Size = new System.Drawing.Size(170, 20);
            this.lblTotalComments.TabIndex = 5;
            this.lblTotalComments.Text = "0";
            this.lblTotalComments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.splitContainer1.Panel1.Controls.Add(this.grpPostList);
            //
            // splitContainer1.Panel2
            //
            this.splitContainer1.Panel2.Controls.Add(this.grpPostDetail);
            this.splitContainer1.Size = new System.Drawing.Size(872, 745);
            this.splitContainer1.SplitterDistance = 500;
            this.splitContainer1.TabIndex = 0;
            //
            // grpPostList
            //
            this.grpPostList.Controls.Add(this.lblPostListCount);
            this.grpPostList.Controls.Add(this.communityListView);
            this.grpPostList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPostList.Location = new System.Drawing.Point(0, 0);
            this.grpPostList.Name = "grpPostList";
            this.grpPostList.Size = new System.Drawing.Size(872, 500);
            this.grpPostList.TabIndex = 0;
            this.grpPostList.TabStop = false;
            this.grpPostList.Text = "게시글 목록";
            //
            // lblPostListCount
            //
            this.lblPostListCount.AutoSize = true;
            this.lblPostListCount.Location = new System.Drawing.Point(8, 0);
            this.lblPostListCount.Name = "lblPostListCount";
            this.lblPostListCount.Size = new System.Drawing.Size(100, 12);
            this.lblPostListCount.TabIndex = 1;
            this.lblPostListCount.Text = "게시글 목록";
            // 
            // communityListView
            // 
            this.communityListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderPostId,
            this.columnHeaderPostTitle,
            this.columnHeaderPostAuthor,
            this.columnHeaderPostCategory,
            this.columnHeaderPostDate,
            this.columnHeaderPostViews,
            this.columnHeaderPostComments});
            this.communityListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.communityListView.FullRowSelect = true;
            this.communityListView.GridLines = true;
            this.communityListView.HideSelection = false;
            this.communityListView.Location = new System.Drawing.Point(3, 17);
            this.communityListView.MultiSelect = false;
            this.communityListView.Name = "communityListView";
            this.communityListView.Size = new System.Drawing.Size(866, 480);
            this.communityListView.TabIndex = 0;
            this.communityListView.UseCompatibleStateImageBehavior = false;
            this.communityListView.View = System.Windows.Forms.View.Details;
            this.communityListView.SelectedIndexChanged += new System.EventHandler(this.communityListView_SelectedIndexChanged);
            // 
            // columnHeaderPostId
            // 
            this.columnHeaderPostId.Text = "ID";
            this.columnHeaderPostId.Width = 60;
            // 
            // columnHeaderPostTitle
            // 
            this.columnHeaderPostTitle.Text = "제목";
            this.columnHeaderPostTitle.Width = 300;
            // 
            // columnHeaderPostAuthor
            // 
            this.columnHeaderPostAuthor.Text = "작성자";
            this.columnHeaderPostAuthor.Width = 100;
            // 
            // columnHeaderPostCategory
            // 
            this.columnHeaderPostCategory.Text = "카테고리";
            this.columnHeaderPostCategory.Width = 100;
            // 
            // columnHeaderPostDate
            // 
            this.columnHeaderPostDate.Text = "날짜";
            this.columnHeaderPostDate.Width = 100;
            // 
            // columnHeaderPostViews
            // 
            this.columnHeaderPostViews.Text = "조회";
            this.columnHeaderPostViews.Width = 70;
            // 
            // columnHeaderPostComments
            // 
            this.columnHeaderPostComments.Text = "댓글";
            this.columnHeaderPostComments.Width = 70;
            //
            // grpPostDetail
            //
            this.grpPostDetail.Controls.Add(this.btnHide);
            this.grpPostDetail.Controls.Add(this.btnDelete);
            this.grpPostDetail.Controls.Add(this.btnUpdate);
            this.grpPostDetail.Controls.Add(this.cmbCategory);
            this.grpPostDetail.Controls.Add(this.lblDetailCategory);
            this.grpPostDetail.Controls.Add(this.txtAuthor);
            this.grpPostDetail.Controls.Add(this.lblAuthor);
            this.grpPostDetail.Controls.Add(this.txtTitle);
            this.grpPostDetail.Controls.Add(this.lblDetailTitle);
            this.grpPostDetail.Controls.Add(this.txtId);
            this.grpPostDetail.Controls.Add(this.lblId);
            this.grpPostDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpPostDetail.Location = new System.Drawing.Point(0, 0);
            this.grpPostDetail.Name = "grpPostDetail";
            this.grpPostDetail.Size = new System.Drawing.Size(872, 241);
            this.grpPostDetail.TabIndex = 0;
            this.grpPostDetail.TabStop = false;
            this.grpPostDetail.Text = "게시글 상세";
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
            // lblDetailTitle
            //
            this.lblDetailTitle.AutoSize = false;
            this.lblDetailTitle.Location = new System.Drawing.Point(12, 28);
            this.lblDetailTitle.Name = "lblDetailTitle";
            this.lblDetailTitle.Size = new System.Drawing.Size(60, 20);
            this.lblDetailTitle.TabIndex = 2;
            this.lblDetailTitle.Text = "제목:";
            this.lblDetailTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtTitle
            //
            this.txtTitle.Location = new System.Drawing.Point(78, 28);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(776, 21);
            this.txtTitle.TabIndex = 3;
            //
            // lblAuthor
            //
            this.lblAuthor.AutoSize = false;
            this.lblAuthor.Location = new System.Drawing.Point(12, 68);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(60, 20);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "작성자:";
            this.lblAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // txtAuthor
            //
            this.txtAuthor.Location = new System.Drawing.Point(78, 68);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.ReadOnly = true;
            this.txtAuthor.Size = new System.Drawing.Size(354, 21);
            this.txtAuthor.TabIndex = 5;
            //
            // lblDetailCategory
            //
            this.lblDetailCategory.AutoSize = false;
            this.lblDetailCategory.Location = new System.Drawing.Point(438, 68);
            this.lblDetailCategory.Name = "lblDetailCategory";
            this.lblDetailCategory.Size = new System.Drawing.Size(80, 20);
            this.lblDetailCategory.TabIndex = 6;
            this.lblDetailCategory.Text = "카테고리:";
            this.lblDetailCategory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            //
            // cmbCategory
            //
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Items.AddRange(new object[] {
            "project",
            "study",
            "question",
            "chat"});
            this.cmbCategory.Location = new System.Drawing.Point(524, 68);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(330, 20);
            this.cmbCategory.TabIndex = 7;
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
            // btnHide
            //
            this.btnHide.Location = new System.Drawing.Point(578, 110);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(276, 40);
            this.btnHide.TabIndex = 10;
            this.btnHide.Text = "숨김";
            this.btnHide.UseVisualStyleBackColor = true;
            this.btnHide.Click += new System.EventHandler(this.btnHide_Click);
            //
            // CommunityManagementForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 761);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.leftPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CommunityManagementForm";
            this.Text = "CommunityManagementForm";
            this.leftPanel.ResumeLayout(false);
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            this.grpCommunityStats.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.grpPostList.ResumeLayout(false);
            this.grpPostList.PerformLayout();
            this.grpPostDetail.ResumeLayout(false);
            this.grpPostDetail.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.ComboBox cmbFilterCategory;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtSearchTitle;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpCommunityStats;
        private System.Windows.Forms.Label lblTotalPostsLabel;
        private System.Windows.Forms.Label lblTotalPosts;
        private System.Windows.Forms.Label lblTotalViewsLabel;
        private System.Windows.Forms.Label lblTotalViews;
        private System.Windows.Forms.Label lblTotalCommentsLabel;
        private System.Windows.Forms.Label lblTotalComments;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.GroupBox grpPostList;
        private System.Windows.Forms.Label lblPostListCount;
        private System.Windows.Forms.ListView communityListView;
        private System.Windows.Forms.ColumnHeader columnHeaderPostId;
        private System.Windows.Forms.ColumnHeader columnHeaderPostTitle;
        private System.Windows.Forms.ColumnHeader columnHeaderPostAuthor;
        private System.Windows.Forms.ColumnHeader columnHeaderPostCategory;
        private System.Windows.Forms.ColumnHeader columnHeaderPostDate;
        private System.Windows.Forms.ColumnHeader columnHeaderPostViews;
        private System.Windows.Forms.ColumnHeader columnHeaderPostComments;
        private System.Windows.Forms.GroupBox grpPostDetail;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label lblDetailTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblDetailCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHide;
    }
}
