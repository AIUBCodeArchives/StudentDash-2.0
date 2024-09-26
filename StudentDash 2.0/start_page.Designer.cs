namespace StudentDash_2._0
{
    partial class start_page
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
            this.components = new System.ComponentModel.Container();
            this.load_progress_bar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.progress_bar_timer = new System.Windows.Forms.Timer(this.components);
            this.progress_percentage_lbl = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // load_progress_bar
            // 
            this.load_progress_bar.BackColor = System.Drawing.Color.Transparent;
            this.load_progress_bar.BorderRadius = 18;
            this.load_progress_bar.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.load_progress_bar.Location = new System.Drawing.Point(100, 714);
            this.load_progress_bar.Name = "load_progress_bar";
            this.load_progress_bar.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(197)))), ((int)(((byte)(106)))));
            this.load_progress_bar.ProgressColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(197)))), ((int)(((byte)(106)))));
            this.load_progress_bar.Size = new System.Drawing.Size(1100, 40);
            this.load_progress_bar.TabIndex = 0;
            this.load_progress_bar.Text = "load_progress_bar";
            this.load_progress_bar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // progress_bar_timer
            // 
            this.progress_bar_timer.Tick += new System.EventHandler(this.progress_bar_timer_Tick);
            // 
            // progress_percentage_lbl
            // 
            this.progress_percentage_lbl.BackColor = System.Drawing.Color.Transparent;
            this.progress_percentage_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.progress_percentage_lbl.ForeColor = System.Drawing.Color.Black;
            this.progress_percentage_lbl.Location = new System.Drawing.Point(1066, 681);
            this.progress_percentage_lbl.Name = "progress_percentage_lbl";
            this.progress_percentage_lbl.Size = new System.Drawing.Size(44, 27);
            this.progress_percentage_lbl.TabIndex = 1;
            this.progress_percentage_lbl.Text = "load";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::StudentDash_2._0.Properties.Resources.icons8_car_unscreen;
            this.pictureBox1.Location = new System.Drawing.Point(1116, 659);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(72, 68);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // start_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::StudentDash_2._0.Properties.Resources.Student_Dash_2_O_1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.progress_percentage_lbl);
            this.Controls.Add(this.load_progress_bar);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "start_page";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "start_page";
            this.Load += new System.EventHandler(this.start_page_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ProgressBar load_progress_bar;
        private System.Windows.Forms.Timer progress_bar_timer;
        private Guna.UI2.WinForms.Guna2HtmlLabel progress_percentage_lbl;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}