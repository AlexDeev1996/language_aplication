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
        
        Excel.Range cell1 = null;
        Excel.Range cell2 = null;
        Excel.Range cell3 = null;
        Excel.Range cell4 = null;
        int count = 1;
        int count_button = 0;
        string path_word = @"C:\Users\Alex\source\repos\language_aplication\appDE.xlsx";
        string check_word = "";
        string deWord = "";
        string ruWord = "";
        string translateWord = "";
        string transkriotionsWord = "";

        Random rand = new Random();
        bool ru_de = false;
        bool de_ru = true;

        private Form2 form2;
        public Form1()
        {
            InitializeComponent();
            form2 = new Form2(this) { Visible = false};
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
            button1.Text = "НАЧАТЬ";
            correctWordLabel.Text = "";
         


        }

        private void button1_Click(object sender, EventArgs e)
        {
           

            int random = rand.Next(2, 499);
            button1.Text = "Далее";
            if (de_ru)
            {
                transriptionsLabel.Visible = true;
                cell1 = worksheet.Cells[random, 2]; //de
                cell2 = worksheet.Cells[random, 5]; //ru
                cell3 = worksheet.Cells[random, 1]; //artikl
                cell4 = worksheet.Cells[random, 4]; //транскрипция

                transkriotionsWord = Convert.ToString(cell4.Value2);
                deWord = Convert.ToString(cell1.Value2);
                translateWord = Convert.ToString(cell2.Value2);
                translateLabel.Text = translateWord;
                check_word = Convert.ToString(cell3.Value2);
                wordLabel.Text = check_word + " " + deWord;
                transriptionsLabel.Text = transkriotionsWord;
            }

           if(ru_de)
           {
                transriptionsLabel.Visible = false;
                cell1 = worksheet.Cells[random, 2]; //de
                cell2 = worksheet.Cells[random, 5]; //ru
                cell3 = worksheet.Cells[random, 1]; //artikl

                ruWord = Convert.ToString(cell2.Value2);
                translateWord = Convert.ToString(cell1.Value2);
                translateLabel.Text = translateWord;
                check_word = Convert.ToString(cell3.Value2);
                wordLabel.Text = ruWord;
            }

            
            //wordLabel.Text = word;
            wordTextBox.Text = "";
            correctWordLabel.Text = "";
            trueWordLabel.Text = "";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //application.Quit();
            
            //освобождаем память, занятую объектами
            Marshal.ReleaseComObject(cell1);
            Marshal.ReleaseComObject(cell2);
            Marshal.ReleaseComObject(worksheet);
            Marshal.ReleaseComObject(worksheets);
            Marshal.ReleaseComObject(workbook);
            Marshal.ReleaseComObject(workbooks);
            Marshal.ReleaseComObject(application);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            correctWordLabel.Visible = true;
          

                if (translateLabel.Text == wordTextBox.Text)
                {
                    correctWordLabel.ForeColor = Color.Green;
                    correctWordLabel.Text = "TRUE";
                }
                else
                {
                    correctWordLabel.ForeColor = Color.Red;
                    correctWordLabel.Text = "FALSE";
                    trueWordLabel.Text = translateLabel.Text;
                }


        }

        private void ru_de_RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (ru_de_RadioButton.Checked)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("deu-DEU"));
                ru_de = true;
                de_ru = false;
            }

            if (de_ru_RadioButton.Checked)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
                de_ru = true;
                ru_de = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            form2.Visible = true;

        }
    }
}