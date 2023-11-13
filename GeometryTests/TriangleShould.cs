﻿using GeometryLib;

namespace GeometryTests;

[TestFixture]
public class TriangleShould
{
    [SetUp]
    public void Setup()
    {
    }

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
        var triangle = new Triangle(3, 3, 2);
        var expected = 0.5 * 2 * Math.Sqrt(8);
        Assert.That(triangle.Square, Is.EqualTo(expected).Within(1e-6));
    }

    [Test]
    public void TriangleIsRectangular()
    {
        var triangle1 = new Triangle(3, 4, 5);
        var triangle2 = new Triangle(3, 3, 2);

        Assert.Multiple(() =>
        {
            Assert.That(triangle1.IsRectangular, Is.EqualTo(true));
            Assert.That(triangle2.IsRectangular, Is.EqualTo(false));
        });
    }
}