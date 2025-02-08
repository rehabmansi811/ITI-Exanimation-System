using System.Drawing.Drawing2D;

namespace Desktop.Admin.CourseTopicForm
{
    partial class CourseTopicForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            returnBTN = new Button();
            topicDATA = new DataGridView();
            courseLBL = new Label();
            courseLIST = new ComboBox();
            showBTN = new Button();
            nameTXT = new RichTextBox();
            idTXT = new RichTextBox();
            nameLBL = new Label();
            idLBL = new Label();
            mainPanel = new Panel();
            sidePanel = new Panel();
            panel2 = new Panel();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)topicDATA).BeginInit();
            mainPanel.SuspendLayout();
            sidePanel.SuspendLayout();
            SuspendLayout();
            // 
            // returnBTN
            // 
            returnBTN.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            returnBTN.BackColor = Color.FromArgb(194, 39, 45);
            returnBTN.Cursor = Cursors.Hand;
            returnBTN.FlatAppearance.BorderSize = 0;
            returnBTN.FlatStyle = FlatStyle.Flat;
            returnBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBTN.ForeColor = Color.White;
            returnBTN.Location = new Point(12, 12);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(1404, 76);
            returnBTN.TabIndex = 0;
            returnBTN.Text = "↩ Return";
            returnBTN.UseVisualStyleBackColor = false;
            returnBTN.Click += returnBTN_Click;
            returnBTN.Paint += RoundedButton_Paint;
            // 
            // topicDATA
            // 
            topicDATA.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            topicDATA.BackgroundColor = Color.White;
            topicDATA.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            topicDATA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            topicDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 163, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            topicDATA.DefaultCellStyle = dataGridViewCellStyle2;
            topicDATA.GridColor = Color.FromArgb(240, 240, 240);
            topicDATA.Location = new Point(20, 100);
            topicDATA.Name = "topicDATA";
            topicDATA.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            topicDATA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            topicDATA.RowHeadersWidth = 51;
            topicDATA.RowTemplate.Height = 40;
            topicDATA.Size = new Size(1396, 800);
            topicDATA.TabIndex = 1;
            topicDATA.CellDoubleClick += topicDATA_CellDoubleClick;
            // 
            // courseLBL
            // 
            courseLBL.AutoSize = true;
            courseLBL.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            courseLBL.ForeColor = Color.FromArgb(64, 64, 64);
            courseLBL.Location = new Point(30, 14);
            courseLBL.Name = "courseLBL";
            courseLBL.Size = new Size(120, 41);
            courseLBL.TabIndex = 2;
            courseLBL.Text = "Course:";
            // 
            // courseLIST
            // 
            courseLIST.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            courseLIST.DropDownStyle = ComboBoxStyle.DropDownList;
            courseLIST.FlatStyle = FlatStyle.Flat;
            courseLIST.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseLIST.FormattingEnabled = true;
            courseLIST.Location = new Point(30, 71);
            courseLIST.Name = "courseLIST";
            courseLIST.Size = new Size(400, 39);
            courseLIST.TabIndex = 3;
            // 
            // showBTN
            // 
            showBTN.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            showBTN.BackColor = Color.FromArgb(28, 163, 232);
            showBTN.Cursor = Cursors.Hand;
            showBTN.FlatAppearance.BorderSize = 0;
            showBTN.FlatStyle = FlatStyle.Flat;
            showBTN.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            showBTN.ForeColor = Color.White;
            showBTN.Location = new Point(30, 413);
            showBTN.Name = "showBTN";
            showBTN.Size = new Size(400, 60);
            showBTN.TabIndex = 4;
            showBTN.Text = "Get Topics";
            showBTN.UseVisualStyleBackColor = false;
            showBTN.Click += showBTN_Click;
            showBTN.Paint += RoundedButton_Paint;
            // 
            // nameTXT
            // 
            nameTXT.BackColor = Color.White;
            nameTXT.BorderStyle = BorderStyle.None;
            nameTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTXT.Location = new Point(33, 307);
            nameTXT.Name = "nameTXT";
            nameTXT.ReadOnly = true;
            nameTXT.Size = new Size(372, 40);
            nameTXT.TabIndex = 6;
            nameTXT.Text = "";
            nameTXT.MouseDown += idTXT_MouseDown;
            // 
            // idTXT
            // 
            idTXT.BackColor = Color.White;
            idTXT.BorderStyle = BorderStyle.None;
            idTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idTXT.Location = new Point(33, 174);
            idTXT.Name = "idTXT";
            idTXT.ReadOnly = true;
            idTXT.Size = new Size(372, 40);
            idTXT.TabIndex = 5;
            idTXT.Text = "";
            idTXT.MouseDown += idTXT_MouseDown;
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            nameLBL.ForeColor = Color.FromArgb(64, 64, 64);
            nameLBL.Location = new Point(30, 259);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(85, 32);
            nameLBL.TabIndex = 8;
            nameLBL.Text = "Name:";
            // 
            // idLBL
            // 
            idLBL.AutoSize = true;
            idLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            idLBL.ForeColor = Color.FromArgb(64, 64, 64);
            idLBL.Location = new Point(30, 126);
            idLBL.Name = "idLBL";
            idLBL.Size = new Size(44, 32);
            idLBL.TabIndex = 7;
            idLBL.Text = "ID:";
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(topicDATA);
            mainPanel.Controls.Add(returnBTN);
            mainPanel.Dock = DockStyle.Left;
            mainPanel.Location = new Point(0, 0);
            mainPanel.Name = "mainPanel";
            mainPanel.Padding = new Padding(20);
            mainPanel.Size = new Size(1436, 1033);
            mainPanel.TabIndex = 9;
            // 
            // sidePanel
            // 
            sidePanel.Controls.Add(panel2);
            sidePanel.Controls.Add(panel1);
            sidePanel.Controls.Add(idLBL);
            sidePanel.Controls.Add(courseLBL);
            sidePanel.Controls.Add(idTXT);
            sidePanel.Controls.Add(nameLBL);
            sidePanel.Controls.Add(courseLIST);
            sidePanel.Controls.Add(nameTXT);
            sidePanel.Controls.Add(showBTN);
            sidePanel.Location = new Point(1442, 0);
            sidePanel.Name = "sidePanel";
            sidePanel.Padding = new Padding(30);
            sidePanel.Size = new Size(460, 1033);
            sidePanel.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(194, 39, 45);
            panel2.Location = new Point(33, 220);
            panel2.Name = "panel2";
            panel2.Size = new Size(372, 2);
            panel2.TabIndex = 69;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 39, 45);
            panel1.Location = new Point(33, 353);
            panel1.Name = "panel1";
            panel1.Size = new Size(372, 2);
            panel1.TabIndex = 68;
            // 
            // CourseTopicForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1902, 1033);
            Controls.Add(sidePanel);
            Controls.Add(mainPanel);
            Name = "CourseTopicForm";
            Text = "Course Topics Management";
            FormClosed += CourseTopicForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)topicDATA).EndInit();
            mainPanel.ResumeLayout(false);
            sidePanel.ResumeLayout(false);
            sidePanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button returnBTN;
        private System.Windows.Forms.DataGridView topicDATA;
        private System.Windows.Forms.Label courseLBL;
        private System.Windows.Forms.ComboBox courseLIST;
        private System.Windows.Forms.Button showBTN;
        private System.Windows.Forms.RichTextBox nameTXT;
        private System.Windows.Forms.RichTextBox idTXT;
        private System.Windows.Forms.Label nameLBL;
        private System.Windows.Forms.Label idLBL;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel sidePanel;

        private void RoundedButton_Paint(object sender, PaintEventArgs e)
        {
            Button btn = (Button)sender;
            // Create the rounded rectangle path
            using (var path = GetRoundedRectanglePath(btn.ClientRectangle, 10))
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                // Draw the background
                using (SolidBrush brush = new SolidBrush(btn.BackColor))
                {
                    e.Graphics.FillPath(brush, path);
                }
                // Optionally, draw the border if needed:
                if (btn.FlatAppearance.BorderSize > 0)
                {
                    using (Pen pen = new Pen(btn.FlatAppearance.BorderColor, btn.FlatAppearance.BorderSize))
                    {
                        e.Graphics.DrawPath(pen, path);
                    }
                }
            }
            TextRenderer.DrawText(
            e.Graphics,
            btn.Text,
            btn.Font,
            btn.ClientRectangle,
            btn.ForeColor,
            TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

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

        private Panel panel1;
        private Panel panel2;
    }
}