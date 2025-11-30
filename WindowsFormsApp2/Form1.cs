using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp2.Forms;

namespace WindowsFormsApp2
{
    /// <summary>
    /// 메인 폼 - 메뉴를 통한 폼 전환 기능 제공
    /// </summary>
    public partial class Form1 : Form
    {
        private Panel contentPanel;

        public Form1()
        {
            InitializeComponent();
            InitializeContentPanel();
            ShowUserManagementForm(); // 기본 표시
        }

        /// <summary>
        /// 콘텐츠 패널 초기화
        /// </summary>
        private void InitializeContentPanel()
        {
            contentPanel = new Panel
            {
                Dock = DockStyle.Fill
            };
            this.Controls.Add(contentPanel);
            // MenuStrip이 맨 위에 표시되도록 설정
            this.menuStrip1.BringToFront();
        }

        /// <summary>
        /// 유저 관리 폼 표시
        /// </summary>
        private void ShowUserManagementForm()
        {
            contentPanel.Controls.Clear();
            UserManagementForm form = new UserManagementForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            contentPanel.Controls.Add(form);
            form.Show();
        }

        /// <summary>
        /// 커뮤니티 관리 폼 표시
        /// </summary>
        private void ShowCommunityManagementForm()
        {
            contentPanel.Controls.Clear();
            CommunityManagementForm form = new CommunityManagementForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            contentPanel.Controls.Add(form);
            form.Show();
        }

        /// <summary>
        /// 기술 스택 관리 폼 표시
        /// </summary>
        private void ShowTechStackManagementForm()
        {
            contentPanel.Controls.Clear();
            TechStackManagementForm form = new TechStackManagementForm
            {
                TopLevel = false,
                Dock = DockStyle.Fill,
                FormBorderStyle = FormBorderStyle.None
            };
            contentPanel.Controls.Add(form);
            form.Show();
        }

        // 메뉴 이벤트 핸들러
        private void menuUserManagement_Click(object sender, EventArgs e)
        {
            ShowUserManagementForm();
        }

        private void menuCommunity_Click(object sender, EventArgs e)
        {
            ShowCommunityManagementForm();
        }

        private void menuTechStack_Click(object sender, EventArgs e)
        {
            ShowTechStackManagementForm();
        }

        private void menuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuStatsDaily_Click(object sender, EventArgs e)
        {
            MessageBox.Show("일별 통계 기능은 준비 중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuStatsMonthly_Click(object sender, EventArgs e)
        {
            MessageBox.Show("월별 통계 기능은 준비 중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void menuStatsYearly_Click(object sender, EventArgs e)
        {
            MessageBox.Show("연도별 통계 기능은 준비 중입니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
