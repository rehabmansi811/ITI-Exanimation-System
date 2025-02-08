namespace Desktop.StudentForms.ExamsForm
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
            endViewBTN = new Button();
            datePICK = new DateTimePicker();
            enterBTN = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            examDATA = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)examDATA).BeginInit();
            SuspendLayout();
            // 
            // idTXT
            // 
            idTXT.BackColor = Color.White;
            idTXT.BorderStyle = BorderStyle.None;
            idTXT.Enabled = false;
            idTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            idTXT.Location = new Point(1538, 12);
            idTXT.Name = "idTXT";
            idTXT.Size = new Size(125, 32);
            idTXT.TabIndex = 70;
            idTXT.Visible = false;
            // 
            // dateLBL
            // 
            dateLBL.AutoSize = true;
            dateLBL.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold);
            dateLBL.ForeColor = Color.FromArgb(64, 64, 64);
            dateLBL.Location = new Point(1328, 323);
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
            nameTXT.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nameTXT.Location = new Point(1328, 230);
            nameTXT.Name = "nameTXT";
            nameTXT.ReadOnly = true;
            nameTXT.Size = new Size(562, 39);
            nameTXT.TabIndex = 58;
            nameTXT.Text = "";
            nameTXT.MouseDown += nameTXT_MouseDown;
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
            returnBTN.Size = new Size(655, 76);
            returnBTN.TabIndex = 11;
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
            refreshBTN.Size = new Size(655, 76);
            refreshBTN.TabIndex = 10;
            refreshBTN.Text = "♻ Refresh";
            refreshBTN.UseVisualStyleBackColor = true;
            refreshBTN.Click += refreshBTN_Click;
            // 
            // endViewBTN
            // 
            endViewBTN.Enabled = false;
            endViewBTN.BackColor = Color.FromArgb(194, 39, 45);
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
            endViewBTN.Click += endViewBTN_Click;
            // 
            // datePICK
            // 
            datePICK.BackColor = Color.White;
            datePICK.Enabled = false;
            datePICK.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            datePICK.Format = DateTimePickerFormat.Custom;
            datePICK.Location = new Point(1328, 358);
            datePICK.Name = "datePICK";
            datePICK.Size = new Size(562, 39);
            datePICK.TabIndex = 74;
            // 
            // enterBTN
            // 
            enterBTN.Enabled = false;
            enterBTN.BackColor = Color.FromArgb(76, 175, 80);
            enterBTN.Cursor = Cursors.Hand;
            enterBTN.FlatAppearance.BorderSize = 0;
            enterBTN.FlatStyle = FlatStyle.Flat;
            enterBTN.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterBTN.ForeColor = Color.White;
            enterBTN.Location = new Point(1328, 870);
            enterBTN.Name = "enterBTN";
            enterBTN.Size = new Size(562, 76);
            enterBTN.TabIndex = 75;
            enterBTN.Text = "Enter Exam";
            enterBTN.UseVisualStyleBackColor = true;
            enterBTN.Click += enterBTN_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(194, 39, 45);
            panel1.Location = new Point(1328, 275);
            panel1.Name = "panel1";
            panel1.Size = new Size(562, 2);
            panel1.TabIndex = 77;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(194, 39, 45);
            panel2.Location = new Point(1328, 403);
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
            examDATA.Location = new Point(21, 94);
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
            examDATA.Size = new Size(1301, 927);
            examDATA.TabIndex = 79;
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
            Controls.Add(enterBTN);
            Controls.Add(datePICK);
            Controls.Add(endViewBTN);
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
        private Button endViewBTN;
        private DateTimePicker datePICK;
        private Button enterBTN;
        private Panel panel1;
        private Panel panel2;
        private DataGridView examDATA;
    }
}