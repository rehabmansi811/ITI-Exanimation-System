namespace Desktop.Admin.InstructorCourseForm
{
    partial class InstructorCourseForm
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
            button1 = new Button();
            showBTN = new Button();
            panel1 = new Panel();
            insLIST = new ComboBox();
            insLBL = new Label();
            idLBL = new Label();
            idTXT = new RichTextBox();
            nameLBL = new Label();
            nameTXT = new RichTextBox();
            panel2 = new Panel();
            panel3 = new Panel();
            topicDATA = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)topicDATA).BeginInit();
            SuspendLayout();
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
            button1.Size = new Size(1156, 76);
            button1.TabIndex = 25;
            button1.Text = "↩ Return";
            button1.UseVisualStyleBackColor = true;
            button1.Click += returnBTN_Click;
            // 
            // showBTN
            // 
            showBTN.BackColor = Color.FromArgb(33, 150, 243);
            showBTN.Cursor = Cursors.Hand;
            showBTN.FlatAppearance.BorderSize = 0;
            showBTN.FlatStyle = FlatStyle.Flat;
            showBTN.Font = new Font("Segoe UI Semibold", 14.2F, FontStyle.Bold);
            showBTN.ForeColor = Color.White;
            showBTN.Location = new Point(1174, 911);
            showBTN.Name = "showBTN";
            showBTN.Size = new Size(716, 110);
            showBTN.TabIndex = 28;
            showBTN.Text = "Get Courses";
            showBTN.UseVisualStyleBackColor = false;
            showBTN.Click += showBTN_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 39, 45);
            panel1.Location = new Point(1174, 174);
            panel1.Name = "panel1";
            panel1.Size = new Size(716, 2);
            panel1.TabIndex = 67;
            // 
            // insLIST
            // 
            insLIST.DropDownStyle = ComboBoxStyle.DropDownList;
            insLIST.FlatStyle = FlatStyle.Flat;
            insLIST.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            insLIST.FormattingEnabled = true;
            insLIST.Location = new Point(1174, 129);
            insLIST.Name = "insLIST";
            insLIST.Size = new Size(716, 39);
            insLIST.TabIndex = 66;
            // 
            // insLBL
            // 
            insLBL.AutoSize = true;
            insLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            insLBL.ForeColor = Color.FromArgb(64, 64, 64);
            insLBL.Location = new Point(1174, 94);
            insLBL.Name = "insLBL";
            insLBL.Size = new Size(120, 32);
            insLBL.TabIndex = 65;
            insLBL.Text = "Instructor";
            // 
            // idLBL
            // 
            idLBL.AutoSize = true;
            idLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            idLBL.ForeColor = Color.FromArgb(64, 64, 64);
            idLBL.Location = new Point(1174, 265);
            idLBL.Name = "idLBL";
            idLBL.Size = new Size(44, 32);
            idLBL.TabIndex = 70;
            idLBL.Text = "ID:";
            // 
            // idTXT
            // 
            idTXT.BackColor = Color.White;
            idTXT.BorderStyle = BorderStyle.None;
            idTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idTXT.Location = new Point(1174, 313);
            idTXT.Name = "idTXT";
            idTXT.ReadOnly = true;
            idTXT.Size = new Size(716, 40);
            idTXT.TabIndex = 68;
            idTXT.Text = "";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            nameLBL.ForeColor = Color.FromArgb(64, 64, 64);
            nameLBL.Location = new Point(1174, 386);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(85, 32);
            nameLBL.TabIndex = 71;
            nameLBL.Text = "Name:";
            // 
            // nameTXT
            // 
            nameTXT.BackColor = Color.White;
            nameTXT.BorderStyle = BorderStyle.None;
            nameTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTXT.Location = new Point(1174, 434);
            nameTXT.Name = "nameTXT";
            nameTXT.ReadOnly = true;
            nameTXT.Size = new Size(716, 40);
            nameTXT.TabIndex = 69;
            nameTXT.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(194, 39, 45);
            panel2.Location = new Point(1174, 359);
            panel2.Name = "panel2";
            panel2.Size = new Size(716, 2);
            panel2.TabIndex = 68;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(194, 39, 45);
            panel3.Location = new Point(1174, 480);
            panel3.Name = "panel3";
            panel3.Size = new Size(716, 2);
            panel3.TabIndex = 68;
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
            topicDATA.TabIndex = 72;
            topicDATA.CellDoubleClick += topicDATA_CellDoubleClick;
            // 
            // InstructorCourseForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(topicDATA);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(idLBL);
            Controls.Add(idTXT);
            Controls.Add(nameLBL);
            Controls.Add(nameTXT);
            Controls.Add(panel1);
            Controls.Add(insLIST);
            Controls.Add(insLBL);
            Controls.Add(showBTN);
            Controls.Add(button1);
            Name = "InstructorCourseForm";
            Text = "CourseTopicForm";
            FormClosed += CourseTopicForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)topicDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button showBTN;
        private Panel panel1;
        private ComboBox insLIST;
        private Label insLBL;
        private Label idLBL;
        private RichTextBox idTXT;
        private Label nameLBL;
        private RichTextBox nameTXT;
        private Panel panel2;
        private Panel panel3;
        private DataGridView topicDATA;
    }
}