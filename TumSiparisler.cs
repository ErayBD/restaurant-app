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
	public partial class TumSiparisler : Form {
		public TumSiparisler() {
			InitializeComponent();
		}

		private void bt_bilgileriGetir_Click(object sender, EventArgs e) {
			string filePath = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\d_siparisler.xlsx";
			Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
			excel.DisplayAlerts = false;
			Workbook wb;
			Worksheet ws;

			wb = excel.Workbooks.Open(filePath);
			ws = wb.Worksheets[1];

			StringBuilder rtbBilgiler = new StringBuilder(rtb_bilgiler.Text);

			for (int i = 2; i <= ws.Cells[1, 1].Value + 1; i++) {
				for (int j = 1; j <= 1; j++) {

					rtbBilgiler.AppendLine("Siparisin Verenin Adi: " + ws.Cells[i, j].Value);
					rtbBilgiler.AppendLine("Siparis Edilen Hamburger Adeti: " + ws.Cells[i, j + 1].Value);
					rtbBilgiler.AppendLine("Siparis Edilen Kebab Adeti: " + ws.Cells[i, j + 2].Value);
					rtbBilgiler.AppendLine("Siparis Edilen Pizza Adeti: " + ws.Cells[i, j + 3].Value);
					rtbBilgiler.AppendLine("Siparis Edilen Balik Adeti: " + ws.Cells[i, j + 4].Value);
					rtbBilgiler.AppendLine("Odecenek Toplam Fiyat: " + ws.Cells[i, j + 5].Value);
					rtbBilgiler.AppendLine("Siparis Numarasi: " + ws.Cells[i, j + 6].Value);
					rtbBilgiler.AppendLine("***********************************************");

					rtb_bilgiler.Text = rtbBilgiler.ToString();

					//rtb_bilgiler.Text = "Siparisin Verenin Adi: " + ws.Cells[i, j].Value + "\n"
					//	+ "Siparis Edilen Hamburger Adeti: " + ws.Cells[i, j + 1].Value + "\n"
					//	+ "Siparis Edilen Kebab Adeti: " + ws.Cells[i, j + 2].Value + "\n"
					//	+ "Siparis Edilen Pizza Adeti: " + ws.Cells[i, j + 3].Value + "\n"
					//	+ "Siparis Edilen Balik Adeti: " + ws.Cells[i, j + 4].Value + "\n"
					//	+ "Odecenek Toplam Fiyat: " + ws.Cells[i, j + 5].Value + "\n"
					//	+ "Siparis Numarasi: " + ws.Cells[i, j + 6].Value + "\n"
					//	+ "\n\n";
				}
			}
			wb.Close();
		}

		private void bt_geriDon_Click(object sender, EventArgs e) {
			MainPageAdmin mainPageAdmin = new MainPageAdmin();
			Visible = false;
			mainPageAdmin.Show();
		}

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}
	}
}
