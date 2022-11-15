namespace language_aplication
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
            this.totalResultButton = new System.Windows.Forms.Button();
            this.resultListView = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader3 = new System.Windows.Forms.ColumnHeader();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.button2 = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
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
            this.wordTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.wordTextBox_KeyPress);
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
            this.button4.Location = new System.Drawing.Point(652, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = "ПРЕДЛОЖЕНИЯ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // totalResultButton
            // 
            this.totalResultButton.Location = new System.Drawing.Point(669, 170);
            this.totalResultButton.Name = "totalResultButton";
            this.totalResultButton.Size = new System.Drawing.Size(119, 46);
            this.totalResultButton.TabIndex = 12;
            this.totalResultButton.Text = "РЕЗУЛЬТАТ";
            this.totalResultButton.UseVisualStyleBackColor = true;
            this.totalResultButton.Click += new System.EventHandler(this.totalResultButton_Click);
            // 
            // resultListView
            // 
            this.resultListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.resultListView.Location = new System.Drawing.Point(40, 222);
            this.resultListView.Name = "resultListView";
            this.resultListView.Size = new System.Drawing.Size(606, 164);
            this.resultListView.TabIndex = 13;
            this.resultListView.UseCompatibleStateImageBehavior = false;
            this.resultListView.View = System.Windows.Forms.View.Details;
            this.resultListView.Visible = false;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Result";
            this.columnHeader1.Width = 100;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Correct Words";
            this.columnHeader2.Width = 250;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Wrong Words";
            this.columnHeader3.Width = 250;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(200, 18);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(652, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(34, 29);
            this.button2.TabIndex = 15;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.resultListView);
            this.Controls.Add(this.totalResultButton);
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
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
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
        private Button totalResultButton;
        private ListView resultListView;
        private ColumnHeader columnHeader1;
        private ColumnHeader columnHeader2;
        private ColumnHeader columnHeader3;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripProgressBar toolStripProgressBar1;
        private Button button2;
    }
}