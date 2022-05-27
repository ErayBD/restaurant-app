using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;

namespace LoginPage {

	public class ReadExcel {

		public string id;
		public string pw;
		public string mail;
		public string location;

		public Boolean adminLogin = false;

		public Boolean readExcel(String name, String password) {

			string filePath = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\database.xlsx";
			Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
			excel.DisplayAlerts = false;
			Workbook wb;
			Worksheet ws;

			wb = excel.Workbooks.Open(filePath);
			ws = wb.Worksheets[1];

			if (name.Equals(Convert.ToString(ws.Cells[2, 1].Value)) && password.Equals(Convert.ToString(ws.Cells[2, 2].Value))) {
				adminLogin = true;
				return true;
			}

			for (int i = 3; i <= ws.Cells[1, 1].Value + 1; i++) {
				for (int j = 1; j <= 1; j++) {
					if (name.Equals(Convert.ToString(ws.Cells[i, j].Value)) && password.Equals(Convert.ToString(ws.Cells[i, j+1].Value))) {
						
						adminLogin = false;

						string id = Convert.ToString(ws.Cells[i, j].Value);
						string pw = Convert.ToString(ws.Cells[i, j + 1].Value);
						string mail = Convert.ToString(ws.Cells[i, j + 2].Value);
						string location = Convert.ToString(ws.Cells[i, j + 4].Value);

						return true;

					}
				}
			}
			wb.Close();
			return false;
		}
	}
}
