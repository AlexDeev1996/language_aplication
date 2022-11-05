using Excel = Microsoft.Office.Interop.Excel;
using System.Runtime.InteropServices;

namespace language_aplication
{
    public partial class Form1 : Form
    {
        Excel.Application application = null;
        Excel.Workbooks workbooks = null;
        Excel.Workbook workbook = null;
        Excel.Sheets worksheets = null;
        Excel.Worksheet worksheet = null;
        
        Excel.Range cell = null;

        string path_word = @"C:\Users\Alex\source\repos\language_aplication\appDE.xlsx";
        public Form1()
        {
            InitializeComponent();
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //создаем объект Application
            application = new Excel.Application();
            //получаем ссылку на коллекцию рабочих книг
            workbooks = application.Workbooks;
            workbook = application.Workbooks.Open(path_word, 
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing, Type.Missing, Type.Missing,
            Type.Missing, Type.Missing);

            //добавляем новую рабочую книгу в коллекцию
            //workbook = workbooks.Add(Type.Missing);
            worksheets = workbook.Worksheets; //получаем доступ к коллекции рабочих листов
            worksheet = (Excel.Worksheet)worksheets.get_Item(1);//получаем доступ к первому листу
            Random rand = new Random();

            for (int i = 0; i < 10; i++)
            {
                button3.Text = "Проверить";
                cell = worksheet.Cells[rand.Next(2,499), 2];
                wordLabel.Text = Convert.ToString(cell.Value2);
                wordTextBox.Text = "";
            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //application.Quit();
            
            //освобождаем память, занятую объектами
            Marshal.ReleaseComObject(cell);
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(worksheets);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(workbooks);
            Marshal.ReleaseComObject(application);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            correctWordLabel.Visible = true;
            if (wordLabel.Text == wordTextBox.Text)
            {
                correctWordLabel.ForeColor = Color.Green;
                correctWordLabel.Text = "TRUE";
            }
            else
            {
                correctWordLabel.ForeColor = Color.Red;
                correctWordLabel.Text = "FALSE";
            }
            button3.Text = "Далее";
        }
    }
}