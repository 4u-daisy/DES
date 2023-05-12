using DES.Realization.Lib.Helper;
using System.Text;
using Xunit;

namespace DES.Realization.Tests.ConverterTests;
public class HexToStringTests
{
    [Theory]
    [InlineData("D0A1D0BED0BBD0BDD186D0B520D0B2D181D182D0B0D0BBD0BE", "Солнце встало")]
    public void HexToString(string input, string expected)
    {
        var actual = Converter.HexToString(input, Encoding.UTF8);
        Assert.Equal(expected, actual);
    }
}
