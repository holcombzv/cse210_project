public class Scripture {
    private Reference _reference;
    private List <Verse> _verses = new List <Verse>();
    public Scripture() {}
    public Scripture(Reference reference, List<Verse> verses) {
        _reference = reference;
        _verses = verses;
    }
    public void setVerses(List<Verse> verses) {
        _verses = verses;
    }
    public string getRenderText() {
        string text = "";
        text += $"{_reference.getRenderText()}";
        foreach(Verse verse in _verses) {
            text += $"\n{verse.getRenderText()}";
        }
        return text;
    }
    public bool isHidden() {
        bool isHidden = true;
        foreach(Verse verse in _verses) {
            if(verse.getWordsLeft() > 1) {
                isHidden = false;
            }
        }
        return isHidden;
    }
    public void hide(int num = 1) {
        foreach(Verse verse in _verses) {
            verse.hideWords(num);
        }
    }
}