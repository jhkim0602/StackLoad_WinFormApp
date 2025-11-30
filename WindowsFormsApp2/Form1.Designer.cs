namespace WindowsFormsApp2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuUserManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCommunity = new System.Windows.Forms.ToolStripMenuItem();
            this.menuTechStack = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStats = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatsDaily = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatsMonthly = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatsYearly = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStatsOverview = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuExitApp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            //
            // menuStrip1
            //
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuUserManagement,
            this.menuCommunity,
            this.menuTechStack,
            this.menuStats,
            this.menuExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            //
            // menuUserManagement
            //
            this.menuUserManagement.Name = "menuUserManagement";
            this.menuUserManagement.Size = new System.Drawing.Size(89, 20);
            this.menuUserManagement.Text = "유저 관리(&U)";
            this.menuUserManagement.Click += new System.EventHandler(this.menuUserManagement_Click);
            //
            // menuCommunity
            //
            this.menuCommunity.Name = "menuCommunity";
            this.menuCommunity.Size = new System.Drawing.Size(89, 20);
            this.menuCommunity.Text = "커뮤니티(&C)";
            this.menuCommunity.Click += new System.EventHandler(this.menuCommunity_Click);
            //
            // menuTechStack
            //
            this.menuTechStack.Name = "menuTechStack";
            this.menuTechStack.Size = new System.Drawing.Size(89, 20);
            this.menuTechStack.Text = "기술 목록(&T)";
            this.menuTechStack.Click += new System.EventHandler(this.menuTechStack_Click);
            //
            // menuStats
            //
            this.menuStats.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuStatsDaily,
            this.menuStatsMonthly,
            this.menuStatsYearly,
            this.menuStatsOverview});
            this.menuStats.Name = "menuStats";
            this.menuStats.Size = new System.Drawing.Size(62, 20);
            this.menuStats.Text = "통계(&S)";
            //
            // menuStatsDaily
            //
            this.menuStatsDaily.Name = "menuStatsDaily";
            this.menuStatsDaily.Size = new System.Drawing.Size(138, 22);
            this.menuStatsDaily.Text = "일별 통계";
            this.menuStatsDaily.Click += new System.EventHandler(this.menuStatsDaily_Click);
            //
            // menuStatsMonthly
            //
            this.menuStatsMonthly.Name = "menuStatsMonthly";
            this.menuStatsMonthly.Size = new System.Drawing.Size(138, 22);
            this.menuStatsMonthly.Text = "월별 통계";
            this.menuStatsMonthly.Click += new System.EventHandler(this.menuStatsMonthly_Click);
            //
            // menuStatsYearly
            //
            this.menuStatsYearly.Name = "menuStatsYearly";
            this.menuStatsYearly.Size = new System.Drawing.Size(138, 22);
            this.menuStatsYearly.Text = "연도별 통계";
            this.menuStatsYearly.Click += new System.EventHandler(this.menuStatsYearly_Click);
            //
            // menuStatsOverview
            //
            this.menuStatsOverview.Name = "menuStatsOverview";
            this.menuStatsOverview.Size = new System.Drawing.Size(138, 22);
            this.menuStatsOverview.Text = "종합 통계";
            this.menuStatsOverview.Click += new System.EventHandler(this.menuStatsOverview_Click);
            //
            // menuExit
            //
            this.menuExit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuExitApp});
            this.menuExit.Name = "menuExit";
            this.menuExit.Size = new System.Drawing.Size(62, 20);
            this.menuExit.Text = "종료(&X)";
            //
            // menuExitApp
            //
            this.menuExitApp.Name = "menuExitApp";
            this.menuExitApp.Size = new System.Drawing.Size(162, 22);
            this.menuExitApp.Text = "프로그램 종료";
            this.menuExitApp.Click += new System.EventHandler(this.menuExit_Click);
            //
            // Form1
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "개발 사이트 관리 (Forms)";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuUserManagement;
        private System.Windows.Forms.ToolStripMenuItem menuCommunity;
        private System.Windows.Forms.ToolStripMenuItem menuTechStack;
        private System.Windows.Forms.ToolStripMenuItem menuStats;
        private System.Windows.Forms.ToolStripMenuItem menuStatsDaily;
        private System.Windows.Forms.ToolStripMenuItem menuStatsMonthly;
        private System.Windows.Forms.ToolStripMenuItem menuStatsYearly;
        private System.Windows.Forms.ToolStripMenuItem menuStatsOverview;
        private System.Windows.Forms.ToolStripMenuItem menuExit;
        private System.Windows.Forms.ToolStripMenuItem menuExitApp;
    }
}

