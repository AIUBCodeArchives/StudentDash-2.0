namespace StudentDash_2._0.Forms
{
    partial class home_book_ride
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
            this.book_ride_lbl = new System.Windows.Forms.Label();
            this.search_btn = new Guna.UI2.WinForms.Guna2Button();
            this.search_destination_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.destination_lbl = new System.Windows.Forms.Label();
            this.book_btn = new Guna.UI2.WinForms.Guna2Button();
            this.rider_id_txtbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.rider_id = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logo_pic = new System.Windows.Forms.PictureBox();
            this.clear_all_lbl = new System.Windows.Forms.LinkLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_btn
            // 
            this.exit_btn.BackColor = System.Drawing.Color.Transparent;
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.Image = global::StudentDash_2._0.Properties.Resources.Screenshot_2024_09_26_232413_removebg_preview;
            this.exit_btn.Location = new System.Drawing.Point(957, 0);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(43, 34);
            this.exit_btn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.exit_btn.TabIndex = 21;
            this.exit_btn.TabStop = false;
            // 
            // book_ride_lbl
            // 
            this.book_ride_lbl.AutoSize = true;
            this.book_ride_lbl.BackColor = System.Drawing.Color.Transparent;
            this.book_ride_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_ride_lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(228)))), ((int)(((byte)(213)))));
            this.book_ride_lbl.Location = new System.Drawing.Point(21, 58);
            this.book_ride_lbl.Name = "book_ride_lbl";
            this.book_ride_lbl.Size = new System.Drawing.Size(352, 76);
            this.book_ride_lbl.TabIndex = 16;
            this.book_ride_lbl.Text = "BOOK RIDE";
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
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(550, 158);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(125, 53);
            this.search_btn.TabIndex = 23;
            this.search_btn.Text = "Search";
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            this.search_btn.MouseLeave += new System.EventHandler(this.search_btn_MouseLeave);
            this.search_btn.MouseHover += new System.EventHandler(this.search_btn_MouseHover);
            // 
            // search_destination_txtbox
            // 
            this.search_destination_txtbox.BackColor = System.Drawing.Color.Transparent;
            this.search_destination_txtbox.BorderRadius = 20;
            this.search_destination_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.search_destination_txtbox.DefaultText = "";
            this.search_destination_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.search_destination_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.search_destination_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_destination_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.search_destination_txtbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.search_destination_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_destination_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.search_destination_txtbox.ForeColor = System.Drawing.Color.Black;
            this.search_destination_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.search_destination_txtbox.Location = new System.Drawing.Point(34, 159);
            this.search_destination_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.search_destination_txtbox.Name = "search_destination_txtbox";
            this.search_destination_txtbox.PasswordChar = '\0';
            this.search_destination_txtbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.search_destination_txtbox.PlaceholderText = "Enter your destination";
            this.search_destination_txtbox.SelectedText = "";
            this.search_destination_txtbox.Size = new System.Drawing.Size(474, 52);
            this.search_destination_txtbox.TabIndex = 22;
            // 
            // destination_lbl
            // 
            this.destination_lbl.AutoSize = true;
            this.destination_lbl.BackColor = System.Drawing.Color.Transparent;
            this.destination_lbl.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.destination_lbl.ForeColor = System.Drawing.Color.Black;
            this.destination_lbl.Location = new System.Drawing.Point(47, 130);
            this.destination_lbl.Name = "destination_lbl";
            this.destination_lbl.Size = new System.Drawing.Size(204, 22);
            this.destination_lbl.TabIndex = 21;
            this.destination_lbl.Text = "Search your destination:";
            // 
            // book_btn
            // 
            this.book_btn.BackColor = System.Drawing.Color.Transparent;
            this.book_btn.BorderRadius = 20;
            this.book_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.book_btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.book_btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.book_btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.book_btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.book_btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.book_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_btn.ForeColor = System.Drawing.Color.White;
            this.book_btn.Location = new System.Drawing.Point(550, 245);
            this.book_btn.Name = "book_btn";
            this.book_btn.Size = new System.Drawing.Size(125, 53);
            this.book_btn.TabIndex = 27;
            this.book_btn.Text = "Book";
            this.book_btn.MouseLeave += new System.EventHandler(this.book_btn_MouseLeave);
            this.book_btn.MouseHover += new System.EventHandler(this.book_btn_MouseHover);
            // 
            // rider_id_txtbox
            // 
            this.rider_id_txtbox.BackColor = System.Drawing.Color.Transparent;
            this.rider_id_txtbox.BorderRadius = 20;
            this.rider_id_txtbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.rider_id_txtbox.DefaultText = "";
            this.rider_id_txtbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.rider_id_txtbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.rider_id_txtbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rider_id_txtbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.rider_id_txtbox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.rider_id_txtbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rider_id_txtbox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.rider_id_txtbox.ForeColor = System.Drawing.Color.Black;
            this.rider_id_txtbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.rider_id_txtbox.Location = new System.Drawing.Point(34, 246);
            this.rider_id_txtbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rider_id_txtbox.Name = "rider_id_txtbox";
            this.rider_id_txtbox.PasswordChar = '\0';
            this.rider_id_txtbox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.rider_id_txtbox.PlaceholderText = "Enter rider\'s ID";
            this.rider_id_txtbox.SelectedText = "";
            this.rider_id_txtbox.Size = new System.Drawing.Size(474, 52);
            this.rider_id_txtbox.TabIndex = 26;
            // 
            // rider_id
            // 
            this.rider_id.AutoSize = true;
            this.rider_id.BackColor = System.Drawing.Color.Transparent;
            this.rider_id.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rider_id.ForeColor = System.Drawing.Color.Black;
            this.rider_id.Location = new System.Drawing.Point(47, 217);
            this.rider_id.Name = "rider_id";
            this.rider_id.Size = new System.Drawing.Size(227, 22);
            this.rider_id.TabIndex = 25;
            this.rider_id.Text = "Rider\'s student ID to book:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Image = global::StudentDash_2._0.Properties.Resources.Screenshot_2024_09_26_232413_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(957, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 34);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // logo_pic
            // 
            this.logo_pic.BackColor = System.Drawing.Color.Transparent;
            this.logo_pic.Image = global::StudentDash_2._0.Properties.Resources._2bdf9038_62f0_4d1e_b329_fc4ef2b6ef861_removebg_preview;
            this.logo_pic.Location = new System.Drawing.Point(745, 159);
            this.logo_pic.Name = "logo_pic";
            this.logo_pic.Size = new System.Drawing.Size(216, 139);
            this.logo_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_pic.TabIndex = 30;
            this.logo_pic.TabStop = false;
            // 
            // clear_all_lbl
            // 
            this.clear_all_lbl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(3)))), ((int)(((byte)(3)))));
            this.clear_all_lbl.BackColor = System.Drawing.Color.Transparent;
            this.clear_all_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_all_lbl.LinkColor = System.Drawing.Color.Black;
            this.clear_all_lbl.Location = new System.Drawing.Point(331, 302);
            this.clear_all_lbl.Name = "clear_all_lbl";
            this.clear_all_lbl.Size = new System.Drawing.Size(119, 23);
            this.clear_all_lbl.TabIndex = 31;
            this.clear_all_lbl.TabStop = true;
            this.clear_all_lbl.Text = "Clear All";
            this.clear_all_lbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.clear_all_lbl_LinkClicked);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(34, 342);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(927, 390);
            this.dataGridView1.TabIndex = 32;
            // 
            // home_book_ride
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::StudentDash_2._0.Properties.Resources._8;
            this.ClientSize = new System.Drawing.Size(1000, 800);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.clear_all_lbl);
            this.Controls.Add(this.logo_pic);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.book_btn);
            this.Controls.Add(this.rider_id_txtbox);
            this.Controls.Add(this.rider_id);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.search_destination_txtbox);
            this.Controls.Add(this.exit_btn);
            this.Controls.Add(this.destination_lbl);
            this.Controls.Add(this.book_ride_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "home_book_ride";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "home_book_ride";
            this.Load += new System.EventHandler(this.home_book_ride_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox exit_btn;
        private System.Windows.Forms.Label book_ride_lbl;
        private Guna.UI2.WinForms.Guna2Button search_btn;
        private Guna.UI2.WinForms.Guna2TextBox search_destination_txtbox;
        private System.Windows.Forms.Label destination_lbl;
        private Guna.UI2.WinForms.Guna2Button book_btn;
        private Guna.UI2.WinForms.Guna2TextBox rider_id_txtbox;
        private System.Windows.Forms.Label rider_id;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox logo_pic;
        private System.Windows.Forms.LinkLabel clear_all_lbl;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}