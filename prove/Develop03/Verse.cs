public class Verse {
    private List<Word> _words = new List<Word>();
    private List<int> _wordsLeft = new List<int>();
    private int _num;
    public Verse(int num){
        _num = num;
    }
    public Verse(int num, List<Word> words) {
        _num = num;
        _words = words;
        _wordsLeft = new List<int>();
        for(int index = 0; index <= words.Count(); index++) {
            _wordsLeft.Add(index);
        }
    }
    public int getWordsLeft() {
        return _wordsLeft.Count();
    }
    public string getRenderText() {
        string text = $"{_num}. ";
        foreach(Word word in _words) {
            text += $"{word.getWord()} ";
        }
        return text;
    }
    public void hideWords(int num) {
        Random random = new Random();
        int word = new int();
        for(int i = 1; i <= num & i < this.getWordsLeft(); i++) {
            //Picks a random entry from list of indexes of remaining words and hides the seleted word.
            word = _wordsLeft[random.Next(1, _wordsLeft.Count())];
            _words[word - 1].hide();
            _wordsLeft.Remove(word);
        }
    }
}