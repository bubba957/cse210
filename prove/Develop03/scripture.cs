public class Scripture
{
    private Reference _reference ;
    private List<Word> _words = new List<Word>();
    public Scripture(Reference reference, string text)
    {
        _reference
        text = "Jesus answered, Verily, verily, I say unto thee, Except a man be born of water and of the Spirit, he cannot enter into the kingdom of God.";
    }
    public void HideRandomWords(int numberToHide)
    {

    }
    public string GetDisplayText()
    {
        return "";
    }
    public bool IsCompletelyHidden()
    {
        return true;
    }
}