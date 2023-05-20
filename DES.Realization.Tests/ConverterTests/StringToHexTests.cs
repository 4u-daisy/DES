using DES.Realization.Lib.Helper;
using System.Text;
using Xunit;

namespace DES.Realization.Tests.ConverterTests;
public class StringToHexTests
{

    [Theory]
    [InlineData("Солнце заходило", "D0A1D0BED0BBD0BDD186D0B520D0B7D0B0D185D0BED0B4D0B8D0BBD0BE")]
    [InlineData("A", "41")]     // english
    [InlineData("А", "D090")]   // russian
    [InlineData("$пецCimв0лы нужно пр0веPить", "24D0BFD0B5D18643696DD0B230D0BBD18B20D0BDD183D0B6D0BDD0BE20D0BFD18030D0B2D0B550D0B8D182D18C")]
    [InlineData("my text", "6D792074657874")]
    [InlineData("daria daria", "6461726961206461726961")]
    [InlineData("русскую раскладку тоже нужно тестить!!", "D180D183D181D181D0BAD183D18E20D180D0B0D181D0BAD0BBD0B0D0B4D0BAD18320D182D0BED0B6D0B520D0BDD183D0B6D0BDD0BE20D182D0B5D181D182D0B8D182D18C2121")]
    public void StringToHexUTF8(string input, string expected)
    {
        var actual = Converter.StringToHex(input, Encoding.UTF8);
        Assert.Equal(expected, actual);
    }
}
