using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleTest
{
    internal class TextBeautifier : IWordProcessor
    {
        public TextBeautifier(ILogger logger)
        {
            Logger = logger;
        }

        private ILogger Logger { get; }

        private string ListToString(List<string> words)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var word in words)
            {
                sb.Append(word);
                sb.Append(' ');
            }
            return sb.ToString().TrimEnd();
        }

        private string RemoveSpecialCharacters(string text)
        {
            var charsToRemove = new string[] { ".", ",", ".", ";", "'" };
            foreach (var c in charsToRemove)
            {
                text = text.Replace(c, string.Empty);
            }
            return text;
        }

        public string BeautifyText(string input)
        {
            input = RemoveSpecialCharacters(input);
            var words = input.Split(' ');
            var listOfWords = words.ToList();
            var comparer = new WordComparer();
            listOfWords.Sort(comparer);
            return ListToString(listOfWords);
        }
    }
}
