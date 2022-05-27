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
	public partial class SiparisVerFinal : Form {
		public SiparisVerFinal() {
			InitializeComponent();
		}

		public void setAd(string input) {
			tb_ad.Text = input;
		}

		public void setKebab(string input) {
			tb_kebab.Text = input;
		}

		public void setHamburger(string input) {
			tb_hamburger.Text = input;
		}

		public void setPizza(string input) {
			tb_pizza.Text = input;
		}

		public void setBalik(string input) {
			tb_balik.Text = input;
		}

		public void setToplamFiyat(string input) {
			tb_toplamFiyat.Text = input;
		}

		public void setAdres(string input) {
			tb_Adres.Text = input;
		}

		private void bt_geriDon_Click(object sender, EventArgs e) {
			SiparisVer siparisVer = new SiparisVer();
			Visible = false;
			siparisVer.Show();
		}

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}

		private void bt_siparisVer_Click(object sender, EventArgs e) {
			DialogResult dialogResult = MessageBox.Show(tb_toplamFiyat.Text + " TL odenecektir, onayliyor musunuz?", "Bilgilendirme", MessageBoxButtons.YesNo);

			if (dialogResult == DialogResult.Yes) {
				MessageBox.Show("Siparisiniz bize basariyla ulasti..!", "Bilgilendirme");
				WriteExcel.writeOrder(tb_ad.Text, tb_hamburger.Text, tb_kebab.Text, tb_pizza.Text, tb_balik.Text, tb_toplamFiyat.Text);
				Visible = false;
				SiparisBasarili siparisBasarili = new SiparisBasarili();
				siparisBasarili.Show();
			} 
			else if (dialogResult == DialogResult.No) {
				MessageBox.Show("Siparis iptal edildi..!", "Bilgilendirme");
			}	




		}
	}
}
