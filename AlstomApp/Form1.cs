using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace AlstomApp
{
    public partial class Form1 : Form
    {
        string filePath = @"C:\Users\hp\Desktop\rendelesallomanyupdate20221130.xlsx";

        public Form1()
        {
            InitializeComponent();
        }

        private void search_BT_Click(object sender, EventArgs e)
        {
            // Létrehozzuk az Excel alkalmazást
            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();

            // Megnyitjuk az Excel fájlt
            Workbook workbook = excelApp.Workbooks.Open(filePath);

            // Választunk ki egy munkalapot
            Worksheet worksheet = workbook.Worksheets["20221130"];

            // A munkalap sorainak és oszlopainak száma
            int rows = worksheet.UsedRange.Rows.Count;
            int columns = worksheet.UsedRange.Columns.Count;

            //fabbrication number
            int i = 1;
            while (worksheet.Cells[i].value != "fabbrication number")
            {
                i++;

                if(worksheet.Cells[i].value == "fabbrication number")
                {
                    for (int j = 1;  <; ++)
                    {

                    }
                }
            }

            // Lezárjuk az Excel fájlt és a munkafolyamatot
            workbook.Close();
            //Marshal.ReleaseComObject(workbook);
            excelApp.Quit();
            //Marshal.FinalReleaseComObject(excelApp);




        }
    }
}
