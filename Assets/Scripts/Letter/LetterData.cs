using System;

public enum ELetterType
{
    Question,
    Response
}

[Serializable]
public class LetterData
{
    public ELetterType type; //question technique : utiliser un bool fonctionnerait-il de la meme maniere (dans l'usage qu'on en fait la) ?
    public int groupLetter; // correspond à un ID de groupe de lettre. Pour stocker le texte de 3 lettres qui partiront ensemble il faut soit "1 LetterData avec 3 variables text dedans" soit "3 LetterData liées par un même groupLetter, mais qu'il faut alors identifier un identifiant d'ordre" <- je suis parti sur le choix 1 mais j'ai peut-être mal analysé la situation
    public int loveLevel;
    public string text0, text1, text2;

    public LetterData(ELetterType type, int groupLetter, int loveLevel, string text0, string text1, string text2)
    {
        this.type = type;
        this.groupLetter = groupLetter;
        this.loveLevel = loveLevel;
        this.text0 = text0;
        this.text1 = text1;
        this.text2 = text2;
    }
}