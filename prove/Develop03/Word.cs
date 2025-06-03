class Word
{
    String _letters;
    bool _hidden;

    public Word(String letters)
    {
        _letters = letters;
        _hidden = false;
    }

    public void hideWord()
    {
        _hidden = true;
    }
}