using System.IO; 

public class Journal{
    private List<Entry> _entries = new List<Entry>();
    private string _author;
    private string _fileName;
    public Journal(string author, string fileName){
        _author = author;
        _fileName = fileName;
    }
    public void createFile(Journal journal) {
        using (StreamWriter outputFile = new StreamWriter(journal._fileName)) {
            outputFile.WriteLine($"{journal._author}");
        }

    }
}