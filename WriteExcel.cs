using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Diagnostics;

namespace LoginPage {

	class WriteExcel {

		public static string setNameExcel(string name) {
			return name;
		}
		
		public static void writeExcel (String name, String password, String mail, String gender, String location) {

			string filePath = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\database.xlsx";
			Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
			excel.DisplayAlerts = false;
			Workbook wb;
			Worksheet ws;

			wb = excel.Workbooks.Open(filePath);
			ws = wb.Worksheets[1];

			string[] info = new[] { name, mail, password, gender, location };
			
			ws.Cells[ws.Cells[1, 1].Value + 2, 1].Value = name;
			ws.Cells[ws.Cells[1, 1].Value + 2, 2].Value = password;
			ws.Cells[ws.Cells[1, 1].Value + 2, 3].Value = mail;
			ws.Cells[ws.Cells[1, 1].Value + 2, 4].Value = gender;
			ws.Cells[ws.Cells[1, 1].Value + 2, 5].Value = location;

			ws.Cells[1, 1].Value++;

			wb.SaveAs(filePath);

			wb.Close();
		}


		public static void writeOrder(string name, string adetHamburger, string adetKebab, string adetPizza, string adetBalik, string toplamTutar) {

			SiparisVer siparisVer = new SiparisVer();
			LoginPage loginPage	= new LoginPage();

			string filePath = "C:\\Users\\erayd\\Desktop\\Coding\\Languages\\C#\\Proje\\d_siparisler.xlsx";
			Microsoft.Office.Interop.Excel.Application excel = new Microsoft.Office.Interop.Excel.Application();
			excel.DisplayAlerts = false;
			Workbook wb;
			Worksheet ws;

			wb = excel.Workbooks.Open(filePath);
			ws = wb.Worksheets[1];

			ws.Cells[ws.Cells[1, 1].Value + 2, 1].Value = name;
			ws.Cells[ws.Cells[1, 1].Value + 2, 2].Value = adetHamburger;
			ws.Cells[ws.Cells[1, 1].Value + 2, 3].Value = adetKebab;
			ws.Cells[ws.Cells[1, 1].Value + 2, 4].Value = adetPizza;
			ws.Cells[ws.Cells[1, 1].Value + 2, 5].Value = adetBalik;
			ws.Cells[ws.Cells[1, 1].Value + 2, 6].Value = toplamTutar;
			ws.Cells[ws.Cells[1, 1].Value + 2, 7].Value = ws.Cells[1, 1].Value + 1;

			ws.Cells[1, 1].Value++;

			wb.SaveAs(filePath);

			wb.Close();


		}
	}
}
