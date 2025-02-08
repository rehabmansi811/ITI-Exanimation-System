namespace Desktop.InstructorForms.Students
{
    partial class StudentsForm
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
            refreshBTN = new Button();
            searchTXT = new TextBox();
            studentDATA = new DataGridView();
            panel2 = new Panel();
            ((System.ComponentModel.ISupportInitialize)studentDATA).BeginInit();
            SuspendLayout();
            // 
            // returnBTN
            // 
            returnBTN.BackColor = Color.FromArgb(194, 39, 45);
            returnBTN.Cursor = Cursors.Hand;
            returnBTN.FlatAppearance.BorderSize = 0;
            returnBTN.FlatStyle = FlatStyle.Flat;
            returnBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            returnBTN.ForeColor = Color.White;
            returnBTN.Location = new Point(12, 3);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(939, 85);
            returnBTN.TabIndex = 21;
            returnBTN.Text = "↩ Return";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // refreshBTN
            // 
            refreshBTN.BackColor = Color.FromArgb(76, 175, 80);
            refreshBTN.Cursor = Cursors.Hand;
            refreshBTN.FlatAppearance.BorderSize = 0;
            refreshBTN.FlatStyle = FlatStyle.Flat;
            refreshBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            refreshBTN.ForeColor = Color.White;
            refreshBTN.Location = new Point(951, 3);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new Size(939, 85);
            refreshBTN.TabIndex = 10;
            refreshBTN.Text = "♻ Refresh";
            refreshBTN.UseVisualStyleBackColor = true;
            refreshBTN.Click += refreshBTN_Click;
            // 
            // searchTXT
            // 
            searchTXT.BackColor = Color.White;
            searchTXT.BorderStyle = BorderStyle.None;
            searchTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTXT.Location = new Point(12, 94);
            searchTXT.Name = "searchTXT";
            searchTXT.Size = new Size(1878, 32);
            searchTXT.TabIndex = 13;
            searchTXT.TextChanged += searchTXT_TextChanged;
            // 
            // studentDATA
            // 
            studentDATA.BackgroundColor = Color.White;
            studentDATA.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            studentDATA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            studentDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 163, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            studentDATA.DefaultCellStyle = dataGridViewCellStyle2;
            studentDATA.GridColor = Color.FromArgb(240, 240, 240);
            studentDATA.Location = new Point(12, 140);
            studentDATA.Name = "studentDATA";
            studentDATA.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            studentDATA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            studentDATA.RowHeadersWidth = 51;
            studentDATA.Size = new Size(1878, 881);
            studentDATA.TabIndex = 24;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(194, 39, 45);
            panel2.Location = new Point(12, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(1878, 2);
            panel2.TabIndex = 66;
            // 
            // StudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel2);
            Controls.Add(studentDATA);
            Controls.Add(returnBTN);
            Controls.Add(refreshBTN);
            Controls.Add(searchTXT);
            Name = "StudentsForm";
            Text = "Students";
            FormClosed += StudentsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)studentDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBTN;
        private Button refreshBTN;
        private TextBox searchTXT;
        private DataGridView studentDATA;
        private Panel panel2;
    }
}