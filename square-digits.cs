        public static int SquareDigits(int n)
        {
            string output = "";
            foreach (char c in n.ToString())
            {
            int square = int.Parse(c.ToString());
            output += (square * square);
            }
            return int.Parse(output);
        }
        static int SquareDigits2(int numbers)
        {
            int[] number = numbers.ToString().ToCharArray().Select(num => (int)Char.GetNumericValue(num)).ToArray();

            string strNum = string.Empty;
            int sum = 0;

            foreach (var num in number)
            {
                sum = num * num;
                strNum += sum;
            }
            return Int32.Parse(strNum);
        }
        public static int SquareDigits3(int n)
        {
            StringBuilder sb = new StringBuilder(10);
            foreach (char ch in n.ToString())
            {
                int c = (int)ch - (int)'0';
                sb.Append(c * c);
            }
            return int.Parse(sb.ToString());
        }