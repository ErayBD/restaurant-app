namespace LoginPage {
	partial class SiparisBasarili {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.p_left = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lb_mainUserL1 = new System.Windows.Forms.Label();
			this.pb_Arrow = new System.Windows.Forms.PictureBox();
			this.bt_close = new System.Windows.Forms.Button();
			this.lb_mainUser_Title = new System.Windows.Forms.Label();
			this.bt_login = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.p_left.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Arrow)).BeginInit();
			this.SuspendLayout();
			// 
			// p_left
			// 
			this.p_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.p_left.Controls.Add(this.pictureBox1);
			this.p_left.Controls.Add(this.pictureBox2);
			this.p_left.Controls.Add(this.lb_mainUserL1);
			this.p_left.Dock = System.Windows.Forms.DockStyle.Left;
			this.p_left.Location = new System.Drawing.Point(0, 0);
			this.p_left.Name = "p_left";
			this.p_left.Size = new System.Drawing.Size(400, 830);
			this.p_left.TabIndex = 26;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LoginPage.Properties.Resources.order;
			this.pictureBox1.Location = new System.Drawing.Point(105, 482);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(160, 160);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::LoginPage.Properties.Resources._11;
			this.pictureBox2.Location = new System.Drawing.Point(-28, -42);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(480, 434);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// lb_mainUserL1
			// 
			this.lb_mainUserL1.AutoSize = true;
			this.lb_mainUserL1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_mainUserL1.ForeColor = System.Drawing.Color.White;
			this.lb_mainUserL1.Location = new System.Drawing.Point(84, 669);
			this.lb_mainUserL1.Name = "lb_mainUserL1";
			this.lb_mainUserL1.Size = new System.Drawing.Size(201, 34);
			this.lb_mainUserL1.TabIndex = 1;
			this.lb_mainUserL1.Text = "Siparis Basarili";
			// 
			// pb_Arrow
			// 
			this.pb_Arrow.Image = global::LoginPage.Properties.Resources.check;
			this.pb_Arrow.Location = new System.Drawing.Point(605, 163);
			this.pb_Arrow.Name = "pb_Arrow";
			this.pb_Arrow.Size = new System.Drawing.Size(250, 229);
			this.pb_Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_Arrow.TabIndex = 0;
			this.pb_Arrow.TabStop = false;
			// 
			// bt_close
			// 
			this.bt_close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bt_close.FlatAppearance.BorderSize = 0;
			this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_close.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.bt_close.Location = new System.Drawing.Point(990, 0);
			this.bt_close.Name = "bt_close";
			this.bt_close.Size = new System.Drawing.Size(60, 60);
			this.bt_close.TabIndex = 27;
			this.bt_close.Text = "X";
			this.bt_close.UseVisualStyleBackColor = true;
			this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
			// 
			// lb_mainUser_Title
			// 
			this.lb_mainUser_Title.AutoSize = true;
			this.lb_mainUser_Title.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_mainUser_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.lb_mainUser_Title.Location = new System.Drawing.Point(462, 447);
			this.lb_mainUser_Title.Name = "lb_mainUser_Title";
			this.lb_mainUser_Title.Size = new System.Drawing.Size(546, 34);
			this.lb_mainUser_Title.TabIndex = 28;
			this.lb_mainUser_Title.Text = "Bizi tercih ettiginiz icin tesekkur ederiz..!\r\n";
			// 
			// bt_login
			// 
			this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_login.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_login.ForeColor = System.Drawing.Color.White;
			this.bt_login.Location = new System.Drawing.Point(605, 533);
			this.bt_login.Name = "bt_login";
			this.bt_login.Size = new System.Drawing.Size(249, 52);
			this.bt_login.TabIndex = 30;
			this.bt_login.Text = "Ana Sayfa";
			this.bt_login.UseVisualStyleBackColor = false;
			this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(606, 711);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(249, 52);
			this.button1.TabIndex = 31;
			this.button1.Text = "Cikis";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(606, 622);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(249, 52);
			this.button2.TabIndex = 32;
			this.button2.Text = "Oturumu Kapat";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// SiparisBasarili
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1050, 830);
			this.ControlBox = false;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.p_left);
			this.Controls.Add(this.bt_close);
			this.Controls.Add(this.pb_Arrow);
			this.Controls.Add(this.lb_mainUser_Title);
			this.Controls.Add(this.bt_login);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SiparisBasarili";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SiparisBasarili";
			this.p_left.ResumeLayout(false);
			this.p_left.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Arrow)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel p_left;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Label lb_mainUserL1;
		private System.Windows.Forms.PictureBox pb_Arrow;
		private System.Windows.Forms.Button bt_close;
		private System.Windows.Forms.Label lb_mainUser_Title;
		private System.Windows.Forms.Button bt_login;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button2;
	}
}