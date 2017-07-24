using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.IO;
using Spire.Xls;


namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        string workbookPath = "d://1.xlsx";
        Workbook workbook = new Workbook();  


        public Form1()
        {
            InitializeComponent();

            workbook.LoadFromFile(workbookPath);
            Worksheet sheet = workbook.Worksheets[0];

            CellRange range = sheet.Range["B2"];
            HyperLink FileLink = sheet.HyperLinks.Add(range);
            FileLink.Type = HyperLinkType.File;
            FileLink.TextToDisplay = sheet.Range["B2"].Text;
            FileLink.Address = @"d://2.xlsx";

            workbook.SaveToFile("d://FileLink.xlsx");
        }

        /*
        public string mFilename;
       
        public Excel.Application excelApp = new Excel.Application();
        public Microsoft.Office.Interop.Excel.Workbooks wbs;
        public Microsoft.Office.Interop.Excel.Workbook wb;
        public Microsoft.Office.Interop.Excel.Worksheets wss;
        public Microsoft.Office.Interop.Excel.Worksheet ws;

        public Form1()
        {
            InitializeComponent();

            //创建
            excelApp.Visible = false;

            string workbookPath = "d://2.xlsx";
            Excel.Workbook workBook = null;
            Excel.Worksheet worksheet = null;

            if (File.Exists(workbookPath))
            {
                workBook = excelApp.Workbooks.Add();
                worksheet = (Excel.Worksheet)workBook.Sheets[1];

                Excel.Range excelCell = (Excel.Range)worksheet.get_Range("A1");
                excelCell.Value2 = "Click";

                worksheet.Hyperlinks.Add(excelCell, @"D://2.xlsx", Type.Missing, Type.Missing, Type.Missing);

                worksheet.SaveAs("d://1.xlsx", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                
                workBook.Close(false, Type.Missing, Type.Missing);
            }
            else
            {
                workBook = excelApp.Workbooks.Add();

                worksheet = (Excel.Worksheet)workBook.Sheets[1];

                worksheet.Name = "Work";

                worksheet.Cells[1, 1] = "FileName";
                worksheet.Cells[1, 2] = "FindString";
                worksheet.Cells[1, 3] = "ReplaceString";

                worksheet.SaveAs(workbookPath, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Excel.XlSaveAsAccessMode.xlNoChange, Type.Missing, Type.Missing, Type.Missing);
                workBook.Close(false, Type.Missing, Type.Missing);
                
            }
            excelApp.Quit();  
        }
         * */
    }
}
