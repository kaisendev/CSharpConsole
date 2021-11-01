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