public class Word{
    private string word;
    private bool hidden;

    public Word(string word)
    {
        this.word = word;
        hidden = false;
    }

    public string GetFormattedWord()
    {
        if (hidden)
        {
            return "______";
        }
        else
        {
            return word;
        }
    }
    public void Hide()
    {
        hidden = true;
    }
    public bool IsHidden()
    {
        return hidden;
    }
}