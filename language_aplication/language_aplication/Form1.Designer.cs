﻿namespace language_aplication
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.wordTextBox = new System.Windows.Forms.TextBox();
            this.wordLabel = new System.Windows.Forms.Label();
            this.ru_de_RadioButton = new System.Windows.Forms.RadioButton();
            this.de_ru_RadioButton = new System.Windows.Forms.RadioButton();
            this.button3 = new System.Windows.Forms.Button();
            this.correctWordLabel = new System.Windows.Forms.Label();
            this.translateLabel = new System.Windows.Forms.Label();
            this.trueWordLabel = new System.Windows.Forms.Label();
            this.transriptionsLabel = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(346, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(300, 49);
            this.button1.TabIndex = 0;
            this.button1.Text = "Начать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // wordTextBox
            // 
            this.wordTextBox.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordTextBox.Location = new System.Drawing.Point(40, 87);
            this.wordTextBox.Name = "wordTextBox";
            this.wordTextBox.Size = new System.Drawing.Size(606, 43);
            this.wordTextBox.TabIndex = 1;
            // 
            // wordLabel
            // 
            this.wordLabel.AutoSize = true;
            this.wordLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordLabel.Location = new System.Drawing.Point(40, 39);
            this.wordLabel.Name = "wordLabel";
            this.wordLabel.Size = new System.Drawing.Size(83, 35);
            this.wordLabel.TabIndex = 3;
            this.wordLabel.Text = "label1";
            this.wordLabel.Visible = false;
            // 
            // ru_de_RadioButton
            // 
            this.ru_de_RadioButton.AutoSize = true;
            this.ru_de_RadioButton.Location = new System.Drawing.Point(669, 50);
            this.ru_de_RadioButton.Name = "ru_de_RadioButton";
            this.ru_de_RadioButton.Size = new System.Drawing.Size(82, 24);
            this.ru_de_RadioButton.TabIndex = 4;
            this.ru_de_RadioButton.Text = "RUS/DE";
            this.ru_de_RadioButton.UseVisualStyleBackColor = true;
            this.ru_de_RadioButton.CheckedChanged += new System.EventHandler(this.ru_de_RadioButton_CheckedChanged);
            // 
            // de_ru_RadioButton
            // 
            this.de_ru_RadioButton.AutoSize = true;
            this.de_ru_RadioButton.Checked = true;
            this.de_ru_RadioButton.Location = new System.Drawing.Point(669, 80);
            this.de_ru_RadioButton.Name = "de_ru_RadioButton";
            this.de_ru_RadioButton.Size = new System.Drawing.Size(82, 24);
            this.de_ru_RadioButton.TabIndex = 5;
            this.de_ru_RadioButton.TabStop = true;
            this.de_ru_RadioButton.Text = "DE/RUS";
            this.de_ru_RadioButton.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(40, 167);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(300, 49);
            this.button3.TabIndex = 6;
            this.button3.Text = "ПРОВЕРИТЬ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // correctWordLabel
            // 
            this.correctWordLabel.AutoSize = true;
            this.correctWordLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.correctWordLabel.Location = new System.Drawing.Point(40, 133);
            this.correctWordLabel.Name = "correctWordLabel";
            this.correctWordLabel.Size = new System.Drawing.Size(79, 31);
            this.correctWordLabel.TabIndex = 7;
            this.correctWordLabel.Text = "label1";
            this.correctWordLabel.Visible = false;
            // 
            // translateLabel
            // 
            this.translateLabel.AutoSize = true;
            this.translateLabel.Location = new System.Drawing.Point(565, 9);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(68, 20);
            this.translateLabel.TabIndex = 8;
            this.translateLabel.Text = "перевод";
            this.translateLabel.Visible = false;
            // 
            // trueWordLabel
            // 
            this.trueWordLabel.AutoSize = true;
            this.trueWordLabel.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trueWordLabel.Location = new System.Drawing.Point(133, 133);
            this.trueWordLabel.Name = "trueWordLabel";
            this.trueWordLabel.Size = new System.Drawing.Size(207, 31);
            this.trueWordLabel.TabIndex = 9;
            this.trueWordLabel.Text = "правильное слово";
            this.trueWordLabel.Visible = false;
            // 
            // transriptionsLabel
            // 
            this.transriptionsLabel.AutoSize = true;
            this.transriptionsLabel.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.transriptionsLabel.Location = new System.Drawing.Point(358, 39);
            this.transriptionsLabel.Name = "transriptionsLabel";
            this.transriptionsLabel.Size = new System.Drawing.Size(183, 35);
            this.transriptionsLabel.TabIndex = 10;
            this.transriptionsLabel.Text = "Транскрипция";
            this.transriptionsLabel.Visible = false;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(40, 393);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = "ПРЕДЛОЖЕНИЯ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.transriptionsLabel);
            this.Controls.Add(this.trueWordLabel);
            this.Controls.Add(this.translateLabel);
            this.Controls.Add(this.correctWordLabel);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.de_ru_RadioButton);
            this.Controls.Add(this.ru_de_RadioButton);
            this.Controls.Add(this.wordLabel);
            this.Controls.Add(this.wordTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button1;
        private TextBox wordTextBox;
        private RadioButton ru_de_RadioButton;
        private RadioButton de_ru_RadioButton;
        public Label wordLabel;
        private Button button3;
        private Label correctWordLabel;
        private Label translateLabel;
        private Label trueWordLabel;
        private Label transriptionsLabel;
        private Button button4;
    }
}