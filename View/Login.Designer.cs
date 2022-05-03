namespace View
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.hopeForm1 = new ReaLTaiizor.Forms.HopeForm();
            this.hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            this.hopeGroupBox1 = new ReaLTaiizor.Controls.HopeGroupBox();
            this.PasswordBox = new ReaLTaiizor.Controls.HopeTextBox();
            this.UsernameBox = new ReaLTaiizor.Controls.HopeTextBox();
            this.dungeonHeaderLabel2 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.dungeonHeaderLabel1 = new ReaLTaiizor.Controls.DungeonHeaderLabel();
            this.LoginButton = new ReaLTaiizor.Controls.HopeRoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).BeginInit();
            this.hopeGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // hopeForm1
            // 
            this.hopeForm1.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeForm1.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.hopeForm1.ControlBoxColorN = System.Drawing.Color.White;
            this.hopeForm1.Cursor = System.Windows.Forms.Cursors.Default;
            this.hopeForm1.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeForm1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeForm1.Image = ((System.Drawing.Image)(resources.GetObject("hopeForm1.Image")));
            this.hopeForm1.Location = new System.Drawing.Point(0, 0);
            this.hopeForm1.Name = "hopeForm1";
            this.hopeForm1.Size = new System.Drawing.Size(800, 40);
            this.hopeForm1.TabIndex = 0;
            this.hopeForm1.Text = "Đăng nhập";
            this.hopeForm1.ThemeColor = System.Drawing.Color.FromArgb(((int)(((byte)(92)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            // 
            // hopePictureBox1
            // 
            this.hopePictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.hopePictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("hopePictureBox1.Image")));
            this.hopePictureBox1.Location = new System.Drawing.Point(64, 131);
            this.hopePictureBox1.Name = "hopePictureBox1";
            this.hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.hopePictureBox1.Size = new System.Drawing.Size(218, 211);
            this.hopePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.hopePictureBox1.TabIndex = 1;
            this.hopePictureBox1.TabStop = false;
            this.hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // hopeGroupBox1
            // 
            this.hopeGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Controls.Add(this.PasswordBox);
            this.hopeGroupBox1.Controls.Add(this.UsernameBox);
            this.hopeGroupBox1.Controls.Add(this.dungeonHeaderLabel2);
            this.hopeGroupBox1.Controls.Add(this.dungeonHeaderLabel1);
            this.hopeGroupBox1.Controls.Add(this.LoginButton);
            this.hopeGroupBox1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hopeGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.hopeGroupBox1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.hopeGroupBox1.Location = new System.Drawing.Point(369, 77);
            this.hopeGroupBox1.Name = "hopeGroupBox1";
            this.hopeGroupBox1.ShowText = false;
            this.hopeGroupBox1.Size = new System.Drawing.Size(416, 319);
            this.hopeGroupBox1.TabIndex = 3;
            this.hopeGroupBox1.TabStop = false;
            this.hopeGroupBox1.Text = "hopeGroupBox1";
            this.hopeGroupBox1.ThemeColor = System.Drawing.Color.WhiteSmoke;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.White;
            this.PasswordBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.PasswordBox.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.PasswordBox.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.PasswordBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.PasswordBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.PasswordBox.Hint = "";
            this.PasswordBox.Location = new System.Drawing.Point(13, 163);
            this.PasswordBox.MaxLength = 32767;
            this.PasswordBox.Multiline = false;
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '\0';
            this.PasswordBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordBox.SelectedText = "";
            this.PasswordBox.SelectionLength = 0;
            this.PasswordBox.SelectionStart = 0;
            this.PasswordBox.Size = new System.Drawing.Size(383, 43);
            this.PasswordBox.TabIndex = 4;
            this.PasswordBox.TabStop = false;
            this.PasswordBox.UseSystemPasswordChar = true;
            // 
            // UsernameBox
            // 
            this.UsernameBox.BackColor = System.Drawing.Color.White;
            this.UsernameBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(55)))), ((int)(((byte)(66)))));
            this.UsernameBox.BorderColorA = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.UsernameBox.BorderColorB = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.UsernameBox.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.UsernameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.UsernameBox.Hint = "";
            this.UsernameBox.Location = new System.Drawing.Point(13, 54);
            this.UsernameBox.MaxLength = 32767;
            this.UsernameBox.Multiline = false;
            this.UsernameBox.Name = "UsernameBox";
            this.UsernameBox.PasswordChar = '\0';
            this.UsernameBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UsernameBox.SelectedText = "";
            this.UsernameBox.SelectionLength = 0;
            this.UsernameBox.SelectionStart = 0;
            this.UsernameBox.Size = new System.Drawing.Size(383, 43);
            this.UsernameBox.TabIndex = 3;
            this.UsernameBox.TabStop = false;
            this.UsernameBox.UseSystemPasswordChar = false;
            // 
            // dungeonHeaderLabel2
            // 
            this.dungeonHeaderLabel2.AutoSize = true;
            this.dungeonHeaderLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel2.Location = new System.Drawing.Point(8, 119);
            this.dungeonHeaderLabel2.Name = "dungeonHeaderLabel2";
            this.dungeonHeaderLabel2.Size = new System.Drawing.Size(96, 25);
            this.dungeonHeaderLabel2.TabIndex = 2;
            this.dungeonHeaderLabel2.Text = "Mật khẩu";
            // 
            // dungeonHeaderLabel1
            // 
            this.dungeonHeaderLabel1.AutoSize = true;
            this.dungeonHeaderLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonHeaderLabel1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.dungeonHeaderLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonHeaderLabel1.Location = new System.Drawing.Point(6, 15);
            this.dungeonHeaderLabel1.Name = "dungeonHeaderLabel1";
            this.dungeonHeaderLabel1.Size = new System.Drawing.Size(131, 25);
            this.dungeonHeaderLabel1.TabIndex = 1;
            this.dungeonHeaderLabel1.Text = "Tên tài khoản";
            // 
            // LoginButton
            // 
            this.LoginButton.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(230)))));
            this.LoginButton.ButtonType = ReaLTaiizor.Util.HopeButtonType.Primary;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.DangerColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(108)))), ((int)(((byte)(108)))));
            this.LoginButton.DefaultColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.LoginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.LoginButton.HoverTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(49)))), ((int)(((byte)(51)))));
            this.LoginButton.InfoColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(147)))), ((int)(((byte)(153)))));
            this.LoginButton.Location = new System.Drawing.Point(72, 245);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.PrimaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(255)))));
            this.LoginButton.Size = new System.Drawing.Size(261, 41);
            this.LoginButton.SuccessColor = System.Drawing.Color.FromArgb(((int)(((byte)(103)))), ((int)(((byte)(194)))), ((int)(((byte)(58)))));
            this.LoginButton.TabIndex = 0;
            this.LoginButton.Text = "Đăng nhập";
            this.LoginButton.TextColor = System.Drawing.Color.White;
            this.LoginButton.WarningColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(162)))), ((int)(((byte)(60)))));
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.hopeGroupBox1);
            this.Controls.Add(this.hopePictureBox1);
            this.Controls.Add(this.hopeForm1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximumSize = new System.Drawing.Size(1920, 1030);
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.hopePictureBox1)).EndInit();
            this.hopeGroupBox1.ResumeLayout(false);
            this.hopeGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.HopeForm hopeForm1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.HopeGroupBox hopeGroupBox1;
        private ReaLTaiizor.Controls.HopeTextBox PasswordBox;
        private ReaLTaiizor.Controls.HopeTextBox UsernameBox;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel2;
        private ReaLTaiizor.Controls.DungeonHeaderLabel dungeonHeaderLabel1;
        private ReaLTaiizor.Controls.HopeRoundButton LoginButton;
    }
}

