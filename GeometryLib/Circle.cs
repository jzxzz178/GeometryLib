namespace GeometryLib;

public class Circle : IGeometryFigure
{
    public double Radius { get; }
    public double Square { get; }


    public Circle(double radius)
    {
        if (radius <= 0)
            throw new ArgumentException("Радиус не может быть отрицательным");

        Radius = radius;
        Square = Math.PI * radius * radius;
    }
}