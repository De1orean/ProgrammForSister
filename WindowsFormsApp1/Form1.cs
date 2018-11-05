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
        private ListCollection listCollection = new ListCollection();
        private List<string> addedWordsRus = new List<string>();
        private List<string> addedWordsEng = new List<string>();

        public Form1()
        {
            InitializeComponent();

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            questPanel.SelectedIndex = 1;
        }

        private void addList_Click(object sender, EventArgs e)
        {
            questPanel.SelectedIndex = 2;
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
            test.Collection.Add(listOfWord);
            listCollection = test;
            wordListBox.Items.Add(listOfWord.nameOfList);
            //Доделать третью страницу, 
            //поставить вместо имени структуры слово на русском/англецком
        }

        private void addWordButton_Click(object sender, EventArgs e)
        {
            addedWordsEng.Add(addedEngWord.Text);
            addedWordsRus.Add(addedRusWord.Text);
            
        }
    }
}
