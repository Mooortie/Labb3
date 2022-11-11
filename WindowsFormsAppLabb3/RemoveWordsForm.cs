using Labb3_AppFörGlosor;
using System.Xml.Linq;

namespace WindowsFormsAppLabb3
{
    public partial class RemoveWordsForm : Form
    {
        public RemoveWordsForm()
        {
            InitializeComponent();
            InitializeFileList();
        }
        public void InitializeFileList()
        {
            var fileNames = WordList.GetLists();
            foreach (var item in fileNames)
            {
                listboxRemoveWords.Items.Add(item);
            }
        }

        private void listboxRemoveWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            listviewRemoveWord.Clear();
            CreateListView(listboxRemoveWords.Text);
        }
        public void CreateListView(string name)
        {
            var currentWordList = WordList.LoadList(name);

            string[] headers = currentWordList.Languages;
            foreach (var language in headers)
            {
                ColumnHeader header = new()
                {
                    Text = language,
                    TextAlign = HorizontalAlignment.Center
                };

                listviewRemoveWord.Columns.Add(header);
            }

            List<Word> allWords = currentWordList.GetAllWords();
            foreach (var word in allWords)
            {
                string[] row = word.Translations;
                var listViewItem = new ListViewItem(row);
                listviewRemoveWord.Items.Add(listViewItem);
            }
            listviewRemoveWord.View = View.Details;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            var currentWordList = WordList.LoadList(listboxRemoveWords.Text);
            foreach (ListViewItem item in listviewRemoveWord.SelectedItems)
            {
                listviewRemoveWord.Items.Remove(item);
                WindowsFormWordList.RemoveWord(listboxRemoveWords.Text, currentWordList.Languages[0], item.Text);
                MessageBox.Show($"{item.Text} has been removed");
            }
        }

        private void CanelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
