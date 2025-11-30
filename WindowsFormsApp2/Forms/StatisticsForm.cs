using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using WindowsFormsApp2.Models;
using WindowsFormsApp2.Services;

namespace WindowsFormsApp2.Forms
{
    public partial class StatisticsForm : Form
    {
        private readonly ApiService _apiService;

        public StatisticsForm()
        {
            InitializeComponent();
            _apiService = new ApiService();
        }

        private async void StatisticsForm_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async System.Threading.Tasks.Task LoadDataAsync()
        {
            try
            {
                // Load Tech Stacks
                var stacks = await _apiService.GetAllAsync<TechStackApiModel>("/rest/v1/tech_stacks?select=*");
                UpdateTechCharts(stacks);
                lblTotalTechs.Text = $"총 기술 스택: {stacks?.Count ?? 0}개";

                // Load Users
                var users = await _apiService.GetAllAsync<UserApiModel>("/rest/v1/users?select=*");
                lblTotalUsers.Text = $"총 사용자: {users?.Count ?? 0}명";

                // Load Posts
                var posts = await _apiService.GetAllAsync<PostApiModel>("/rest/v1/posts?select=*");
                UpdatePostCharts(posts);
                lblTotalPosts.Text = $"총 게시글: {posts?.Count ?? 0}개";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"데이터 로드 실패: {ex.Message}", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTechCharts(List<TechStackApiModel> stacks)
        {
            if (stacks == null) return;

            // Chart 1: Category Distribution (Pie)
            var categoryStats = stacks
                .GroupBy(s => s.Category)
                .Select(g => new { Category = g.Key, Count = g.Count() })
                .ToList();

            chartTechCategory.Series[0].Points.Clear();
            foreach (var stat in categoryStats)
            {
                chartTechCategory.Series[0].Points.AddXY(stat.Category, stat.Count);
            }

            // Chart 2: Top 5 Popularity (Bar)
            var popularityStats = stacks
                .OrderByDescending(s => s.Popularity)
                .Take(5)
                .ToList();

            chartTechPopularity.Series[0].Points.Clear();
            foreach (var stat in popularityStats)
            {
                chartTechPopularity.Series[0].Points.AddXY(stat.Name, stat.Popularity);
            }
        }

        private void UpdatePostCharts(List<PostApiModel> posts)
        {
            if (posts == null) return;

            // Chart 3: Post Type Distribution (Column)
            var typeStats = posts
                .GroupBy(p => p.PostType)
                .Select(g => new { Type = g.Key, Count = g.Count() })
                .ToList();

            chartPostType.Series[0].Points.Clear();
            foreach (var stat in typeStats)
            {
                chartPostType.Series[0].Points.AddXY(stat.Type, stat.Count);
            }
        }
    }
}
