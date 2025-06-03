class Scripture
{
    Reference _scriptureReference;
    List<Word> _scriptureVerse;
    private string v;

    public Scripture(List<Word> scriptureVerse, Reference scriptureReference)
    {
        _scriptureReference = scriptureReference;
        _scriptureVerse = scriptureVerse;
    }

    public Scripture()
    {
        _scriptureReference = null;
        _scriptureVerse = [];
    }

    public void AddReference(String scriptureVerse, Reference scriptureReference)
    {
        _scriptureReference = scriptureReference;

        List<String> _scriptureVerse= [.. scriptureVerse.Split(" ")];
    }
}