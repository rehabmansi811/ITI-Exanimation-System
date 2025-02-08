namespace Desktop.InstructorForms.Exams
{
    partial class ExamsForm
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
            idTXT = new TextBox();
            dateLBL = new Label();
            nameLBL = new Label();
            nameTXT = new RichTextBox();
            returnBTN = new Button();
            refreshBTN = new Button();
            insertBTN = new Button();
            endViewBTN = new Button();
            deleteBTN = new Button();
            datePICK = new DateTimePicker();
            updateBTN = new Button();
            studentsBTN = new Button();
            questionsBTN = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            examDATA = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)examDATA).BeginInit();
            SuspendLayout();
            // 
            // idTXT
            // 
            idTXT.Enabled = false;
            idTXT.Location = new Point(605, 12);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(125, 27);
            idTXT.TabIndex = 70;
            idTXT.Visible = false;
            // 
            // dateLBL
            // 
            dateLBL.AutoSize = true;
            dateLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            dateLBL.ForeColor = Color.FromArgb(64, 64, 64);
            dateLBL.Location = new Point(1328, 347);
            dateLBL.Name = "dateLBL";
            dateLBL.Size = new Size(174, 32);
            dateLBL.TabIndex = 61;
            dateLBL.Text = "Date and Time";
            // 
            // nameLBL
            // 
            nameLBL.AutoSize = true;
            nameLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            nameLBL.ForeColor = Color.FromArgb(64, 64, 64);
            nameLBL.Location = new Point(1328, 195);
            nameLBL.Name = "nameLBL";
            nameLBL.Size = new Size(79, 32);
            nameLBL.TabIndex = 59;
            nameLBL.Text = "Name";
            // 
            // nameTXT
            // 
            nameTXT.BackColor = Color.White;
            nameTXT.BorderStyle = BorderStyle.None;
            nameTXT.Font = new Font("Segoe UI", 12F);
            nameTXT.Location = new Point(1328, 230);
            nameTXT.Name = "nameTXT";
            nameTXT.Size = new Size(562, 39);
            nameTXT.TabIndex = 58;
            nameTXT.Text = "";
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
            // insertBTN
            // 
            insertBTN.BackColor = Color.FromArgb(76, 175, 80);
            insertBTN.Cursor = Cursors.Hand;
            insertBTN.FlatAppearance.BorderSize = 0;
            insertBTN.FlatStyle = FlatStyle.Flat;
            insertBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            insertBTN.ForeColor = Color.White;
            insertBTN.Location = new Point(1328, 952);
            insertBTN.Name = "insertBTN";
            insertBTN.Size = new Size(562, 76);
            insertBTN.TabIndex = 71;
            insertBTN.Text = "Insert";
            insertBTN.UseVisualStyleBackColor = true;
            insertBTN.Click += insertBTN_Click;
            // 
            // endViewBTN
            // 
            endViewBTN.BackColor = Color.FromArgb(33, 43, 224);
            endViewBTN.Cursor = Cursors.Hand;
            endViewBTN.FlatAppearance.BorderSize = 0;
            endViewBTN.FlatStyle = FlatStyle.Flat;
            endViewBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            endViewBTN.ForeColor = Color.White;
            endViewBTN.Location = new Point(1328, 952);
            endViewBTN.Name = "endViewBTN";
            endViewBTN.Size = new Size(562, 76);
            endViewBTN.TabIndex = 73;
            endViewBTN.Text = "End View";
            endViewBTN.UseVisualStyleBackColor = true;
            endViewBTN.Visible = false;
            endViewBTN.Click += endViewBTN_Click;
            // 
            // deleteBTN
            // 
            deleteBTN.BackColor = Color.FromArgb(194, 39, 45);
            deleteBTN.Cursor = Cursors.Hand;
            deleteBTN.FlatAppearance.BorderSize = 0;
            deleteBTN.FlatStyle = FlatStyle.Flat;
            deleteBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteBTN.ForeColor = Color.White;
            deleteBTN.Location = new Point(1609, 870);
            deleteBTN.Name = "deleteBTN";
            deleteBTN.Size = new Size(281, 76);
            deleteBTN.TabIndex = 72;
            deleteBTN.Text = "Delete";
            deleteBTN.UseVisualStyleBackColor = true;
            deleteBTN.Visible = false;
            deleteBTN.Click += deleteBTN_Click;
            // 
            // datePICK
            // 
            datePICK.BackColor = Color.White;
            datePICK.Font = new Font("Segoe UI", 12F);
            datePICK.Format = DateTimePickerFormat.Custom;
            datePICK.Location = new Point(1328, 382);
            datePICK.Name = "datePICK";
            datePICK.Size = new Size(562, 34);
            datePICK.TabIndex = 74;
            // 
            // updateBTN
            // 
            updateBTN.BackColor = Color.FromArgb(76, 175, 80);
            updateBTN.Cursor = Cursors.Hand;
            updateBTN.FlatAppearance.BorderSize = 0;
            updateBTN.FlatStyle = FlatStyle.Flat;
            updateBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            updateBTN.ForeColor = Color.White;
            updateBTN.Location = new Point(1328, 870);
            updateBTN.Name = "updateBTN";
            updateBTN.Size = new Size(281, 76);
            updateBTN.TabIndex = 75;
            updateBTN.Text = "Update";
            updateBTN.UseVisualStyleBackColor = true;
            updateBTN.Visible = false;
            updateBTN.Click += updateBTN_Click;
            // 
            // studentsBTN
            // 
            studentsBTN.BackColor = Color.FromArgb(33, 43, 224);
            studentsBTN.Cursor = Cursors.Hand;
            studentsBTN.FlatAppearance.BorderSize = 0;
            studentsBTN.FlatStyle = FlatStyle.Flat;
            studentsBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            studentsBTN.ForeColor = Color.White;
            studentsBTN.Location = new Point(1328, 706);
            studentsBTN.Name = "studentsBTN";
            studentsBTN.Size = new Size(562, 76);
            studentsBTN.TabIndex = 77;
            studentsBTN.Text = "View Students";
            studentsBTN.UseVisualStyleBackColor = true;
            studentsBTN.Visible = false;
            studentsBTN.Click += studentsBTN_Click;
            // 
            // questionsBTN
            // 
            questionsBTN.BackColor = Color.FromArgb(33, 43, 224);
            questionsBTN.Cursor = Cursors.Hand;
            questionsBTN.FlatAppearance.BorderSize = 0;
            questionsBTN.FlatStyle = FlatStyle.Flat;
            questionsBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            questionsBTN.ForeColor = Color.White;
            questionsBTN.Location = new Point(1328, 788);
            questionsBTN.Name = "questionsBTN";
            questionsBTN.Size = new Size(562, 76);
            questionsBTN.TabIndex = 76;
            questionsBTN.Text = "View Questions";
            questionsBTN.UseVisualStyleBackColor = true;
            questionsBTN.Visible = false;
            questionsBTN.Click += questionsBTN_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 39, 45);
            panel1.Location = new Point(1328, 275);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 2);
            panel1.TabIndex = 78;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(194, 39, 45);
            panel2.Location = new Point(1328, 422);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 2);
            panel2.TabIndex = 78;
            // 
            // examDATA
            // 
            examDATA.BackgroundColor = Color.White;
            examDATA.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            examDATA.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            examDATA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(28, 163, 232);
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            examDATA.DefaultCellStyle = dataGridViewCellStyle2;
            examDATA.GridColor = Color.FromArgb(240, 240, 240);
            examDATA.Location = new Point(12, 80);
            examDATA.Name = "examDATA";
            examDATA.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            examDATA.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            examDATA.RowHeadersWidth = 51;
            examDATA.Size = new Size(1310, 941);
            examDATA.TabIndex = 80;
            examDATA.CellDoubleClick += examDATA_CellDoubleClick;
            // 
            // ExamsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(examDATA);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(studentsBTN);
            Controls.Add(questionsBTN);
            Controls.Add(updateBTN);
            Controls.Add(datePICK);
            Controls.Add(endViewBTN);
            Controls.Add(deleteBTN);
            Controls.Add(insertBTN);
            Controls.Add(idTXT);
            Controls.Add(dateLBL);
            Controls.Add(nameLBL);
            Controls.Add(nameTXT);
            Controls.Add(returnBTN);
            Controls.Add(refreshBTN);
            Name = "ExamsForm";
            Text = "Exams";
            FormClosed += ExamsForm_FormClosed;
            ((System.ComponentModel.ISupportInitialize)examDATA).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idTXT;
        private Label dateLBL;
        private Label nameLBL;
        private RichTextBox nameTXT;
        private Button returnBTN;
        private Button refreshBTN;
        private Button insertBTN;
        private Button endViewBTN;
        private Button deleteBTN;
        private DateTimePicker datePICK;
        private Button updateBTN;
        private Button studentsBTN;
        private Button questionsBTN;
        private Panel panel1;
        private Panel panel2;
        private DataGridView examDATA;
    }
}