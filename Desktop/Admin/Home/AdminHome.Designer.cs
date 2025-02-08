using System.Drawing.Drawing2D;

namespace Desktop
{
    partial class AdminHome
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
            crsTopBTN = new Button();
            examQuReport = new Button();
            stdAnsBTN = new Button();
            insCrsBTN = new Button();
            stdGradeBTN = new Button();
            stdDeptBTN = new Button();
            logOutBTN = new Button();
            mainPanel = new TableLayoutPanel();
            headerPanel = new Panel();
            titleLBL = new Label();
            footerPanel = new Panel();
            mainPanel.SuspendLayout();
            headerPanel.SuspendLayout();
            SuspendLayout();
            // 
            // crsTopBTN
            // 
            crsTopBTN.BackColor = Color.FromArgb(28, 163, 232);
            crsTopBTN.Cursor = Cursors.Hand;
            crsTopBTN.Dock = DockStyle.Fill;
            crsTopBTN.FlatAppearance.BorderSize = 0;
            crsTopBTN.FlatStyle = FlatStyle.Flat;
            crsTopBTN.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            crsTopBTN.ForeColor = Color.White;
            crsTopBTN.Location = new Point(23, 23);
            crsTopBTN.Name = "crsTopBTN";
            crsTopBTN.Size = new Size(614, 390);
            crsTopBTN.TabIndex = 0;
            crsTopBTN.Text = "Course Topics Report";
            crsTopBTN.UseVisualStyleBackColor = false;
            crsTopBTN.Click += crsTopBTN_Click;
            // 
            // examQuReport
            // 
            examQuReport.BackColor = Color.FromArgb(76, 175, 80);
            examQuReport.Cursor = Cursors.Hand;
            examQuReport.Dock = DockStyle.Fill;
            examQuReport.FlatAppearance.BorderSize = 0;
            examQuReport.FlatStyle = FlatStyle.Flat;
            examQuReport.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            examQuReport.ForeColor = Color.White;
            examQuReport.Location = new Point(643, 23);
            examQuReport.Name = "examQuReport";
            examQuReport.Size = new Size(614, 390);
            examQuReport.TabIndex = 1;
            examQuReport.Text = "Exam Questions Report";
            examQuReport.UseVisualStyleBackColor = false;
            examQuReport.Click += examQuReport_Click;
            // 
            // stdAnsBTN
            // 
            stdAnsBTN.BackColor = Color.FromArgb(156, 39, 176);
            stdAnsBTN.Cursor = Cursors.Hand;
            stdAnsBTN.Dock = DockStyle.Fill;
            stdAnsBTN.FlatAppearance.BorderSize = 0;
            stdAnsBTN.FlatStyle = FlatStyle.Flat;
            stdAnsBTN.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            stdAnsBTN.ForeColor = Color.White;
            stdAnsBTN.Location = new Point(1263, 23);
            stdAnsBTN.Name = "stdAnsBTN";
            stdAnsBTN.Size = new Size(616, 390);
            stdAnsBTN.TabIndex = 2;
            stdAnsBTN.Text = "Student Answers Report";
            stdAnsBTN.UseVisualStyleBackColor = false;
            stdAnsBTN.Click += stdAnsBTN_Click;
            // 
            // insCrsBTN
            // 
            insCrsBTN.BackColor = Color.FromArgb(33, 150, 243);
            insCrsBTN.Cursor = Cursors.Hand;
            insCrsBTN.Dock = DockStyle.Fill;
            insCrsBTN.FlatAppearance.BorderSize = 0;
            insCrsBTN.FlatStyle = FlatStyle.Flat;
            insCrsBTN.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            insCrsBTN.ForeColor = Color.White;
            insCrsBTN.Location = new Point(1263, 419);
            insCrsBTN.Name = "insCrsBTN";
            insCrsBTN.Size = new Size(616, 391);
            insCrsBTN.TabIndex = 5;
            insCrsBTN.Text = "Instructor Courses Report";
            insCrsBTN.UseVisualStyleBackColor = false;
            insCrsBTN.Click += insCrsBTN_Click;
            // 
            // stdGradeBTN
            // 
            stdGradeBTN.BackColor = Color.FromArgb(244, 67, 54);
            stdGradeBTN.Cursor = Cursors.Hand;
            stdGradeBTN.Dock = DockStyle.Fill;
            stdGradeBTN.FlatAppearance.BorderSize = 0;
            stdGradeBTN.FlatStyle = FlatStyle.Flat;
            stdGradeBTN.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            stdGradeBTN.ForeColor = Color.White;
            stdGradeBTN.Location = new Point(643, 419);
            stdGradeBTN.Name = "stdGradeBTN";
            stdGradeBTN.Size = new Size(614, 391);
            stdGradeBTN.TabIndex = 4;
            stdGradeBTN.Text = "Student Grades Report";
            stdGradeBTN.UseVisualStyleBackColor = false;
            stdGradeBTN.Click += stdGradeBTN_Click;
            // 
            // stdDeptBTN
            // 
            stdDeptBTN.BackColor = Color.FromArgb(255, 152, 0);
            stdDeptBTN.Cursor = Cursors.Hand;
            stdDeptBTN.Dock = DockStyle.Fill;
            stdDeptBTN.FlatAppearance.BorderSize = 0;
            stdDeptBTN.FlatStyle = FlatStyle.Flat;
            stdDeptBTN.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold);
            stdDeptBTN.ForeColor = Color.White;
            stdDeptBTN.Location = new Point(23, 419);
            stdDeptBTN.Name = "stdDeptBTN";
            stdDeptBTN.Size = new Size(614, 391);
            stdDeptBTN.TabIndex = 3;
            stdDeptBTN.Text = "Department Students Report";
            stdDeptBTN.UseVisualStyleBackColor = false;
            stdDeptBTN.Click += stdDeptBTN_Click;
            // 
            // logOutBTN
            // 
            logOutBTN.Anchor = AnchorStyles.Right;
            logOutBTN.BackColor = Color.FromArgb(194, 39, 45);
            logOutBTN.Cursor = Cursors.Hand;
            logOutBTN.FlatAppearance.BorderSize = 0;
            logOutBTN.FlatStyle = FlatStyle.Flat;
            logOutBTN.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            logOutBTN.ForeColor = Color.White;
            logOutBTN.Location = new Point(1720, 25);
            logOutBTN.Name = "logOutBTN";
            logOutBTN.Size = new Size(150, 50);
            logOutBTN.TabIndex = 1;
            logOutBTN.Text = "LOGOUT";
            logOutBTN.UseVisualStyleBackColor = false;
            logOutBTN.Click += logOutBTN_Click;
            // 
            // mainPanel
            // 
            mainPanel.ColumnCount = 3;
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33333F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            mainPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33334F));
            mainPanel.Controls.Add(crsTopBTN, 0, 0);
            mainPanel.Controls.Add(examQuReport, 1, 0);
            mainPanel.Controls.Add(stdAnsBTN, 2, 0);
            mainPanel.Controls.Add(stdDeptBTN, 0, 1);
            mainPanel.Controls.Add(stdGradeBTN, 1, 1);
            mainPanel.Controls.Add(insCrsBTN, 2, 1);
            mainPanel.Dock = DockStyle.Fill;
            mainPanel.Location = new Point(0, 100);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.RowCount = 2;
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            mainPanel.Size = new Size(1902, 833);
            mainPanel.TabIndex = 1;
            // 
            // headerPanel
            // 
            headerPanel.Controls.Add(titleLBL);
            headerPanel.Controls.Add(logOutBTN);
            headerPanel.Dock = DockStyle.Top;
            headerPanel.Location = new Point(0, 0);
            headerPanel.Name = "headerPanel";
            headerPanel.Size = new Size(1902, 100);
            headerPanel.TabIndex = 0;
            // 
            // titleLBL
            // 
            titleLBL.Anchor = AnchorStyles.Left;
            titleLBL.AutoSize = true;
            titleLBL.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            titleLBL.Location = new Point(20, 23);
            titleLBL.Name = "titleLBL";
            titleLBL.Size = new Size(351, 54);
            titleLBL.TabIndex = 0;
            titleLBL.Text = "Admin Dashboard";
            // 
            // footerPanel
            // 
            footerPanel.Dock = DockStyle.Bottom;
            footerPanel.Location = new Point(0, 933);
            footerPanel.Name = "footerPanel";
            footerPanel.Size = new Size(1902, 100);
            footerPanel.TabIndex = 2;
            // 
            // AdminHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(mainPanel);
            Controls.Add(footerPanel);
            Controls.Add(headerPanel);
            Name = "AdminHome";
            Text = "Admin Dashboard";
            FormClosed += AdminHome_FormClosed;
            mainPanel.ResumeLayout(false);
            headerPanel.ResumeLayout(false);
            headerPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button crsTopBTN;
        private Button examQuReport;
        private Button stdAnsBTN;
        private Button insCrsBTN;
        private Button stdGradeBTN;
        private Button stdDeptBTN;
        private Button logOutBTN;
        private Label headerLBL;
        private Panel panel3;
        private TableLayoutPanel mainPanel;
        private Panel headerPanel;
        private Panel footerPanel;
        private Label titleLBL;

        private void RoundedButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            using (var path = GetRoundedRectanglePath(btn.ClientRectangle, 15))
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                e.Graphics.FillPath(new SolidBrush(btn.BackColor), path);
            }
        }

        private GraphicsPath GetRoundedRectanglePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }
    }
}