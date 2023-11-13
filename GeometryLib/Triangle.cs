namespace GeometryLib;

public class Triangle : IGeometryFigure
{
    private readonly List<double> _edges;
    public double A => _edges[2];
    public double B => _edges[1];
    public double C => _edges[0];
    public double Perimeter => _edges.Sum();
    public double Square { get; }
    public bool IsRectangular { get; }

    public Triangle(double a, double b, double c)
    {
        if (a <= 0 || b <= 0 || c <= 0)
            throw new ArgumentException("Сторона треугольника не может быть отрицательной");

        _edges = new List<double> { a, b, c };
        _edges.Sort();

        if (Math.Abs(Perimeter - 2 * A) < 1e-6)
            throw new ArgumentException("Сторона треугольника должна быть меньше суммы двух других");

        IsRectangular = Math.Abs(A * A - (C * C + B * B)) < 1e-6;

        Square = GetSquare();
    }

    private double GetSquare()
    {
        var halfP = (A + B + C) / 2d;
        var square = Math.Sqrt(
            halfP
            * (halfP - A)
            * (halfP - B)
            * (halfP - C)
        );

        return square;
    }
}