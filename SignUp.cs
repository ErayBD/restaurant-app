using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace LoginPage {
	public partial class SignUp : Form {
		public SignUp() {
			InitializeComponent();
		}

		string name;
		string password;
		string mail;
		string gender;
		public string location;

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}

		private void bt_login_Click(object sender, EventArgs e) {
			
			if (!(tb_id.Text == "") && !(tb_mail.Text == "") && !(tb_pw.Text == "") && ((gender_male.Checked) || (gender_female.Checked))) {
				if (tb_mail.Text.Contains("@") && tb_mail.Text.Contains(".com")) {
					LoginPage lp = new LoginPage();

					MessageBox.Show("Kayit Basarili!\nSimdi Giris Yapabilirsiniz.", "Bilgilendirme");

					Visible = false;

					lp.Show();

					name = tb_id.Text;
					password = tb_pw.Text;
					mail = tb_mail.Text;
					location = tb_location.Text;

					if (gender_male.Checked)
						gender = "Erkek";
					else if (gender_female.Checked) {
						gender = "Kadin";
					}
					WriteExcel.writeExcel(name, password, mail, gender, location);
				}
				else {

					MessageBox.Show("Mail hatali sekilde girildi..!", "Bilgilendirme");
				}
			}
			else {
				MessageBox.Show("Formu dogru doldurunuz..!", "Bilgilendirme");
			}
		}

		private void tb_id_Click(object sender, EventArgs e) {
			tb_id.BackColor = Color.White;
			p_right_id.BackColor = Color.White;
			tb_pw.BackColor = SystemColors.Control;
			p_right_pw.BackColor = SystemColors.Control;
		}

		private void tb_mail_Click(object sender, EventArgs e) {
			tb_id.BackColor = Color.White;
			p_right_id.BackColor = Color.White;
			tb_pw.BackColor = SystemColors.Control;
			p_right_pw.BackColor = SystemColors.Control;
		}

		private void tb_pw_Click(object sender, EventArgs e) {
			tb_pw.BackColor = Color.White;
			p_right_pw.BackColor = Color.White;
			tb_id.BackColor = SystemColors.Control;
			p_right_id.BackColor = SystemColors.Control;
		}

		private void pb_showPw_MouseDown(object sender, MouseEventArgs e) {
			tb_pw.UseSystemPasswordChar = false;
		}

		private void pb_showPw_MouseUp(object sender, MouseEventArgs e) {
			tb_pw.UseSystemPasswordChar = true;
		}

		private void tb_id_Click_1(object sender, EventArgs e) {
			tb_id.BackColor = Color.White;
			p_right_id.BackColor = Color.White;
			//tb_pw.BackColor = SystemColors.Control;
			p_right_pw.BackColor = SystemColors.Control;
			//tb_mail.BackColor = SystemColors.Control;
			p_right_mail.BackColor = SystemColors.Control;
			//tb_location.BackColor = SystemColors.Control;
			p_right_location.BackColor = SystemColors.Control;
		}

		private void tb_mail_Click_1(object sender, EventArgs e) {
			tb_mail.BackColor = Color.White;
			p_right_mail.BackColor = Color.White;
			//tb_id.BackColor = SystemColors.Control;
			p_right_id.BackColor = SystemColors.Control;
			//tb_pw.BackColor= SystemColors.Control;
			p_right_pw.BackColor = SystemColors.Control;
			//tb_location.BackColor = SystemColors.Control;
			p_right_location.BackColor = SystemColors.Control;

		}

		private void tb_pw_Click_1(object sender, EventArgs e) {
			tb_pw.BackColor = Color.White;
			p_right_pw.BackColor = Color.White;
			//tb_id.BackColor = SystemColors.Control;
			p_right_id.BackColor = SystemColors.Control;
			//tb_mail.BackColor = SystemColors.Control;
			p_right_mail.BackColor = SystemColors.Control;
			//tb_location.BackColor = SystemColors.Control;
			p_right_location.BackColor = SystemColors.Control;
			
		}

		private void pb_showPw_MouseUp_2(object sender, MouseEventArgs e) {
			pb_showPw.ImageLocation = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\Resources\\eye-crossed.png";
			tb_pw.UseSystemPasswordChar = true;
		}

		private void pb_showPw_MouseDown_2(object sender, MouseEventArgs e) {
			pb_showPw.ImageLocation = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\Resources\\eye.png";
			tb_pw.UseSystemPasswordChar = false;
		}

		private void tb_location_Click(object sender, EventArgs e) {
			tb_location.BackColor = Color.White;
			p_right_location.BackColor = Color.White;
			//tb_pw.BackColor = SystemColors.Control;
			//tb_id.BackColor = SystemColors.Control;
			//tb_mail.BackColor = SystemColors.Control;
			p_right_pw.BackColor = SystemColors.Control;
			p_right_mail.BackColor = SystemColors.Control;
			p_right_id.BackColor = SystemColors.Control;
		}

		private void button1_Click(object sender, EventArgs e) {
			LoginPage lp = new LoginPage();
			Visible = false;
			lp.Show();
		}
	}
}
