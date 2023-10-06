using System.Collections.Generic;

public class Prompt{
    public List<string> _prompts = new List<string>();

    public string selectRandom() {
        //Returns a random entry in _prompts
        var random = new Random();
        int index = random.Next(_prompts.Count);
        return _prompts[index];
    }
}