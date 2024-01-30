// Usage
class Program
{
    static void Main(string[] args)
    {
        var morseCode = new MorseCodeTranslator();

        string wordToEncode = "BCDE";

        var encodedMessage = morseCode.TranslateToMorseCode(wordToEncode);

        Console.WriteLine($"{wordToEncode}: {encodedMessage}");
    }
}

