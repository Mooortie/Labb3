using System.IO;
using System.Text;
using System.Xml.Linq;

namespace Labb3_AppFörGlosor
{
    public class WordList
    {
        private readonly List<Word> words = new();

        private static readonly string fullPath = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Labb3 AppFörGlosor";
        
        public string Name { get; }
        public string[] Languages { get; }

        public WordList(string name, params string[] languages)
        {
            Name = name;
            Languages = languages;
        }

        public static string[] GetLists()
        {
            var fileNames = new List<string>();
            var fileObjects = new DirectoryInfo(fullPath);

            FileInfo[] files = fileObjects.GetFiles("*.dat");

            fileNames.AddRange(files.Select(f => f.Name.Replace(".dat", "")));
            
            return fileNames.ToArray();
        }
        public static bool Exists(string listName)
        {
            return GetLists().Contains(listName);
        } 
        public static WordList LoadList(string name)
        {
            string filePath = $@"{fullPath}\{name}.dat";

            using StreamReader currentFile = File.OpenText(filePath);

            var languages = currentFile.ReadLine().Split(';').SkipLast(1).ToArray();

            var loadList = new WordList(name,languages);
            while (!currentFile.EndOfStream)
            {
                string[] wordTranslations = (currentFile.ReadLine() ?? string.Empty).Split(";").SkipLast(1).ToArray();

                loadList.Add(wordTranslations);
            }

            return loadList;
        }

        public void Save()
        {
            var fileContent = new List<string>();
            var lineContent = new StringBuilder();
            using var writer = new StreamWriter(fullPath + @$"\{Name}.dat");

            Array.ForEach(Languages, s => lineContent.Append(s + ";"));

            fileContent.Add(lineContent.ToString());
            writer.WriteLine(lineContent.ToString());
            foreach (Word word in words)
            {
                writer.WriteLine(string.Join(";", word.Translations)+";");
            }
        }
        public void Add(params string[] translations)
        {
            words.Add(new(translations
                .Select(translation => translation
                    .Replace(';', ' ')
                    .ToLower())
                .ToArray()));
        }

        public bool Remove(int translation, string word)
        {
            Word findword = words.Find(w => w.Translations[translation] == word.ToLower());
            return findword != null && words.Remove(findword);
        }
        public int Count()
        {
            return words.Count;
        }
        
        public void List(int sortByTranslation, Action<string[]> showTranslations)
        {
            var sortingWords = words.OrderBy(word => word.Translations[sortByTranslation]);

            foreach(var word in sortingWords)
            {
                showTranslations(word.Translations);
            }
        }

        public Word GetWordToPractice()
        {
            var random = new Random();

            int randomFromLanguage = random.Next(0, Languages.Length);
            int randomToLanguage = random.Next(0, Languages.Length);

            while (randomFromLanguage == randomToLanguage)
            {
                randomToLanguage = random.Next(0, Languages.Length);
            }

            return new Word(randomFromLanguage, randomToLanguage, words[random.Next(0, words.Count)].Translations);
        }
        public List<Word> GetAllWords()
        {
            return words;
        } 
    }
}