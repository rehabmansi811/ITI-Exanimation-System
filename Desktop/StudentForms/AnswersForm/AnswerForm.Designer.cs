namespace Desktop.StudentForms.AnswersForm
{
    partial class AnswerForm
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
            prevBTN = new Button();
            nextBTN = new Button();
            timeLBL = new Label();
            timeTXT = new Label();
            choice1TXT = new RichTextBox();
            choice2TXT = new RichTextBox();
            choice3TXT = new RichTextBox();
            choice4TXT = new RichTextBox();
            bodyTXT = new RichTextBox();
            questionLBL = new Label();
            endBTN = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // prevBTN
            // 
            prevBTN.BackColor = Color.FromArgb(37, 37, 38);
            prevBTN.Cursor = Cursors.Hand;
            prevBTN.FlatAppearance.BorderSize = 0;
            prevBTN.FlatStyle = FlatStyle.Flat;
            prevBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prevBTN.ForeColor = Color.White;
            prevBTN.Location = new Point(12, 12);
            prevBTN.Name = "prevBTN";
            prevBTN.Size = new Size(664, 88);
            prevBTN.TabIndex = 4;
            prevBTN.Text = "Previous Question";
            prevBTN.UseVisualStyleBackColor = false;
            prevBTN.Click += prevBTN_Click;
            // 
            // nextBTN
            // 
            nextBTN.BackColor = Color.FromArgb(37, 37, 38);
            nextBTN.Cursor = Cursors.Hand;
            nextBTN.FlatAppearance.BorderSize = 0;
            nextBTN.FlatStyle = FlatStyle.Flat;
            nextBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nextBTN.ForeColor = Color.White;
            nextBTN.Location = new Point(1226, 12);
            nextBTN.Name = "nextBTN";
            nextBTN.Size = new Size(664, 88);
            nextBTN.TabIndex = 5;
            nextBTN.Text = "Next Question";
            nextBTN.UseVisualStyleBackColor = true;
            nextBTN.Click += nextBTN_Click;
            // 
            // timeLBL
            // 
            timeLBL.AutoSize = true;
            timeLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            timeLBL.ForeColor = Color.FromArgb(64, 64, 64);
            timeLBL.Location = new Point(761, 103);
            timeLBL.Name = "timeLBL";
            timeLBL.Size = new Size(129, 32);
            timeLBL.TabIndex = 6;
            timeLBL.Text = "Time Left :";
            // 
            // timeTXT
            // 
            timeTXT.AutoSize = true;
            timeTXT.BackColor = Color.White;
            timeTXT.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            timeTXT.Location = new Point(984, 103);
            timeTXT.Name = "timeTXT";
            timeTXT.Size = new Size(88, 32);
            timeTXT.TabIndex = 7;
            timeTXT.Text = "1:00:00";
            // 
            // choice1TXT
            // 
            choice1TXT.BackColor = Color.White;
            choice1TXT.BorderStyle = BorderStyle.None;
            choice1TXT.Cursor = Cursors.Hand;
            choice1TXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            choice1TXT.Location = new Point(3, 3);
            choice1TXT.Name = "choice1TXT";
            choice1TXT.ReadOnly = true;
            choice1TXT.Size = new Size(1872, 114);
            choice1TXT.TabIndex = 8;
            choice1TXT.Text = "";
            choice1TXT.MouseDown += choice1TXT_MouseDown;
            // 
            // choice2TXT
            // 
            choice2TXT.BackColor = Color.White;
            choice2TXT.BorderStyle = BorderStyle.None;
            choice2TXT.Cursor = Cursors.Hand;
            choice2TXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            choice2TXT.Location = new Point(3, 6);
            choice2TXT.Name = "choice2TXT";
            choice2TXT.ReadOnly = true;
            choice2TXT.Size = new Size(1872, 111);
            choice2TXT.TabIndex = 9;
            choice2TXT.Text = "";
            choice2TXT.MouseDown += choice2TXT_MouseDown;
            // 
            // choice3TXT
            // 
            choice3TXT.BackColor = Color.White;
            choice3TXT.BorderStyle = BorderStyle.None;
            choice3TXT.Cursor = Cursors.Hand;
            choice3TXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            choice3TXT.Location = new Point(3, 3);
            choice3TXT.Name = "choice3TXT";
            choice3TXT.ReadOnly = true;
            choice3TXT.Size = new Size(1872, 114);
            choice3TXT.TabIndex = 10;
            choice3TXT.Text = "";
            choice3TXT.MouseDown += choice3TXT_MouseDown;
            // 
            // choice4TXT
            // 
            choice4TXT.BackColor = Color.White;
            choice4TXT.BorderStyle = BorderStyle.None;
            choice4TXT.Cursor = Cursors.Hand;
            choice4TXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            choice4TXT.Location = new Point(3, 3);
            choice4TXT.Name = "choice4TXT";
            choice4TXT.ReadOnly = true;
            choice4TXT.Size = new Size(1872, 114);
            choice4TXT.TabIndex = 11;
            choice4TXT.Text = "";
            choice4TXT.MouseDown += choice4TXT_MouseDown;
            // 
            // bodyTXT
            // 
            bodyTXT.BackColor = Color.White;
            bodyTXT.BorderStyle = BorderStyle.None;
            bodyTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bodyTXT.Location = new Point(15, 141);
            bodyTXT.Name = "bodyTXT";
            bodyTXT.ReadOnly = true;
            bodyTXT.Size = new Size(1872, 355);
            bodyTXT.TabIndex = 12;
            bodyTXT.Text = "";
            bodyTXT.MouseDown += bodyTXT_MouseDown;
            // 
            // questionLBL
            // 
            questionLBL.AutoSize = true;
            questionLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            questionLBL.ForeColor = Color.FromArgb(64, 64, 64);
            questionLBL.Location = new Point(12, 103);
            questionLBL.Name = "questionLBL";
            questionLBL.Size = new Size(132, 32);
            questionLBL.TabIndex = 13;
            questionLBL.Text = "Question 0";
            // 
            // endBTN
            // 
            endBTN.BackColor = Color.FromArgb(194, 39, 45);
            endBTN.Cursor = Cursors.Hand;
            endBTN.FlatAppearance.BorderSize = 0;
            endBTN.FlatStyle = FlatStyle.Flat;
            endBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endBTN.ForeColor = Color.White;
            endBTN.Location = new Point(682, 12);
            endBTN.Name = "endBTN";
            endBTN.Size = new Size(538, 88);
            endBTN.TabIndex = 14;
            endBTN.Text = "End Exam";
            endBTN.UseVisualStyleBackColor = false;
            endBTN.Click += endBTN_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(choice1TXT);
            panel1.Location = new Point(12, 520);
            panel1.Name = "panel1";
            panel1.Size = new Size(1878, 120);
            panel1.TabIndex = 78;
            panel1.Paint += panel1_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.Controls.Add(choice2TXT);
            panel2.Location = new Point(12, 646);
            panel2.Name = "panel2";
            panel2.Size = new Size(1878, 120);
            panel2.TabIndex = 79;
            panel2.Paint += panel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Transparent;
            panel3.Controls.Add(choice3TXT);
            panel3.Location = new Point(12, 775);
            panel3.Name = "panel3";
            panel3.Size = new Size(1878, 120);
            panel3.TabIndex = 79;
            panel3.Paint += panel1_Paint;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Transparent;
            panel4.Controls.Add(choice4TXT);
            panel4.Location = new Point(12, 901);
            panel4.Name = "panel4";
            panel4.Size = new Size(1878, 120);
            panel4.TabIndex = 79;
            panel4.Paint += panel1_Paint;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Transparent;
            panel5.Location = new Point(12, 138);
            panel5.Name = "panel5";
            panel5.Size = new Size(1878, 361);
            panel5.TabIndex = 79;
            panel5.Paint += panel1_Paint;
            // 
            // AnswerForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(endBTN);
            Controls.Add(questionLBL);
            Controls.Add(bodyTXT);
            Controls.Add(timeTXT);
            Controls.Add(timeLBL);
            Controls.Add(nextBTN);
            Controls.Add(prevBTN);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel4);
            Controls.Add(panel5);
            Name = "AnswerForm";
            Text = "AnswerForm";
            FormClosed += AnswerForm_FormClosed;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button prevBTN;
        private Button nextBTN;
        private Label timeLBL;
        private Label timeTXT;
        private RichTextBox choice1TXT;
        private RichTextBox choice2TXT;
        private RichTextBox choice3TXT;
        private RichTextBox choice4TXT;
        private RichTextBox bodyTXT;
        private Label questionLBL;
        private Button endBTN;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
    }
}