namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.questPanel = new System.Windows.Forms.TabControl();
            this.startPage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.addList = new System.Windows.Forms.Button();
            this.listCollectionsControl = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.questPage = new System.Windows.Forms.TabPage();
            this.addingPage = new System.Windows.Forms.TabPage();
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listNameBox = new System.Windows.Forms.TextBox();
            this.addedRusWord = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.addedEngWord = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addWordButton = new System.Windows.Forms.Button();
            this.questPanel.SuspendLayout();
            this.startPage.SuspendLayout();
            this.questPage.SuspendLayout();
            this.addingPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(252, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "Word";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Berlin Sans FB", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(221, 210);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(210, 26);
            this.textBox1.TabIndex = 4;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nextButton
            // 
            this.nextButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(193)))), ((int)(((byte)(119)))));
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(159)))), ((int)(((byte)(87)))));
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(205)))), ((int)(((byte)(128)))));
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.ForeColor = System.Drawing.Color.White;
            this.nextButton.Location = new System.Drawing.Point(252, 242);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(149, 35);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "ДАЛЕЕ";
            this.nextButton.UseVisualStyleBackColor = false;
            // 
            // questPanel
            // 
            this.questPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questPanel.Controls.Add(this.startPage);
            this.questPanel.Controls.Add(this.questPage);
            this.questPanel.Controls.Add(this.addingPage);
            this.questPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.questPanel.Location = new System.Drawing.Point(-8, -29);
            this.questPanel.Multiline = true;
            this.questPanel.Name = "questPanel";
            this.questPanel.SelectedIndex = 0;
            this.questPanel.Size = new System.Drawing.Size(655, 474);
            this.questPanel.TabIndex = 7;
            // 
            // startPage
            // 
            this.startPage.Controls.Add(this.button2);
            this.startPage.Controls.Add(this.addList);
            this.startPage.Controls.Add(this.listCollectionsControl);
            this.startPage.Controls.Add(this.startButton);
            this.startPage.Location = new System.Drawing.Point(4, 27);
            this.startPage.Name = "startPage";
            this.startPage.Padding = new System.Windows.Forms.Padding(3);
            this.startPage.Size = new System.Drawing.Size(647, 443);
            this.startPage.TabIndex = 2;
            this.startPage.Text = "7";
            this.startPage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(289, 256);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // addList
            // 
            this.addList.Location = new System.Drawing.Point(289, 226);
            this.addList.Name = "addList";
            this.addList.Size = new System.Drawing.Size(75, 23);
            this.addList.TabIndex = 2;
            this.addList.Text = "Add";
            this.addList.UseVisualStyleBackColor = true;
            this.addList.Click += new System.EventHandler(this.addList_Click);
            // 
            // listCollectionsControl
            // 
            this.listCollectionsControl.FormattingEnabled = true;
            this.listCollectionsControl.ItemHeight = 18;
            this.listCollectionsControl.Location = new System.Drawing.Point(31, 59);
            this.listCollectionsControl.Name = "listCollectionsControl";
            this.listCollectionsControl.Size = new System.Drawing.Size(139, 256);
            this.listCollectionsControl.TabIndex = 1;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(289, 184);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // questPage
            // 
            this.questPage.Controls.Add(this.label1);
            this.questPage.Controls.Add(this.textBox1);
            this.questPage.Controls.Add(this.nextButton);
            this.questPage.Location = new System.Drawing.Point(4, 27);
            this.questPage.Name = "questPage";
            this.questPage.Padding = new System.Windows.Forms.Padding(3);
            this.questPage.Size = new System.Drawing.Size(647, 443);
            this.questPage.TabIndex = 1;
            this.questPage.Text = "Все слова";
            this.questPage.UseVisualStyleBackColor = true;
            // 
            // addingPage
            // 
            this.addingPage.Controls.Add(this.addWordButton);
            this.addingPage.Controls.Add(this.label4);
            this.addingPage.Controls.Add(this.addedEngWord);
            this.addingPage.Controls.Add(this.label3);
            this.addingPage.Controls.Add(this.label2);
            this.addingPage.Controls.Add(this.addedRusWord);
            this.addingPage.Controls.Add(this.listNameBox);
            this.addingPage.Controls.Add(this.button1);
            this.addingPage.Controls.Add(this.wordListBox);
            this.addingPage.Location = new System.Drawing.Point(4, 27);
            this.addingPage.Name = "addingPage";
            this.addingPage.Size = new System.Drawing.Size(647, 443);
            this.addingPage.TabIndex = 3;
            this.addingPage.Text = "tabPage1";
            this.addingPage.UseVisualStyleBackColor = true;
            // 
            // wordListBox
            // 
            this.wordListBox.FormattingEnabled = true;
            this.wordListBox.ItemHeight = 18;
            this.wordListBox.Location = new System.Drawing.Point(17, 35);
            this.wordListBox.Name = "wordListBox";
            this.wordListBox.Size = new System.Drawing.Size(175, 256);
            this.wordListBox.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(396, 251);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listNameBox
            // 
            this.listNameBox.Location = new System.Drawing.Point(243, 64);
            this.listNameBox.Name = "listNameBox";
            this.listNameBox.Size = new System.Drawing.Size(133, 24);
            this.listNameBox.TabIndex = 2;
            // 
            // addedRusWord
            // 
            this.addedRusWord.Location = new System.Drawing.Point(243, 94);
            this.addedRusWord.Name = "addedRusWord";
            this.addedRusWord.Size = new System.Drawing.Size(133, 24);
            this.addedRusWord.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя списка";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(406, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Слово на русском";
            // 
            // addedEngWord
            // 
            this.addedEngWord.Location = new System.Drawing.Point(243, 124);
            this.addedEngWord.Name = "addedEngWord";
            this.addedEngWord.Size = new System.Drawing.Size(133, 24);
            this.addedEngWord.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Слово на англецком";
            // 
            // addWordButton
            // 
            this.addWordButton.Location = new System.Drawing.Point(243, 170);
            this.addWordButton.Name = "addWordButton";
            this.addWordButton.Size = new System.Drawing.Size(139, 29);
            this.addWordButton.TabIndex = 8;
            this.addWordButton.Text = "Добавить Слово";
            this.addWordButton.UseVisualStyleBackColor = true;
            this.addWordButton.Click += new System.EventHandler(this.addWordButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(637, 434);
            this.Controls.Add(this.questPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.questPanel.ResumeLayout(false);
            this.startPage.ResumeLayout(false);
            this.questPage.ResumeLayout(false);
            this.questPage.PerformLayout();
            this.addingPage.ResumeLayout(false);
            this.addingPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TabControl questPanel;
        private System.Windows.Forms.TabPage questPage;
        private System.Windows.Forms.TabPage startPage;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox listCollectionsControl;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addList;
        private System.Windows.Forms.TabPage addingPage;
        private System.Windows.Forms.ListBox wordListBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox addedRusWord;
        private System.Windows.Forms.TextBox listNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addedEngWord;
        private System.Windows.Forms.Button addWordButton;
    }
}

