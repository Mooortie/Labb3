using System.IO.Enumeration;
using System.Runtime.CompilerServices;

namespace Labb3_AppFörGlosor
{
    public class Word
    {
        public string[] Translations { get; }
        public int FromLanguage { get; }
        public int ToLanguage { get; }

        public Word(params string[] translations)
        {
            Translations = translations;
        }
        public Word(int fromLanguage, int toLanguage, params string[] translations)
        {
            Translations = translations;
            FromLanguage = fromLanguage;
            ToLanguage = toLanguage;
        }
    }
}