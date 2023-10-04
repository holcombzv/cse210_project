public class Entry{
    private string _date;
    private Prompt _prompt;
    private string _response;

    public Entry(string date, Prompt prompt, string response){
        _date = date;
        _prompt = prompt;
        _response = response;
    }
}