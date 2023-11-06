public class Rectangle: Shape {
    private double _length;
    private double _width;
    public Rectangle(double length, double width) {
        _length = length;
        _width = width;
    }
    public override double getArea() {
        double area = _length * _width;
        return area;
    }
}