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
        public static void AccumV2()
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