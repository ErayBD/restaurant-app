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
	public partial class FiyatGuncelle : Form {
		public FiyatGuncelle() {
			InitializeComponent();
		}

		private void bt_geriDon_Click(object sender, EventArgs e) {
			MainPageAdmin mainPageAdmin = new MainPageAdmin();
			Visible = false;
			mainPageAdmin.Show();
		}

		private void bt_hamburger_Click(object sender, EventArgs e) {
			SiparisVer siparisVer = new SiparisVer();
			siparisVer.setHamburgerFiyat(int.Parse(lb_hamburger.Text));
			MessageBox.Show("Fiyat Basariyla Guncellendi..!");
		}

		private void bt_kebab_Click(object sender, EventArgs e) {
			SiparisVer siparisVer = new SiparisVer();
			siparisVer.setKebabFiyat(int.Parse(lb_kebab.Text));
			MessageBox.Show("Fiyat Basariyla Guncellendi..!");
		}

		private void bt_pizza_Click(object sender, EventArgs e) {
			SiparisVer siparisVer = new SiparisVer();
			siparisVer.setPizzaFiyat(int.Parse(lb_pizza.Text));
			MessageBox.Show("Fiyat Basariyla Guncellendi..!");
		}

		private void bt_balik_Click(object sender, EventArgs e) {
			SiparisVer siparisVer = new SiparisVer();
			siparisVer.setBalikFiyat(int.Parse(lb_balik.Text));
			MessageBox.Show("Fiyat Basariyla Guncellendi..!");
		}

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}
	}
}
