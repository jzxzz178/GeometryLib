using GeometryLib;

namespace GeometryTests;

[TestFixture]
public class TriangleShould
{
    [SetUp]
    public void Setup()
    {
        _isoscelesTriangle = new Triangle(3, 3, 2);
    }

    private Triangle _isoscelesTriangle;


    [Test]
    public void TriangleExists()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var triangle = new Triangle(3, 3, 6);
        });
    }

    [Test]
    public void TriangleDoesntHaveEdgesUnderZero()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var triangle = new Triangle(0, 1, 2);
        });
    }

    [Test]
    public void TriangleSquare()
    {
        var expected = 0.5 * 2 * Math.Sqrt(8);
        Assert.That(_isoscelesTriangle.Square, Is.EqualTo(expected).Within(1e-6));
    }

    [Test]
    public void TriangleIsRectangular()
    {
        var triangle = new Triangle(3, 4, 5);

        Assert.Multiple(() =>
        {
            Assert.That(triangle.IsRectangular, Is.EqualTo(true));
            Assert.That(_isoscelesTriangle.IsRectangular, Is.EqualTo(false));
        });
    }
}