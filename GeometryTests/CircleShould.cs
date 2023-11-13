using GeometryLib;

namespace GeometryTests;

[TestFixture]
public class CircleShould
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void SquareTest()
    {
        var circle1 = new Circle(1);
        var circle2 = new Circle(10);
        var expectedForSecond = Math.PI * 100;

        Assert.Multiple(() =>
        {
            Assert.That(circle1.Square, Is.EqualTo(Math.PI).Within(1e-6));
            Assert.That(circle2.Square, Is.EqualTo(expectedForSecond));
        });
    }

    [Test]
    public void ZeroRadiusTest()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var circle = new Circle(0d);
        });
    }

    [Test]
    public void NegativeRadiusTest()
    {
        Assert.Catch<ArgumentException>(() =>
        {
            var circle = new Circle(-1);
        });
    }
}