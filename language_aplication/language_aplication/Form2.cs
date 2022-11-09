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
using System.Runtime.InteropServices;

namespace language_aplication
{ 
    public partial class Form2 : Form
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
        string deSentence = "";
        string ruSentence = "";
        string infoSentence = "";
       

        Random rand = new Random();
        bool ru_de = false;
        bool de_ru = true;

        private Form1 _form1;
        public Form2(Form1 form1)
        {
            _form1 = form1;
            InitializeComponent();
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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            _form1.Visible = true;

        }

        private void ru_de_RadioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (ru_de_RadioButton2.Checked)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("deu-DEU"));
                ru_de = true;
                de_ru = false;
            }

            if (de_ru_RadioButton2.Checked)
            {
                InputLanguage.CurrentInputLanguage = InputLanguage.FromCulture(new System.Globalization.CultureInfo("ru-RU"));
                de_ru = true;
                ru_de = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            correctLabel.Text = "";
            sentenceTextBox.Text = "";
            infoTextBox.Text = "";
            sentenceLabel.Visible = true;
            correctLabel.Visible = true;

            int random = rand.Next(2, 285);
            button1.Text = "Далее";

            if (de_ru)
            {
                cell1 = worksheet.Cells[random, 7]; //de
                cell2 = worksheet.Cells[random, 8]; //ru
                cell3 = worksheet.Cells[random, 9]; //премечание 

                string deSentence = Convert.ToString(cell1.Value2);
                string ruSentence = Convert.ToString(cell2.Value2);
                string infoSentence = Convert.ToString(cell3.Value2);

                sentenceLabel.Text = deSentence;
                infoTextBox.Text = infoSentence;
                checkLabel.Text = ruSentence;


            }
            if (ru_de)
            {
                cell1 = worksheet.Cells[random, 7]; //de
                cell2 = worksheet.Cells[random, 8]; //ru
                cell3 = worksheet.Cells[random, 9]; //премечание 

                string deSentence = Convert.ToString(cell1.Value2);
                string ruSentence = Convert.ToString(cell2.Value2);
                string infoSentence = Convert.ToString(cell3.Value2);

                sentenceLabel.Text = ruSentence;
                infoTextBox.Text = infoSentence;
                checkLabel.Text = deSentence;

                

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (de_ru)
            {
                correctLabel.Text = checkLabel.Text;
            }

            if (ru_de)
            {
                correctLabel.Text = checkLabel.Text;
            }
        }
    }
}
