public static int GetVowelCount(string letters)
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