class Menu
{
    List<Scripture> _scriptures;

    public Menu(List<Scripture> scriptures)
    {
        _scriptures = scriptures;
    }

    public Menu()
    {
        _scriptures = [];
    }

    private List<Scripture> AddScripture(Scripture scripture)
    {
        _scriptures.Append(scripture);
        return _scriptures;
    }

    public void AddVerse(String verse)
    {
        Console.WriteLine("What is the reference for your verse? \n Enter as Book Chapter:VerseStart-VerseEnd");
        String ReferenceString = Console.ReadLine();
        List<String> SplitBook = [.. ReferenceString.Split(" ")];
        if (SplitBook.Count > 2)
        {
            SplitBook[0] = $"{SplitBook[0]} {SplitBook[1]}";
            SplitBook.RemoveAt(1);
        }
        List<String> SplitChapter = [.. SplitBook[1].Split(":")];
        List<String> SplitVerse = [.. SplitChapter[1].Split("-")];
        Reference reference = new Reference(SplitVerse[0], 1, 2, 3);
    } 
}