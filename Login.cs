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
	public partial class LoginPage : Form {
		public LoginPage() {
			InitializeComponent();
		}

		public string name;
		public string password;

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}

		private void tb_id_Click(object sender, EventArgs e) {
			tb_id.BackColor = Color.White;
			tb_pw.BackColor = SystemColors.Control;
			p_right_id.BackColor = Color.White;
			p_right_pw.BackColor = SystemColors.Control;
		}

		private void tb_pw_Click(object sender, EventArgs e) {
			tb_pw.BackColor = Color.White;
			tb_id.BackColor = SystemColors.Control;
			p_right_pw.BackColor = Color.White;
			p_right_id.BackColor = SystemColors.Control;
		}

		private void pb_showPw_MouseDown(object sender, MouseEventArgs e) {
			pb_showPw.ImageLocation = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\Resources\\eye.png";
			tb_pw.UseSystemPasswordChar = false;
		}

		private void pb_showPw_MouseUp(object sender, MouseEventArgs e) {
			pb_showPw.ImageLocation = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\Resources\\eye-crossed.png";
			tb_pw.UseSystemPasswordChar = true;
		}

		private void bt_fpw_Click(object sender, EventArgs e) {
			Forgot f = new Forgot();
			Visible = false;
			f.Show();
		}



		private void bt_login_Click(object sender, EventArgs e) {

			ReadExcel excel = new ReadExcel();

			if (!(tb_id.Text == "") && (!(tb_pw.Text == ""))) {

				name = tb_id.Text;
				password = tb_pw.Text;

				if (excel.readExcel(name, password)) {
					MainPageAdmin mpAdmin = new MainPageAdmin();
					MainPage mpUser = new MainPage();

					mpUser.setUserName(name);

					MessageBox.Show("Giris Basarili..!", "Bilgilendirme");
					Visible = false;

					if (excel.adminLogin) {
						mpAdmin.Show();
					}
					else {
						mpUser.Show();
					}
				}
					else {
					MessageBox.Show("Hatali Giris..!", "Bilgilendirme");
				}

			}
		}



		private void button1_Click(object sender, EventArgs e) {
			SignUp su = new SignUp();
			Visible = false;
			su.Show();
		}
	}
}
