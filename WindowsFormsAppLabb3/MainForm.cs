using Labb3_AppFörGlosor;
using System.Xml.Linq;

namespace WindowsFormsAppLabb3
{
    public partial class MainForm : Form
    {
        private static readonly string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Labb3 AppFörGlosor";
        private readonly List<Word> words = new();

        //public string[] Translations { get; }
        //public Word(params string[] translations)
        //{
        //    Translations = translations;
        //}

        public MainForm()
        {
            InitializeComponent();
            InitializeFileList();

        }
        public void InitializeFileList()
        {
            var fileNames = WordList.GetLists();
            foreach (var item in fileNames)
            {
                FoundList.Items.Add(item);
            }
        }
        private void NewList_Click(object sender, EventArgs e)
        {
            NewListForm addnewlist = new();

            addnewlist.ShowDialog();
            FoundList.Items.Clear();
            InitializeFileList();
        }

        private void AddWords_Click(object sender, EventArgs e)
        {
            AddNewWordsForm addWordsToList = new();

            addWordsToList.ShowDialog();
        }
        private void FoundList_SelectedIndexChanged(object sender, EventArgs e)
        {
            ViewInformation.Clear();
            CreateListView(FoundList.Text);
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

                ViewInformation.Columns.Add(header);
            }

            List<Word> allWords = currentWordList.GetAllWords();
            foreach (var word in allWords)
            {
                string[] row = word.Translations;
                var listViewItem = new ListViewItem(row);
                ViewInformation.Items.Add(listViewItem);
            }
            ViewInformation.View = View.Details;
        }

        private void Remove_Click(object sender, EventArgs e)
        {
             RemoveWordsForm removedWord = new();

             removedWord.ShowDialog();
        }

        private void Count_Click(object sender, EventArgs e)
        {
            int wordAmount = 0;
            if (!string.IsNullOrEmpty(FoundList.Text))
            {
                WordList currentWordList = WordList.LoadList(FoundList.Text);
                wordAmount = currentWordList.Count();
            }
            MessageBox.Show("It is currently " + wordAmount.ToString() + " words in this list" );
        }

        private void PracticeButton_Click(object sender, EventArgs e)
        {
            PracticeWordsForm practiceWords = new();
            
            practiceWords.ShowDialog();
        }
    }
}