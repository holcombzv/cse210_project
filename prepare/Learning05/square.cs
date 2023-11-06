public class Square: Shape {
    double _side;
    public Square(double side) {
        _side = side;
    }
    public override double getArea() {
        double area = _side * _side;
        return area;
    }
}