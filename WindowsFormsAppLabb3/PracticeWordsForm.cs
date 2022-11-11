using Labb3_AppFörGlosor;

namespace WindowsFormsAppLabb3
{
    public partial class PracticeWordsForm : Form
    {
        float totalCorrectWords = 0;
        float totalAmountOfPracticedWords = 0;
        string currentPracticeLanguage;
        string currentPracticeWord;
        string currentCorrectLanguage;
        string currentCorrectWord;

        public PracticeWordsForm()
        {
            InitializeComponent();
            InitializeFileList();
            PracticeButtonInForm.Text = "Guess";

        }
        public void InitializeFileList()
        {
            var fileNames = WordList.GetLists();
            foreach (var item in fileNames)
            {
                PracticeListBox.Items.Add(item);
            }
        }
        void GuessWordPratice(object sender, EventArgs e)
        {
            PracticeButtonInForm.Text = "Guess";

            if (Guessing())
            {
                PracticeWordsMetod();
            }
            else
            {
                PracticeWordsMetod();
            }
        }
        public void PracticeWordsMetod()
        {
            WordList currentWordList = WordList.LoadList(PracticeListBox.Text);
            Word practiceWord = currentWordList.GetWordToPractice();

            currentPracticeLanguage = currentWordList.Languages[practiceWord.FromLanguage];
            currentPracticeWord = practiceWord.Translations[practiceWord.FromLanguage];
            currentCorrectLanguage = currentWordList.Languages[practiceWord.ToLanguage];
            currentCorrectWord = practiceWord.Translations[practiceWord.ToLanguage];

            LanguageFrom.Text = currentPracticeLanguage;
            WordToGuess.Text = currentPracticeWord;
            LanguageTo.Text = currentCorrectLanguage;

        }

        public bool Guessing()
        {
            if (UsersAnswer.Text == String.Empty)
            {
                MessageBox.Show("You cant guess on nothing"); 
            }
            else if (UsersAnswer.Text == currentCorrectWord)
            {
                MessageBox.Show($"{UsersAnswer.Text.ToUpper()} is correct!");
                UsersAnswer.Text = string.Empty;
                totalCorrectWords++;
                totalAmountOfPracticedWords++;
                return true;
            }
            else if (UsersAnswer.Text != string.Empty)
            {
                MessageBox.Show($"That was wrong the correct word is {currentCorrectWord.ToUpper()}");
                totalAmountOfPracticedWords++;
                return false;
            }
            return false;
        }

        private void PracticeListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            PracticeWordsMetod();
        }

        private void CancelButtonPractice_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"You practiced on {totalAmountOfPracticedWords} you were right on {totalCorrectWords / totalAmountOfPracticedWords * 100:0}% of the guesses");

            Close();
        }
    }
}
