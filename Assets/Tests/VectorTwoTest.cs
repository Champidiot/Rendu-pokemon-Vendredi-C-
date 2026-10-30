using NUnit.Framework;
using TU_Challenge;
using UnityEngine;

public class VectorTwoTest
{
    [Test]
    [TestCase (1,2, 1, 2)]
    [TestCase (-1, 3, -1,3)]
    public void CreateVector(float a, float b, float expectedX, float expectedY)
    {
        VectorTwo result = new VectorTwo(a,b);
        Assert.That(result.X, Is.EqualTo(expectedX));
        Assert.That(result.Y, Is.EqualTo(expectedY));
    }

    [Test]
    [TestCase(1, -2, 5, 2)]
    [TestCase(-1, 3, 7, 2)]
    public void CreateVectorFalse(float a, float b, float expectedX, float expectedY)
    {
        VectorTwo result = new VectorTwo(a, b);
        Assert.That(result.X, Is.Not.EqualTo(expectedX));
        Assert.That(result.Y, Is.Not.EqualTo(expectedY));
    }

    [Test]
    [TestCase (3,4,5)]
    [TestCase (1,1,1)]

    public void Magnitude(float a, float b, float expected)
    {
        VectorTwo result = new VectorTwo(a, b);
        float res = result.Magnitude();
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase (1,2,1)]
    [TestCase (2,7,90)]

    public void MagnitudeFalse(float a, float b, float expected)
    {
        VectorTwo result = new VectorTwo(a, b);
        float res = result.Magnitude();
        Assert.That(result, Is.Not.EqualTo(expected));
    }

    [Test]
    [TestCase(1, 2, 5)]
    [TestCase(2, 7, 53)]

    public void SqrMagnitude(float a, float b, float expected)
    {
        VectorTwo result = new VectorTwo(a, b);
        float res = result.sqrMagnitude();
        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    [TestCase(1, 2, 50)]
    [TestCase(2, 7, 531)]

    public void SqrMagnitudeFalse(float a, float b, float expected)
    {
        VectorTwo result = new VectorTwo(a, b);
        float res = result.sqrMagnitude();
        Assert.That(result, Is.Not.EqualTo(expected));
    }
}
