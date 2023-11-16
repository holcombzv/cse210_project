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
    public void save(string fileName = _fileName) {
        _fileName = fileName;
        string path = $"{_fileName}.txt";
        if(File.Exists(path)) {
             _file = new StreamWriter(_fileName);
        }
        File.WriteAllText(_fileName, "");
        using(StreamWriter save = _file) {
            save.WriteLine(_user.getName());
            save.WriteLine(_user.getPoints());
            foreach(Goal goal in _user.getGoals()) {
                save.WriteLine(goal.list());
            }
        }
    }
}