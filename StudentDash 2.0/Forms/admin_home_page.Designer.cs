namespace StudentDash_2._0.Forms
{
    partial class admin_home_page
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
            this.exit_btn = new System.Windows.Forms.PictureBox();
            this.back_btn = new System.Windows.Forms.PictureBox();
            this.admin_logo = new System.Windows.Forms.PictureBox();
            this.signout_btn = new Guna.UI2.WinForms.Guna2Button();
            this.admin_home_lbl = new System.Windows.Forms.Label();
            this.admin_id_lbl = new System.Windows.Forms.Label();
            this.admin_name_lbl = new System.Windows.Forms.Label();
            this.search_btn = new Guna.UI2.WinForms.Guna2Button();
            this.search_student_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.search_student_id_lbl = new System.Windows.Forms.Label();
            this.block_btn = new Guna.UI2.WinForms.Guna2Button();
            this.block_user_lbl = new System.Windows.Forms.Label();
            this.info_panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.description_lbl = new System.Windows.Forms.Label();
            this.ride_description_lbl = new System.Windows.Forms.Label();
            this.username_lbl = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.vehicle_number_value_lbl = new System.Windows.Forms.Label();
            this.vehicle_number_lbl = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_logo)).BeginInit();
            this.info_panel1.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
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
            this.exit_btn.TabIndex = 9;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
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
            this.back_btn.TabIndex = 8;
            this.back_btn.TabStop = false;
            this.back_btn.Click += new System.EventHandler(this.back_btn_Click);
            // 
            // admin_logo
            // 
            this.admin_logo.BackColor = System.Drawing.Color.Transparent;
            this.admin_logo.Image = global::StudentDash_2._0.Properties.Resources.icon_5359553_640;
            this.admin_logo.Location = new System.Drawing.Point(114, 177);
            this.admin_logo.Name = "admin_logo";
            this.admin_logo.Size = new System.Drawing.Size(181, 221);
            this.admin_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.admin_logo.TabIndex = 10;
            this.admin_logo.TabStop = false;
            // 
            // signout_btn
            // 
            this.signout_btn.BackColor = System.Drawing.Color.Transparent;
            this.signout_btn.BorderRadius = 20;
            this.signout_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signout_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signout_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signout_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signout_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signout_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.signout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signout_btn.ForeColor = System.Drawing.Color.White;
            this.signout_btn.Location = new System.Drawing.Point(87, 636);
            this.signout_btn.Name = "signout_btn";
            this.signout_btn.Size = new System.Drawing.Size(243, 53);
            this.signout_btn.TabIndex = 27;
            this.signout_btn.Text = "Sign Out";
            this.signout_btn.Click += new System.EventHandler(this.signout_btn_Click);
            this.signout_btn.MouseLeave += new System.EventHandler(this.signout_btn_MouseLeave);
            this.signout_btn.MouseHover += new System.EventHandler(this.signout_btn_MouseHover);
            // 
            // admin_home_lbl
            // 
            this.admin_home_lbl.AutoSize = true;
            this.admin_home_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_home_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_home_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(213)))));
            this.admin_home_lbl.Location = new System.Drawing.Point(447, 26);
            this.admin_home_lbl.Name = "admin_home_lbl";
            this.admin_home_lbl.Size = new System.Drawing.Size(406, 76);
            this.admin_home_lbl.TabIndex = 28;
            this.admin_home_lbl.Text = "Admin Home";
            // 
            // admin_id_lbl
            // 
            this.admin_id_lbl.AutoSize = true;
            this.admin_id_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_id_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_id_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(213)))));
            this.admin_id_lbl.Location = new System.Drawing.Point(95, 401);
            this.admin_id_lbl.Name = "admin_id_lbl";
            this.admin_id_lbl.Size = new System.Drawing.Size(176, 44);
            this.admin_id_lbl.TabIndex = 29;
            this.admin_id_lbl.Text = "Admin ID";
            // 
            // admin_name_lbl
            // 
            this.admin_name_lbl.AutoSize = true;
            this.admin_name_lbl.BackColor = System.Drawing.Color.Transparent;
            this.admin_name_lbl.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.admin_name_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(213)))));
            this.admin_name_lbl.Location = new System.Drawing.Point(92, 477);
            this.admin_name_lbl.Name = "admin_name_lbl";
            this.admin_name_lbl.Size = new System.Drawing.Size(203, 37);
            this.admin_name_lbl.TabIndex = 30;
            this.admin_name_lbl.Text = "Admin Name";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.Transparent;
            this.search_btn.BorderRadius = 20;
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.search_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.search_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.search_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.search_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.search_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.search_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(902, 445);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(154, 48);
            this.search_btn.TabIndex = 23;
            this.search_btn.Text = "Search";
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            this.search_btn.MouseLeave += new System.EventHandler(this.search_btn_MouseLeave);
            this.search_btn.MouseHover += new System.EventHandler(this.search_btn_MouseHover);
            // 
            // search_student_txtbox
            // 
            this.search_student_txtbox.BackColor = System.Drawing.Color.Transparent;
            this.search_student_txtbox.BorderRadius = 18;
            this.search_student_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_student_txtbox.DefaultText = "";
            this.search_student_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_student_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_student_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_student_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_student_txtbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.search_student_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_student_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_student_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_student_txtbox.Location = new System.Drawing.Point(388, 446);
            this.search_student_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_student_txtbox.Name = "search_student_txtbox";
            this.search_student_txtbox.PasswordChar = '\0';
            this.search_student_txtbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.search_student_txtbox.PlaceholderText = "Enter your old password";
            this.search_student_txtbox.SelectedText = "";
            this.search_student_txtbox.Size = new System.Drawing.Size(480, 47);
            this.search_student_txtbox.TabIndex = 22;
            // 
            // search_student_id_lbl
            // 
            this.search_student_id_lbl.AutoSize = true;
            this.search_student_id_lbl.BackColor = System.Drawing.Color.Transparent;
            this.search_student_id_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_student_id_lbl.ForeColor = System.Drawing.Color.Black;
            this.search_student_id_lbl.Location = new System.Drawing.Point(401, 418);
            this.search_student_id_lbl.Name = "search_student_id_lbl";
            this.search_student_id_lbl.Size = new System.Drawing.Size(172, 25);
            this.search_student_id_lbl.TabIndex = 21;
            this.search_student_id_lbl.Text = "Search Student ID:";
            // 
            // block_btn
            // 
            this.block_btn.BackColor = System.Drawing.Color.Transparent;
            this.block_btn.BorderRadius = 20;
            this.block_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.block_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.block_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.block_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.block_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.block_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.block_btn.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.block_btn.ForeColor = System.Drawing.Color.White;
            this.block_btn.Location = new System.Drawing.Point(1076, 446);
            this.block_btn.Name = "block_btn";
            this.block_btn.Size = new System.Drawing.Size(154, 48);
            this.block_btn.TabIndex = 32;
            this.block_btn.Text = "Block";
            this.block_btn.Click += new System.EventHandler(this.block_btn_Click);
            this.block_btn.MouseLeave += new System.EventHandler(this.block_btn_MouseLeave);
            this.block_btn.MouseHover += new System.EventHandler(this.block_btn_MouseHover);
            // 
            // block_user_lbl
            // 
            this.block_user_lbl.AutoSize = true;
            this.block_user_lbl.BackColor = System.Drawing.Color.Transparent;
            this.block_user_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.block_user_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.block_user_lbl.Location = new System.Drawing.Point(691, 394);
            this.block_user_lbl.Name = "block_user_lbl";
            this.block_user_lbl.Size = new System.Drawing.Size(205, 48);
            this.block_user_lbl.TabIndex = 33;
            this.block_user_lbl.Text = "Block User";
            // 
            // info_panel1
            // 
            this.info_panel1.BackColor = System.Drawing.Color.Transparent;
            this.info_panel1.BorderRadius = 30;
            this.info_panel1.Controls.Add(this.description_lbl);
            this.info_panel1.Controls.Add(this.ride_description_lbl);
            this.info_panel1.Controls.Add(this.username_lbl);
            this.info_panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(121)))), ((int)(((byte)(139)))));
            this.info_panel1.Location = new System.Drawing.Point(388, 515);
            this.info_panel1.Name = "info_panel1";
            this.info_panel1.Size = new System.Drawing.Size(385, 262);
            this.info_panel1.TabIndex = 34;
            // 
            // description_lbl
            // 
            this.description_lbl.BackColor = System.Drawing.Color.Transparent;
            this.description_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.description_lbl.ForeColor = System.Drawing.Color.White;
            this.description_lbl.Location = new System.Drawing.Point(13, 115);
            this.description_lbl.Name = "description_lbl";
            this.description_lbl.Size = new System.Drawing.Size(341, 120);
            this.description_lbl.TabIndex = 18;
            this.description_lbl.Text = "description";
            // 
            // ride_description_lbl
            // 
            this.ride_description_lbl.AutoSize = true;
            this.ride_description_lbl.BackColor = System.Drawing.Color.Transparent;
            this.ride_description_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ride_description_lbl.ForeColor = System.Drawing.Color.White;
            this.ride_description_lbl.Location = new System.Drawing.Point(3, 67);
            this.ride_description_lbl.Name = "ride_description_lbl";
            this.ride_description_lbl.Size = new System.Drawing.Size(359, 48);
            this.ride_description_lbl.TabIndex = 16;
            this.ride_description_lbl.Text = "Report Description:";
            // 
            // username_lbl
            // 
            this.username_lbl.AutoSize = true;
            this.username_lbl.BackColor = System.Drawing.Color.Transparent;
            this.username_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(213)))));
            this.username_lbl.Location = new System.Drawing.Point(1, 7);
            this.username_lbl.Name = "username_lbl";
            this.username_lbl.Size = new System.Drawing.Size(282, 60);
            this.username_lbl.TabIndex = 15;
            this.username_lbl.Text = "ID: Number";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 30;
            this.guna2Panel1.Controls.Add(this.vehicle_number_value_lbl);
            this.guna2Panel1.Controls.Add(this.vehicle_number_lbl);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(121)))), ((int)(((byte)(139)))));
            this.guna2Panel1.Location = new System.Drawing.Point(808, 515);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(422, 262);
            this.guna2Panel1.TabIndex = 35;
            // 
            // vehicle_number_value_lbl
            // 
            this.vehicle_number_value_lbl.AutoSize = true;
            this.vehicle_number_value_lbl.BackColor = System.Drawing.Color.Transparent;
            this.vehicle_number_value_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_number_value_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(189)))), ((int)(((byte)(89)))));
            this.vehicle_number_value_lbl.Location = new System.Drawing.Point(27, 135);
            this.vehicle_number_value_lbl.Name = "vehicle_number_value_lbl";
            this.vehicle_number_value_lbl.Size = new System.Drawing.Size(288, 48);
            this.vehicle_number_value_lbl.TabIndex = 38;
            this.vehicle_number_value_lbl.Text = "vehicle number";
            // 
            // vehicle_number_lbl
            // 
            this.vehicle_number_lbl.AutoSize = true;
            this.vehicle_number_lbl.BackColor = System.Drawing.Color.Transparent;
            this.vehicle_number_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehicle_number_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(213)))));
            this.vehicle_number_lbl.Location = new System.Drawing.Point(25, 30);
            this.vehicle_number_lbl.Name = "vehicle_number_lbl";
            this.vehicle_number_lbl.Size = new System.Drawing.Size(377, 60);
            this.vehicle_number_lbl.TabIndex = 15;
            this.vehicle_number_lbl.Text = "Vehicle Number";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(388, 175);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(385, 204);
            this.dataGridView1.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.label2.Location = new System.Drawing.Point(380, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 44);
            this.label2.TabIndex = 36;
            this.label2.Text = "Reports";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(808, 175);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(422, 204);
            this.dataGridView2.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.label3.Location = new System.Drawing.Point(800, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(227, 44);
            this.label3.TabIndex = 38;
            this.label3.Text = "Active Riders";
            // 
            // admin_home_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentDash_2._0.Properties.Resources.Student_Dash_2_O_9_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.info_panel1);
            this.Controls.Add(this.block_user_lbl);
            this.Controls.Add(this.block_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_student_txtbox);
            this.Controls.Add(this.search_student_id_lbl);
            this.Controls.Add(this.admin_name_lbl);
            this.Controls.Add(this.admin_id_lbl);
            this.Controls.Add(this.admin_home_lbl);
            this.Controls.Add(this.signout_btn);
            this.Controls.Add(this.admin_logo);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.back_btn);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "admin_home_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "admin_home_page";
            this.Load += new System.EventHandler(this.admin_home_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.back_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.admin_logo)).EndInit();
            this.info_panel1.ResumeLayout(false);
            this.info_panel1.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit_btn;
        private System.Windows.Forms.PictureBox back_btn;
        private System.Windows.Forms.PictureBox admin_logo;
        private Guna.UI2.WinForms.Guna2Button signout_btn;
        private System.Windows.Forms.Label admin_home_lbl;
        private System.Windows.Forms.Label admin_id_lbl;
        private System.Windows.Forms.Label admin_name_lbl;
        private Guna.UI2.WinForms.Guna2Button search_btn;
        private Guna.UI2.WinForms.Guna2TextBox search_student_txtbox;
        private System.Windows.Forms.Label search_student_id_lbl;
        private Guna.UI2.WinForms.Guna2Button block_btn;
        private System.Windows.Forms.Label block_user_lbl;
        private Guna.UI2.WinForms.Guna2Panel info_panel1;
        private System.Windows.Forms.Label ride_description_lbl;
        private System.Windows.Forms.Label username_lbl;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label vehicle_number_lbl;
        private System.Windows.Forms.Label vehicle_number_value_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label description_lbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label3;
    }
}