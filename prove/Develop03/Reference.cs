public class Reference {
    private string _book;
    private int _chapter;
    private List<int> _verses = new List<int>();
    public Reference(string book, int chapter, int start, int end = 0) {
        //Constructor for a range of verses.
        _book = book;
        _chapter = chapter;
        addVerses(start, end);
    }
    public void addVerses(int start, int end = 0) {
        //Adds verses to reference
        if (end == 0) {
            //If only one verse:
            if (!_verses.Contains(start)) {
                _verses.Add(start);
            }
        }
        else {
            //If multiple verses:
            for (int i = start; i <= end; i++) {
                if (_verses.Contains(i) == false) {
                    _verses.Add(i);
                }
            }
        }
        _verses.Sort();
    }
    public string getBook() {
        return _book;
    }
    public int getChapter() {
        return _chapter;
    }
    public List<int> getVerses() {
        return _verses;
    }
    public string getRenderText() {
        string text = $"{_book} {_chapter}:";
        int previousVerse = -1;
        int startVerse = -1;
        int endVerse = -1;
        if(_verses.Count() > 1) {
            foreach(int verse in _verses) {
                //Iterates each int in _verses
                if(previousVerse > 0) {
                    if(verse != previousVerse + 1) {
                        //Adds section to text if there is a break in _verses
                        if(endVerse > 0) {
                            text += $"{startVerse}-{endVerse}, ";
                            startVerse = verse;
                        }
                        else {
                            text += $"{startVerse}, ";
                            startVerse = verse;
                        }
                    }
                    else {
                        endVerse = verse;
                    }
                }
                else {
                    //Only happens on first item in _verses
                    startVerse = verse;
                }
                previousVerse = verse;
                if(_verses.IndexOf(verse) + 1 == _verses.Count()) {
                    //Only happens on last item in _verses
                    if(verse == startVerse) {
                        //If only one verse:
                        text += $"{verse}";
                    }
                    else {
                        //If multiple verses:
                        text += $"{startVerse}-{verse}";
                    }
                }
            }
        }
        else {
            //If only one verse:
            text += $"{_verses[0]}";
        }
        return text;
    }
}