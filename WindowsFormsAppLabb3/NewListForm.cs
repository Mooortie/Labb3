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
using Labb3_AppFörGlosor;

namespace WindowsFormsAppLabb3
{
    public partial class NewListForm : Form
    {
        
        private static readonly string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Labb3 AppFörGlosor";
        public NewListForm()
        {
            InitializeComponent();
        }

        private void SaveNewList(object sender, EventArgs e)
        {

            if (WordList.Exists(FileNameTextBox.Text))
            {
                DialogResult dialogResult = MessageBox.Show("This list does already exist do you want to replace it?","Existing", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    if (FileNameTextBox.Text == string.Empty || LanguageTextboxOne.Text == string.Empty || LanguageTextboxTwo.Text == string.Empty)
                    {
                        MessageBox.Show("The file name or the languanges cant be empty");
                    }
                    else
                    {
                        string[] newListArgs = { FileNameTextBox.Text, LanguageTextboxOne.Text, LanguageTextboxTwo.Text };
                        WindowsFormWordList.NewList(newListArgs);
                        DialogResult AdddialogResult = MessageBox.Show("Do you want to add words to the list? ", "Add Words", MessageBoxButtons.YesNo);
                        if (AdddialogResult == DialogResult.Yes)
                        {
                            AddNewWordsForm addWordsToList = new();
                            addWordsToList.ShowDialog();
                        }
                        else
                        {
                            Close();
                        }
                    }
                }
                else if (dialogResult == DialogResult.No)
                {
                    Close();
                }
            }
            
            else
            {
                string[] newListArgs = { FileNameTextBox.Text, LanguageTextboxOne.Text, LanguageTextboxTwo.Text };
                WindowsFormWordList.NewList(newListArgs);
                MessageBox.Show("New list has been created");
                DialogResult AddWordsdialogResult = MessageBox.Show("Do you want to add words to the list? ", "Add Words", MessageBoxButtons.YesNo);
                if (AddWordsdialogResult == DialogResult.Yes)
                {
                    AddNewWordsForm addWordsToList = new();
                    addWordsToList.ShowDialog();
                }
                else
                {
                    Close();
                }
            }
        }
        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SaveNewList(sender, e);
            }
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
        private void CloseNewList_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
