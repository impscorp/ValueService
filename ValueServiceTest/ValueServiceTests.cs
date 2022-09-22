namespace ValueServiceTest;

public class ValueServiceTest
{
    [Fact]
    public void CheckPfList() 
    {
        ValueService.Lib.ValueService vs = new();
        Assert.Equal(10, vs.PostFactors.Count);
    }
    
    [Theory]
    [InlineData(-3,"m")]
    [InlineData(-6,"µ")]
    [InlineData(-9,"n")]
    [InlineData(-12, "p")]
    [InlineData(3,"k")]
    [InlineData(6,"M")]
    [InlineData(9,"G")]
    [InlineData(12, "T")]
    [InlineData(15,"P")]
    [InlineData(18, "E")]
    [InlineData(null, "x")]
    [InlineData(0, "")]
    public void getPotentzFromPostfactor(int? power, string postfactor)
    {
        ValueService.Lib.ValueService vs = new();
        Assert.Equal(power, vs.GetPotenz(postfactor));
    }
    
    [Theory]
    [InlineData(0.001, "1m")]
    [InlineData(0.000001, "1µ")]
    [InlineData(0.000000001, "1n")]
    [InlineData(0.000000000001, "1p")]
    [InlineData(100, "100")]
    [InlineData(100000, "100k")]
    [InlineData(1000000, "1M")]
    [InlineData(1000000000, "1G")]
    [InlineData(1000000000000, "1T")]
    [InlineData(1000000000000000, "1P")]
    [InlineData(0.0025, "2,5m")]
    [InlineData(0.0000025, "2.5µ")]
    [InlineData(0.0000000025, "2.5n")]
    public void CheckGetDecimalFromString(decimal result, string input)
    {
        ValueService.Lib.ValueService vs = new();
        Assert.Equal(result, vs.GetDecimal(input));
    }
    
    [Theory]
    [InlineData("1mm")]
    [InlineData("1kk")]
    [InlineData("1xx")]
    public void CheckGetDecimalExeption(string input)
    {
        ValueService.Lib.ValueService vs = new();
        Assert.Throws<FormatException>(() => vs.GetDecimal(input));
    }
    
    [Theory]
    [InlineData(0.000001, "µ")]
    [InlineData(1000, "k")]
    [InlineData(1000000, "M")]
    [InlineData(1000000000, "G")]
    [InlineData(100, "")]
    public void checkGetPostFactor(decimal input, string expected)
    {
        ValueService.Lib.ValueService vs = new();
        Assert.Equal(expected, vs.GetPostFactor(input));
    }
    
    [Theory]
    [InlineData(0.000001, 2, "µ", "1µ")]
    [InlineData(1000, 2, "k", "1k")]
    [InlineData(1000000, 2, "M", "1M")]
    [InlineData(1000000000, 2, "G", "1G")]
    [InlineData(1, 1, " ", "1")]
    [InlineData(154, 2, " ", "154")]
    public void checkGetDisplayValue(decimal value, int precision, string postfactor ,string expected)
    {
        ValueService.Lib.ValueService vs = new();
        Assert.Equal(expected, vs.GetDisplayValue(value, precision, postfactor));
    }
    
}