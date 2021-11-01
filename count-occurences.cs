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