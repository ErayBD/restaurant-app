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
	public partial class SiparisVer : Form {
		public SiparisVer() {
			InitializeComponent();
			int toplamDynamic = int.Parse(lbl_siparisVerHamburger.Text) + int.Parse(lbl_siparisVerKebab.Text) + int.Parse(lbl_siparisVerPizza.Text) + int.Parse(lbl_siparisVerBalik.Text);
			lb_odenecekTutar.Text = toplamDynamic.ToString();
		}

		public int hamburgerFiyat = 150;
		public int kebabFiyat = 250;
		public int pizzaFiyat = 200;
		public int balikFiyat = 250;
		public int toplam = 0;

		public void setHamburgerFiyat(int sayi) {
			hamburgerFiyat = sayi;
		}

		public void setKebabFiyat(int sayi) {
			kebabFiyat = sayi;
		}

		public void setPizzaFiyat(int sayi) {
			pizzaFiyat = sayi;
		}

		public void setBalikFiyat(int sayi) {
			balikFiyat = sayi;
		}


		public void setUserName(String text) {
			adHolder.Text = text;
		}

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}

		private void lb_mainUser_Title_Click(object sender, EventArgs e) {

		}

		private void cb_adetHamburger_SelectedIndexChanged(object sender, EventArgs e) {
			int menuFiyat = int.Parse(cb_adetHamburger.SelectedItem.ToString()) * hamburgerFiyat;
			lbl_siparisVerHamburger.Text = menuFiyat.ToString();
			lb_odenecekTutar.Text = toplam.ToString();
			int toplamDynamic = int.Parse(lbl_siparisVerHamburger.Text) + int.Parse(lbl_siparisVerKebab.Text) + int.Parse(lbl_siparisVerPizza.Text) + int.Parse(lbl_siparisVerBalik.Text);
			lb_odenecekTutar.Text = toplamDynamic.ToString();
			

		}

		private void cb_adetKebab_SelectedIndexChanged(object sender, EventArgs e) {
			int menuFiyat = int.Parse(cb_adetKebab.SelectedItem.ToString()) * kebabFiyat;
			lbl_siparisVerKebab.Text = menuFiyat.ToString();
			int toplamDynamic = int.Parse(lbl_siparisVerHamburger.Text) + int.Parse(lbl_siparisVerKebab.Text) + int.Parse(lbl_siparisVerPizza.Text) + int.Parse(lbl_siparisVerBalik.Text);
			lb_odenecekTutar.Text = toplamDynamic.ToString();

		}

		private void cb_adetPizza_SelectedIndexChanged(object sender, EventArgs e) {
			int menuFiyat = int.Parse(cb_adetPizza.SelectedItem.ToString()) * pizzaFiyat;
			lbl_siparisVerPizza.Text = menuFiyat.ToString();
			int toplamDynamic = int.Parse(lbl_siparisVerHamburger.Text) + int.Parse(lbl_siparisVerKebab.Text) + int.Parse(lbl_siparisVerPizza.Text) + int.Parse(lbl_siparisVerBalik.Text);
			lb_odenecekTutar.Text = toplamDynamic.ToString();

		}

		private void cb_adetBalik_SelectedIndexChanged(object sender, EventArgs e) {
			int menuFiyat = int.Parse(cb_adetBalik.SelectedItem.ToString()) * balikFiyat;
			lbl_siparisVerBalik.Text = menuFiyat.ToString();
			int toplamDynamic = int.Parse(lbl_siparisVerHamburger.Text) + int.Parse(lbl_siparisVerKebab.Text) + int.Parse(lbl_siparisVerPizza.Text) + int.Parse(lbl_siparisVerBalik.Text);
			lb_odenecekTutar.Text = toplamDynamic.ToString();

		}

		private void bt_login_Click(object sender, EventArgs e) {
			//toplam = int.Parse(lbl_siparisVerHamburger.Text) + int.Parse(lbl_siparisVerKebab.Text) + int.Parse(lbl_siparisVerPizza.Text) + int.Parse(lbl_siparisVerBalik.Text);
			//DialogResult dialogResult = MessageBox.Show(toplam + " TL odenecektir, onayliyor musunuz?", "Bilgilendirme", MessageBoxButtons.YesNo);

			
			hamburgerHolder.Text = cb_adetHamburger.Text;
			kebabHolder.Text = cb_adetKebab.Text;
			pizzaHolder.Text = cb_adetPizza.Text;
			balikHolder.Text = cb_adetBalik.Text;
			toplamFiyatHolder.Text = lb_odenecekTutar.Text;

			SiparisVerFinal siparisVerFinal = new SiparisVerFinal();

			//adresi okumak icin
			string filePath = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\database.xlsx";
			Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
			excel.DisplayAlerts = false;
			Workbook wb;
			Worksheet ws;

			wb = excel.Workbooks.Open(filePath);
			ws = wb.Worksheets[1];

			for (int i = 2; i <= ws.Cells[1, 1].Value + 1; i++) {
				for (int j = 1; j <= 1; j++) {
					if (adHolder.Text.Equals(Convert.ToString(ws.Cells[i, j].Value))) {
						siparisVerFinal.setAdres(ws.Cells[i, j + 4].Value);
					}
				}
			}
			wb.Close();

			
			siparisVerFinal.setAd(adHolder.Text);
			siparisVerFinal.setHamburger(hamburgerHolder.Text);
			siparisVerFinal.setPizza(pizzaHolder.Text);
			siparisVerFinal.setBalik(balikHolder.Text);
			siparisVerFinal.setKebab(kebabHolder.Text);
			siparisVerFinal.setToplamFiyat(toplamFiyatHolder.Text);


			//if (dialogResult == DialogResult.Yes) {
			//	MessageBox.Show("Siparisiniz bize basariyla ulasti..!\nYine Bekleriz", "Bilgilendirme");
			//	WriteExcel.writeOrder(adHolder.Text, hamburgerHolder.Text, kebabHolder.Text, pizzaHolder.Text, balikHolder.Text, toplamFiyatHolder.Text);
			//	Visible = false;
			//	SiparisBasarili siparisBasarili = new SiparisBasarili();
			//	siparisBasarili.Show();
			//} 
			//else if (dialogResult == DialogResult.No) {
			//	MessageBox.Show("Siparis iptal edildi..!", "Bilgilendirme");
			//}	

			Visible = false;
			siparisVerFinal.Show();

		}

		private void button1_Click(object sender, EventArgs e) {
			MainPage mainPage = new MainPage();
			Visible = false;
			mainPage.Show();
		}
	}
}
