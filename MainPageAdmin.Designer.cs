namespace LoginPage {
	partial class MainPageAdmin {
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
			this.pb_Arrow = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.lb_ArrowT1 = new System.Windows.Forms.Label();
			this.bt_close = new System.Windows.Forms.Button();
			this.bt_login = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.lb_UserName = new System.Windows.Forms.Label();
			this.p_left.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Arrow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			this.SuspendLayout();
			// 
			// p_left
			// 
			this.p_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.p_left.Controls.Add(this.pb_Arrow);
			this.p_left.Controls.Add(this.pictureBox2);
			this.p_left.Controls.Add(this.lb_ArrowT1);
			this.p_left.Dock = System.Windows.Forms.DockStyle.Left;
			this.p_left.Location = new System.Drawing.Point(0, 0);
			this.p_left.Name = "p_left";
			this.p_left.Size = new System.Drawing.Size(400, 830);
			this.p_left.TabIndex = 7;
			// 
			// pb_Arrow
			// 
			this.pb_Arrow.Image = global::LoginPage.Properties.Resources.admin;
			this.pb_Arrow.Location = new System.Drawing.Point(132, 440);
			this.pb_Arrow.Name = "pb_Arrow";
			this.pb_Arrow.Size = new System.Drawing.Size(160, 160);
			this.pb_Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_Arrow.TabIndex = 3;
			this.pb_Arrow.TabStop = false;
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
			// lb_ArrowT1
			// 
			this.lb_ArrowT1.AutoSize = true;
			this.lb_ArrowT1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ArrowT1.ForeColor = System.Drawing.Color.White;
			this.lb_ArrowT1.Location = new System.Drawing.Point(116, 640);
			this.lb_ArrowT1.Name = "lb_ArrowT1";
			this.lb_ArrowT1.Size = new System.Drawing.Size(193, 34);
			this.lb_ArrowT1.TabIndex = 1;
			this.lb_ArrowT1.Text = "Admin Ekrani";
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
			this.bt_close.TabIndex = 8;
			this.bt_close.Text = "X";
			this.bt_close.UseVisualStyleBackColor = true;
			this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
			// 
			// bt_login
			// 
			this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_login.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_login.ForeColor = System.Drawing.Color.White;
			this.bt_login.Location = new System.Drawing.Point(613, 322);
			this.bt_login.Name = "bt_login";
			this.bt_login.Size = new System.Drawing.Size(260, 70);
			this.bt_login.TabIndex = 21;
			this.bt_login.Text = "Urun Fiyatlarini Guncelle";
			this.bt_login.UseVisualStyleBackColor = false;
			this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(613, 472);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(260, 70);
			this.button1.TabIndex = 22;
			this.button1.Text = "Tum Siparisleri Goruntule";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button2.ForeColor = System.Drawing.Color.White;
			this.button2.Location = new System.Drawing.Point(613, 622);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(260, 70);
			this.button2.TabIndex = 23;
			this.button2.Text = "Oturumu Kapat";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.label1.Location = new System.Drawing.Point(607, 178);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(169, 34);
			this.label1.TabIndex = 25;
			this.label1.Text = "Hos Geldin,";
			// 
			// lb_UserName
			// 
			this.lb_UserName.AutoSize = true;
			this.lb_UserName.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_UserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.lb_UserName.Location = new System.Drawing.Point(782, 178);
			this.lb_UserName.Name = "lb_UserName";
			this.lb_UserName.Size = new System.Drawing.Size(103, 34);
			this.lb_UserName.TabIndex = 24;
			this.lb_UserName.Text = "admin";
			// 
			// MainPageAdmin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.bt_close;
			this.ClientSize = new System.Drawing.Size(1050, 830);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lb_UserName);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.bt_login);
			this.Controls.Add(this.p_left);
			this.Controls.Add(this.bt_close);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "MainPageAdmin";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "MainPageAdmin";
			this.p_left.ResumeLayout(false);
			this.p_left.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Arrow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel p_left;
		private System.Windows.Forms.Label lb_ArrowT1;
		private System.Windows.Forms.Button bt_close;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button bt_login;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lb_UserName;
		private System.Windows.Forms.PictureBox pb_Arrow;
	}
}