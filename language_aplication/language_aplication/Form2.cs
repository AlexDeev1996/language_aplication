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
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp);
         
        }
        private void Form2_KeyUp(object? sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
                this.KeyUp -= this.Form2_KeyUp;
                this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form2_KeyUp_two);
            }
        }
        private void Form2_KeyUp_two(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
                this.KeyUp += this.Form2_KeyUp;
                this.KeyUp -= this.Form2_KeyUp_two;
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
                    case 0:  // 2-75 1
                        {
                            random = rand.Next(2, 75);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;

                    case 1:  // 77 - 132 2          
                        {
                            random = rand.Next(77, 132);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;

                    case 2: //134-200 3
                        {
                            random = rand.Next(134, 200);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;

                    case 3: //202-294 4
                        {
                            random = rand.Next(202, 294);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;

                    case 4: //296-374 5
                        {
                            random = rand.Next(296, 374);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;

                    case 5: //376-461 6
                        {
                            random = rand.Next(376, 461);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;
                    case 6: //463-508 7
                        {
                            random = rand.Next(463, 508);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;

                    case 7: //510-599 8
                        {
                            random = rand.Next(510, 599);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;
                    case 8: //601-718 9
                        {
                            random = rand.Next(601, 718);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;
                    case 9: //720-765 10
                        {
                            random = rand.Next(720, 765);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;

                        }
                        break;
                    case 10: //767-828 11
                        {
                            random = rand.Next(767, 828);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    case 11: //830-879 12
                        {
                            random = rand.Next(830, 879);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    case 12: //881-952 13
                        {
                            random = rand.Next(881, 952);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    case 13: //954-1018 14
                        {
                            random = rand.Next(954, 1018);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    case 14: //1020-1081 1
                        {
                            random = rand.Next(1020, 1081);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    case 15: //1083-1146 2
                        {
                            random = rand.Next(1083, 1146);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    case 16: //1148-1217 3
                        {
                            random = rand.Next(1148, 1217);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    case 17: //1219-1279 4
                        {
                            random = rand.Next(1219, 1279);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    case 18: //1281-1360 5
                        {
                            random = rand.Next(1281, 1260);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    case 19: //1362-1428 6
                        {
                            random = rand.Next(1362, 1428);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    case 20: //1430-1479 7
                        {
                            random = rand.Next(1430, 1479);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = deSentence;
                            checkLabel.Text = ruSentence;
                        }
                        break;
                    case 21:
                        { //модальные глаголы
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
                    case 0:  // 2-75 1
                        {
                            random = rand.Next(2, 75);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;

                    case 1:  // 77 - 132 2          
                        {
                            random = rand.Next(77, 132);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;

                    case 2: //134-200 3
                        {
                            random = rand.Next(134, 200);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;

                    case 3: //202-294 4
                        {
                            random = rand.Next(202, 294);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;

                    case 4: //296-374 5
                        {
                            random = rand.Next(296, 374);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;

                    case 5: //376-461 6
                        {
                            random = rand.Next(376, 461);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;

                        }
                        break;
                    case 6: //463-508 7
                        {
                            random = rand.Next(463, 508);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;

                    case 7: //510-599 8
                        {
                            random = rand.Next(510, 599);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 8: //601-718 9
                        {
                            random = rand.Next(601, 718);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 9: //720-765 10
                        {
                            random = rand.Next(720, 765);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 10: //767-828 11
                        {
                            random = rand.Next(767, 828);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 11: //830-879 12
                        {
                            random = rand.Next(830, 879);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 12: //881-952 13
                        {
                            random = rand.Next(881, 952);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 13: //954-1018 14
                        {
                            random = rand.Next(954, 1018);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 14: //1020-1081 1
                        {
                            random = rand.Next(1020, 1081);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 15: //1083-1146 2
                        {
                            random = rand.Next(1083, 1146);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 16: //1148-1217 3
                        {
                            random = rand.Next(1148, 1217);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 17: //1219-1279 4
                        {
                            random = rand.Next(1219, 1279);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 18: //1281-1360 5
                        {
                            random = rand.Next(1281, 1260);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 19: //1362-1428 6
                        {
                            random = rand.Next(1362, 1428);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 20: //1430-1479 7
                        {
                            random = rand.Next(1430, 1479);
                            cell1 = worksheet.Cells[random, 11]; //de
                            cell2 = worksheet.Cells[random, 12]; //ru

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                        }
                        break;
                    case 21:
                        { //модальные глаголы
                            random = rand.Next(2, 285);
                            cell1 = worksheet.Cells[random, 7]; //de
                            cell2 = worksheet.Cells[random, 8]; //ru
                            cell3 = worksheet.Cells[random, 9]; //премечание 

                            deSentence = Convert.ToString(cell1.Value2);
                            ruSentence = Convert.ToString(cell2.Value2);
                            infoSentence = Convert.ToString(cell3.Value2);

                            sentenceLabel.Text = ruSentence;
                            checkLabel.Text = deSentence;
                            infoTextBox.Text = infoSentence;
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

        private void sentenceTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
                e.Handled = true;
            else base.OnKeyPress(e);
        }


        private void button4_Click(object sender, EventArgs e)
        {
            if (!infoTextBox.Visible) infoTextBox.Visible = true;
            else infoTextBox.Visible = false;
        }
    }
}
