public class FileHandler {
    string _fileName;
    StreamWriter _file;
    User _user;
    public FileHandler() { }
    public void setFileName(string fileName) {
        _fileName = fileName;
    }
    public void setUser(User user) {
        _user = user;
    }
    public void load(string fileName) {
        //Creates and fills Journal object from txt file
        string[] lines = System.IO.File.ReadAllLines(fileName);

    }
    public void save(string fileName) {
        _fileName = fileName;
        string path = $"{_fileName}.txt";
        File.WriteAllText(_fileName, "");
        _file = new StreamWriter(_fileName);
        using(StreamWriter save = new StreamWriter(_fileName)) {
            save.WriteLine(_user.getName());
            save.WriteLine(_user.getPoints());
            foreach(Goal goal in _user.getGoals()) {
                save.WriteLine(goal.save());
            }
        }
    }
}