using Labb3_AppFörGlosor;

namespace WordListConsolApplication
{
    internal class MainAppForWordList
    {
        private static readonly string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Labb3 AppFörGlosor";
        static void Main(string[] args)
        {
            CheckforDirectory();
            UserMenu(args);
        }
        private static void CheckforDirectory()
        {
            if (!Directory.Exists(fullPath))
            {
                Directory.CreateDirectory(fullPath);
            }
        }

        private static void PrintLists(string[] args)
        {
            Console.WriteLine("Currently available lists");
            foreach (var item in WordList.GetLists())
            {
                Console.WriteLine(item);
            }
        }
        private static void NewList(string[] args)
        {
            if (args.Length < 3)
            {
                throw new ArgumentException("\n-new <list name> <language 1> <language 2> .. <langauge n>");
            }

            string name = args[0];
            string[] languages = args[1..];

            if (WordList.Exists(name))
            {
                Console.WriteLine($"This list does already exist do you want to rewrite it? Y/N");

                if (YesOrNoCheck(Console.ReadLine().ToUpper()))
                {
                    WordList wordlist = new(name, languages);
                    wordlist.Save();
                }
            }
            else
            {
                WordList wordlist = new(name, languages);
                wordlist.Save();
                Console.WriteLine($"{name} has been added as a new list!");

            }

            Console.WriteLine("Do you want to add words the list you just created? Y/N");
            if (YesOrNoCheck(Console.ReadLine().ToUpper()))
            {
                Add(new[] { name });
            }
        }
        private static void Add(string[] args)
        {
            if (args.Length != 1)
            {
                throw new ArgumentException("\n-add <listname>");
            }

            string tempUserInput = "temp";
            string name = args[0];
            WordList currentWordList = WordList.LoadList(name);

            var words = new List<string>();

            while (tempUserInput != string.Empty)
            {
                foreach (var language in currentWordList.Languages)
                {
                    Console.WriteLine($"Enter a word in {language}");
                    tempUserInput = Console.ReadLine();

                    if (tempUserInput == string.Empty) break;

                    words.Add(tempUserInput.TrimStart().TrimEnd().ToLower());
                }
                if (tempUserInput != string.Empty)
                {
                    currentWordList.Add(words.ToArray());
                    words.Clear();
                }
            }
            currentWordList.Save();
        }
        private static void RemoveWord(string[] args)
        {
            if (args.Length < 3)
            {
                throw new ArgumentException("\n-remove <list name> <language> <word 1> <word 2> .. <word n>");
            }
            string name = args[0];
            WordList currentWordList = WordList.LoadList(name);

            string language = args[1].ToLower();
            string[] wordsToRemove = args[2..];

            int languageIndex = Array.IndexOf(currentWordList.Languages, language);

            if (languageIndex < 0)
            {
                throw new KeyNotFoundException($"\nLanguage {language} was not found " +
                    "-remove <list name> <language> <word 1> <word 2> .. <word n>");
            }

            foreach (var word in wordsToRemove)
            {
                currentWordList.Remove(languageIndex, word);
                Console.WriteLine($"{word} has been removed");
            }
            currentWordList.Save();
        }
        private static void PrintWordList(string[] args)
        {
            if (args.Length != 1 && args.Length != 2)
            {
                throw new KeyNotFoundException($"\n- words < list name > < sortByLanguage > ");
            }
            string name = args[0];
            WordList currentWordList = WordList.LoadList(name);

            int sorting = 0;
            if (args.Length == 2)
            {
                string language = args[1].ToLower();
                sorting = Array.IndexOf(currentWordList.Languages, language);

                if (sorting < 0)
                {
                    throw new KeyNotFoundException($"\nLanguage {language} was not found " +
                    "- words < list name > < sortByLanguage >");
                }
            }
            Console.WriteLine(string.Join("\t", currentWordList.Languages));
            currentWordList.List(sorting, word => Console.WriteLine(string.Join("\t", word)));
        }
        static void Count(string[] args)
        {
            if (args.Length <= 0)
            {
                throw new KeyNotFoundException($"\n-count <list name>");
            }
            string name = args[0];
            WordList currentWordList = WordList.LoadList(name);

            Console.WriteLine($"there is currently {currentWordList.Count()} words in {name}");
        }
        static void Practice(string[] args)
        {
            if (args.Length <= 0)
            {
                throw new KeyNotFoundException($"\n-practice <list name>");
            }
            string name = args[0];
            WordList currentWordList = WordList.LoadList(name);

            float totalCorrectWords = 0;
            float totalAmountOfPracticedWords = 0;
            Console.WriteLine();
            Console.Write($"The list {name} has been loaded and ");
            string userInput;
            do
            {
                Word practiceWord = currentWordList.GetWordToPractice();
                string currentPracticeLanguage = currentWordList.Languages[practiceWord.FromLanguage];
                string currentPracticeWord = practiceWord.Translations[practiceWord.FromLanguage];
                string currentCorrectLanguage = currentWordList.Languages[practiceWord.ToLanguage];
                string currentCorrectWord = practiceWord.Translations[practiceWord.ToLanguage];

                Console.WriteLine($"Please translate the following words in to {currentCorrectLanguage}");
                Console.Write($"The language is {currentPracticeLanguage} and the word is {currentPracticeWord}: ");
                userInput = Console.ReadLine();

                if (totalAmountOfPracticedWords == 0 && userInput == string.Empty)
                {
                    Console.WriteLine("You didnt guess on a word dont worry better luck next time!");
                    break;
                }
                else if (userInput == currentCorrectWord)
                {
                    Console.Clear();
                    Console.WriteLine($"{currentCorrectWord.ToUpper()} is correct!");
                    totalCorrectWords++;
                    Thread.Sleep(1500);
                    Console.Clear();
                }
                else if (userInput != string.Empty)
                {
                    Console.Clear();
                    Console.WriteLine($"That was wrong the correct word is {currentCorrectWord.ToUpper()}");
                    Thread.Sleep(2500);
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine($"You practiced on {totalAmountOfPracticedWords} you were right on {totalCorrectWords / totalAmountOfPracticedWords * 100:0}% of the guesses");
                }
                totalAmountOfPracticedWords++;
            } while (userInput != string.Empty);


        }
        private static void UserMenu(string[] args)
        {
            try
            {
                if (args.Length > 0)
                {
                    string function = args[0].ToLower();
                    switch (function)
                    {
                        case "-lists":
                            PrintLists(args[1..]);
                            break;
                        case "-new":
                            NewList(args[1..]);
                            break;
                        case "-add":
                            Add(args[1..]);
                            break;
                        case "-remove":
                            RemoveWord(args[1..]);
                            break;
                        case "-words":
                            PrintWordList(args[1..]);
                            break;
                        case "-count":
                            Count(args[1..]);
                            break;
                        case "-practice":
                            Practice(args[1..]);
                            break;
                        default:
                            printHelpCommands();
                            break;
                    }
                }
                else printHelpCommands();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static void printHelpCommands()
        {
            const string helpCommands =
                "-lists" + "\n" +
                "-new <list name> <language 1> <language 2> .. <language n>" + "\n" +
                "-add <list name>" + "\n" +
                "-remove <list name> <language> <word 1> <word 2> .. <word n>" + "\n" +
                "-words <list name> <sortByLanguage>" + "\n" +
                "-count <list name>" + "\n" +
                "-practice <list name>";
            Console.WriteLine(helpCommands);
        }
        private static bool YesOrNoCheck(string answer)
        {
            do
            {
                if (answer == "Y")
                {
                    return true;
                }
                if (answer == "N")
                {
                    return false;
                }
                else
                {
                    Console.WriteLine("You have to write Y or N");
                    answer = Console.ReadLine().ToUpper();
                }
            } while (true);
        }
    }
}
