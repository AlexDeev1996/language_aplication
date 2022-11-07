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
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 143);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(289, 46);
            this.button1.TabIndex = 0;
            this.button1.Text = "НАЧАТЬ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sentenceLabel
            // 
            this.sentenceLabel.AutoSize = true;
            this.sentenceLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sentenceLabel.Location = new System.Drawing.Point(12, 20);
            this.sentenceLabel.Name = "sentenceLabel";
            this.sentenceLabel.Size = new System.Drawing.Size(116, 31);
            this.sentenceLabel.TabIndex = 1;
            this.sentenceLabel.Text = "DE WORD";
            // 
            // sentenceTextBox
            // 
            this.sentenceTextBox.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sentenceTextBox.Location = new System.Drawing.Point(12, 54);
            this.sentenceTextBox.Name = "sentenceTextBox";
            this.sentenceTextBox.Size = new System.Drawing.Size(767, 38);
            this.sentenceTextBox.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 409);
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
            this.ru_de_RadioButton2.Location = new System.Drawing.Point(706, 270);
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
            this.de_ru_RadioButton2.Location = new System.Drawing.Point(706, 300);
            this.de_ru_RadioButton2.Name = "de_ru_RadioButton2";
            this.de_ru_RadioButton2.Size = new System.Drawing.Size(82, 24);
            this.de_ru_RadioButton2.TabIndex = 5;
            this.de_ru_RadioButton2.TabStop = true;
            this.de_ru_RadioButton2.Text = "DE/RUS";
            this.de_ru_RadioButton2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 143);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(223, 46);
            this.button3.TabIndex = 6;
            this.button3.Text = "ПРОВЕРИТЬ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // correctLabel
            // 
            this.correctLabel.AutoSize = true;
            this.correctLabel.Location = new System.Drawing.Point(12, 109);
            this.correctLabel.Name = "correctLabel";
            this.correctLabel.Size = new System.Drawing.Size(121, 20);
            this.correctLabel.TabIndex = 7;
            this.correctLabel.Text = "Correct Sentence";
            // 
            // infoTextBox
            // 
            this.infoTextBox.Location = new System.Drawing.Point(12, 209);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.Size = new System.Drawing.Size(674, 194);
            this.infoTextBox.TabIndex = 8;
            this.infoTextBox.Text = "Премечание";
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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkLabel);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.correctLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.de_ru_RadioButton2);
            this.Controls.Add(this.ru_de_RadioButton2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.sentenceTextBox);
            this.Controls.Add(this.sentenceLabel);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
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
    }
}