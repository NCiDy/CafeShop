
namespace QuanLyCafe_FormNew
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_DangNhap = new Guna.UI2.WinForms.Guna2Button();
            this.Password_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Accout_txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.Img_CafeLogin = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2CircleButton1 = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_CafeLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.LemonChiffon;
            this.guna2Panel1.BorderRadius = 50;
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.BT_DangNhap);
            this.guna2Panel1.Controls.Add(this.Password_txt);
            this.guna2Panel1.Controls.Add(this.Accout_txt);
            this.guna2Panel1.Controls.Add(this.Img_CafeLogin);
            this.guna2Panel1.Controls.Add(this.guna2CircleButton1);
            this.guna2Panel1.Location = new System.Drawing.Point(263, 181);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1112, 550);
            this.guna2Panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(658, 110);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 38);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Login";
            // 
            // BT_DangNhap
            // 
            this.BT_DangNhap.BorderRadius = 18;
            this.BT_DangNhap.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BT_DangNhap.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BT_DangNhap.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BT_DangNhap.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BT_DangNhap.FillColor = System.Drawing.Color.Tan;
            this.BT_DangNhap.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_DangNhap.ForeColor = System.Drawing.Color.White;
            this.BT_DangNhap.Location = new System.Drawing.Point(521, 369);
            this.BT_DangNhap.Name = "BT_DangNhap";
            this.BT_DangNhap.Size = new System.Drawing.Size(415, 51);
            this.BT_DangNhap.TabIndex = 2;
            this.BT_DangNhap.Text = "Login";
            this.BT_DangNhap.Click += new System.EventHandler(this.BT_DangNhap_Click);
            // 
            // Password_txt
            // 
            this.Password_txt.BorderRadius = 18;
            this.Password_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password_txt.DefaultText = "";
            this.Password_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Password_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Password_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Password_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_txt.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_txt.ForeColor = System.Drawing.Color.Black;
            this.Password_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Password_txt.IconLeft = ((System.Drawing.Image)(resources.GetObject("Password_txt.IconLeft")));
            this.Password_txt.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Password_txt.Location = new System.Drawing.Point(521, 272);
            this.Password_txt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Password_txt.MaxLength = 20;
            this.Password_txt.Name = "Password_txt";
            this.Password_txt.PasswordChar = '●';
            this.Password_txt.PlaceholderText = "PassWord";
            this.Password_txt.SelectedText = "";
            this.Password_txt.Size = new System.Drawing.Size(415, 67);
            this.Password_txt.TabIndex = 1;
            this.Password_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password_txt.UseSystemPasswordChar = true;
            // 
            // Accout_txt
            // 
            this.Accout_txt.BorderRadius = 18;
            this.Accout_txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Accout_txt.DefaultText = "";
            this.Accout_txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.Accout_txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.Accout_txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Accout_txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.Accout_txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Accout_txt.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Accout_txt.ForeColor = System.Drawing.Color.Black;
            this.Accout_txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.Accout_txt.IconLeft = ((System.Drawing.Image)(resources.GetObject("Accout_txt.IconLeft")));
            this.Accout_txt.IconLeftSize = new System.Drawing.Size(30, 30);
            this.Accout_txt.Location = new System.Drawing.Point(521, 173);
            this.Accout_txt.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Accout_txt.MaxLength = 20;
            this.Accout_txt.Name = "Accout_txt";
            this.Accout_txt.PasswordChar = '\0';
            this.Accout_txt.PlaceholderText = "UserName";
            this.Accout_txt.SelectedText = "";
            this.Accout_txt.Size = new System.Drawing.Size(415, 67);
            this.Accout_txt.TabIndex = 0;
            this.Accout_txt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Img_CafeLogin
            // 
            this.Img_CafeLogin.BackColor = System.Drawing.Color.Transparent;
            this.Img_CafeLogin.Image = ((System.Drawing.Image)(resources.GetObject("Img_CafeLogin.Image")));
            this.Img_CafeLogin.ImageRotate = 0F;
            this.Img_CafeLogin.Location = new System.Drawing.Point(54, 86);
            this.Img_CafeLogin.Name = "Img_CafeLogin";
            this.Img_CafeLogin.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.Img_CafeLogin.Size = new System.Drawing.Size(390, 400);
            this.Img_CafeLogin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Img_CafeLogin.TabIndex = 1;
            this.Img_CafeLogin.TabStop = false;
            // 
            // guna2CircleButton1
            // 
            this.guna2CircleButton1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2CircleButton1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2CircleButton1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2CircleButton1.FillColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2CircleButton1.ForeColor = System.Drawing.Color.White;
            this.guna2CircleButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2CircleButton1.Image")));
            this.guna2CircleButton1.ImageSize = new System.Drawing.Size(30, 30);
            this.guna2CircleButton1.Location = new System.Drawing.Point(1057, -1);
            this.guna2CircleButton1.Name = "guna2CircleButton1";
            this.guna2CircleButton1.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.guna2CircleButton1.Size = new System.Drawing.Size(56, 48);
            this.guna2CircleButton1.TabIndex = 4;
            this.guna2CircleButton1.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 18;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.FillColor = System.Drawing.Color.Tan;
            this.guna2Button1.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(521, 435);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(415, 51);
            this.guna2Button1.TabIndex = 7;
            this.guna2Button1.Text = "Khách vãng lai";
            this.guna2Button1.Click += new System.EventHandler(this.guna2Button1_Click);
            // 
            // Login
            // 
            this.AcceptButton = this.BT_DangNhap;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1456, 748);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Img_CafeLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button BT_DangNhap;
        private Guna.UI2.WinForms.Guna2TextBox Password_txt;
        private Guna.UI2.WinForms.Guna2TextBox Accout_txt;
        private Guna.UI2.WinForms.Guna2CirclePictureBox Img_CafeLogin;
        private Guna.UI2.WinForms.Guna2CircleButton guna2CircleButton1;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
    }
}

