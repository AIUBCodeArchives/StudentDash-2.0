namespace StudentDash_2._0.Forms
{
    partial class user_login_page
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.show_password_btn = new System.Windows.Forms.PictureBox();
            this.signup_btn = new System.Windows.Forms.LinkLabel();
            this.dont_have_account_lbl = new System.Windows.Forms.Label();
            this.login_btn = new Guna.UI2.WinForms.Guna2Button();
            this.password_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.student_id_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.password_lbl = new System.Windows.Forms.Label();
            this.student_id_lbl = new System.Windows.Forms.Label();
            this.login_lbl = new System.Windows.Forms.Label();
            this.forgot_password_lbl = new System.Windows.Forms.LinkLabel();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.logo_pic = new System.Windows.Forms.PictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_password_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.show_password_btn);
            this.guna2Panel1.Controls.Add(this.signup_btn);
            this.guna2Panel1.Controls.Add(this.dont_have_account_lbl);
            this.guna2Panel1.Controls.Add(this.login_btn);
            this.guna2Panel1.Controls.Add(this.password_txtbox);
            this.guna2Panel1.Controls.Add(this.student_id_txtbox);
            this.guna2Panel1.Controls.Add(this.password_lbl);
            this.guna2Panel1.Controls.Add(this.student_id_lbl);
            this.guna2Panel1.Controls.Add(this.login_lbl);
            this.guna2Panel1.Controls.Add(this.forgot_password_lbl);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.guna2Panel1.Location = new System.Drawing.Point(111, 72);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(480, 657);
            this.guna2Panel1.TabIndex = 0;
            // 
            // show_password_btn
            // 
            this.show_password_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.show_password_btn.Image = global::StudentDash_2._0.Properties.Resources.icons8_eye_50;
            this.show_password_btn.Location = new System.Drawing.Point(389, 367);
            this.show_password_btn.Name = "show_password_btn";
            this.show_password_btn.Size = new System.Drawing.Size(26, 29);
            this.show_password_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.show_password_btn.TabIndex = 10;
            this.show_password_btn.TabStop = false;
            this.show_password_btn.Click += new System.EventHandler(this.show_password_btn_Click);
            // 
            // signup_btn
            // 
            this.signup_btn.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.signup_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_btn.LinkColor = System.Drawing.Color.Black;
            this.signup_btn.Location = new System.Drawing.Point(311, 534);
            this.signup_btn.Name = "signup_btn";
            this.signup_btn.Size = new System.Drawing.Size(135, 23);
            this.signup_btn.TabIndex = 9;
            this.signup_btn.TabStop = true;
            this.signup_btn.Text = "Signup!";
            this.signup_btn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.signup_btn_LinkClicked);
            // 
            // dont_have_account_lbl
            // 
            this.dont_have_account_lbl.AutoSize = true;
            this.dont_have_account_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dont_have_account_lbl.Location = new System.Drawing.Point(108, 534);
            this.dont_have_account_lbl.Name = "dont_have_account_lbl";
            this.dont_have_account_lbl.Size = new System.Drawing.Size(185, 20);
            this.dont_have_account_lbl.TabIndex = 8;
            this.dont_have_account_lbl.Text = "Don\'t have an account?";
            // 
            // login_btn
            // 
            this.login_btn.BorderRadius = 20;
            this.login_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.login_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(46, 478);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(388, 53);
            this.login_btn.TabIndex = 7;
            this.login_btn.Text = "Log In";
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            this.login_btn.MouseLeave += new System.EventHandler(this.login_btn_MouseLeave);
            this.login_btn.MouseHover += new System.EventHandler(this.login_btn_MouseHover);
            // 
            // password_txtbox
            // 
            this.password_txtbox.BackColor = System.Drawing.Color.Transparent;
            this.password_txtbox.BorderRadius = 25;
            this.password_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_txtbox.DefaultText = "";
            this.password_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_txtbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.password_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_txtbox.ForeColor = System.Drawing.Color.Black;
            this.password_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_txtbox.Location = new System.Drawing.Point(46, 351);
            this.password_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.password_txtbox.Name = "password_txtbox";
            this.password_txtbox.PasswordChar = '*';
            this.password_txtbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.password_txtbox.PlaceholderText = "Enter your password";
            this.password_txtbox.SelectedText = "";
            this.password_txtbox.Size = new System.Drawing.Size(388, 60);
            this.password_txtbox.TabIndex = 5;
            // 
            // student_id_txtbox
            // 
            this.student_id_txtbox.BackColor = System.Drawing.Color.Transparent;
            this.student_id_txtbox.BorderRadius = 25;
            this.student_id_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.student_id_txtbox.DefaultText = "";
            this.student_id_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.student_id_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.student_id_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.student_id_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.student_id_txtbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.student_id_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.student_id_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.student_id_txtbox.ForeColor = System.Drawing.Color.Black;
            this.student_id_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.student_id_txtbox.Location = new System.Drawing.Point(46, 229);
            this.student_id_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.student_id_txtbox.Name = "student_id_txtbox";
            this.student_id_txtbox.PasswordChar = '\0';
            this.student_id_txtbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.student_id_txtbox.PlaceholderText = "Enter your student ID";
            this.student_id_txtbox.SelectedText = "";
            this.student_id_txtbox.Size = new System.Drawing.Size(388, 60);
            this.student_id_txtbox.TabIndex = 4;
            // 
            // password_lbl
            // 
            this.password_lbl.AutoSize = true;
            this.password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.password_lbl.Location = new System.Drawing.Point(57, 327);
            this.password_lbl.Name = "password_lbl";
            this.password_lbl.Size = new System.Drawing.Size(97, 20);
            this.password_lbl.TabIndex = 3;
            this.password_lbl.Text = "Password:";
            // 
            // student_id_lbl
            // 
            this.student_id_lbl.AutoSize = true;
            this.student_id_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_id_lbl.Location = new System.Drawing.Point(57, 205);
            this.student_id_lbl.Name = "student_id_lbl";
            this.student_id_lbl.Size = new System.Drawing.Size(104, 20);
            this.student_id_lbl.TabIndex = 1;
            this.student_id_lbl.Text = "Student ID:";
            // 
            // login_lbl
            // 
            this.login_lbl.AutoSize = true;
            this.login_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.login_lbl.Location = new System.Drawing.Point(136, 58);
            this.login_lbl.Name = "login_lbl";
            this.login_lbl.Size = new System.Drawing.Size(209, 76);
            this.login_lbl.TabIndex = 0;
            this.login_lbl.Text = "Log In";
            // 
            // forgot_password_lbl
            // 
            this.forgot_password_lbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.forgot_password_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgot_password_lbl.LinkColor = System.Drawing.Color.Black;
            this.forgot_password_lbl.Location = new System.Drawing.Point(245, 415);
            this.forgot_password_lbl.Name = "forgot_password_lbl";
            this.forgot_password_lbl.Size = new System.Drawing.Size(201, 23);
            this.forgot_password_lbl.TabIndex = 6;
            this.forgot_password_lbl.TabStop = true;
            this.forgot_password_lbl.Text = "Forgot Password?";
            // 
            // back_btn
            // 
            this.back_btn.BackColor = System.Drawing.Color.Transparent;
            this.back_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back_btn.Image = global::StudentDash_2._0.Properties.Resources.Screenshot_2024_09_26_232421_removebg_preview;
            this.back_btn.Location = new System.Drawing.Point(0, 0);
            this.back_btn.Name = "back_btn";
            this.back_btn.Size = new System.Drawing.Size(43, 34);
            this.back_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.back_btn.TabIndex = 1;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Image = global::StudentDash_2._0.Properties.Resources.Screenshot_2024_09_26_232413_removebg_preview;
            this.exit_btn.Location = new System.Drawing.Point(1257, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(43, 34);
            this.exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_btn.TabIndex = 3;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // logo_pic
            // 
            this.logo_pic.BackColor = System.Drawing.Color.Transparent;
            this.logo_pic.Image = global::StudentDash_2._0.Properties.Resources.Student_Dash_2_O_2__removebg_preview2;
            this.logo_pic.Location = new System.Drawing.Point(609, 154);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(666, 493);
            this.logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pic.TabIndex = 7;
            this.logo_pic.TabStop = false;
            // 
            // user_login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentDash_2._0.Properties.Resources._5;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.logo_pic);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.back_btn);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "user_login_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "user_login_page";
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.show_password_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.Label login_lbl;
        private System.Windows.Forms.Label student_id_lbl;
        private System.Windows.Forms.Label password_lbl;
        private Guna.UI2.WinForms.Guna2TextBox student_id_txtbox;
        private Guna.UI2.WinForms.Guna2Button login_btn;
        private Guna.UI2.WinForms.Guna2TextBox password_txtbox;
        private System.Windows.Forms.LinkLabel forgot_password_lbl;
        private System.Windows.Forms.LinkLabel signup_btn;
        private System.Windows.Forms.Label dont_have_account_lbl;
        private System.Windows.Forms.PictureBox exit_btn;
        private System.Windows.Forms.PictureBox logo_pic;
        private System.Windows.Forms.PictureBox show_password_btn;
    }
}