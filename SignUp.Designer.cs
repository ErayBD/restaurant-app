namespace LoginPage {
	partial class SignUp {
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
			this.tb_id = new System.Windows.Forms.TextBox();
			this.bt_login = new System.Windows.Forms.Button();
			this.tb_pw = new System.Windows.Forms.TextBox();
			this.p_right_pw = new System.Windows.Forms.Panel();
			this.pb_showPw = new System.Windows.Forms.PictureBox();
			this.pb_pw = new System.Windows.Forms.PictureBox();
			this.p_right_id = new System.Windows.Forms.Panel();
			this.pb_id = new System.Windows.Forms.PictureBox();
			this.p_right = new System.Windows.Forms.Panel();
			this.p_right_location = new System.Windows.Forms.Panel();
			this.tb_location = new System.Windows.Forms.RichTextBox();
			this.pb_location = new System.Windows.Forms.PictureBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.gender_female = new System.Windows.Forms.RadioButton();
			this.gender_male = new System.Windows.Forms.RadioButton();
			this.p_right_mail = new System.Windows.Forms.Panel();
			this.tb_mail = new System.Windows.Forms.TextBox();
			this.pb_mail = new System.Windows.Forms.PictureBox();
			this.bt_close = new System.Windows.Forms.Button();
			this.lb_singIn = new System.Windows.Forms.Label();
			this.lb_ArrowT1 = new System.Windows.Forms.Label();
			this.p_left = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pb_Arrow = new System.Windows.Forms.PictureBox();
			this.button1 = new System.Windows.Forms.Button();
			this.p_right_pw.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_showPw)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_pw)).BeginInit();
			this.p_right_id.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_id)).BeginInit();
			this.p_right.SuspendLayout();
			this.p_right_location.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_location)).BeginInit();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.p_right_mail.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_mail)).BeginInit();
			this.p_left.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Arrow)).BeginInit();
			this.SuspendLayout();
			// 
			// tb_id
			// 
			this.tb_id.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_id.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_id.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.tb_id.Location = new System.Drawing.Point(83, 22);
			this.tb_id.Name = "tb_id";
			this.tb_id.Size = new System.Drawing.Size(500, 25);
			this.tb_id.TabIndex = 1;
			this.tb_id.Click += new System.EventHandler(this.tb_id_Click_1);
			// 
			// bt_login
			// 
			this.bt_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.bt_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_login.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_login.ForeColor = System.Drawing.Color.White;
			this.bt_login.Location = new System.Drawing.Point(188, 664);
			this.bt_login.Name = "bt_login";
			this.bt_login.Size = new System.Drawing.Size(249, 52);
			this.bt_login.TabIndex = 6;
			this.bt_login.Text = "Kayit Ol";
			this.bt_login.UseVisualStyleBackColor = false;
			this.bt_login.Click += new System.EventHandler(this.bt_login_Click);
			// 
			// tb_pw
			// 
			this.tb_pw.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_pw.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_pw.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.tb_pw.Location = new System.Drawing.Point(83, 25);
			this.tb_pw.Name = "tb_pw";
			this.tb_pw.Size = new System.Drawing.Size(500, 25);
			this.tb_pw.TabIndex = 3;
			this.tb_pw.UseSystemPasswordChar = true;
			this.tb_pw.Click += new System.EventHandler(this.tb_pw_Click_1);
			// 
			// p_right_pw
			// 
			this.p_right_pw.BackColor = System.Drawing.SystemColors.Control;
			this.p_right_pw.Controls.Add(this.tb_pw);
			this.p_right_pw.Controls.Add(this.pb_showPw);
			this.p_right_pw.Controls.Add(this.pb_pw);
			this.p_right_pw.Location = new System.Drawing.Point(0, 379);
			this.p_right_pw.Name = "p_right_pw";
			this.p_right_pw.Size = new System.Drawing.Size(650, 72);
			this.p_right_pw.TabIndex = 3;
			// 
			// pb_showPw
			// 
			this.pb_showPw.Image = global::LoginPage.Properties.Resources.eye_crossed;
			this.pb_showPw.Location = new System.Drawing.Point(594, 17);
			this.pb_showPw.Name = "pb_showPw";
			this.pb_showPw.Size = new System.Drawing.Size(40, 38);
			this.pb_showPw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_showPw.TabIndex = 0;
			this.pb_showPw.TabStop = false;
			this.pb_showPw.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pb_showPw_MouseDown_2);
			this.pb_showPw.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pb_showPw_MouseUp_2);
			// 
			// pb_pw
			// 
			this.pb_pw.Image = global::LoginPage.Properties.Resources._lock;
			this.pb_pw.Location = new System.Drawing.Point(13, 12);
			this.pb_pw.Name = "pb_pw";
			this.pb_pw.Size = new System.Drawing.Size(53, 50);
			this.pb_pw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_pw.TabIndex = 0;
			this.pb_pw.TabStop = false;
			// 
			// p_right_id
			// 
			this.p_right_id.BackColor = System.Drawing.SystemColors.Control;
			this.p_right_id.Controls.Add(this.tb_id);
			this.p_right_id.Controls.Add(this.pb_id);
			this.p_right_id.Location = new System.Drawing.Point(0, 198);
			this.p_right_id.Name = "p_right_id";
			this.p_right_id.Size = new System.Drawing.Size(650, 72);
			this.p_right_id.TabIndex = 1;
			// 
			// pb_id
			// 
			this.pb_id.Image = global::LoginPage.Properties.Resources.user;
			this.pb_id.Location = new System.Drawing.Point(13, 11);
			this.pb_id.Name = "pb_id";
			this.pb_id.Size = new System.Drawing.Size(53, 50);
			this.pb_id.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_id.TabIndex = 0;
			this.pb_id.TabStop = false;
			// 
			// p_right
			// 
			this.p_right.Controls.Add(this.button1);
			this.p_right.Controls.Add(this.p_right_location);
			this.p_right.Controls.Add(this.panel2);
			this.p_right.Controls.Add(this.bt_login);
			this.p_right.Controls.Add(this.p_right_pw);
			this.p_right.Controls.Add(this.p_right_mail);
			this.p_right.Controls.Add(this.p_right_id);
			this.p_right.Controls.Add(this.bt_close);
			this.p_right.Controls.Add(this.lb_singIn);
			this.p_right.Dock = System.Windows.Forms.DockStyle.Fill;
			this.p_right.Location = new System.Drawing.Point(400, 0);
			this.p_right.Name = "p_right";
			this.p_right.Size = new System.Drawing.Size(650, 830);
			this.p_right.TabIndex = 3;
			// 
			// p_right_location
			// 
			this.p_right_location.BackColor = System.Drawing.SystemColors.Control;
			this.p_right_location.Controls.Add(this.tb_location);
			this.p_right_location.Controls.Add(this.pb_location);
			this.p_right_location.Location = new System.Drawing.Point(0, 477);
			this.p_right_location.Name = "p_right_location";
			this.p_right_location.Size = new System.Drawing.Size(650, 72);
			this.p_right_location.TabIndex = 8;
			// 
			// tb_location
			// 
			this.tb_location.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_location.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_location.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.tb_location.Location = new System.Drawing.Point(83, 18);
			this.tb_location.Name = "tb_location";
			this.tb_location.Size = new System.Drawing.Size(500, 38);
			this.tb_location.TabIndex = 4;
			this.tb_location.Text = "";
			this.tb_location.Click += new System.EventHandler(this.tb_location_Click);
			// 
			// pb_location
			// 
			this.pb_location.Image = global::LoginPage.Properties.Resources.home;
			this.pb_location.Location = new System.Drawing.Point(13, 12);
			this.pb_location.Name = "pb_location";
			this.pb_location.Size = new System.Drawing.Size(53, 50);
			this.pb_location.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_location.TabIndex = 0;
			this.pb_location.TabStop = false;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.Control;
			this.panel2.Controls.Add(this.pictureBox1);
			this.panel2.Controls.Add(this.gender_female);
			this.panel2.Controls.Add(this.gender_male);
			this.panel2.Location = new System.Drawing.Point(0, 570);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(650, 72);
			this.panel2.TabIndex = 6;
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = global::LoginPage.Properties.Resources.venus_mars__1_;
			this.pictureBox1.Location = new System.Drawing.Point(13, 11);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(53, 50);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// gender_female
			// 
			this.gender_female.AutoSize = true;
			this.gender_female.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gender_female.Location = new System.Drawing.Point(387, 23);
			this.gender_female.Name = "gender_female";
			this.gender_female.Size = new System.Drawing.Size(78, 25);
			this.gender_female.TabIndex = 5;
			this.gender_female.TabStop = true;
			this.gender_female.Text = "Kadın";
			this.gender_female.UseVisualStyleBackColor = true;
			// 
			// gender_male
			// 
			this.gender_male.AutoSize = true;
			this.gender_male.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gender_male.Location = new System.Drawing.Point(188, 23);
			this.gender_male.Name = "gender_male";
			this.gender_male.Size = new System.Drawing.Size(74, 25);
			this.gender_male.TabIndex = 4;
			this.gender_male.TabStop = true;
			this.gender_male.Text = "Erkek";
			this.gender_male.UseVisualStyleBackColor = true;
			// 
			// p_right_mail
			// 
			this.p_right_mail.BackColor = System.Drawing.SystemColors.Control;
			this.p_right_mail.Controls.Add(this.tb_mail);
			this.p_right_mail.Controls.Add(this.pb_mail);
			this.p_right_mail.Location = new System.Drawing.Point(0, 286);
			this.p_right_mail.Name = "p_right_mail";
			this.p_right_mail.Size = new System.Drawing.Size(650, 72);
			this.p_right_mail.TabIndex = 2;
			// 
			// tb_mail
			// 
			this.tb_mail.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.tb_mail.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tb_mail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.tb_mail.Location = new System.Drawing.Point(83, 22);
			this.tb_mail.Name = "tb_mail";
			this.tb_mail.Size = new System.Drawing.Size(500, 25);
			this.tb_mail.TabIndex = 2;
			this.tb_mail.Click += new System.EventHandler(this.tb_mail_Click_1);
			// 
			// pb_mail
			// 
			this.pb_mail.Image = global::LoginPage.Properties.Resources.envelope__1_;
			this.pb_mail.Location = new System.Drawing.Point(13, 11);
			this.pb_mail.Name = "pb_mail";
			this.pb_mail.Size = new System.Drawing.Size(53, 50);
			this.pb_mail.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_mail.TabIndex = 0;
			this.pb_mail.TabStop = false;
			// 
			// bt_close
			// 
			this.bt_close.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_close.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.bt_close.FlatAppearance.BorderSize = 0;
			this.bt_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_close.Font = new System.Drawing.Font("Verdana", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_close.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.bt_close.Location = new System.Drawing.Point(589, 1);
			this.bt_close.Name = "bt_close";
			this.bt_close.Size = new System.Drawing.Size(60, 60);
			this.bt_close.TabIndex = 7;
			this.bt_close.Text = "X";
			this.bt_close.UseVisualStyleBackColor = true;
			this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
			// 
			// lb_singIn
			// 
			this.lb_singIn.AutoSize = true;
			this.lb_singIn.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_singIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.lb_singIn.Location = new System.Drawing.Point(241, 130);
			this.lb_singIn.Name = "lb_singIn";
			this.lb_singIn.Size = new System.Drawing.Size(155, 34);
			this.lb_singIn.TabIndex = 1;
			this.lb_singIn.Text = "Kayit Olun";
			// 
			// lb_ArrowT1
			// 
			this.lb_ArrowT1.AutoSize = true;
			this.lb_ArrowT1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ArrowT1.ForeColor = System.Drawing.Color.White;
			this.lb_ArrowT1.Location = new System.Drawing.Point(108, 664);
			this.lb_ArrowT1.Name = "lb_ArrowT1";
			this.lb_ArrowT1.Size = new System.Drawing.Size(171, 34);
			this.lb_ArrowT1.TabIndex = 1;
			this.lb_ArrowT1.Text = "Kayit Ekrani";
			// 
			// p_left
			// 
			this.p_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.p_left.Controls.Add(this.pictureBox2);
			this.p_left.Controls.Add(this.lb_ArrowT1);
			this.p_left.Controls.Add(this.pb_Arrow);
			this.p_left.Dock = System.Windows.Forms.DockStyle.Left;
			this.p_left.Location = new System.Drawing.Point(0, 0);
			this.p_left.Name = "p_left";
			this.p_left.Size = new System.Drawing.Size(400, 830);
			this.p_left.TabIndex = 2;
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
			// pb_Arrow
			// 
			this.pb_Arrow.Image = global::LoginPage.Properties.Resources.edit;
			this.pb_Arrow.Location = new System.Drawing.Point(114, 462);
			this.pb_Arrow.Name = "pb_Arrow";
			this.pb_Arrow.Size = new System.Drawing.Size(160, 160);
			this.pb_Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_Arrow.TabIndex = 0;
			this.pb_Arrow.TabStop = false;
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(188, 739);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(249, 52);
			this.button1.TabIndex = 9;
			this.button1.Text = "Geri Don";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// SignUp
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.bt_close;
			this.ClientSize = new System.Drawing.Size(1050, 830);
			this.ControlBox = false;
			this.Controls.Add(this.p_right);
			this.Controls.Add(this.p_left);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "SignUp";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Form2";
			this.p_right_pw.ResumeLayout(false);
			this.p_right_pw.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_showPw)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_pw)).EndInit();
			this.p_right_id.ResumeLayout(false);
			this.p_right_id.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_id)).EndInit();
			this.p_right.ResumeLayout(false);
			this.p_right.PerformLayout();
			this.p_right_location.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pb_location)).EndInit();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.p_right_mail.ResumeLayout(false);
			this.p_right_mail.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_mail)).EndInit();
			this.p_left.ResumeLayout(false);
			this.p_left.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Arrow)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.PictureBox pb_Arrow;
		private System.Windows.Forms.PictureBox pb_showPw;
		private System.Windows.Forms.PictureBox pb_pw;
		private System.Windows.Forms.TextBox tb_id;
		private System.Windows.Forms.Button bt_login;
		private System.Windows.Forms.TextBox tb_pw;
		private System.Windows.Forms.Panel p_right_pw;
		private System.Windows.Forms.Panel p_right_id;
		private System.Windows.Forms.PictureBox pb_id;
		private System.Windows.Forms.Panel p_right;
		private System.Windows.Forms.Button bt_close;
		private System.Windows.Forms.Label lb_singIn;
		private System.Windows.Forms.Label lb_ArrowT1;
		private System.Windows.Forms.Panel p_left;
		private System.Windows.Forms.Panel p_right_mail;
		private System.Windows.Forms.TextBox tb_mail;
		private System.Windows.Forms.PictureBox pb_mail;
		private System.Windows.Forms.RadioButton gender_female;
		private System.Windows.Forms.RadioButton gender_male;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Panel p_right_location;
		private System.Windows.Forms.RichTextBox tb_location;
		private System.Windows.Forms.PictureBox pb_location;
		private System.Windows.Forms.Button button1;
	}
}