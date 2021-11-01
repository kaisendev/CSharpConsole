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