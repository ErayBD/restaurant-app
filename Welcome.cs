using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginPage {
	public partial class Welcome : Form {
		public Welcome() {
			InitializeComponent();
			
		}

		public Boolean userTypeAdmin = false;

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}

		private void pb_welcomeUser_Click(object sender, EventArgs e) {
			LoginPage loginPage = new LoginPage();
			userTypeAdmin = false;
			Visible = false;
			loginPage.Show();
		}

		private void pb_welcomeUser_MouseHover(object sender, EventArgs e) {
			pb_welcomeUser.Size = new System.Drawing.Size(220, 220);
			pb_welcomeUser.Location = new System.Drawing.Point(495, 330);
			pb_welcomeUser.ImageLocation = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\Resources\\sign-inneww.png";
		}

		private void pb_welcomeUser_MouseLeave(object sender, EventArgs e) {
			pb_welcomeUser.Size = new System.Drawing.Size(190, 190);
			pb_welcomeUser.Location = new System.Drawing.Point(520, 330);
			pb_welcomeUser.ImageLocation = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\Resources\\sign-in.png";
		}

		private void pb_exitUser_Click(object sender, EventArgs e) {
			MessageBox.Show("Yine Bekleriz..!", "Hosca kalin!");
			System.Windows.Forms.Application.Exit();
		}

		private void pb_exitUser_MouseHover(object sender, EventArgs e) {
			pb_exitUser.Size = new System.Drawing.Size(220, 220);
			pb_exitUser.Location = new System.Drawing.Point(795, 330);
			pb_exitUser.ImageLocation = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\Resources\\sign-outnew.png";
		}

		private void pb_exitUser_MouseLeave(object sender, EventArgs e) {
			pb_exitUser.Size = new System.Drawing.Size(190, 190);
			pb_exitUser.Location = new System.Drawing.Point(770, 330);
			pb_exitUser.ImageLocation = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\Resources\\sign-out.png";
		}

	}
}
