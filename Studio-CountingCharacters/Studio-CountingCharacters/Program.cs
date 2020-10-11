using System;
using System.Collections.Generic;

namespace Studio_CountingCharacters
{
    class Program
    {
        private static string quote = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
        static char[] quoteChars = quote.ToCharArray();
        static Dictionary<char, int> charDictionary = new Dictionary<char, int>();
        public static Dictionary<char, int> CharCounterMethod(char[] charArray)
        {
            

            foreach(char chars in charArray)
            {
                if (!charDictionary.ContainsKey(chars))
                {
                    charDictionary.Add(chars, 1);
                }
                else
                {
                    charDictionary[chars]++;
                }
            };
            return charDictionary;
        }


        static void Main(string[] args)
        {

            CharCounterMethod(quoteChars);
            foreach (KeyValuePair<char, int> a in charDictionary)
            {
                Console.WriteLine(a.Key + ": " + a.Value);
            }
        }
    }
}
