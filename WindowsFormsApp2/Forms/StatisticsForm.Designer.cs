namespace WindowsFormsApp2.Forms
{
    partial class StatisticsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.chartTechCategory = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartTechPopularity = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPostType = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelTop = new System.Windows.Forms.Panel();
            this.lblTotalPosts = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblTotalTechs = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartTechCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTechPopularity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPostType)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            //
            // tableLayoutPanel1
            //
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.chartTechCategory, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartTechPopularity, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.chartPostType, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 60);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 390);
            this.tableLayoutPanel1.TabIndex = 0;
            //
            // chartTechCategory
            //
            chartArea1.Name = "ChartArea1";
            this.chartTechCategory.ChartAreas.Add(chartArea1);
            this.chartTechCategory.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chartTechCategory.Legends.Add(legend1);
            this.chartTechCategory.Location = new System.Drawing.Point(3, 3);
            this.chartTechCategory.Name = "chartTechCategory";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartTechCategory.Series.Add(series1);
            this.chartTechCategory.Size = new System.Drawing.Size(394, 189);
            this.chartTechCategory.TabIndex = 0;
            this.chartTechCategory.Text = "기술 스택 카테고리";
            this.chartTechCategory.Titles.Add("기술 스택 카테고리 분포");
            //
            // chartTechPopularity
            //
            chartArea2.Name = "ChartArea1";
            this.chartTechPopularity.ChartAreas.Add(chartArea2);
            this.chartTechPopularity.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.chartTechPopularity.Legends.Add(legend2);
            this.chartTechPopularity.Location = new System.Drawing.Point(403, 3);
            this.chartTechPopularity.Name = "chartTechPopularity";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.chartTechPopularity.Series.Add(series2);
            this.chartTechPopularity.Size = new System.Drawing.Size(394, 189);
            this.chartTechPopularity.TabIndex = 1;
            this.chartTechPopularity.Text = "인기 기술 스택 Top 5";
            this.chartTechPopularity.Titles.Add("인기 기술 스택 Top 5");
            //
            // chartPostType
            //
            chartArea3.Name = "ChartArea1";
            this.chartPostType.ChartAreas.Add(chartArea3);
            this.chartPostType.Dock = System.Windows.Forms.DockStyle.Fill;
            legend3.Name = "Legend1";
            this.chartPostType.Legends.Add(legend3);
            this.chartPostType.Location = new System.Drawing.Point(3, 198);
            this.chartPostType.Name = "chartPostType";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            this.chartPostType.Series.Add(series3);
            this.chartPostType.Size = new System.Drawing.Size(394, 189);
            this.chartPostType.TabIndex = 2;
            this.chartPostType.Text = "게시글 유형";
            this.chartPostType.Titles.Add("게시글 유형별 현황");
            //
            // panelTop
            //
            this.panelTop.Controls.Add(this.btnRefresh);
            this.panelTop.Controls.Add(this.lblTotalPosts);
            this.panelTop.Controls.Add(this.lblTotalUsers);
            this.panelTop.Controls.Add(this.lblTotalTechs);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(800, 60);
            this.panelTop.TabIndex = 1;
            //
            // lblTotalTechs
            //
            this.lblTotalTechs.AutoSize = true;
            this.lblTotalTechs.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalTechs.Location = new System.Drawing.Point(22, 20);
            this.lblTotalTechs.Name = "lblTotalTechs";
            this.lblTotalTechs.Size = new System.Drawing.Size(110, 21);
            this.lblTotalTechs.TabIndex = 0;
            this.lblTotalTechs.Text = "총 기술 스택: -";
            //
            // lblTotalUsers
            //
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalUsers.Location = new System.Drawing.Point(200, 20);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(94, 21);
            this.lblTotalUsers.TabIndex = 1;
            this.lblTotalUsers.Text = "총 사용자: -";
            //
            // lblTotalPosts
            //
            this.lblTotalPosts.AutoSize = true;
            this.lblTotalPosts.Font = new System.Drawing.Font("Malgun Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblTotalPosts.Location = new System.Drawing.Point(380, 20);
            this.lblTotalPosts.Name = "lblTotalPosts";
            this.lblTotalPosts.Size = new System.Drawing.Size(94, 21);
            this.lblTotalPosts.TabIndex = 2;
            this.lblTotalPosts.Text = "총 게시글: -";
            //
            // btnRefresh
            //
            this.btnRefresh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRefresh.Location = new System.Drawing.Point(688, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(100, 40);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            //
            // StatisticsForm
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panelTop);
            this.Name = "StatisticsForm";
            this.Text = "종합 통계";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartTechCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartTechPopularity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPostType)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTechCategory;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartTechPopularity;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPostType;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Label lblTotalPosts;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label lblTotalTechs;
        private System.Windows.Forms.Button btnRefresh;
    }
}
