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
            this.questWord = new System.Windows.Forms.Label();
            this.questTextBox = new System.Windows.Forms.TextBox();
            this.nextButton = new System.Windows.Forms.Button();
            this.questPanel = new System.Windows.Forms.TabControl();
            this.startPage = new System.Windows.Forms.TabPage();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteList = new System.Windows.Forms.Button();
            this.addList = new System.Windows.Forms.Button();
            this.listCollectionsControl = new System.Windows.Forms.ListBox();
            this.startButton = new System.Windows.Forms.Button();
            this.questPage = new System.Windows.Forms.TabPage();
            this.addingPage = new System.Windows.Forms.TabPage();
            this.backToStartPageButton = new System.Windows.Forms.Button();
            this.addWordButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.addedEngWord = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addedRusWord = new System.Windows.Forms.TextBox();
            this.listNameBox = new System.Windows.Forms.TextBox();
            this.addListOfWordsButton = new System.Windows.Forms.Button();
            this.wordListBox = new System.Windows.Forms.ListBox();
            this.changingPage = new System.Windows.Forms.TabPage();
            this.backButtonChangingPage = new System.Windows.Forms.Button();
            this.deleteWordButton = new System.Windows.Forms.Button();
            this.addWordChangedButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.addedRusWordChanged = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addedEngWordChanged = new System.Windows.Forms.TextBox();
            this.changingWordListBox = new System.Windows.Forms.ListBox();
            this.endPage = new System.Windows.Forms.TabPage();
            this.ResoultLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.goToStart = new System.Windows.Forms.Button();
            this.questPanel.SuspendLayout();
            this.startPage.SuspendLayout();
            this.questPage.SuspendLayout();
            this.addingPage.SuspendLayout();
            this.changingPage.SuspendLayout();
            this.endPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // questWord
            // 
            this.questWord.AutoSize = true;
            this.questWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questWord.Location = new System.Drawing.Point(252, 128);
            this.questWord.Name = "questWord";
            this.questWord.Size = new System.Drawing.Size(139, 55);
            this.questWord.TabIndex = 3;
            this.questWord.Text = "Word";
            // 
            // questTextBox
            // 
            this.questTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questTextBox.Location = new System.Drawing.Point(221, 210);
            this.questTextBox.Multiline = true;
            this.questTextBox.Name = "questTextBox";
            this.questTextBox.Size = new System.Drawing.Size(213, 26);
            this.questTextBox.TabIndex = 4;
            this.questTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.nextButton.Size = new System.Drawing.Size(152, 35);
            this.nextButton.TabIndex = 5;
            this.nextButton.Text = "ДАЛЕЕ";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.nextButton_Click);
            // 
            // questPanel
            // 
            this.questPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.questPanel.Controls.Add(this.startPage);
            this.questPanel.Controls.Add(this.questPage);
            this.questPanel.Controls.Add(this.addingPage);
            this.questPanel.Controls.Add(this.changingPage);
            this.questPanel.Controls.Add(this.endPage);
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
            this.startPage.Controls.Add(this.changeButton);
            this.startPage.Controls.Add(this.deleteList);
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
            // changeButton
            // 
            this.changeButton.Location = new System.Drawing.Point(289, 286);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(75, 23);
            this.changeButton.TabIndex = 4;
            this.changeButton.Text = "изменить";
            this.changeButton.UseVisualStyleBackColor = true;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // deleteList
            // 
            this.deleteList.Location = new System.Drawing.Point(289, 256);
            this.deleteList.Name = "deleteList";
            this.deleteList.Size = new System.Drawing.Size(75, 23);
            this.deleteList.TabIndex = 3;
            this.deleteList.Text = "Delete";
            this.deleteList.UseVisualStyleBackColor = true;
            this.deleteList.Click += new System.EventHandler(this.deleteList_Click);
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
            this.questPage.Controls.Add(this.questWord);
            this.questPage.Controls.Add(this.questTextBox);
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
            this.addingPage.Controls.Add(this.backToStartPageButton);
            this.addingPage.Controls.Add(this.addWordButton);
            this.addingPage.Controls.Add(this.label4);
            this.addingPage.Controls.Add(this.addedEngWord);
            this.addingPage.Controls.Add(this.label3);
            this.addingPage.Controls.Add(this.label2);
            this.addingPage.Controls.Add(this.addedRusWord);
            this.addingPage.Controls.Add(this.listNameBox);
            this.addingPage.Controls.Add(this.addListOfWordsButton);
            this.addingPage.Controls.Add(this.wordListBox);
            this.addingPage.Location = new System.Drawing.Point(4, 27);
            this.addingPage.Name = "addingPage";
            this.addingPage.Size = new System.Drawing.Size(647, 443);
            this.addingPage.TabIndex = 3;
            this.addingPage.Text = "tabPage1";
            this.addingPage.UseVisualStyleBackColor = true;
            // 
            // backToStartPageButton
            // 
            this.backToStartPageButton.Location = new System.Drawing.Point(286, 251);
            this.backToStartPageButton.Name = "backToStartPageButton";
            this.backToStartPageButton.Size = new System.Drawing.Size(75, 23);
            this.backToStartPageButton.TabIndex = 9;
            this.backToStartPageButton.Text = "Назад";
            this.backToStartPageButton.UseVisualStyleBackColor = true;
            this.backToStartPageButton.Click += new System.EventHandler(this.button3_Click);
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Слово на англецком";
            // 
            // addedEngWord
            // 
            this.addedEngWord.Location = new System.Drawing.Point(243, 124);
            this.addedEngWord.Name = "addedEngWord";
            this.addedEngWord.Size = new System.Drawing.Size(133, 24);
            this.addedEngWord.TabIndex = 6;
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
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Имя списка";
            // 
            // addedRusWord
            // 
            this.addedRusWord.Location = new System.Drawing.Point(243, 94);
            this.addedRusWord.Name = "addedRusWord";
            this.addedRusWord.Size = new System.Drawing.Size(133, 24);
            this.addedRusWord.TabIndex = 3;
            // 
            // listNameBox
            // 
            this.listNameBox.Location = new System.Drawing.Point(243, 64);
            this.listNameBox.Name = "listNameBox";
            this.listNameBox.Size = new System.Drawing.Size(133, 24);
            this.listNameBox.TabIndex = 2;
            // 
            // addListOfWordsButton
            // 
            this.addListOfWordsButton.Location = new System.Drawing.Point(396, 251);
            this.addListOfWordsButton.Name = "addListOfWordsButton";
            this.addListOfWordsButton.Size = new System.Drawing.Size(75, 23);
            this.addListOfWordsButton.TabIndex = 1;
            this.addListOfWordsButton.Text = "Сохранить";
            this.addListOfWordsButton.UseVisualStyleBackColor = true;
            this.addListOfWordsButton.Click += new System.EventHandler(this.button1_Click);
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
            // changingPage
            // 
            this.changingPage.Controls.Add(this.backButtonChangingPage);
            this.changingPage.Controls.Add(this.deleteWordButton);
            this.changingPage.Controls.Add(this.addWordChangedButton);
            this.changingPage.Controls.Add(this.label1);
            this.changingPage.Controls.Add(this.addedRusWordChanged);
            this.changingPage.Controls.Add(this.label5);
            this.changingPage.Controls.Add(this.addedEngWordChanged);
            this.changingPage.Controls.Add(this.changingWordListBox);
            this.changingPage.Location = new System.Drawing.Point(4, 27);
            this.changingPage.Name = "changingPage";
            this.changingPage.Size = new System.Drawing.Size(647, 443);
            this.changingPage.TabIndex = 4;
            this.changingPage.Text = "changingPage";
            this.changingPage.UseVisualStyleBackColor = true;
            // 
            // backButtonChangingPage
            // 
            this.backButtonChangingPage.Location = new System.Drawing.Point(16, 340);
            this.backButtonChangingPage.Name = "backButtonChangingPage";
            this.backButtonChangingPage.Size = new System.Drawing.Size(75, 23);
            this.backButtonChangingPage.TabIndex = 15;
            this.backButtonChangingPage.Text = "Назад";
            this.backButtonChangingPage.UseVisualStyleBackColor = true;
            this.backButtonChangingPage.Click += new System.EventHandler(this.backButtonChangingPage_Click);
            // 
            // deleteWordButton
            // 
            this.deleteWordButton.Location = new System.Drawing.Point(228, 134);
            this.deleteWordButton.Name = "deleteWordButton";
            this.deleteWordButton.Size = new System.Drawing.Size(139, 26);
            this.deleteWordButton.TabIndex = 14;
            this.deleteWordButton.Text = "Удалить слово";
            this.deleteWordButton.UseVisualStyleBackColor = true;
            this.deleteWordButton.Click += new System.EventHandler(this.deleteWordButton_Click);
            // 
            // addWordChangedButton
            // 
            this.addWordChangedButton.Location = new System.Drawing.Point(228, 98);
            this.addWordChangedButton.Name = "addWordChangedButton";
            this.addWordChangedButton.Size = new System.Drawing.Size(139, 29);
            this.addWordChangedButton.TabIndex = 13;
            this.addWordChangedButton.Text = "Добавить Слово";
            this.addWordChangedButton.UseVisualStyleBackColor = true;
            this.addWordChangedButton.Click += new System.EventHandler(this.addWordChangedButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(391, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 18);
            this.label1.TabIndex = 12;
            this.label1.Text = "Слово на англецком";
            // 
            // addedRusWordChanged
            // 
            this.addedRusWordChanged.Location = new System.Drawing.Point(228, 25);
            this.addedRusWordChanged.Name = "addedRusWordChanged";
            this.addedRusWordChanged.Size = new System.Drawing.Size(133, 24);
            this.addedRusWordChanged.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(391, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Слово на русском";
            // 
            // addedEngWordChanged
            // 
            this.addedEngWordChanged.Location = new System.Drawing.Point(228, 52);
            this.addedEngWordChanged.Name = "addedEngWordChanged";
            this.addedEngWordChanged.Size = new System.Drawing.Size(133, 24);
            this.addedEngWordChanged.TabIndex = 9;
            // 
            // changingWordListBox
            // 
            this.changingWordListBox.FormattingEnabled = true;
            this.changingWordListBox.ItemHeight = 18;
            this.changingWordListBox.Location = new System.Drawing.Point(16, 14);
            this.changingWordListBox.Name = "changingWordListBox";
            this.changingWordListBox.Size = new System.Drawing.Size(181, 310);
            this.changingWordListBox.TabIndex = 0;
            // 
            // endPage
            // 
            this.endPage.Controls.Add(this.label7);
            this.endPage.Controls.Add(this.goToStart);
            this.endPage.Controls.Add(this.ResoultLabel);
            this.endPage.Location = new System.Drawing.Point(4, 27);
            this.endPage.Name = "endPage";
            this.endPage.Padding = new System.Windows.Forms.Padding(3);
            this.endPage.Size = new System.Drawing.Size(647, 443);
            this.endPage.TabIndex = 5;
            this.endPage.Text = "endPage";
            this.endPage.UseVisualStyleBackColor = true;
            // 
            // ResoultLabel
            // 
            this.ResoultLabel.AutoSize = true;
            this.ResoultLabel.Location = new System.Drawing.Point(72, 61);
            this.ResoultLabel.Name = "ResoultLabel";
            this.ResoultLabel.Size = new System.Drawing.Size(46, 18);
            this.ResoultLabel.TabIndex = 0;
            this.ResoultLabel.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(72, 102);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 18);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // goToStart
            // 
            this.goToStart.Location = new System.Drawing.Point(278, 190);
            this.goToStart.Name = "goToStart";
            this.goToStart.Size = new System.Drawing.Size(75, 23);
            this.goToStart.TabIndex = 9;
            this.goToStart.Text = "button1";
            this.goToStart.UseVisualStyleBackColor = true;
            this.goToStart.Click += new System.EventHandler(this.GoToStart_Click);
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
            this.changingPage.ResumeLayout(false);
            this.changingPage.PerformLayout();
            this.endPage.ResumeLayout(false);
            this.endPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label questWord;
        private System.Windows.Forms.TextBox questTextBox;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.TabControl questPanel;
        private System.Windows.Forms.TabPage questPage;
        private System.Windows.Forms.TabPage startPage;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.ListBox listCollectionsControl;
        private System.Windows.Forms.Button deleteList;
        private System.Windows.Forms.Button addList;
        private System.Windows.Forms.TabPage addingPage;
        private System.Windows.Forms.ListBox wordListBox;
        private System.Windows.Forms.Button addListOfWordsButton;
        private System.Windows.Forms.TextBox addedRusWord;
        private System.Windows.Forms.TextBox listNameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox addedEngWord;
        private System.Windows.Forms.Button addWordButton;
        private System.Windows.Forms.Button backToStartPageButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.TabPage changingPage;
        private System.Windows.Forms.ListBox changingWordListBox;
        private System.Windows.Forms.Button deleteWordButton;
        private System.Windows.Forms.Button addWordChangedButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox addedRusWordChanged;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox addedEngWordChanged;
        private System.Windows.Forms.Button backButtonChangingPage;
        private System.Windows.Forms.TabPage endPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button goToStart;
        private System.Windows.Forms.Label ResoultLabel;
    }
}

