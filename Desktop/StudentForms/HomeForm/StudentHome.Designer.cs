namespace Desktop
{
    partial class StudentHome
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
            examBTN = new Button();
            idLBL = new Label();
            nameLBL = new Label();
            searchTXT = new TextBox();
            refreshBTN = new Button();
            button1 = new Button();
            idTXT = new RichTextBox();
            nameTXT = new RichTextBox();
            panel1 = new Panel();
            panel2 = new Panel();
            courseDATA = new DataGridView();
            panel3 = new Panel();
            ((System.ComponentModel.ISupportInitialize)courseDATA).BeginInit();
            SuspendLayout();
            // 
            // examBTN
            // 
            examBTN.BackColor = Color.FromArgb(76, 175, 80);
            examBTN.Cursor = Cursors.Hand;
            examBTN.Enabled = false;
            examBTN.FlatAppearance.BorderSize = 0;
            examBTN.FlatStyle = FlatStyle.Flat;
            examBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            examBTN.ForeColor = Color.White;
            examBTN.Location = new Point(1174, 911);
            examBTN.Name = "examBTN";
            examBTN.Size = new Size(716, 110);
            examBTN.TabIndex = 4;
            examBTN.Text = "Exams";
            examBTN.UseVisualStyleBackColor = false;
            examBTN.Click += examBTN_Click;
            // 
            // idLBL
            // 
            idLBL.AutoSize = true;
            idLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            idLBL.ForeColor = Color.FromArgb(64, 64, 64);
            idLBL.Location = new Point(1174, 163);
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
            nameLBL.Location = new Point(1174, 355);
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
            searchTXT.Size = new Size(1156, 32);
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
            refreshBTN.Location = new Point(590, 12);
            refreshBTN.Name = "refreshBTN";
            refreshBTN.Size = new Size(578, 76);
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
            button1.Size = new Size(578, 76);
            button1.TabIndex = 11;
            button1.Text = "↩ Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // idTXT
            // 
            idTXT.BackColor = Color.White;
            idTXT.BorderStyle = BorderStyle.None;
            idTXT.Font = new Font("Segoe UI", 20F);
            idTXT.Location = new Point(1174, 198);
            idTXT.Name = "idTXT";
            idTXT.ReadOnly = true;
            idTXT.Size = new Size(716, 54);
            idTXT.TabIndex = 12;
            idTXT.Text = "";
            idTXT.Enter += idTXT_Enter;
            // 
            // nameTXT
            // 
            nameTXT.BackColor = Color.White;
            nameTXT.BorderStyle = BorderStyle.None;
            nameTXT.Font = new Font("Segoe UI", 20F);
            nameTXT.Location = new Point(1174, 390);
            nameTXT.Name = "nameTXT";
            nameTXT.ReadOnly = true;
            nameTXT.Size = new Size(716, 54);
            nameTXT.TabIndex = 13;
            nameTXT.Text = "";
            nameTXT.Enter += nameTXT_Enter;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 39, 45);
            panel1.Location = new Point(1174, 258);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 2);
            panel1.TabIndex = 76;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(194, 39, 45);
            panel2.Location = new Point(1174, 450);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 2);
            panel2.TabIndex = 77;
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
            courseDATA.Location = new Point(12, 140);
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
            courseDATA.Size = new Size(1156, 881);
            courseDATA.TabIndex = 78;
            courseDATA.CellDoubleClick += courseDATA_CellDoubleClick;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(194, 39, 45);
            panel3.Location = new Point(12, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(1156, 2);
            panel3.TabIndex = 77;
            // 
            // StudentHome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panel3);
            Controls.Add(courseDATA);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(nameTXT);
            Controls.Add(idTXT);
            Controls.Add(button1);
            Controls.Add(refreshBTN);
            Controls.Add(searchTXT);
            Controls.Add(nameLBL);
            Controls.Add(idLBL);
            Controls.Add(examBTN);
            Name = "StudentHome";
            Text = "Instructor Home";
            FormClosed += InstructorHome_FormClosed;
            ((System.ComponentModel.ISupportInitialize)courseDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button examBTN;
        private Label idLBL;
        private Label nameLBL;
        private TextBox searchTXT;
        private Button refreshBTN;
        private Button button1;
        private RichTextBox idTXT;
        private RichTextBox nameTXT;
        private Panel panel1;
        private Panel panel2;
        private DataGridView courseDATA;
        private Panel panel3;
    }
}