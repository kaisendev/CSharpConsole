        public static string ToCamelCase(string str)
        {
            //var newStr = Regex.Split(str, @"[-|_]");
            var newStr2 = str.Split(new char[] { '_', '-' });
            StringBuilder sb = new StringBuilder();

            foreach (var item in newStr2)
            {
                sb.Append(item.Substring(0, 1).ToUpper() + item.Substring(1));
            }
            return sb.ToString();
        }

        public static string ToCamelCase2(string str)
        {
            //var newStr = Regex.Split(str, @"[-|_]");
            var newStr2 = str.Split(new char[] { '_', '-' });
            var newVal = string.Empty;

            foreach (var item in newStr2)
            {
                newVal += item.Substring(0, 1).ToUpper() + item.Substring(1);
            }

            //return string.Join("", newStr2);
            return newVal;
        }


        public static string ToCamelCase3(string str)
        {
            return string.Concat(str.Split('-','_').Select((s, i) => i > 0 ? char.ToUpper(s[0]) + s.Substring(1) : s));
        }

        public static string ToCamelCase4(string str)
        {
            //use using System.Globalization;
            var words = str.Split('-','_');
            for (int i = 1; i < words.Length; i++)
            {
              words[i] = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(words[i]);
            }
            return String.Join("", words);
        }

        public static string ToCamelCase5(string str)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
            if (str[i] != '-' && str[i] != '_') sb.Append(str[i]);
            else sb.Append(char.ToUpper(str[++i]));
            }
            return sb.ToString();
        }

        public static string ToCamelCase6(string str)
        {
            return str
            .Split('_', '-')
            .Aggregate((result, word) => {
                result += char.ToUpper(word[0]) + word.Substring(1);
                return result;
            });
        }

        public static string ToCamelCase7(string str)
        {
            string s = "";
            for (int i = 0; i < str.Length; ++i)
            {
                if (str[i] == '-' || str[i] == '_')
                {
                    s += Char.ToUpper(str[i + 1]);
                    i++;
                }
                else
                {
                    s += str[i];
                }
            }
            return s;
        }