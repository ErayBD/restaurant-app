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
	public partial class MainPage : Form {

		

		public MainPage() {
			InitializeComponent();
		}

		public void setUserName(String text) {
			lb_UserName.Text = text;
		}
		

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e) {
			Visible = false;
			SiparisVer siparisVer = new SiparisVer();
			siparisVer.setUserName(lb_UserName.Text);
			siparisVer.Show();
		}

		private void button2_Click(object sender, EventArgs e) {
			Visible = false;
			SiparisSorgula siparisSorgula = new SiparisSorgula();
			siparisSorgula.Show();
		}

		private void button3_Click(object sender, EventArgs e) {
			LoginPage lp = new LoginPage();
			Visible = false;
			lp.Show();
		}
	}
}
