namespace MathTests;

using System;
//using XUnit;
using Math;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        var actual = Class1.Add(1, 3);
        Assert.Equal(4, actual);
    }
}