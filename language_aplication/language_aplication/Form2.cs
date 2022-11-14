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

            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
        }

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
                this.KeyUp -= this.Form1_KeyUp;
                this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_two);
            }
        }

        private void Form1_KeyUp_two(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                this.KeyUp += this.Form1_KeyUp;
                this.KeyUp -= this.Form1_KeyUp_two;

            }
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

            button1.Text = "Далее";

            int random = rand.Next(2, 285);
            string deSentence;
            string ruSentence;
            string infoSentence;

            if (de_ru)
            {
                switch (temaComboBox.SelectedIndex)
                {
                    case 0:  // 2-91 8
                        {
                            random = rand.Next(2, 91);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;

                    case 1:  // 92 - 209 9          
                        {
                            random = rand.Next(92, 209);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;

                    case 2: //210-255 10
                        {
                            random = rand.Next(210, 255);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;

                    case 3: //256-317 11
                        {
                            random = rand.Next(256, 317);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;

                    case 4: //318-367 12
                        {
                            random = rand.Next(318, 367);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;

                    case 5: //368-439 13
                        {
                            random = rand.Next(368, 439);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;
                    case 6: //440-504 14
                        {
                            random = rand.Next(440, 504);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;
                    case 7:
                        {
                            random = rand.Next(2, 285);
                            cell1 = worksheet.Cells[random, 7]; //de
                            cell2 = worksheet.Cells[random, 8]; //ru
                            cell3 = worksheet.Cells[random, 9]; //премечание 

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);
                            infoSentence = Convert.ToString(cell3.Value2);

                            sentenceLabel.Text = deSentence;
                            infoTextBox.Text = infoSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    default:
                        break;
                }

            }
            if (ru_de)
            {
                switch (temaComboBox.SelectedIndex)
                {
                    case 0:  // 2-91 8
                        {
                            random = rand.Next(2, 91);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;

                    case 1:  // 92 - 209 9          
                        {
                            random = rand.Next(92, 209);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;

                    case 2: //210-255 10
                        {
                            random = rand.Next(210, 255);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;

                    case 3: //256-317 11
                        {
                            random = rand.Next(256, 317);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;

                    case 4: //318-367 12
                        {
                            random = rand.Next(318, 367);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;

                    case 5: //368-439 13
                        {
                            random = rand.Next(368, 439);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;
                    case 6: //440-504 14
                        {
                            random = rand.Next(440, 504);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;
                    case 7:
                        {
                            random = rand.Next(2, 285);
                            cell1 = worksheet.Cells[random, 7]; //de
                            cell2 = worksheet.Cells[random, 8]; //ru
                            cell3 = worksheet.Cells[random, 9]; //премечание 

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);
                            infoSentence = Convert.ToString(cell3.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    default:
                        break;
                }
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
