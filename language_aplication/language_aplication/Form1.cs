using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace language_aplication
{
    public partial class Form1 : Form
    {
        private Excel.Application excelapp = null;
        private Excel.Window excelWindow = null;

        public Form1()
        {
            InitializeComponent();

            string path_word = @"C:\Users\Alex\source\repos\language_aplication\appDE.xlsx";
          


            
        }
    }
}