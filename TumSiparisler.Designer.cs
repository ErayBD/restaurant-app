namespace LoginPage {
	partial class TumSiparisler {
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
			this.bt_geriDon = new System.Windows.Forms.Button();
			this.bt_close = new System.Windows.Forms.Button();
			this.p_left = new System.Windows.Forms.Panel();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.rtb_bilgiler = new System.Windows.Forms.RichTextBox();
			this.bt_bilgileriGetir = new System.Windows.Forms.Button();
			this.lb_mainUserL1 = new System.Windows.Forms.Label();
			this.pb_Arrow = new System.Windows.Forms.PictureBox();
			this.p_left.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Arrow)).BeginInit();
			this.SuspendLayout();
			// 
			// bt_geriDon
			// 
			this.bt_geriDon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.bt_geriDon.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_geriDon.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_geriDon.ForeColor = System.Drawing.Color.White;
			this.bt_geriDon.Location = new System.Drawing.Point(652, 745);
			this.bt_geriDon.Name = "bt_geriDon";
			this.bt_geriDon.Size = new System.Drawing.Size(164, 48);
			this.bt_geriDon.TabIndex = 53;
			this.bt_geriDon.Text = "Geri Don";
			this.bt_geriDon.UseVisualStyleBackColor = false;
			this.bt_geriDon.Click += new System.EventHandler(this.bt_geriDon_Click);
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
			this.bt_close.TabIndex = 40;
			this.bt_close.Text = "X";
			this.bt_close.UseVisualStyleBackColor = true;
			this.bt_close.Click += new System.EventHandler(this.bt_close_Click);
			// 
			// p_left
			// 
			this.p_left.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.p_left.Controls.Add(this.lb_mainUserL1);
			this.p_left.Controls.Add(this.pb_Arrow);
			this.p_left.Controls.Add(this.pictureBox2);
			this.p_left.Dock = System.Windows.Forms.DockStyle.Left;
			this.p_left.Location = new System.Drawing.Point(0, 0);
			this.p_left.Name = "p_left";
			this.p_left.Size = new System.Drawing.Size(400, 830);
			this.p_left.TabIndex = 39;
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
			// rtb_bilgiler
			// 
			this.rtb_bilgiler.BackColor = System.Drawing.SystemColors.HighlightText;
			this.rtb_bilgiler.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.rtb_bilgiler.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rtb_bilgiler.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.rtb_bilgiler.Location = new System.Drawing.Point(421, 82);
			this.rtb_bilgiler.Name = "rtb_bilgiler";
			this.rtb_bilgiler.ReadOnly = true;
			this.rtb_bilgiler.Size = new System.Drawing.Size(604, 537);
			this.rtb_bilgiler.TabIndex = 54;
			this.rtb_bilgiler.Text = "";
			// 
			// bt_bilgileriGetir
			// 
			this.bt_bilgileriGetir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
			this.bt_bilgileriGetir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.bt_bilgileriGetir.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_bilgileriGetir.ForeColor = System.Drawing.Color.White;
			this.bt_bilgileriGetir.Location = new System.Drawing.Point(652, 653);
			this.bt_bilgileriGetir.Name = "bt_bilgileriGetir";
			this.bt_bilgileriGetir.Size = new System.Drawing.Size(164, 48);
			this.bt_bilgileriGetir.TabIndex = 55;
			this.bt_bilgileriGetir.Text = "Bilgileri Getir";
			this.bt_bilgileriGetir.UseVisualStyleBackColor = false;
			this.bt_bilgileriGetir.Click += new System.EventHandler(this.bt_bilgileriGetir_Click);
			// 
			// lb_mainUserL1
			// 
			this.lb_mainUserL1.AutoSize = true;
			this.lb_mainUserL1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_mainUserL1.ForeColor = System.Drawing.Color.White;
			this.lb_mainUserL1.Location = new System.Drawing.Point(57, 685);
			this.lb_mainUserL1.Name = "lb_mainUserL1";
			this.lb_mainUserL1.Size = new System.Drawing.Size(252, 34);
			this.lb_mainUserL1.TabIndex = 4;
			this.lb_mainUserL1.Text = "Bilgileri Goruntule";
			// 
			// pb_Arrow
			// 
			this.pb_Arrow.Image = global::LoginPage.Properties.Resources.order;
			this.pb_Arrow.Location = new System.Drawing.Point(108, 490);
			this.pb_Arrow.Name = "pb_Arrow";
			this.pb_Arrow.Size = new System.Drawing.Size(160, 160);
			this.pb_Arrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pb_Arrow.TabIndex = 3;
			this.pb_Arrow.TabStop = false;
			// 
			// TumSiparisler
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1050, 830);
			this.ControlBox = false;
			this.Controls.Add(this.bt_bilgileriGetir);
			this.Controls.Add(this.rtb_bilgiler);
			this.Controls.Add(this.bt_geriDon);
			this.Controls.Add(this.bt_close);
			this.Controls.Add(this.p_left);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "TumSiparisler";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "TumSiparisler";
			this.p_left.ResumeLayout(false);
			this.p_left.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pb_Arrow)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button bt_geriDon;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button bt_close;
		private System.Windows.Forms.Panel p_left;
		private System.Windows.Forms.RichTextBox rtb_bilgiler;
		private System.Windows.Forms.Button bt_bilgileriGetir;
		private System.Windows.Forms.Label lb_mainUserL1;
		private System.Windows.Forms.PictureBox pb_Arrow;
	}
}