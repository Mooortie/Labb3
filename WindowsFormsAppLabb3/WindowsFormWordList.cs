using Labb3_AppFörGlosor;

namespace WindowsFormsAppLabb3
{
    internal class WindowsFormWordList
    {
        public static void NewList(string[] args)
        {
            string name = args[0];
            string[] languages = args[1..];

            WordList wordlist = new(name, languages);
            wordlist.Save();
        }
        public static void Add(string listName, string firstWord, string secondWord, string thirdWord)
        {
            string name = listName;
            WordList currentWordList = WordList.LoadList(name);

            var words = new List<string>();

            if (!string.IsNullOrEmpty(firstWord))
            {
                words.Add(firstWord.TrimStart().TrimEnd().ToLower());
            }
            if (!string.IsNullOrEmpty(secondWord))
            {
                words.Add(secondWord.TrimStart().TrimEnd().ToLower());
            }
            if (!string.IsNullOrEmpty(thirdWord))
            {
                words.Add(thirdWord.TrimStart().TrimEnd().ToLower());
            }

            currentWordList.Add(words.ToArray());
            words.Clear();


            currentWordList.Save();
        }
        public static void RemoveWord(string name, string removeLang, string wordtoRemove)
        {
            WordList currentWordList = WordList.LoadList(name);

            string language = removeLang.ToLower();

            int languageIndex = Array.IndexOf(currentWordList.Languages, language);

            currentWordList.Remove(languageIndex, wordtoRemove);

            currentWordList.Save();
        }
    }
}

