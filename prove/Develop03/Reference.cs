class Reference
{
    String _book;
    int _chapter;
    int _verseStart;
    int _verseEnd;

    public Reference(String book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }
    public Reference(String book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
        _verseEnd = verse;
    }

    public Reference(String referenceString)
    {
        
    }
}