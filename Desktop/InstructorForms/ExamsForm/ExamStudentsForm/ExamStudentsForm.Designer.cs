namespace Desktop.InstructorForms.Exams
{
    partial class ExamStudentsForm
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
            idTXT = new TextBox();
            answersBTN = new Button();
            studentDATA = new DataGridView();
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
            returnBTN.Location = new Point(12, 12);
            returnBTN.Name = "returnBTN";
            returnBTN.Size = new Size(655, 62);
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
            refreshBTN.Location = new Point(667, 12);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new Size(655, 62);
            refreshBTN.TabIndex = 10;
            refreshBTN.Text = "♻ Refresh";
            refreshBTN.UseVisualStyleBackColor = true;
            refreshBTN.Click += refreshBTN_Click;
            // 
            // idTXT
            // 
            idTXT.Enabled = false;
            idTXT.Location = new Point(1503, 47);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(125, 27);
            idTXT.TabIndex = 48;
            idTXT.Visible = false;
            // 
            // answersBTN
            // 
            answersBTN.BackColor = Color.FromArgb(76, 175, 80);
            answersBTN.Cursor = Cursors.Hand;
            answersBTN.Enabled = false;
            answersBTN.FlatAppearance.BorderSize = 0;
            answersBTN.FlatStyle = FlatStyle.Flat;
            answersBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            answersBTN.ForeColor = Color.White;
            answersBTN.Location = new Point(1328, 952);
            answersBTN.Name = "answersBTN";
            answersBTN.Size = new Size(562, 76);
            answersBTN.TabIndex = 49;
            answersBTN.Text = "View Answers";
            answersBTN.UseVisualStyleBackColor = true;
            answersBTN.Click += answersBTN_Click;
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
            studentDATA.Location = new Point(12, 80);
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
            studentDATA.Size = new Size(1310, 948);
            studentDATA.TabIndex = 50;
            studentDATA.CellMouseDoubleClick += questionDATA_CellMouseDoubleClick;
            // 
            // ExamStudentsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(studentDATA);
            Controls.Add(answersBTN);
            Controls.Add(idTXT);
            Controls.Add(returnBTN);
            Controls.Add(refreshBTN);
            Name = "ExamStudentsForm";
            Text = "Question";
            FormClosed += QuestionForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)studentDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBTN;
        private Button refreshBTN;
        private TextBox idTXT;
        private Button answersBTN;
        private DataGridView studentDATA;
    }
}