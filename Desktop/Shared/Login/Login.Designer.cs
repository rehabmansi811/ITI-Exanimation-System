namespace Desktop
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            logBTN = new Button();
            Header = new Label();
            userTXT = new TextBox();
            passTXT = new TextBox();
            warningLBL = new Label();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            lockPIC = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)lockPIC).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // logBTN
            // 
            logBTN.Anchor = AnchorStyles.None;
            logBTN.BackColor = Color.FromArgb(194, 39, 45);
            logBTN.Cursor = Cursors.Hand;
            logBTN.FlatAppearance.BorderSize = 0;
            logBTN.FlatStyle = FlatStyle.Flat;
            logBTN.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            logBTN.ForeColor = Color.White;
            logBTN.Location = new Point(540, 580);
            logBTN.Name = "logBTN";
            logBTN.Size = new Size(400, 70);
            logBTN.TabIndex = 4;
            logBTN.Text = "LOGIN";
            logBTN.UseVisualStyleBackColor = false;
            logBTN.Click += logBTN_Click;
            logBTN.MouseEnter += logBTN_MouseEnter;
            logBTN.MouseLeave += logBTN_MouseLeave;
            // 
            // Header
            // 
            Header.Anchor = AnchorStyles.Top;
            Header.AutoSize = true;
            Header.Font = new Font("Segoe UI Semibold", 36F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            Header.ForeColor = Color.FromArgb(64, 64, 64);
            Header.Location = new Point(407, 31);
            Header.Name = "Header";
            Header.Size = new Size(666, 81);
            Header.TabIndex = 1;
            Header.Text = "EXAMINATION SYSTEM";
            Header.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // userTXT
            // 
            userTXT.Anchor = AnchorStyles.None;
            userTXT.BorderStyle = BorderStyle.None;
            userTXT.Font = new Font("Segoe UI", 18F);
            userTXT.ForeColor = Color.FromArgb(64, 64, 64);
            userTXT.Location = new Point(540, 350);
            userTXT.MaxLength = 255;
            userTXT.Name = "userTXT";
            userTXT.PlaceholderText = "Email";
            userTXT.Size = new Size(357, 40);
            userTXT.TabIndex = 1;
            // 
            // passTXT
            // 
            passTXT.Anchor = AnchorStyles.None;
            passTXT.BorderStyle = BorderStyle.None;
            passTXT.Font = new Font("Segoe UI", 18F);
            passTXT.ForeColor = Color.FromArgb(64, 64, 64);
            passTXT.Location = new Point(540, 450);
            passTXT.MaxLength = 255;
            passTXT.Name = "passTXT";
            passTXT.PlaceholderText = "Password";
            passTXT.Size = new Size(357, 40);
            passTXT.TabIndex = 2;
            passTXT.UseSystemPasswordChar = true;
            // 
            // warningLBL
            // 
            warningLBL.Anchor = AnchorStyles.None;
            warningLBL.AutoSize = true;
            warningLBL.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            warningLBL.ForeColor = Color.FromArgb(220, 50, 50);
            warningLBL.Location = new Point(540, 520);
            warningLBL.Name = "warningLBL";
            warningLBL.Size = new Size(290, 28);
            warningLBL.TabIndex = 6;
            warningLBL.Text = "Incorrect username or password";
            warningLBL.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1143, -35);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(358, 288);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(194, 39, 45);
            panel1.Location = new Point(540, 400);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 2);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(194, 39, 45);
            panel2.Location = new Point(540, 500);
            panel2.Name = "panel2";
            panel2.Size = new Size(400, 2);
            panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(903, 356);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(37, 43);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // lockPIC
            // 
            lockPIC.Anchor = AnchorStyles.Top;
            lockPIC.Cursor = Cursors.Hand;
            lockPIC.Image = (Image)resources.GetObject("lockPIC.Image");
            lockPIC.Location = new Point(903, 447);
            lockPIC.Name = "lockPIC";
            lockPIC.Size = new Size(37, 52);
            lockPIC.SizeMode = PictureBoxSizeMode.Zoom;
            lockPIC.TabIndex = 9;
            lockPIC.TabStop = false;
            lockPIC.Click += lockPIC_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Anchor = AnchorStyles.Top;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(-89, 365);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(623, 521);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1480, 800);
            Controls.Add(lockPIC);
            Controls.Add(pictureBox2);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(warningLBL);
            Controls.Add(passTXT);
            Controls.Add(userTXT);
            Controls.Add(Header);
            Controls.Add(logBTN);
            Controls.Add(pictureBox1);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login System";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)lockPIC).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        // Add to your class variables
        private Panel panel1;
        private Panel panel2;

        #endregion

        private Button logBTN;
        private Label Header;
        private TextBox userTXT;
        private TextBox passTXT;
        private Label warningLBL;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox lockPIC;
        private PictureBox pictureBox3;
    }
}
