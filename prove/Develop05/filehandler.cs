public class FileHandler {
    string _fileName;
    User _user;
    public FileHandler() { }
    public void setFileName(string fileName) {
        _fileName = fileName;
    }
    public void setUser(User user) {
        _user = user;
    }
    public void load()
    {
        // Sets filename to load from based on the username
        _fileName = $"{_user.getName()}.txt";

        if (System.IO.File.Exists(_fileName))
        {
            // Loads goals and points from txt file
            _user.setGoals(new List<Goal>{}); // Resets the current list of goals

            string[] linesRaw = System.IO.File.ReadAllLines(_fileName); // Creates array of each line in the file
            List<string> lines = new List<string>(); // Converts array to list
            foreach(string item in linesRaw)
            {
                lines.Add(item);
            }

            // Sets the username and points then removes them from lines
            _user.setName(lines[0]);
            _user.setPoints(int.Parse(lines[1]));
            lines.RemoveAt(0);
            lines.RemoveAt(0);

            // Iterates through each remaining line, determines its goal type, then creates the proper goal and adds it to the users goals
            foreach(string line in lines)
            {
                String[] items = line.Split('|');
                switch(items[0])
                {
                    case "simple":
                        Goal goalSimple = new SimpleGoal(items[1], int.Parse(items[2]), bool.Parse(items[3]));
                        _user.addGoal(goalSimple);
                        break;
                    case "eternal":
                        Goal goalEternal = new EternalGoal(items[1], int.Parse(items[2]));
                        _user.addGoal(goalEternal);
                        break;
                    case "checklist":
                        Goal goalChecklist = new ChecklistGoal(items[1], int.Parse(items[2]), int.Parse(items[3]), int.Parse(items[4]), bool.Parse(items[5]), int.Parse(items[6]));
                        _user.addGoal(goalChecklist);
                        break;
                }
            }
        }
        else
        {
            // If the file does not exist, create a new file
            System.IO.File.Create(_fileName).Close();
        }
    }
    public void save() {
        // Saves user attributes to txt file
        File.WriteAllText(_fileName, ""); // Empties file
        using(StreamWriter save = new StreamWriter(_fileName)) {
            // Saves the user's name and points
            save.WriteLine(_user.getName());
            save.WriteLine(_user.getPoints());

            // iterates through each goal and saves it to the next line in the txt file
            foreach(Goal goal in _user.getGoals()) {
                save.WriteLine(goal.saveGoal());
            }
        }
    }
}