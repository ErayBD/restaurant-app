namespace LoginPage {
	partial class Welcome {
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
			this.bt_close = new System.Windows.Forms.Button();
			this.p_left = new System.Windows.Forms.Panel();
			this.lb_WelcomeL3 = new System.Windows.Forms.Label();
			this.lb_WelcomeL2 = new System.Windows.Forms.Label();
			this.lb_WelcomeL1 = new System.Windows.Forms.Label();
			this.pb_Arrow = new System.Windows.Forms.PictureBox();
			this.lb_mainUser_Title = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.pb_exitUser = new System.Windows.Forms.PictureBox();
			this.pb_welcomeUser = new System.Windows.Forms.PictureBox();
			this.p_left.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Arrow)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_exitUser)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_welcomeUser)).BeginInit();
			this.SuspendLayout();
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
			// p_left
			// 
			this.p_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.p_left.Controls.Add(this.lb_WelcomeL3);
			this.p_left.Controls.Add(this.lb_WelcomeL2);
			this.p_left.Controls.Add(this.lb_WelcomeL1);
			this.p_left.Controls.Add(this.pb_Arrow);
			this.p_left.Dock = System.Windows.Forms.DockStyle.Left;
			this.p_left.Location = new System.Drawing.Point(0, 0);
			this.p_left.Name = "p_left";
			this.p_left.Size = new System.Drawing.Size(400, 830);
			this.p_left.TabIndex = 7;
			// 
			// lb_WelcomeL3
			// 
			this.lb_WelcomeL3.AutoSize = true;
			this.lb_WelcomeL3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_WelcomeL3.ForeColor = System.Drawing.Color.White;
			this.lb_WelcomeL3.Location = new System.Drawing.Point(44, 640);
			this.lb_WelcomeL3.Name = "lb_WelcomeL3";
			this.lb_WelcomeL3.Size = new System.Drawing.Size(314, 34);
			this.lb_WelcomeL3.TabIndex = 2;
			this.lb_WelcomeL3.Text = "Lutfen Bir Islem Seciniz\r\n";
			// 
			// lb_WelcomeL2
			// 
			this.lb_WelcomeL2.AutoSize = true;
			this.lb_WelcomeL2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_WelcomeL2.ForeColor = System.Drawing.Color.White;
			this.lb_WelcomeL2.Location = new System.Drawing.Point(103, 490);
			this.lb_WelcomeL2.Name = "lb_WelcomeL2";
			this.lb_WelcomeL2.Size = new System.Drawing.Size(212, 34);
			this.lb_WelcomeL2.TabIndex = 1;
			this.lb_WelcomeL2.Text = " Hos Geldiniz..!";
			// 
			// lb_WelcomeL1
			// 
			this.lb_WelcomeL1.AutoSize = true;
			this.lb_WelcomeL1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_WelcomeL1.ForeColor = System.Drawing.Color.White;
			this.lb_WelcomeL1.Location = new System.Drawing.Point(44, 446);
			this.lb_WelcomeL1.Name = "lb_WelcomeL1";
			this.lb_WelcomeL1.Size = new System.Drawing.Size(331, 34);
			this.lb_WelcomeL1.TabIndex = 1;
			this.lb_WelcomeL1.Text = "ErayBD\'nin Kebaplarına";
			// 
			// pb_Arrow
			// 
			this.pb_Arrow.Image = global::LoginPage.Properties.Resources._11;
			this.pb_Arrow.Location = new System.Drawing.Point(-28, -42);
			this.pb_Arrow.Name = "pb_Arrow";
			this.pb_Arrow.Size = new System.Drawing.Size(480, 434);
			this.pb_Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_Arrow.TabIndex = 0;
			this.pb_Arrow.TabStop = false;
			// 
			// lb_mainUser_Title
			// 
			this.lb_mainUser_Title.AutoSize = true;
			this.lb_mainUser_Title.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_mainUser_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.lb_mainUser_Title.Location = new System.Drawing.Point(538, 236);
			this.lb_mainUser_Title.Name = "lb_mainUser_Title";
			this.lb_mainUser_Title.Size = new System.Drawing.Size(144, 37);
			this.lb_mainUser_Title.TabIndex = 19;
			this.lb_mainUser_Title.Text = "Giris Yap";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.label1.Location = new System.Drawing.Point(812, 236);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(148, 37);
			this.label1.TabIndex = 21;
			this.label1.Text = "Cikis Yap";
			// 
			// pb_exitUser
			// 
			this.pb_exitUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb_exitUser.Image = global::LoginPage.Properties.Resources.sign_out;
			this.pb_exitUser.Location = new System.Drawing.Point(770, 330);
			this.pb_exitUser.Name = "pb_exitUser";
			this.pb_exitUser.Size = new System.Drawing.Size(190, 190);
			this.pb_exitUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_exitUser.TabIndex = 20;
			this.pb_exitUser.TabStop = false;
			this.pb_exitUser.Click += new System.EventHandler(this.pb_exitUser_Click);
			this.pb_exitUser.MouseLeave += new System.EventHandler(this.pb_exitUser_MouseLeave);
			this.pb_exitUser.MouseHover += new System.EventHandler(this.pb_exitUser_MouseHover);
			// 
			// pb_welcomeUser
			// 
			this.pb_welcomeUser.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pb_welcomeUser.Image = global::LoginPage.Properties.Resources.sign_in;
			this.pb_welcomeUser.Location = new System.Drawing.Point(520, 330);
			this.pb_welcomeUser.Name = "pb_welcomeUser";
			this.pb_welcomeUser.Size = new System.Drawing.Size(190, 190);
			this.pb_welcomeUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_welcomeUser.TabIndex = 9;
			this.pb_welcomeUser.TabStop = false;
			this.pb_welcomeUser.Click += new System.EventHandler(this.pb_welcomeUser_Click);
			this.pb_welcomeUser.MouseLeave += new System.EventHandler(this.pb_welcomeUser_MouseLeave);
			this.pb_welcomeUser.MouseHover += new System.EventHandler(this.pb_welcomeUser_MouseHover);
			// 
			// Welcome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.bt_close;
			this.ClientSize = new System.Drawing.Size(1050, 830);
			this.ControlBox = false;
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pb_exitUser);
			this.Controls.Add(this.lb_mainUser_Title);
			this.Controls.Add(this.pb_welcomeUser);
			this.Controls.Add(this.bt_close);
			this.Controls.Add(this.p_left);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Welcome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Welcome";
			this.p_left.ResumeLayout(false);
			this.p_left.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pb_Arrow)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_exitUser)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_welcomeUser)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bt_close;
		private System.Windows.Forms.Panel p_left;
		private System.Windows.Forms.Label lb_WelcomeL2;
		private System.Windows.Forms.Label lb_WelcomeL1;
		private System.Windows.Forms.PictureBox pb_Arrow;
		private System.Windows.Forms.Label lb_WelcomeL3;
		private System.Windows.Forms.PictureBox pb_welcomeUser;
		private System.Windows.Forms.Label lb_mainUser_Title;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pb_exitUser;
	}
}