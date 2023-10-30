public class Elevator {
    private int _currentFloor;
    private int _bottomFloor;
    private int _topFloor;
    private bool _doorsOpen;
    public Elevator(int bottomFloor, int topFloor) {
        _bottomFloor = bottomFloor;
        _topFloor = topFloor;
        _currentFloor = 1;
        _doorsOpen = false;
    }
    public bool getDoorsOpen() {
        return _doorsOpen;
    }
    public void changeFloor(int newFloor) {
        _currentFloor = newFloor;
    }
    public void openDoors() {
        _doorsOpen = true;
    }
    public void closeDoors() {
        _doorsOpen = false;
    }
    public string displayFloor() {
        return $"{_currentFloor}";
    }
    public string listFloors() {
        string text = "";
        for(int i = _bottomFloor; i <= _topFloor; i ++) {
            if(i != _currentFloor) {
                text += $"{i}|";
            }
        }
        return text;
    }
}