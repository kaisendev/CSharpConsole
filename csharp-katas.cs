using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpKatas
{
    public class CSharpKatas
    {
        static string FindNeedle(object[] haystack)
        {
            int count = 0;
            int index = 0;

            foreach (var item in haystack)
            {
                if (item is string && (string)item == "needle")
                {
                    index = count;
                }
                count++;
            }

            return $"found the needle at position {index}";
        }
        public static int GetVowelCount2(string letters)
        {
            int vowelCount = 0;
            var checkVowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            foreach (char letter in letters.ToLower())
            {
                if (checkVowels.Contains(letter))
                    vowelCount++;
            }

            return vowelCount;
        }
        static string DisEmVowel(string str)
        {
            string newText = string.Empty;
            var checkVowels = new HashSet<char> { 'a', 'e', 'i', 'o', 'u' };

            foreach (char letter in str)
            {
                if (!checkVowels.Contains(letter))
                    newText += letter;
            }

            return newText;
        }
        public static String Accum(string input)
        {
            var parts =
              // Take the string
              input
                // Turn each character to a repeated string based on it's index
                .Select((character, index) => new String(character, index + 1))
                // Then turn that string into a string where the first character is upper cased, and the rest is left alone
                .Select(subString => subString.Substring(0, 1).ToUpper() + subString.Substring(1).ToLower());

            // We will end up with everything joined by dashes     
            return String.Join("-", parts);
        }
        private static void AccumVersion1()
        {
            string s = "asR";
            char[] letters = s.ToCharArray();
            var newWord = new List<string>();
            string eachWord = string.Empty;

            for (int i = 0; i < letters.Length; i++)
            {
                //Console.WriteLine(letters[i]);
                for (int j = 0; j <= i; j++)
                {
                    eachWord += letters[i];
                }

                newWord.Add(eachWord.Substring(0, 1).ToUpper() + eachWord.Substring(1).ToLower());
                eachWord = "";
            }

            Console.WriteLine(string.Join("-", newWord));
        }
        public static void CountOccurences()
        {
            int[] numbers = new int[12] { 5, 5, 5, 7, 7, 7, 9, 7, 9, 9, 9, 1 };
            var dictionary = new Dictionary<int, int>();
            //var numbersWithFour = new List<int>();

            foreach (var number in numbers)
            {
                if (dictionary.ContainsKey(number))
                    dictionary[number]++;
                else
                    dictionary.Add(number, 1);
            }

            foreach (var val in dictionary)
            {
                if (val.Value == 4)
                {
                    Console.WriteLine(val.Key + " " + val.Value);
                }
            }
        }
    }
}
