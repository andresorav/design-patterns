using System;
using System.Collections.Generic;

namespace ProxyPattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            const int numberOfWordsForABook = 100;
            var aBook = GenerateABook(numberOfWordsForABook);

            var lazyBookParserProxy = new LazyBookParserProxy(aBook);

            Console.WriteLine(
                "Number of words in a book is {0} (which is {1})", 
                lazyBookParserProxy.GetNumberOfWords(),
                lazyBookParserProxy.GetNumberOfWords() == numberOfWordsForABook ? "correct" : "not correct"
            );
        }

        private static string GenerateABook(int numberOfWords)
        {
            var words = new List<string>();
            var rand = new Random();

            var letters = "abcdefghijklmnopqrstuvwxyz".ToCharArray();

            // Make the words.
            for (var i = 1; i <= numberOfWords; i++)
            {
                // Make a word.
                var word = "";
                for (var j = 1; j <= 5; j++)
                {
                    word += letters[rand.Next(0, letters.Length - 1)];
                }

                // Add the word to the list.
                words.Add(word);
            }

            return string.Join(" ", words);
        }
    }
}