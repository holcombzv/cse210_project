public class Word {
    private string _word;
    private string hiddenChars = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";    //List of characters to hide
    public Word(string word) {
        _word = word;
    }
    public string getWord() {
        return _word;
    }
    public void hide() {
        //Hides characters in hiddenChars that also occur in word.
        foreach(char letter in hiddenChars) {
            _word = _word.Replace(letter, '_');
        }
    }
}