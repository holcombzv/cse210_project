public class FileHandler {
    string _fileName;
    StreamWriter _file;
    User _user;
    public FileHandler() { }
    public FileHandler(string fileName, User user) {
        _fileName = fileName;
        _user = user;
        _file = new StreamWriter(_fileName);
    }
    public void load(string fileName) {
        //Creates and fills Journal object from txt file
        string[] lines = System.IO.File.ReadAllLines(fileName);

    }
    public void save() {
        File.WriteAllText(_fileName, "");
        using(StreamWriter newSave = _file) {
            newSave.WriteLine(_user.getName());
            newSave.WriteLine(_user.getPoints());
            foreach(Goal goal in _user.getGoals()) {
                
            }
        }
    }
}