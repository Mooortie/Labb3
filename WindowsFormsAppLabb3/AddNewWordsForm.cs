using Labb3_AppFörGlosor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsFormsAppLabb3
{
    public partial class AddNewWordsForm : Form
    {
        public AddNewWordsForm()
        {
            InitializeComponent();
            InitializeFileList();
        }

        public void InitializeFileList()
        {
            var fileNames = WordList.GetLists();
            foreach (var item in fileNames)
            {
                AddWordsListbox.Items.Add(item);
            }
        }
        private void AddWordsListbox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            LanguageList(AddWordsListbox.Text);
        }

        public  void LanguageList(string name)
        {
            var currentWordList = WordList.LoadList(name);
            if (currentWordList.Languages.Length > 2)
            {
                AddLanguageOne.Text = currentWordList.Languages[0];
                AddLanguageTwo.Text = currentWordList.Languages[1];
                AddLanguageThree.Text = currentWordList.Languages[2];
                thirdWord.Enabled = true;
            }
            else
            {
                AddLanguageOne.Text = currentWordList.Languages[0];
                AddLanguageTwo.Text = currentWordList.Languages[1];
                AddLanguageThree.Text = String.Empty;
                thirdWord.Enabled = false;
            }
        }

        private void ADDBUTTON_Click(object sender, EventArgs e)
        {
            WindowsFormWordList.Add(AddWordsListbox.Text,firstWord.Text,secondWord.Text,thirdWord.Text);
            MessageBox.Show("New word has been added!");
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
