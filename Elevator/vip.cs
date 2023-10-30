public class Vip : Elevator {
    private string _password;
    public Vip(int bottomFloor, int  topFloor, string password) : base(bottomFloor, topFloor) {
        _password = password;
    }
    public bool enterPassword(string password) {
        bool pass = false;
        if(password == _password) {
            pass = true;
        }
        return pass;
    }
}