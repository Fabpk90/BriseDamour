public enum ELetterType
{
    Question,
    Response
}

public class LetterData
{
    public ELetterType type;
    public int groupLetter;
    public int loveLevel;
    public string text;

    public LetterData(ELetterType type, int groupLetter, int loveLevel, string text)
    {
        this.type = type;
        this.groupLetter = groupLetter;
        this.loveLevel = loveLevel;
        this.text = text;
    }
}