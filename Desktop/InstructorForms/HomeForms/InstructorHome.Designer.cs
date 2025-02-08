namespace Desktop
{
    partial class InstructorHome
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
            questionBTN = new Button();
            examBTN = new Button();
            studentBTN = new Button();
            idLBL = new Label();
            nameLBL = new Label();
            searchTXT = new TextBox();
            refreshBTN = new Button();
            button1 = new Button();
            idTXT = new RichTextBox();
            nameTXT = new RichTextBox();
            courseDATA = new DataGridView();
            panel1 = new Panel();
            panel2 = new Panel();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)courseDATA).BeginInit();
            SuspendLayout();
            // 
            // questionBTN
            // 
            questionBTN.BackColor = Color.FromArgb(37, 37, 38);
            questionBTN.Cursor = Cursors.Hand;
            questionBTN.Enabled = false;
            questionBTN.FlatAppearance.BorderSize = 0;
            questionBTN.FlatStyle = FlatStyle.Flat;
            questionBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionBTN.ForeColor = Color.White;
            questionBTN.Location = new Point(1328, 751);
            questionBTN.Name = "questionBTN";
            questionBTN.Size = new Size(562, 86);
            questionBTN.TabIndex = 3;
            questionBTN.Text = "Questions";
            questionBTN.UseVisualStyleBackColor = false;
            questionBTN.Click += questionBTN_Click;
            // 
            // examBTN
            // 
            examBTN.BackColor = Color.FromArgb(194, 39, 45);
            examBTN.Cursor = Cursors.Hand;
            examBTN.Enabled = false;
            examBTN.FlatAppearance.BorderSize = 0;
            examBTN.FlatStyle = FlatStyle.Flat;
            examBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            examBTN.ForeColor = Color.White;
            examBTN.Location = new Point(1328, 843);
            examBTN.Name = "examBTN";
            examBTN.Size = new Size(562, 86);
            examBTN.TabIndex = 4;
            examBTN.Text = "Exams";
            examBTN.UseVisualStyleBackColor = false;
            examBTN.Click += examBTN_Click;
            // 
            // studentBTN
            // 
            studentBTN.BackColor = Color.FromArgb(76, 175, 80);
            studentBTN.Cursor = Cursors.Hand;
            studentBTN.Enabled = false;
            studentBTN.FlatAppearance.BorderSize = 0;
            studentBTN.FlatStyle = FlatStyle.Flat;
            studentBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentBTN.ForeColor = Color.White;
            studentBTN.Location = new Point(1328, 935);
            studentBTN.Name = "studentBTN";
            studentBTN.Size = new Size(562, 86);
            studentBTN.TabIndex = 5;
            studentBTN.Text = "Students";
            studentBTN.UseVisualStyleBackColor = false;
            studentBTN.Click += studentBTN_Click;
            // 
            // idLBL
            // 
            idLBL.AutoSize = true;
            idLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            idLBL.ForeColor = Color.FromArgb(64, 64, 64);
            idLBL.Location = new Point(1328, 132);
            idLBL.Name = "idLBL";
            idLBL.Size = new Size(38, 32);
            idLBL.TabIndex = 7;
            idLBL.Text = "ID";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            nameLBL.ForeColor = Color.FromArgb(64, 64, 64);
            nameLBL.Location = new Point(1328, 304);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(79, 32);
            nameLBL.TabIndex = 8;
            nameLBL.Text = "Name";
            // 
            // searchTXT
            // 
            searchTXT.BackColor = Color.White;
            searchTXT.BorderStyle = BorderStyle.None;
            searchTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTXT.Location = new Point(12, 94);
            searchTXT.Name = "searchTXT";
            searchTXT.Size = new Size(1310, 32);
            searchTXT.TabIndex = 9;
            searchTXT.TextChanged += searchTXT_TextChanged;
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
            refreshBTN.Size = new Size(655, 76);
            refreshBTN.TabIndex = 10;
            refreshBTN.Text = "♻ Refresh";
            refreshBTN.UseVisualStyleBackColor = true;
            refreshBTN.Click += refreshBTN_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(194, 39, 45);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(655, 76);
            button1.TabIndex = 11;
            button1.Text = "↩ Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // idTXT
            // 
            idTXT.BackColor = Color.White;
            idTXT.BorderStyle = BorderStyle.None;
            idTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idTXT.Location = new Point(1328, 167);
            idTXT.Name = "idTXT";
            idTXT.ReadOnly = true;
            idTXT.Size = new Size(562, 39);
            idTXT.TabIndex = 12;
            idTXT.Text = "";
            idTXT.Enter += idTXT_Enter;
            // 
            // nameTXT
            // 
            nameTXT.BackColor = Color.White;
            nameTXT.BorderStyle = BorderStyle.None;
            nameTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTXT.Location = new Point(1328, 339);
            nameTXT.Name = "nameTXT";
            nameTXT.ReadOnly = true;
            nameTXT.Size = new Size(562, 39);
            nameTXT.TabIndex = 13;
            nameTXT.Text = "";
            nameTXT.Enter += nameTXT_Enter;
            // 
            // courseDATA
            // 
            courseDATA.BackgroundColor = Color.White;
            courseDATA.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            courseDATA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            courseDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 163, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            courseDATA.DefaultCellStyle = dataGridViewCellStyle2;
            courseDATA.GridColor = Color.FromArgb(240, 240, 240);
            courseDATA.Location = new Point(12, 143);
            courseDATA.Name = "courseDATA";
            courseDATA.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            courseDATA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            courseDATA.RowHeadersWidth = 51;
            courseDATA.Size = new Size(1310, 916);
            courseDATA.TabIndex = 80;
            courseDATA.CellDoubleClick += courseDATA_CellDoubleClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 39, 45);
            panel1.Location = new Point(1328, 212);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 2);
            panel1.TabIndex = 81;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(194, 39, 45);
            panel2.Location = new Point(1328, 384);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 2);
            panel2.TabIndex = 78;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(194, 39, 45);
            panel3.Location = new Point(12, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(1310, 2);
            panel3.TabIndex = 79;
            // 
            // InstructorHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(courseDATA);
            Controls.Add(nameTXT);
            Controls.Add(idTXT);
            Controls.Add(button1);
            Controls.Add(refreshBTN);
            Controls.Add(searchTXT);
            Controls.Add(nameLBL);
            Controls.Add(idLBL);
            Controls.Add(studentBTN);
            Controls.Add(examBTN);
            Controls.Add(questionBTN);
            Name = "InstructorHome";
            Text = "Instructor Home";
            FormClosed += InstructorHome_FormClosed;
            ((System.ComponentModel.ISupportInitialize)courseDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button questionBTN;
        private Button examBTN;
        private Button studentBTN;
        private Label idLBL;
        private Label nameLBL;
        private TextBox searchTXT;
        private Button refreshBTN;
        private Button button1;
        private RichTextBox idTXT;
        private RichTextBox nameTXT;
        private DataGridView courseDATA;
        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
    }
}