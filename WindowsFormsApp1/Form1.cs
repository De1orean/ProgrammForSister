using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.IO;

namespace WindowsFormsApp1
{
    
    
    public partial class Form1 : Form
    {
        private void listBoxUpdate()
        {
            listCollectionsControl.Items.Clear();
            for(int i = 0;i<listCollection.Collection.Count();i++)
            {
                listCollectionsControl.Items.Add(listCollection.Collection[i].nameOfList);
            }
        }

        private void questBoxUppdatePosition()
        {
            questWord.Text = listCollection.Collection[listCollectionsControl.SelectedIndex].russWords[indexOfWordInCollection];
            Point point = new Point(questPage.Size.Width / 2 - questWord.Size.Width / 2, 128);
            questWord.Location = point;
        }

        private int selectedListIndex;
        private int indexOfWordInCollection=0;
        private ListCollection listCollection = new ListCollection();
        private List<string> addedWordsRus = new List<string>();
        private List<string> addedWordsEng = new List<string>();
        private List<string> userTypedWords = new List<string>();

        public Form1()
        {
            InitializeComponent();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (listCollectionsControl.SelectedIndex != -1)
            {
                questPanel.SelectedIndex = 1;
                selectedListIndex = listCollectionsControl.SelectedIndex;
                questBoxUppdatePosition();
            }
        }

        private void addList_Click(object sender, EventArgs e)
        {
            questPanel.SelectedIndex = 2;
            wordListBox.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("listCollections.dat", FileMode.OpenOrCreate))
            {
                listCollection = (ListCollection)binaryFormatter.Deserialize(fileStream);
            }

            for(int i = 0; i < listCollection.Collection.Count();i++)
            {
                listCollectionsControl.Items.Add(listCollection.Collection[i].nameOfList);
            }
            listBoxUpdate();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();

            using (FileStream fileStream = new FileStream("listCollections.dat", FileMode.OpenOrCreate))
            {
                binaryFormatter.Serialize(fileStream, listCollection);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ListCollection.listOfWord listOfWord = new ListCollection.listOfWord();
            ListCollection test = new ListCollection();
            listOfWord.nameOfList = listNameBox.Text;
            listOfWord.engWords = addedWordsEng;
            listOfWord.russWords = addedWordsRus;
            if (listCollection == null)
            {
                test.Collection.Add(listOfWord);
                listCollection = test;
            }
            else
                listCollection.Collection.Add(listOfWord);
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            if (addedRusWord.Text != String.Empty && addedEngWord.Text != String.Empty)
            {
                addedWordsEng.Add(addedEngWord.Text);
                addedWordsRus.Add(addedRusWord.Text);
                wordListBox.Items.Add(addedEngWord.Text);
                addedEngWord.Clear();
                addedRusWord.Clear();

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            questPanel.SelectedIndex = 0;
            listBoxUpdate();
        }

        private void deleteList_Click(object sender, EventArgs e)
        {
            listCollection.Collection.Remove(listCollection.Collection[listCollectionsControl.SelectedIndex]);
            listCollectionsControl.Items.Remove(listCollectionsControl.SelectedIndex);
            listBoxUpdate();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            
            if (questTextBox.Text.ToUpper() == listCollection.Collection[selectedListIndex].engWords[indexOfWordInCollection].ToUpper())
            {
                if (indexOfWordInCollection+1 == listCollection.Collection[selectedListIndex].engWords.Count-1)
                {
                    nextButton.Text = "ЗАКОНЧИТЬ";
                }
                indexOfWordInCollection++;
                questWord.Text = listCollection.Collection[selectedListIndex].russWords[indexOfWordInCollection];
                questTextBox.Clear();
                questBoxUppdatePosition();
            }
        }

        private void changeButton_Click(object sender, EventArgs e)
        {
            if (listCollectionsControl.SelectedIndex != -1)
            {
                questPanel.SelectedIndex = 3;
                for (int i = 0; i < listCollection.Collection[selectedListIndex].engWords.Count(); i++)
                {
                    changingWordListBox.Items.Add(listCollection.Collection[selectedListIndex].engWords[i]);
                }
            }
        }

        private void deleteWordButton_Click(object sender, EventArgs e)
        {
            if(changingWordListBox.SelectedIndex != -1)
            {
                listCollection.Collection[selectedListIndex].russWords.Remove(listCollection.Collection[selectedListIndex].russWords[changingWordListBox.SelectedIndex]);
                listCollection.Collection[selectedListIndex].engWords.Remove(listCollection.Collection[selectedListIndex].engWords[changingWordListBox.SelectedIndex]);
                changingWordListBox.Items.Remove(changingWordListBox.SelectedIndex);
                changingWordListBox.Items.Clear();
                for (int i = 0; i < listCollection.Collection[selectedListIndex].engWords.Count(); i++)
                {
                    changingWordListBox.Items.Add(listCollection.Collection[selectedListIndex].engWords[i]);
                }
            }
        }

        private void addWordChangedButton_Click(object sender, EventArgs e)
        {
            if (addedEngWordChanged.Text != String.Empty && addedRusWordChanged.Text != String.Empty)
            {
                listCollection.Collection[selectedListIndex].engWords.Add(addedEngWordChanged.Text);
                listCollection.Collection[selectedListIndex].russWords.Add(addedRusWordChanged.Text);
                changingWordListBox.Items.Add(addedEngWordChanged.Text);
                addedEngWordChanged.Clear();
                addedRusWordChanged.Clear();
            }
        }

        private void backButtonChangingPage_Click(object sender, EventArgs e)
        {
            changingWordListBox.Items.Clear();
            questPanel.SelectedIndex = 0;
        }
    }
}
