class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(string book, int chapter, int verse, string text)
    {
        _reference = new Reference(book, chapter, verse);
        _words = new List<Word>();

        string[] splitText = text.Split(' ');
        foreach (string word in splitText)
        {
            _words.Add(new Word(word));
        }

    }

    public void Display()
    {
        Console.WriteLine($"{_reference}:");
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
                Console.Write(new string('_', word.GetText().Length) + " ");
            }
            else
            {
                Console.WriteLine(word.GetText() + " ");
            }
        }
    }
    public bool HideRandomWord()
    {
        List<Word> visableWords = GetVisableWords();
        if (visableWords.Count < 2)
        {
            return false;
        }
        Random random = new Random();
        int randomIndex1 = random.Next(visableWords.Count);
        int randomIndex2;

        do
        {
            randomIndex2 = random.Next(visableWords.Count);
        }
        while (randomIndex1 == randomIndex2);
        visableWords[randomIndex1].Hide();
        visableWords[randomIndex2].Hide();
        return true;
    }
    private List<Word> GetVisableWords()
    {
        List<Word> visableWords = new List<Word>();
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                visableWords.Add(word);
        }
        return visableWords;
    }
}