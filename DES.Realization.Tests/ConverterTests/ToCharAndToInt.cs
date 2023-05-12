using System.Text;
using Xunit;

namespace DES.Realization.Tests.ConverterTests
{
    public class ToCharAndToInt
    {
        [Theory]
        [InlineData(112, 'p')]  // englist
        [InlineData(1088, 'р')] // russian
        [InlineData(100, 'd')] 
        [InlineData(97, 'a')]
        [InlineData(1092, 'ф')]
        [InlineData(64, '@')]

        public void IntToChar(int input, char expected)
        {
            var actual = (char)input;
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData("pa @", $"112\b97\b\t\b64\b")]
        [InlineData("ф@@ р", $"1092\b64\b64\b\t\b1088\b")]
        public void StringToChar(string input, string expected)
        {
            var actual = new StringBuilder();
            for(var i = 0; i < input.Length; i++)
            {
                var t = input[i] == ' ' ? $"\t" : (int)input[i] + $"\b";
                actual.Append(input[i] == ' ' ? $"\t" + "\b" : (int)input[i] + $"\b");
            }
            var r = actual.ToString();
            Assert.Equal(expected, r);
        }

        [Theory]
        [InlineData("pa @", $"112\b97\b\t\b64\b")]
        [InlineData("ф@@ р", $"1092\b64\b64\b\t\b1088\b")]
        public void CharToString(string expected, string input)
        {
            var actual = new StringBuilder();
            var tmp = input.Split('\b');
            for (var i = 0; i < input.Length; i++)
            {
                if (tmp[i] == "\t")
                {
                    actual.Append(" ");
                    continue;
                }
                else if (tmp[i] == "")
                    break;
                var e = int.Parse(tmp[i]);
                actual.Append((char)e);
            }
            var r = actual.ToString();
            Assert.Equal(expected, r);
        }

        [Theory]
        [InlineData("pa @", $"112\b97\b\t\b64\b")]
        [InlineData("ф@@ р", $"1092\b64\b64\b\t\b1088\b")]
        public void HEXToString(string expected, string input)
        {
            var actual = new StringBuilder();
            var tmp = input.Split('\b');
            for (var i = 0; i < input.Length; i++)
            {
                if (tmp[i] == "\t")
                {
                    actual.Append(" ");
                    continue;
                }
                else if (tmp[i] == "")
                    break;
                var e = int.Parse(tmp[i]);
                actual.Append((char)e);
            }
            var r = actual.ToString();
            Assert.Equal(expected, r);
        }
    }
}
