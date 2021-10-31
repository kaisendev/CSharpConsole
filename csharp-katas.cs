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