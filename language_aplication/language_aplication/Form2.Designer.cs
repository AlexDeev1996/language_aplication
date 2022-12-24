namespace language_aplication
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();

            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.sentenceLabel = new System.Windows.Forms.Label();
            this.sentenceTextBox = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.ru_de_RadioButton2 = new System.Windows.Forms.RadioButton();
            this.de_ru_RadioButton2 = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.correctLabel = new System.Windows.Forms.Label();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.checkLabel = new System.Windows.Forms.Label();
            this.temaComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "НАЧАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sentenceLabel
            // 
            this.sentenceLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sentenceLabel.Location = new System.Drawing.Point(12, 9);
            this.sentenceLabel.Name = "sentenceLabel";
            this.sentenceLabel.Size = new System.Drawing.Size(776, 63);
            this.sentenceLabel.TabIndex = 1;
            this.sentenceLabel.Text = "DE WORD";
            this.sentenceLabel.Visible = false;
            // 
            // sentenceTextBox
            // 
            this.sentenceTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sentenceTextBox.Location = new System.Drawing.Point(12, 72);
            this.sentenceTextBox.Name = "sentenceTextBox";
            this.sentenceTextBox.Size = new System.Drawing.Size(767, 38);
            this.sentenceTextBox.TabIndex = 2;
            this.sentenceTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.sentenceTextBox_KeyPress);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 410);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 29);
            this.button2.TabIndex = 3;
            this.button2.Text = "Обратно";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ru_de_RadioButton2
            // 
            this.ru_de_RadioButton2.AutoSize = true;
            this.ru_de_RadioButton2.Location = new System.Drawing.Point(8, 14);
            this.ru_de_RadioButton2.Name = "ru_de_RadioButton2";
            this.ru_de_RadioButton2.Size = new System.Drawing.Size(82, 24);
            this.ru_de_RadioButton2.TabIndex = 4;
            this.ru_de_RadioButton2.Text = "RUS/DE";
            this.ru_de_RadioButton2.UseVisualStyleBackColor = true;
            this.ru_de_RadioButton2.CheckedChanged += new System.EventHandler(this.ru_de_RadioButton2_CheckedChanged);
            // 
            // de_ru_RadioButton2
            // 
            this.de_ru_RadioButton2.AutoSize = true;
            this.de_ru_RadioButton2.Checked = true;
            this.de_ru_RadioButton2.Location = new System.Drawing.Point(8, 44);
            this.de_ru_RadioButton2.Name = "de_ru_RadioButton2";
            this.de_ru_RadioButton2.Size = new System.Drawing.Size(82, 24);
            this.de_ru_RadioButton2.TabIndex = 5;
            this.de_ru_RadioButton2.TabStop = true;
            this.de_ru_RadioButton2.Text = "DE/RUS";
            this.de_ru_RadioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 166);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "ПРОВЕРИТЬ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // correctLabel
            // 
            this.correctLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.correctLabel.Location = new System.Drawing.Point(12, 112);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(767, 55);
            this.correctLabel.TabIndex = 7;
            this.correctLabel.Text = "Correct Sentence";
            this.correctLabel.Visible = false;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.infoTextBox.Location = new System.Drawing.Point(12, 261);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(674, 143);
            this.infoTextBox.TabIndex = 8;
            this.infoTextBox.Text = "Премечание";
            this.infoTextBox.Visible = false;
            // 
            // checkLabel
            // 
            this.checkLabel.AutoSize = true;
            this.checkLabel.Location = new System.Drawing.Point(445, 9);
            this.checkLabel.Name = "checkLabel";
            this.checkLabel.Size = new System.Drawing.Size(48, 20);
            this.checkLabel.TabIndex = 9;
            this.checkLabel.Text = "Check";
            this.checkLabel.Visible = false;
            // 
            // temaComboBox
            // 
            this.temaComboBox.FormattingEnabled = true;
            this.temaComboBox.Items.AddRange(new object[] {
            "А 1.1_1) Guten Tag. Mein Name ist... ",
            "2) Meine Familie",
            "3) Einkaufen",
            "4) Meine Wohnung",
            "5) Mein Tag",
            "6) Freizeit ",
            "7) Kinder und Schule",
            "А 1.2_8) Beruf und Arbeit",
            "9) Ämter und Behörden",
            "10) Gesundheit und Krankheit",
            "11) In der Stadt unterwegs",
            "12) Kundenservice",
            "13) Neue Kleider",
            "14) Feste",
            "A 2.1_1) Ankommen",
            "2) Zu Hause",
            "3) Essen und Trinken",
            "4) Arbeitswelt",
            "5) Sport und Fitness",
            "6) Schule und Ausbildung",
            "7) Feste und Geschenke",
            "Modalverben"});
            this.temaComboBox.Location = new System.Drawing.Point(583, 166);
            this.temaComboBox.Name = "temaComboBox";
            this.temaComboBox.Size = new System.Drawing.Size(205, 28);
            this.temaComboBox.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.groupBox1.Controls.Add(this.ru_de_RadioButton2);
            this.groupBox1.Controls.Add(this.de_ru_RadioButton2);
            this.groupBox1.Location = new System.Drawing.Point(692, 280);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(96, 76);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 226);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(94, 29);
            this.button4.TabIndex = 14;
            this.button4.Text = "INFO";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.temaComboBox);
            this.Controls.Add(this.checkLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sentenceTextBox);
            this.Controls.Add(this.sentenceLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private Label sentenceLabel;
        private TextBox sentenceTextBox;
        private Button button2;
        private RadioButton ru_de_RadioButton2;
        private RadioButton de_ru_RadioButton2;
        private Button button3;
        private Label correctLabel;
        private TextBox infoTextBox;
        private Label checkLabel;
        private ComboBox temaComboBox;
        private GroupBox groupBox1;
        private Button button4;
    }
}