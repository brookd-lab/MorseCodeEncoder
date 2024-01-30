class MorseCodeTranslator
{
    const string separator = "/";

    private readonly Dictionary<char, string> morseCode = new Dictionary<char, string>()
    {
        {'A', ".-"},
        {'B', "-..."},
        {'C', "-.-."},
        {'D', "-.."},
        {'E', "."},
        {'F', "..-."},
        {'G', "--."},
        {'H', "...."},
        {'I', ".."},
        {'J', ".---"},
        {'K', "-.-"},
        {'L', ".-.."},
        {'M', "--"},
        {'N', "-."},
        {'O', "---"},
        {'P', ".--."},
        {'Q', "--.-"},
        {'R', ".-."},
        {'S', "..."},
        {'T', "-"},
        {'U', "..-"},
        {'V', "...-"},
        {'W', ".--"},
        {'X', "-..-"},
        {'Y', "-.--"},
        {'Z', "--.."},
    };

    public string TranslateToMorseCode(string word)
    {
        var encodedMessage = "";

        word = word.ToUpper(); 

        foreach (var ch in word)
        {
            if (morseCode.ContainsKey(ch))
            {
                encodedMessage += morseCode[ch] + separator;
            }
            else
            {
                throw new Exception($"Error, MorseCodeDecoder: The character {ch} does not exist");
            }
        }

        encodedMessage = encodedMessage.Trim();

        return encodedMessage;
    }
}

