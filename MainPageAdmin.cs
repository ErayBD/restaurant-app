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
	public partial class MainPageAdmin : Form {
		public MainPageAdmin() {
			InitializeComponent();
		}

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}

		private void button2_Click(object sender, EventArgs e) {
			LoginPage loginPage = new LoginPage();
			Visible = false;
			loginPage.Show();
		}

		private void bt_login_Click(object sender, EventArgs e) {
			FiyatGuncelle fiyatGuncelle = new FiyatGuncelle();
			Visible = false;
			fiyatGuncelle.Show();
		}

		private void button1_Click(object sender, EventArgs e) {
			TumSiparisler tumSiparisler = new TumSiparisler();
			Visible = false;
			tumSiparisler.Show();
		}
	}
}
