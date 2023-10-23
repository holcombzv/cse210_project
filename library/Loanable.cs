public class Loanable {
    protected bool _isCheckedIn = true;
    public void checkOut() {
        _isCheckedIn = false;
    }
    public void checkIn() {
        _isCheckedIn = true;
    }
    public virtual void Display() {
        Console.WriteLine($"Available: {_isCheckedIn}");
    }
}