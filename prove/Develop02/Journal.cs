using System.IO; 

public class Journal{
    public List<Entry> _entries = new List<Entry>();
    public string _author;
    public string _fileName;
    public Journal(string author, string fileName){
        _author = author;
        _fileName = fileName;
    }
    public void createFile(Journal journal) {
        //Creates txt file to save journal to
        using (StreamWriter outputFile = new StreamWriter(journal._fileName)) {
            outputFile.WriteLine($"{journal._author}");
        }
    }

    public void addEntry(Journal journal, Entry entry) {
        journal._entries.Add(entry);
    }
}