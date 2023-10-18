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
            if (_verses.Contains(start) == false) {
                _verses.Add(start);
            }
        }
        else {
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
}