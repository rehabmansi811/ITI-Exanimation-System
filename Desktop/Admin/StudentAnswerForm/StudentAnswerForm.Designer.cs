namespace Desktop.Admin.ExamQuestionsForm
{
    partial class StudentAnswerForm
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
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            showBTN = new Button();
            examLIST = new ComboBox();
            examLBL = new Label();
            returnBTN = new Button();
            courseLIST = new ComboBox();
            courseLBL = new Label();
            correctChoice4 = new Button();
            correctChoice3 = new Button();
            correctChoice2 = new Button();
            correctChoice1 = new Button();
            choice4LBL = new Label();
            choice4TXT = new RichTextBox();
            choice3LBL = new Label();
            choice3TXT = new RichTextBox();
            choice2LBL = new Label();
            choice2TXT = new RichTextBox();
            choice1LBL = new Label();
            choice1TXT = new RichTextBox();
            label3 = new Label();
            degreeNUM = new NumericUpDown();
            label2 = new Label();
            bodyTXT = new RichTextBox();
            studentLIST = new ComboBox();
            studentLBL = new Label();
            panel5 = new Panel();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel8 = new Panel();
            panel4 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel9 = new Panel();
            topicDATA = new DataGridView();
            questionsDATA = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)degreeNUM).BeginInit();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)topicDATA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)questionsDATA).BeginInit();
            SuspendLayout();
            // 
            // showBTN
            // 
            showBTN.BackColor = Color.FromArgb(156, 39, 176);
            showBTN.Cursor = Cursors.Hand;
            showBTN.FlatAppearance.BorderSize = 0;
            showBTN.FlatStyle = FlatStyle.Flat;
            showBTN.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            showBTN.ForeColor = Color.White;
            showBTN.Location = new Point(1182, 911);
            showBTN.Name = "showBTN";
            showBTN.Size = new Size(716, 110);
            showBTN.TabIndex = 28;
            showBTN.Text = "Get Answers";
            showBTN.UseVisualStyleBackColor = false;
            showBTN.Click += showBTN_Click;
            // 
            // examLIST
            // 
            examLIST.DropDownStyle = ComboBoxStyle.DropDownList;
            examLIST.FlatStyle = FlatStyle.Flat;
            examLIST.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            examLIST.FormattingEnabled = true;
            examLIST.Location = new Point(1174, 157);
            examLIST.Name = "examLIST";
            examLIST.Size = new Size(716, 39);
            examLIST.TabIndex = 26;
            // 
            // examLBL
            // 
            examLBL.AutoSize = true;
            examLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            examLBL.ForeColor = Color.FromArgb(64, 64, 64);
            examLBL.Location = new Point(1174, 110);
            examLBL.Name = "examLBL";
            examLBL.Size = new Size(72, 32);
            examLBL.TabIndex = 25;
            examLBL.Text = "Exam";
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
            returnBTN.Size = new Size(1156, 76);
            returnBTN.TabIndex = 25;
            returnBTN.Text = "↩ Return";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // courseLIST
            // 
            courseLIST.DropDownStyle = ComboBoxStyle.DropDownList;
            courseLIST.FlatStyle = FlatStyle.Flat;
            courseLIST.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            courseLIST.FormattingEnabled = true;
            courseLIST.Location = new Point(1174, 49);
            courseLIST.Name = "courseLIST";
            courseLIST.Size = new Size(716, 39);
            courseLIST.TabIndex = 33;
            courseLIST.SelectedIndexChanged += courseLIST_SelectedIndexChanged;
            // 
            // courseLBL
            // 
            courseLBL.AutoSize = true;
            courseLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            courseLBL.ForeColor = Color.FromArgb(64, 64, 64);
            courseLBL.Location = new Point(1174, 9);
            courseLBL.Name = "courseLBL";
            courseLBL.Size = new Size(89, 32);
            courseLBL.TabIndex = 32;
            courseLBL.Text = "Course";
            // 
            // correctChoice4
            // 
            correctChoice4.BackColor = Color.White;
            correctChoice4.Cursor = Cursors.Hand;
            correctChoice4.Enabled = false;
            correctChoice4.FlatAppearance.BorderColor = Color.FromArgb(194, 39, 45);
            correctChoice4.FlatStyle = FlatStyle.Flat;
            correctChoice4.Location = new Point(1814, 782);
            correctChoice4.Name = "correctChoice4";
            correctChoice4.Size = new Size(84, 69);
            correctChoice4.TabIndex = 63;
            correctChoice4.UseVisualStyleBackColor = false;
            // 
            // correctChoice3
            // 
            correctChoice3.BackColor = Color.White;
            correctChoice3.Cursor = Cursors.Hand;
            correctChoice3.Enabled = false;
            correctChoice3.FlatAppearance.BorderColor = Color.FromArgb(194, 39, 45);
            correctChoice3.FlatStyle = FlatStyle.Flat;
            correctChoice3.Location = new Point(1449, 782);
            correctChoice3.Name = "correctChoice3";
            correctChoice3.Size = new Size(84, 69);
            correctChoice3.TabIndex = 62;
            correctChoice3.UseVisualStyleBackColor = false;
            // 
            // correctChoice2
            // 
            correctChoice2.BackColor = Color.White;
            correctChoice2.Cursor = Cursors.Hand;
            correctChoice2.Enabled = false;
            correctChoice2.FlatAppearance.BorderColor = Color.FromArgb(194, 39, 45);
            correctChoice2.FlatStyle = FlatStyle.Flat;
            correctChoice2.Location = new Point(1814, 653);
            correctChoice2.Name = "correctChoice2";
            correctChoice2.Size = new Size(84, 69);
            correctChoice2.TabIndex = 61;
            correctChoice2.UseVisualStyleBackColor = false;
            // 
            // correctChoice1
            // 
            correctChoice1.BackColor = Color.Green;
            correctChoice1.Cursor = Cursors.Hand;
            correctChoice1.FlatAppearance.BorderColor = Color.FromArgb(194, 39, 45);
            correctChoice1.FlatStyle = FlatStyle.Flat;
            correctChoice1.Location = new Point(1449, 653);
            correctChoice1.Name = "correctChoice1";
            correctChoice1.Size = new Size(84, 69);
            correctChoice1.TabIndex = 6;
            correctChoice1.UseVisualStyleBackColor = false;
            // 
            // choice4LBL
            // 
            choice4LBL.AutoSize = true;
            choice4LBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            choice4LBL.ForeColor = Color.FromArgb(64, 64, 64);
            choice4LBL.Location = new Point(1539, 733);
            choice4LBL.Name = "choice4LBL";
            choice4LBL.Size = new Size(108, 32);
            choice4LBL.TabIndex = 59;
            choice4LBL.Text = "Choice 4";
            // 
            // choice4TXT
            // 
            choice4TXT.BackColor = Color.White;
            choice4TXT.BorderStyle = BorderStyle.None;
            choice4TXT.Font = new Font("Segoe UI", 12F);
            choice4TXT.Location = new Point(1539, 782);
            choice4TXT.Name = "choice4TXT";
            choice4TXT.ReadOnly = true;
            choice4TXT.Size = new Size(269, 69);
            choice4TXT.TabIndex = 58;
            choice4TXT.Text = "";
            // 
            // choice3LBL
            // 
            choice3LBL.AutoSize = true;
            choice3LBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            choice3LBL.ForeColor = Color.FromArgb(64, 64, 64);
            choice3LBL.Location = new Point(1174, 733);
            choice3LBL.Name = "choice3LBL";
            choice3LBL.Size = new Size(107, 32);
            choice3LBL.TabIndex = 57;
            choice3LBL.Text = "Choice 3";
            // 
            // choice3TXT
            // 
            choice3TXT.BackColor = Color.White;
            choice3TXT.BorderStyle = BorderStyle.None;
            choice3TXT.Font = new Font("Segoe UI", 12F);
            choice3TXT.Location = new Point(1174, 782);
            choice3TXT.Name = "choice3TXT";
            choice3TXT.ReadOnly = true;
            choice3TXT.Size = new Size(269, 69);
            choice3TXT.TabIndex = 56;
            choice3TXT.Text = "";
            // 
            // choice2LBL
            // 
            choice2LBL.AutoSize = true;
            choice2LBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            choice2LBL.ForeColor = Color.FromArgb(64, 64, 64);
            choice2LBL.Location = new Point(1539, 600);
            choice2LBL.Name = "choice2LBL";
            choice2LBL.Size = new Size(107, 32);
            choice2LBL.TabIndex = 55;
            choice2LBL.Text = "Choice 2";
            // 
            // choice2TXT
            // 
            choice2TXT.BackColor = Color.White;
            choice2TXT.BorderStyle = BorderStyle.None;
            choice2TXT.Font = new Font("Segoe UI", 12F);
            choice2TXT.Location = new Point(1539, 653);
            choice2TXT.Name = "choice2TXT";
            choice2TXT.ReadOnly = true;
            choice2TXT.Size = new Size(269, 69);
            choice2TXT.TabIndex = 54;
            choice2TXT.Text = "";
            // 
            // choice1LBL
            // 
            choice1LBL.AutoSize = true;
            choice1LBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            choice1LBL.ForeColor = Color.FromArgb(64, 64, 64);
            choice1LBL.Location = new Point(1174, 600);
            choice1LBL.Name = "choice1LBL";
            choice1LBL.Size = new Size(104, 32);
            choice1LBL.TabIndex = 53;
            choice1LBL.Text = "Choice 1";
            // 
            // choice1TXT
            // 
            choice1TXT.BackColor = Color.White;
            choice1TXT.BorderStyle = BorderStyle.None;
            choice1TXT.Font = new Font("Segoe UI", 12F);
            choice1TXT.Location = new Point(1174, 653);
            choice1TXT.Name = "choice1TXT";
            choice1TXT.ReadOnly = true;
            choice1TXT.Size = new Size(269, 69);
            choice1TXT.TabIndex = 5;
            choice1TXT.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(1174, 494);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 51;
            label3.Text = "Degree";
            // 
            // degreeNUM
            // 
            degreeNUM.BackColor = Color.White;
            degreeNUM.BorderStyle = BorderStyle.None;
            degreeNUM.Font = new Font("Segoe UI", 14F);
            degreeNUM.Location = new Point(1174, 529);
            degreeNUM.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            degreeNUM.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            degreeNUM.Name = "degreeNUM";
            degreeNUM.ReadOnly = true;
            degreeNUM.Size = new Size(716, 35);
            degreeNUM.TabIndex = 50;
            degreeNUM.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(1174, 328);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 49;
            label2.Text = "Body";
            // 
            // bodyTXT
            // 
            bodyTXT.BackColor = Color.White;
            bodyTXT.BorderStyle = BorderStyle.None;
            bodyTXT.Font = new Font("Segoe UI", 12F);
            bodyTXT.Location = new Point(1174, 363);
            bodyTXT.Name = "bodyTXT";
            bodyTXT.ReadOnly = true;
            bodyTXT.Size = new Size(716, 120);
            bodyTXT.TabIndex = 1;
            bodyTXT.Text = "";
            // 
            // studentLIST
            // 
            studentLIST.DropDownStyle = ComboBoxStyle.DropDownList;
            studentLIST.FlatStyle = FlatStyle.Flat;
            studentLIST.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            studentLIST.FormattingEnabled = true;
            studentLIST.Location = new Point(1174, 269);
            studentLIST.Name = "studentLIST";
            studentLIST.Size = new Size(716, 39);
            studentLIST.TabIndex = 65;
            // 
            // studentLBL
            // 
            studentLBL.AutoSize = true;
            studentLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            studentLBL.ForeColor = Color.FromArgb(64, 64, 64);
            studentLBL.Location = new Point(1174, 220);
            studentLBL.Name = "studentLBL";
            studentLBL.Size = new Size(109, 32);
            studentLBL.TabIndex = 64;
            studentLBL.Text = "Students";
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(194, 39, 45);
            panel5.Location = new Point(1174, 728);
            panel5.Name = "panel5";
            panel5.Size = new Size(359, 2);
            panel5.TabIndex = 67;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 39, 45);
            panel1.Location = new Point(1539, 728);
            panel1.Name = "panel1";
            panel1.Size = new Size(359, 2);
            panel1.TabIndex = 67;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(194, 39, 45);
            panel2.Location = new Point(1174, 857);
            panel2.Name = "panel2";
            panel2.Size = new Size(359, 2);
            panel2.TabIndex = 67;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(194, 39, 45);
            panel3.Location = new Point(1539, 857);
            panel3.Name = "panel3";
            panel3.Size = new Size(359, 2);
            panel3.TabIndex = 67;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(194, 39, 45);
            panel8.Location = new Point(1174, 489);
            panel8.Name = "panel8";
            panel8.Size = new Size(716, 2);
            panel8.TabIndex = 68;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(194, 39, 45);
            panel4.Location = new Point(1174, 314);
            panel4.Name = "panel4";
            panel4.Size = new Size(716, 2);
            panel4.TabIndex = 69;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(194, 39, 45);
            panel6.Location = new Point(1174, 202);
            panel6.Name = "panel6";
            panel6.Size = new Size(716, 2);
            panel6.TabIndex = 69;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(194, 39, 45);
            panel7.Location = new Point(1174, 94);
            panel7.Name = "panel7";
            panel7.Size = new Size(716, 2);
            panel7.TabIndex = 69;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(194, 39, 45);
            panel9.Controls.Add(topicDATA);
            panel9.Location = new Point(1174, 570);
            panel9.Name = "panel9";
            panel9.Size = new Size(716, 2);
            panel9.TabIndex = 70;
            // 
            // topicDATA
            // 
            topicDATA.BackgroundColor = Color.White;
            topicDATA.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = SystemColors.Control;
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle7.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.True;
            topicDATA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            topicDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(28, 163, 232);
            dataGridViewCellStyle8.SelectionForeColor = Color.White;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            topicDATA.DefaultCellStyle = dataGridViewCellStyle8;
            topicDATA.GridColor = Color.FromArgb(240, 240, 240);
            topicDATA.Location = new Point(-220, -462);
            topicDATA.Name = "topicDATA";
            topicDATA.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            topicDATA.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            topicDATA.RowHeadersWidth = 51;
            topicDATA.Size = new Size(1156, 927);
            topicDATA.TabIndex = 73;
            // 
            // questionsDATA
            // 
            questionsDATA.BackgroundColor = Color.White;
            questionsDATA.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = SystemColors.Control;
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle10.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.True;
            questionsDATA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            questionsDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle11.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = SystemColors.Window;
            dataGridViewCellStyle11.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle11.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(28, 163, 232);
            dataGridViewCellStyle11.SelectionForeColor = Color.White;
            dataGridViewCellStyle11.WrapMode = DataGridViewTriState.False;
            questionsDATA.DefaultCellStyle = dataGridViewCellStyle11;
            questionsDATA.GridColor = Color.FromArgb(240, 240, 240);
            questionsDATA.Location = new Point(12, 94);
            questionsDATA.Name = "questionsDATA";
            questionsDATA.ReadOnly = true;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = SystemColors.Control;
            dataGridViewCellStyle12.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            questionsDATA.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            questionsDATA.RowHeadersWidth = 51;
            questionsDATA.Size = new Size(1156, 927);
            questionsDATA.TabIndex = 73;
            questionsDATA.CellDoubleClick += questionsDATA_CellDoubleClick;
            // 
            // StudentAnswerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(questionsDATA);
            Controls.Add(panel9);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel4);
            Controls.Add(panel8);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel5);
            Controls.Add(studentLIST);
            Controls.Add(studentLBL);
            Controls.Add(correctChoice4);
            Controls.Add(correctChoice3);
            Controls.Add(correctChoice2);
            Controls.Add(correctChoice1);
            Controls.Add(choice4LBL);
            Controls.Add(choice4TXT);
            Controls.Add(choice3LBL);
            Controls.Add(choice3TXT);
            Controls.Add(choice2LBL);
            Controls.Add(choice2TXT);
            Controls.Add(choice1LBL);
            Controls.Add(choice1TXT);
            Controls.Add(label3);
            Controls.Add(degreeNUM);
            Controls.Add(label2);
            Controls.Add(bodyTXT);
            Controls.Add(courseLIST);
            Controls.Add(courseLBL);
            Controls.Add(showBTN);
            Controls.Add(examLIST);
            Controls.Add(examLBL);
            Controls.Add(returnBTN);
            Name = "StudentAnswerForm";
            Text = "ExamQuestionForm";
            FormClosed += ExamQuestionForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)degreeNUM).EndInit();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)topicDATA).EndInit();
            ((System.ComponentModel.ISupportInitialize)questionsDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button showBTN;
        private ComboBox examLIST;
        private Label examLBL;
        private Button returnBTN;
        private ComboBox courseLIST;
        private Label courseLBL;
        private Button correctChoice4;
        private Button correctChoice3;
        private Button correctChoice2;
        private Button correctChoice1;
        private Label choice4LBL;
        private RichTextBox choice4TXT;
        private Label choice3LBL;
        private RichTextBox choice3TXT;
        private Label choice2LBL;
        private RichTextBox choice2TXT;
        private Label choice1LBL;
        private RichTextBox choice1TXT;
        private Label label3;
        private NumericUpDown degreeNUM;
        private Label label2;
        private RichTextBox bodyTXT;
        private ComboBox studentLIST;
        private Label studentLBL;
        private Panel panel5;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel8;
        private Panel panel4;
        private Panel panel6;
        private Panel panel7;
        private Panel panel9;
        private DataGridView topicDATA;
        private DataGridView questionsDATA;
    }
}