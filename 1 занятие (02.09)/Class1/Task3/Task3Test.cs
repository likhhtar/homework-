using NUnit.Framework;
using static NUnit.Framework.Assert;
using static Task3.Task3;

namespace Task3;

public class Tests
{
    [Test]
    public void FTest()
    {
        That(F(0.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(0.223), Is.EqualTo(1.0).Within(1e-5));
        That(F(2.99999), Is.EqualTo(1.0).Within(1e-5));
        That(F(10000.00000001), Is.EqualTo(1.0).Within(1e-5));
        That(F(10101100.0), Is.EqualTo(1.0).Within(1e-5));
        That(F(1.0), Is.EqualTo(-1.0).Within(1e-5));
        That(F(1.99999998), Is.EqualTo(-1.0).Within(1e-5));
        That(F(7.000001), Is.EqualTo(-1.0).Within(1e-5));
        That(F(1000101001.0), Is.EqualTo(-1.0).Within(1e-5));
        That(F(10001.9898999), Is.EqualTo(-1.0).Within(1e-5));
        
        That(F(-1.0), Is.EqualTo(0.0).Within(1e-5));
        That(F(-1010.0), Is.EqualTo(0.0).Within(1e-5));
        That(F(-6.0), Is.EqualTo(0.0).Within(1e-5));
        That(F(-0.99999), Is.EqualTo(0.0).Within(1e-5));
        That(F(-7.123456), Is.EqualTo(0.0).Within(1e-5));
    }

    [Test]
    public void NumberOfDaysTest()
    {
        That(NumberOfDays(2021), Is.EqualTo(365));
        That(NumberOfDays(1500), Is.EqualTo(365));
        That(NumberOfDays(1442), Is.EqualTo(365));
        That(NumberOfDays(1300), Is.EqualTo(365));
        That(NumberOfDays(2023), Is.EqualTo(365));
        That(NumberOfDays(2020), Is.EqualTo(366));
        That(NumberOfDays(2024), Is.EqualTo(366));
        That(NumberOfDays(1600), Is.EqualTo(366));
        That(NumberOfDays(2000), Is.EqualTo(366));
        That(NumberOfDays(1344), Is.EqualTo(366));
    }

    [Test]
    public void Rotate2Test()
    {
        That(Rotate2('В', -1, -1), Is.EqualTo('З'));
        That(Rotate2('В', -1,  1), Is.EqualTo('В'));
        That(Rotate2('С', -1,  2), Is.EqualTo('З'));
        That(Rotate2('С',  1, -1), Is.EqualTo('С'));
        That(Rotate2('С',  1,  1), Is.EqualTo('Ю'));
        That(Rotate2('Ю',  1,  2), Is.EqualTo('З'));
        That(Rotate2('Ю',  2, -1), Is.EqualTo('В'));
        That(Rotate2('З',  2,  1), Is.EqualTo('С'));
        That(Rotate2('З',  2,  2), Is.EqualTo('З'));
    }

    [Test]
    public void AgeDescriptionTest()
    {
        That(AgeDescription(42), Is.EqualTo("сорок два года"));
        That(AgeDescription(20), Is.EqualTo("двадцать лет"));
        That(AgeDescription(21), Is.EqualTo("двадцать один год"));
        That(AgeDescription(25), Is.EqualTo("двадцать пять лет"));
        That(AgeDescription(40), Is.EqualTo("сорок лет"));
        That(AgeDescription(46), Is.EqualTo("сорок шесть лет"));
        That(AgeDescription(53), Is.EqualTo("пятьдесят три года"));
        That(AgeDescription(69), Is.EqualTo("шестьдесят девять лет"));
    }

    [Test]
    public void MainTest()
    {
        Main(Array.Empty<string>());
    }
}