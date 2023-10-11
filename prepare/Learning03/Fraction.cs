public class Fraction {
    private float _top;
    private float _bottom;
    
    public Fraction() {
        _top = 1;
        _bottom = 1;
    }
    public Fraction(float top) {
        _top = top;
        _bottom = 1;
    }
    public Fraction(float top, float bottom) {
        _top = top;
        _bottom = bottom;
    }

    public void SetTop(float top) {
        _top = top;
    }
    public float GetTop() {
        return _top;
    }

    public void SetBottom(float bottom) {
        _bottom = bottom;
    }
    public float GetBottom() {
        return _bottom;
    }

    public string GetFractionString() {
        string fraction = $"{_top}/{_bottom}";
        return fraction;
    }

    public float GetDecimalValue() {
        return (_top / _bottom);
    }
}