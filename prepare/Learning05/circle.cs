public class Circle: Shape {
    private double _radius;
    public Circle(double radius) {
        _radius = radius;
    }
    public override double getArea()
    {
        double area = 3.1415926 * _radius * _radius;
        return area;
    }
}