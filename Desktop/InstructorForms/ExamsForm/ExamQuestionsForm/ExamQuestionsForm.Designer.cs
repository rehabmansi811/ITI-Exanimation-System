namespace Desktop.InstructorForms.Exams
{
    partial class ExamQuestionsForm
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
            bodyTXT = new RichTextBox();
            typeBOX = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            degreeNUM = new NumericUpDown();
            label3 = new Label();
            choice1TXT = new RichTextBox();
            choice1LBL = new Label();
            choice2LBL = new Label();
            choice2TXT = new RichTextBox();
            choice3LBL = new Label();
            choice3TXT = new RichTextBox();
            choice4LBL = new Label();
            choice4TXT = new RichTextBox();
            correctChoice1 = new Button();
            correctChoice2 = new Button();
            correctChoice3 = new Button();
            correctChoice4 = new Button();
            idTXT = new TextBox();
            endViewBTN = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            questionDATA = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)degreeNUM).BeginInit();
            ((System.ComponentModel.ISupportInitialize)questionDATA).BeginInit();
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
            // bodyTXT
            // 
            bodyTXT.BackColor = Color.White;
            bodyTXT.BorderStyle = BorderStyle.None;
            bodyTXT.Font = new Font("Segoe UI", 12F);
            bodyTXT.Location = new Point(1328, 163);
            bodyTXT.Name = "bodyTXT";
            bodyTXT.Size = new Size(562, 39);
            bodyTXT.TabIndex = 22;
            bodyTXT.Text = "";
            // 
            // typeBOX
            // 
            typeBOX.DropDownStyle = ComboBoxStyle.DropDownList;
            typeBOX.FlatStyle = FlatStyle.Flat;
            typeBOX.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            typeBOX.FormattingEnabled = true;
            typeBOX.Items.AddRange(new object[] { "T/F", "MCQ" });
            typeBOX.Location = new Point(1328, 58);
            typeBOX.Name = "typeBOX";
            typeBOX.Size = new Size(562, 39);
            typeBOX.TabIndex = 23;
            typeBOX.SelectedIndexChanged += typeBOX_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(1328, 5);
            label1.Name = "label1";
            label1.Size = new Size(65, 32);
            label1.TabIndex = 24;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(64, 64, 64);
            label2.Location = new Point(1328, 128);
            label2.Name = "label2";
            label2.Size = new Size(69, 32);
            label2.TabIndex = 25;
            label2.Text = "Body";
            // 
            // degreeNUM
            // 
            degreeNUM.BackColor = Color.White;
            degreeNUM.BorderStyle = BorderStyle.None;
            degreeNUM.Font = new Font("Segoe UI", 14F);
            degreeNUM.Location = new Point(1328, 278);
            degreeNUM.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            degreeNUM.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            degreeNUM.Name = "degreeNUM";
            degreeNUM.Size = new Size(562, 35);
            degreeNUM.TabIndex = 30;
            degreeNUM.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            label3.ForeColor = Color.FromArgb(64, 64, 64);
            label3.Location = new Point(1328, 243);
            label3.Name = "label3";
            label3.Size = new Size(93, 32);
            label3.TabIndex = 31;
            label3.Text = "Degree";
            // 
            // choice1TXT
            // 
            choice1TXT.BackColor = Color.White;
            choice1TXT.BorderStyle = BorderStyle.None;
            choice1TXT.Font = new Font("Segoe UI", 12F);
            choice1TXT.Location = new Point(1328, 399);
            choice1TXT.Name = "choice1TXT";
            choice1TXT.Size = new Size(472, 69);
            choice1TXT.TabIndex = 32;
            choice1TXT.Text = "";
            // 
            // choice1LBL
            // 
            choice1LBL.AutoSize = true;
            choice1LBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            choice1LBL.ForeColor = Color.FromArgb(64, 64, 64);
            choice1LBL.Location = new Point(1328, 364);
            choice1LBL.Name = "choice1LBL";
            choice1LBL.Size = new Size(104, 32);
            choice1LBL.TabIndex = 36;
            choice1LBL.Text = "Choice 1";
            // 
            // choice2LBL
            // 
            choice2LBL.AutoSize = true;
            choice2LBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            choice2LBL.ForeColor = Color.FromArgb(64, 64, 64);
            choice2LBL.Location = new Point(1328, 512);
            choice2LBL.Name = "choice2LBL";
            choice2LBL.Size = new Size(107, 32);
            choice2LBL.TabIndex = 38;
            choice2LBL.Text = "Choice 2";
            // 
            // choice2TXT
            // 
            choice2TXT.BackColor = Color.White;
            choice2TXT.BorderStyle = BorderStyle.None;
            choice2TXT.Font = new Font("Segoe UI", 12F);
            choice2TXT.Location = new Point(1328, 547);
            choice2TXT.Name = "choice2TXT";
            choice2TXT.Size = new Size(472, 69);
            choice2TXT.TabIndex = 37;
            choice2TXT.Text = "";
            // 
            // choice3LBL
            // 
            choice3LBL.AutoSize = true;
            choice3LBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            choice3LBL.ForeColor = Color.FromArgb(64, 64, 64);
            choice3LBL.Location = new Point(1325, 651);
            choice3LBL.Name = "choice3LBL";
            choice3LBL.Size = new Size(107, 32);
            choice3LBL.TabIndex = 40;
            choice3LBL.Text = "Choice 3";
            choice3LBL.Visible = false;
            // 
            // choice3TXT
            // 
            choice3TXT.BackColor = Color.White;
            choice3TXT.BorderStyle = BorderStyle.None;
            choice3TXT.Font = new Font("Segoe UI", 12F);
            choice3TXT.Location = new Point(1324, 686);
            choice3TXT.Name = "choice3TXT";
            choice3TXT.Size = new Size(472, 69);
            choice3TXT.TabIndex = 39;
            choice3TXT.Text = "";
            choice3TXT.Visible = false;
            // 
            // choice4LBL
            // 
            choice4LBL.AutoSize = true;
            choice4LBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            choice4LBL.ForeColor = Color.FromArgb(64, 64, 64);
            choice4LBL.Location = new Point(1328, 790);
            choice4LBL.Name = "choice4LBL";
            choice4LBL.Size = new Size(108, 32);
            choice4LBL.TabIndex = 42;
            choice4LBL.Text = "Choice 4";
            choice4LBL.Visible = false;
            // 
            // choice4TXT
            // 
            choice4TXT.BackColor = Color.White;
            choice4TXT.BorderStyle = BorderStyle.None;
            choice4TXT.Font = new Font("Segoe UI", 12F);
            choice4TXT.Location = new Point(1324, 825);
            choice4TXT.Name = "choice4TXT";
            choice4TXT.Size = new Size(472, 69);
            choice4TXT.TabIndex = 41;
            choice4TXT.Text = "";
            choice4TXT.Visible = false;
            // 
            // correctChoice1
            // 
            correctChoice1.BackColor = Color.Green;
            correctChoice1.Cursor = Cursors.Hand;
            correctChoice1.FlatAppearance.BorderColor = Color.FromArgb(194, 39, 45);
            correctChoice1.FlatStyle = FlatStyle.Flat;
            correctChoice1.Location = new Point(1806, 399);
            correctChoice1.Name = "correctChoice1";
            correctChoice1.Size = new Size(84, 69);
            correctChoice1.TabIndex = 44;
            correctChoice1.UseVisualStyleBackColor = false;
            correctChoice1.Click += correctChoice1_Click;
            // 
            // correctChoice2
            // 
            correctChoice2.BackColor = Color.White;
            correctChoice2.Cursor = Cursors.Hand;
            correctChoice2.FlatAppearance.BorderColor = Color.FromArgb(194, 39, 45);
            correctChoice2.FlatStyle = FlatStyle.Flat;
            correctChoice2.Location = new Point(1806, 547);
            correctChoice2.Name = "correctChoice2";
            correctChoice2.Size = new Size(84, 69);
            correctChoice2.TabIndex = 45;
            correctChoice2.UseVisualStyleBackColor = false;
            correctChoice2.Click += correctChoice2_Click;
            // 
            // correctChoice3
            // 
            correctChoice3.BackColor = Color.White;
            correctChoice3.Cursor = Cursors.Hand;
            correctChoice3.Enabled = false;
            correctChoice3.FlatAppearance.BorderColor = Color.FromArgb(194, 39, 45);
            correctChoice3.FlatStyle = FlatStyle.Flat;
            correctChoice3.Location = new Point(1802, 686);
            correctChoice3.Name = "correctChoice3";
            correctChoice3.Size = new Size(84, 69);
            correctChoice3.TabIndex = 46;
            correctChoice3.UseVisualStyleBackColor = false;
            correctChoice3.Visible = false;
            correctChoice3.Click += correctChoice3_Click;
            // 
            // correctChoice4
            // 
            correctChoice4.BackColor = Color.White;
            correctChoice4.Cursor = Cursors.Hand;
            correctChoice4.Enabled = false;
            correctChoice4.FlatAppearance.BorderColor = Color.FromArgb(194, 39, 45);
            correctChoice4.FlatStyle = FlatStyle.Flat;
            correctChoice4.Location = new Point(1802, 825);
            correctChoice4.Name = "correctChoice4";
            correctChoice4.Size = new Size(84, 69);
            correctChoice4.TabIndex = 47;
            correctChoice4.UseVisualStyleBackColor = false;
            correctChoice4.Visible = false;
            correctChoice4.Click += correctChoice4_Click;
            // 
            // idTXT
            // 
            idTXT.Enabled = false;
            idTXT.Location = new Point(596, 5);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(125, 27);
            idTXT.TabIndex = 48;
            idTXT.Visible = false;
            // 
            // endViewBTN
            // 
            endViewBTN.BackColor = Color.FromArgb(76, 175, 80);
            endViewBTN.Cursor = Cursors.Hand;
            endViewBTN.FlatAppearance.BorderSize = 0;
            endViewBTN.FlatStyle = FlatStyle.Flat;
            endViewBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endViewBTN.ForeColor = Color.White;
            endViewBTN.Location = new Point(1328, 952);
            endViewBTN.Name = "endViewBTN";
            endViewBTN.Size = new Size(562, 76);
            endViewBTN.TabIndex = 49;
            endViewBTN.Text = "End View";
            endViewBTN.UseVisualStyleBackColor = true;
            endViewBTN.Click += endViewBTN_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 39, 45);
            panel1.Location = new Point(1328, 103);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 2);
            panel1.TabIndex = 82;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(194, 39, 45);
            panel2.Location = new Point(1328, 208);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 2);
            panel2.TabIndex = 82;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(194, 39, 45);
            panel3.Location = new Point(1328, 319);
            panel3.Name = "panel3";
            panel3.Size = new Size(562, 2);
            panel3.TabIndex = 82;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(194, 39, 45);
            panel4.Location = new Point(1328, 474);
            panel4.Name = "panel4";
            panel4.Size = new Size(562, 2);
            panel4.TabIndex = 82;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(194, 39, 45);
            panel5.Location = new Point(1328, 622);
            panel5.Name = "panel5";
            panel5.Size = new Size(562, 2);
            panel5.TabIndex = 82;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(194, 39, 45);
            panel6.Location = new Point(1328, 761);
            panel6.Name = "panel6";
            panel6.Size = new Size(562, 2);
            panel6.TabIndex = 82;
            panel6.Visible = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(194, 39, 45);
            panel7.Location = new Point(1325, 900);
            panel7.Name = "panel7";
            panel7.Size = new Size(562, 2);
            panel7.TabIndex = 83;
            panel7.Visible = false;
            // 
            // questionDATA
            // 
            questionDATA.BackgroundColor = Color.White;
            questionDATA.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            questionDATA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            questionDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 163, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            questionDATA.DefaultCellStyle = dataGridViewCellStyle2;
            questionDATA.GridColor = Color.FromArgb(240, 240, 240);
            questionDATA.Location = new Point(12, 79);
            questionDATA.Name = "questionDATA";
            questionDATA.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            questionDATA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            questionDATA.RowHeadersWidth = 51;
            questionDATA.Size = new Size(1310, 949);
            questionDATA.TabIndex = 24;
            questionDATA.CellMouseDoubleClick += questionDATA_CellMouseDoubleClick;
            // 
            // ExamQuestionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(questionDATA);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(endViewBTN);
            Controls.Add(idTXT);
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
            Controls.Add(label1);
            Controls.Add(typeBOX);
            Controls.Add(bodyTXT);
            Controls.Add(returnBTN);
            Controls.Add(refreshBTN);
            Name = "ExamQuestionsForm";
            Text = "Question";
            FormClosed += QuestionForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)degreeNUM).EndInit();
            ((System.ComponentModel.ISupportInitialize)questionDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBTN;
        private Button refreshBTN;
        private DataGridView questionDATA;
        private RichTextBox bodyTXT;
        private ComboBox typeBOX;
        private Label label1;
        private Label label2;
        private NumericUpDown degreeNUM;
        private Label label3;
        private RichTextBox choice1TXT;
        private Label choice1LBL;
        private Label choice2LBL;
        private RichTextBox choice2TXT;
        private Label choice3LBL;
        private RichTextBox choice3TXT;
        private Label choice4LBL;
        private RichTextBox choice4TXT;
        private Button correctChoice1;
        private Button correctChoice2;
        private Button correctChoice3;
        private Button correctChoice4;
        private TextBox idTXT;
        private Button endViewBTN;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
    }
}