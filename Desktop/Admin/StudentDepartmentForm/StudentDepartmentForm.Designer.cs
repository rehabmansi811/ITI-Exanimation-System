namespace Desktop.Admin.StudentDepartmentForm
{
    partial class StudentDepartmentForm
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
            deptLBL = new Label();
            deptLIST = new ComboBox();
            showBTN = new Button();
            emailTXT = new RichTextBox();
            nameTXT = new RichTextBox();
            emailLBL = new Label();
            nameLBL = new Label();
            dobTXT = new RichTextBox();
            addressTXT = new RichTextBox();
            dobLBL = new Label();
            addressLBL = new Label();
            salaryTXT = new RichTextBox();
            phoneTXT = new RichTextBox();
            salaryLBL = new Label();
            phoneLBL = new Label();
            collegeTXT = new RichTextBox();
            collegeLBL = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel6 = new Panel();
            panel7 = new Panel();
            panel8 = new Panel();
            topicDATA = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)topicDATA).BeginInit();
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
            returnBTN.Size = new Size(1156, 76);
            returnBTN.TabIndex = 25;
            returnBTN.Text = "↩ Return";
            returnBTN.UseVisualStyleBackColor = true;
            returnBTN.Click += returnBTN_Click;
            // 
            // deptLBL
            // 
            deptLBL.AutoSize = true;
            deptLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            deptLBL.ForeColor = Color.FromArgb(64, 64, 64);
            deptLBL.Location = new Point(1174, 9);
            deptLBL.Name = "deptLBL";
            deptLBL.Size = new Size(147, 32);
            deptLBL.TabIndex = 16;
            deptLBL.Text = "Department";
            // 
            // deptLIST
            // 
            deptLIST.DropDownStyle = ComboBoxStyle.DropDownList;
            deptLIST.FlatStyle = FlatStyle.Flat;
            deptLIST.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            deptLIST.FormattingEnabled = true;
            deptLIST.Location = new Point(1174, 69);
            deptLIST.Name = "deptLIST";
            deptLIST.Size = new Size(716, 39);
            deptLIST.TabIndex = 17;
            // 
            // showBTN
            // 
            showBTN.BackColor = Color.FromArgb(255, 152, 0);
            showBTN.Cursor = Cursors.Hand;
            showBTN.FlatAppearance.BorderSize = 0;
            showBTN.FlatStyle = FlatStyle.Flat;
            showBTN.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            showBTN.ForeColor = Color.White;
            showBTN.Location = new Point(1174, 911);
            showBTN.Name = "showBTN";
            showBTN.Size = new Size(716, 110);
            showBTN.TabIndex = 18;
            showBTN.Text = "Get Students";
            showBTN.UseVisualStyleBackColor = true;
            showBTN.Click += showBTN_Click;
            // 
            // emailTXT
            // 
            emailTXT.BackColor = Color.White;
            emailTXT.BorderStyle = BorderStyle.None;
            emailTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            emailTXT.Location = new Point(1174, 278);
            emailTXT.Name = "emailTXT";
            emailTXT.ReadOnly = true;
            emailTXT.Size = new Size(716, 54);
            emailTXT.TabIndex = 22;
            emailTXT.Text = "";
            emailTXT.MouseDown += idTXT_MouseDown;
            // 
            // nameTXT
            // 
            nameTXT.BackColor = Color.White;
            nameTXT.BorderStyle = BorderStyle.None;
            nameTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTXT.Location = new Point(1174, 172);
            nameTXT.Name = "nameTXT";
            nameTXT.ReadOnly = true;
            nameTXT.Size = new Size(716, 54);
            nameTXT.TabIndex = 21;
            nameTXT.Text = "";
            nameTXT.MouseDown += idTXT_MouseDown;
            // 
            // emailLBL
            // 
            emailLBL.AutoSize = true;
            emailLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            emailLBL.ForeColor = Color.FromArgb(64, 64, 64);
            emailLBL.Location = new Point(1174, 243);
            emailLBL.Name = "emailLBL";
            emailLBL.Size = new Size(72, 32);
            emailLBL.TabIndex = 20;
            emailLBL.Text = "Email";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            nameLBL.ForeColor = Color.FromArgb(64, 64, 64);
            nameLBL.Location = new Point(1174, 137);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(79, 32);
            nameLBL.TabIndex = 19;
            nameLBL.Text = "Name";
            // 
            // dobTXT
            // 
            dobTXT.BackColor = Color.White;
            dobTXT.BorderStyle = BorderStyle.None;
            dobTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dobTXT.Location = new Point(1174, 490);
            dobTXT.Name = "dobTXT";
            dobTXT.ReadOnly = true;
            dobTXT.Size = new Size(716, 54);
            dobTXT.TabIndex = 26;
            dobTXT.Text = "";
            dobTXT.MouseDown += idTXT_Mouse;
            // 
            // addressTXT
            // 
            addressTXT.BackColor = Color.White;
            addressTXT.BorderStyle = BorderStyle.None;
            addressTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addressTXT.Location = new Point(1174, 384);
            addressTXT.Name = "addressTXT";
            addressTXT.ReadOnly = true;
            addressTXT.Size = new Size(716, 54);
            addressTXT.TabIndex = 25;
            addressTXT.Text = "";
            addressTXT.MouseDown += idTXT_Mouse;
            // 
            // dobLBL
            // 
            dobLBL.AutoSize = true;
            dobLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            dobLBL.ForeColor = Color.FromArgb(64, 64, 64);
            dobLBL.Location = new Point(1174, 455);
            dobLBL.Name = "dobLBL";
            dobLBL.Size = new Size(64, 32);
            dobLBL.TabIndex = 24;
            dobLBL.Text = "DOB";
            // 
            // addressLBL
            // 
            addressLBL.AutoSize = true;
            addressLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            addressLBL.ForeColor = Color.FromArgb(64, 64, 64);
            addressLBL.Location = new Point(1174, 349);
            addressLBL.Name = "addressLBL";
            addressLBL.Size = new Size(100, 32);
            addressLBL.TabIndex = 23;
            addressLBL.Text = "Address";
            // 
            // salaryTXT
            // 
            salaryTXT.BackColor = Color.White;
            salaryTXT.BorderStyle = BorderStyle.None;
            salaryTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salaryTXT.Location = new Point(1174, 702);
            salaryTXT.Name = "salaryTXT";
            salaryTXT.ReadOnly = true;
            salaryTXT.Size = new Size(716, 54);
            salaryTXT.TabIndex = 30;
            salaryTXT.Text = "";
            salaryTXT.MouseDown += idTXT_Mouse;
            // 
            // phoneTXT
            // 
            phoneTXT.BackColor = Color.White;
            phoneTXT.BorderStyle = BorderStyle.None;
            phoneTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            phoneTXT.Location = new Point(1174, 596);
            phoneTXT.Name = "phoneTXT";
            phoneTXT.ReadOnly = true;
            phoneTXT.Size = new Size(716, 54);
            phoneTXT.TabIndex = 29;
            phoneTXT.Text = "";
            phoneTXT.MouseDown += idTXT_Mouse;
            // 
            // salaryLBL
            // 
            salaryLBL.AutoSize = true;
            salaryLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            salaryLBL.ForeColor = Color.FromArgb(64, 64, 64);
            salaryLBL.Location = new Point(1174, 667);
            salaryLBL.Name = "salaryLBL";
            salaryLBL.Size = new Size(81, 32);
            salaryLBL.TabIndex = 28;
            salaryLBL.Text = "Salary";
            // 
            // phoneLBL
            // 
            phoneLBL.AutoSize = true;
            phoneLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            phoneLBL.ForeColor = Color.FromArgb(64, 64, 64);
            phoneLBL.Location = new Point(1174, 561);
            phoneLBL.Name = "phoneLBL";
            phoneLBL.Size = new Size(83, 32);
            phoneLBL.TabIndex = 27;
            phoneLBL.Text = "Phone";
            // 
            // collegeTXT
            // 
            collegeTXT.BackColor = Color.White;
            collegeTXT.BorderStyle = BorderStyle.None;
            collegeTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            collegeTXT.Location = new Point(1174, 808);
            collegeTXT.Name = "collegeTXT";
            collegeTXT.ReadOnly = true;
            collegeTXT.Size = new Size(716, 54);
            collegeTXT.TabIndex = 33;
            collegeTXT.Text = "";
            collegeTXT.MouseDown += idTXT_Mouse;
            // 
            // collegeLBL
            // 
            collegeLBL.AutoSize = true;
            collegeLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            collegeLBL.ForeColor = Color.FromArgb(64, 64, 64);
            collegeLBL.Location = new Point(1174, 773);
            collegeLBL.Name = "collegeLBL";
            collegeLBL.Size = new Size(95, 32);
            collegeLBL.TabIndex = 31;
            collegeLBL.Text = "College";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 39, 45);
            panel1.Location = new Point(1174, 232);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 2);
            panel1.TabIndex = 75;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(194, 39, 45);
            panel2.Location = new Point(1174, 114);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 2);
            panel2.TabIndex = 75;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(194, 39, 45);
            panel3.Location = new Point(1174, 338);
            panel3.Name = "panel3";
            panel3.Size = new Size(716, 2);
            panel3.TabIndex = 75;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(194, 39, 45);
            panel4.Location = new Point(1174, 444);
            panel4.Name = "panel4";
            panel4.Size = new Size(716, 2);
            panel4.TabIndex = 75;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(194, 39, 45);
            panel5.Location = new Point(1174, 550);
            panel5.Name = "panel5";
            panel5.Size = new Size(716, 2);
            panel5.TabIndex = 75;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(194, 39, 45);
            panel6.Location = new Point(1174, 656);
            panel6.Name = "panel6";
            panel6.Size = new Size(716, 2);
            panel6.TabIndex = 75;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(194, 39, 45);
            panel7.Location = new Point(1174, 762);
            panel7.Name = "panel7";
            panel7.Size = new Size(716, 2);
            panel7.TabIndex = 75;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(194, 39, 45);
            panel8.Location = new Point(1174, 868);
            panel8.Name = "panel8";
            panel8.Size = new Size(716, 2);
            panel8.TabIndex = 75;
            // 
            // topicDATA
            // 
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
            topicDATA.Location = new Point(12, 94);
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
            topicDATA.Size = new Size(1156, 927);
            topicDATA.TabIndex = 76;
            topicDATA.CellDoubleClick += topicDATA_CellDoubleClick;
            // 
            // StudentDepartmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(topicDATA);
            Controls.Add(panel8);
            Controls.Add(panel7);
            Controls.Add(panel6);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(collegeTXT);
            Controls.Add(collegeLBL);
            Controls.Add(salaryTXT);
            Controls.Add(phoneTXT);
            Controls.Add(salaryLBL);
            Controls.Add(phoneLBL);
            Controls.Add(dobTXT);
            Controls.Add(addressTXT);
            Controls.Add(dobLBL);
            Controls.Add(addressLBL);
            Controls.Add(emailTXT);
            Controls.Add(nameTXT);
            Controls.Add(emailLBL);
            Controls.Add(nameLBL);
            Controls.Add(showBTN);
            Controls.Add(deptLIST);
            Controls.Add(deptLBL);
            Controls.Add(returnBTN);
            Name = "StudentDepartmentForm";
            Text = "CourseTopicForm";
            FormClosed += CourseTopicForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)topicDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button returnBTN;
        private Label deptLBL;
        private ComboBox deptLIST;
        private Button showBTN;
        private RichTextBox emailTXT;
        private RichTextBox nameTXT;
        private Label emailLBL;
        private Label nameLBL;
        private RichTextBox dobTXT;
        private RichTextBox addressTXT;
        private Label dobLBL;
        private Label addressLBL;
        private RichTextBox salaryTXT;
        private RichTextBox phoneTXT;
        private Label salaryLBL;
        private Label phoneLBL;
        private RichTextBox collegeTXT;
        private Label collegeLBL;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
        private Panel panel7;
        private Panel panel8;
        private DataGridView topicDATA;
    }
}