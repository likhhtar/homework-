using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task2.Task2;

namespace Task2;

public class Tests
{
    [Test]
    public void Min3Test1()
    {
        That(Min3(2, 0, 3), Is.EqualTo(0));
    }

    [Test]
    public void Min3Test2()
    {
        That(Min3(2000000, 100000000, 700000), Is.EqualTo(700000));
    }

    [Test]
    public void Min3Test3()
    {
        That(Min3(-17, -20, -19), Is.EqualTo(-20));
    }

    [Test]
    public void Max3Test1()
    {
        That(Max3(10, 15, 4), Is.EqualTo(15));
    }

    [Test]
    public void Max3Test2()
    {
        That(Max3(2000000, 1234567, 30000000), Is.EqualTo(30000000));
    }

    [Test]
    public void Max3Test3()
    {
        That(Max3(-5, -10, 4), Is.EqualTo(4));
    }

    [Test]
    public void Deg2RadTest1()
    {
        That(Deg2Rad(180.0), Is.EqualTo(Math.PI).Within(1e-5));
        That(Deg2Rad(2 * 360 + 180.0), Is.EqualTo(5 * Math.PI).Within(1e-5));
    }

    [Test]
    public void Rad2DegTest1()
    {
        That(Rad2Deg(Math.PI), Is.EqualTo(180.0).Within(1e-5));
        That(Rad2Deg(5 * Math.PI), Is.EqualTo(5 * 180.0).Within(1e-5));
    }
    
    [Test]
    public void MoreRadDegTests()
    {
        That(Deg2Rad(90.0), Is.EqualTo(0.5 * Math.PI).Within(1e-5));
        That(Deg2Rad(45.0), Is.EqualTo(0.25 * Math.PI).Within(1e-5));
        That(Deg2Rad(3 * 360 + 120.0), Is.EqualTo(6.666666 * Math.PI).Within(1e-5));
        That(Deg2Rad(340.0), Is.EqualTo(Math.PI * 17 / 9).Within(1e-5));
        That(Deg2Rad(107.5), Is.EqualTo(Math.PI * 107.5 / 180).Within(1e-5));
        That(Rad2Deg(0.5 * Math.PI), Is.EqualTo(90.0).Within(1e-5));
        That(Rad2Deg(0.25 * Math.PI), Is.EqualTo(45.0).Within(1e-5));
        That(Rad2Deg(6.66666667 * Math.PI), Is.EqualTo(3 * 360 + 120.0).Within(1e-5));
        That(Rad2Deg(Math.PI * 17 / 9), Is.EqualTo(340.0).Within(1e-5));
        That(Rad2Deg(Math.PI * 107.5 / 180), Is.EqualTo(107.5).Within(1e-5));
    }
}