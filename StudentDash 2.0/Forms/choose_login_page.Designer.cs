namespace StudentDash_2._0.Forms
{
    partial class choose_login_page
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
            this.logo_pic = new Guna.UI2.WinForms.Guna2PictureBox();
            this.user_logo_pic = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.user_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_btn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_logo_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // logo_pic
            // 
            this.logo_pic.BackColor = System.Drawing.Color.Transparent;
            this.logo_pic.Image = global::StudentDash_2._0.Properties.Resources.Student_Dash_2_O_2__removebg_preview;
            this.logo_pic.ImageRotate = 0F;
            this.logo_pic.Location = new System.Drawing.Point(500, 223);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(300, 269);
            this.logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pic.TabIndex = 0;
            this.logo_pic.TabStop = false;
            // 
            // user_logo_pic
            // 
            this.user_logo_pic.BackColor = System.Drawing.Color.Transparent;
            this.user_logo_pic.Image = global::StudentDash_2._0.Properties.Resources.Student_Dash_2_O_1__removebg_preview;
            this.user_logo_pic.Location = new System.Drawing.Point(175, 315);
            this.user_logo_pic.Name = "user_logo_pic";
            this.user_logo_pic.Size = new System.Drawing.Size(170, 170);
            this.user_logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.user_logo_pic.TabIndex = 1;
            this.user_logo_pic.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StudentDash_2._0.Properties.Resources.icon_5359553_640;
            this.pictureBox1.Location = new System.Drawing.Point(950, 315);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // user_btn
            // 
            this.user_btn.BackColor = System.Drawing.Color.Transparent;
            this.user_btn.BorderColor = System.Drawing.Color.Transparent;
            this.user_btn.BorderRadius = 20;
            this.user_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.user_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.user_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.user_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.user_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.user_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(190)))), ((int)(((byte)(200)))));
            this.user_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_btn.ForeColor = System.Drawing.Color.White;
            this.user_btn.Location = new System.Drawing.Point(175, 503);
            this.user_btn.Name = "user_btn";
            this.user_btn.Size = new System.Drawing.Size(170, 52);
            this.user_btn.TabIndex = 3;
            this.user_btn.Text = "User";
            this.user_btn.Click += new System.EventHandler(this.user_btn_Click);
            this.user_btn.MouseLeave += new System.EventHandler(this.user_btn_MouseLeave);
            this.user_btn.MouseHover += new System.EventHandler(this.user_btn_MouseHover);
            // 
            // admin_btn
            // 
            this.admin_btn.BackColor = System.Drawing.Color.Transparent;
            this.admin_btn.BorderColor = System.Drawing.Color.Transparent;
            this.admin_btn.BorderRadius = 20;
            this.admin_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.admin_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.admin_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.admin_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.admin_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.admin_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(121)))), ((int)(((byte)(139)))));
            this.admin_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_btn.ForeColor = System.Drawing.Color.White;
            this.admin_btn.Location = new System.Drawing.Point(950, 503);
            this.admin_btn.Name = "admin_btn";
            this.admin_btn.Size = new System.Drawing.Size(170, 52);
            this.admin_btn.TabIndex = 4;
            this.admin_btn.Text = "Admin";
            this.admin_btn.MouseLeave += new System.EventHandler(this.admin_btn_MouseLeave);
            this.admin_btn.MouseHover += new System.EventHandler(this.admin_btn_MouseHover);
            // 
            // choose_login_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentDash_2._0.Properties.Resources._3;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.admin_btn);
            this.Controls.Add(this.user_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.user_logo_pic);
            this.Controls.Add(this.logo_pic);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "choose_login_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "choose_login_page";
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.user_logo_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox logo_pic;
        private System.Windows.Forms.PictureBox user_logo_pic;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button user_btn;
        private Guna.UI2.WinForms.Guna2Button admin_btn;
    }
}