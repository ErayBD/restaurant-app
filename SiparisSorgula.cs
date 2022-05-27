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
	public partial class SiparisSorgula : Form {
		public SiparisSorgula() {
			InitializeComponent();
		}

		private void bt_login_Click(object sender, EventArgs e) {
			string filePath = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\d_siparisler.xlsx";
			Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
			Workbook wb;
			Worksheet ws;

			wb = excel.Workbooks.Open(filePath);
			ws = wb.Worksheets[1];

			Boolean bulunduMu = false;

			for (int i = 2; i <= ws.Cells[1, 1].Value + 1; i++) {
				for (int j = 1; j <= 1; j++) {
					if (tb_kulAdi.Text.Equals(Convert.ToString(ws.Cells[i, j].Value))) {
						MessageBox.Show("Siparis No: " + ws.Cells[i, j + 6].Value, "Siparis No Bulundu..!");
						bulunduMu = true;
						break;
					}
					else {
						if (!bulunduMu) {
							MessageBox.Show("Gecersiz Kullanici Adi..!");
						}
					}
				}
			}
			
			wb.Close();

			MainPage mainPage = new MainPage();
			MessageBox.Show("Ana Sayfaya donuluyor..");
			Visible = false;
			mainPage.Show();
		}

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e) {
			MainPage mainPage = new MainPage();
			Visible = false;
			mainPage.Show();
		}
	}
}
