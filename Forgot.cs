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
	public partial class Forgot : Form {
		public Forgot() {
			InitializeComponent();
		}

		private void bt_login_Click(object sender, EventArgs e) {
			string filePath = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\database.xlsx";
			Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
			excel.DisplayAlerts = false;
			Workbook wb;
			Worksheet ws;

			wb = excel.Workbooks.Open(filePath);
			ws = wb.Worksheets[1];

			for (int i = 2; i <= ws.Cells[1, 1].Value + 1; i++) {
				for (int j = 1; j <= 1; j++) {
					if (tb_id.Text.Equals(Convert.ToString(ws.Cells[i, j].Value))) {
						MessageBox.Show("Sifreniz: " + ws.Cells[i, j + 1].Value, "Sifreniz Bulundu..!");
					}
				}
			}
			wb.Close();

			LoginPage lp = new LoginPage();
			MessageBox.Show("Giris Yapmaya Hazirsin!", "Bilgilendirme");
			Visible = false;
			lp.Show();
		}

		private void bt_close_Click(object sender, EventArgs e) {
			System.Windows.Forms.Application.Exit();
		}

		private void button1_Click(object sender, EventArgs e) {
			LoginPage lp = new LoginPage();
			Visible = false;
			lp.Show();
		}
	}
}
