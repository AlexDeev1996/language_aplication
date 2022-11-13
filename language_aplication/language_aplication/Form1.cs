﻿using Excel = Microsoft.Office.Interop.Excel;
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
        bool button_visible = false;    
        static int count_ListView = 0;
        private Form2 form2;


        private void CompareWord(string word1, string word2)
        {
            word1 = word1.Trim();
            word2 = word2.Trim();
            if (word1 == word2)
            {
                correctWordLabel.ForeColor = Color.Green;
                correctWordLabel.Text = "TRUE";
                resultListView.ForeColor = Color.Green;
                resultListView.Items.Add("TRUE");
                resultListView.ForeColor = Color.Black;
                resultListView.Items[count_ListView].SubItems.Add(word1);
                resultListView.Items[count_ListView].SubItems.Add(word2);
            }
            else
            {
                correctWordLabel.ForeColor = Color.Red;
                correctWordLabel.Text = "FALSE";
                resultListView.ForeColor = Color.Red;
                resultListView.Items.Add("FALSE");
                trueWordLabel.Text = translateLabel.Text;
                resultListView.ForeColor = Color.Black;
                resultListView.Items[count_ListView].SubItems.Add(word1);
                resultListView.Items[count_ListView].SubItems.Add(word2);
            }
            count_ListView++;
        }
        private static void CloseExcel(Excel.Application ExcelApplication = null)
        {
            if (ExcelApplication != null)
            {
                ExcelApplication.Workbooks.Close();
                ExcelApplication.Quit();
            }

            System.Diagnostics.Process[] PROC = System.Diagnostics.Process.GetProcessesByName("EXCEL");
            foreach (System.Diagnostics.Process PK in PROC)
            {
                if (PK.MainWindowTitle.Length == 0) { PK.Kill(); }
            }
        }
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

            this.KeyPreview = true;
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);

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

        private void Form1_KeyUp(object? sender, KeyEventArgs e)
        {
            

            if (e.KeyCode == Keys.Enter)
            {
                button3.PerformClick();
                this.KeyUp -= this.Form1_KeyUp;
                this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp_two);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            wordLabel.Visible = true;

            int random = rand.Next(2, 1580);
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
            //  resultListView.Items.Add()
              //  translateLabel.Text
              //  wordTextBox.Text

            //wordLabel.Text = word;
            wordTextBox.Text = "";
            correctWordLabel.Text = "";
            trueWordLabel.Text = "";

        }

       

        private void button3_Click(object sender, EventArgs e) //Button compare
        {
            correctWordLabel.Visible = true;
            trueWordLabel.Visible = true;
            CompareWord(translateLabel.Text, wordTextBox.Text);
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

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseExcel(application);

        }

        private void totalResultButton_Click(object sender, EventArgs e)
        {
            if (!resultListView.Visible) resultListView.Visible = true;
            else resultListView.Visible = false;
            

        }
    }
}