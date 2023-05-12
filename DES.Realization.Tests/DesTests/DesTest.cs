using DES.Realization.Lib.Algorithm;
using DES.Realization.Lib.Helper;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace DES.Realization.Tests.DesTests
{

    public class DesTest
    {
        [Theory]
        [InlineData("85E813540F0AB405", "0123456789ABCDEF", "133457799BBCDFF1")]
        [InlineData("C0999FDDE378D7ED727DA00BCA5A84EE47F269A4D64381909DD52F78F5358499828AC9B453E0E653", "596F7572206C6970732061726520736D6F6F74686572207468616E20766173656C696E650D0A0000", "0E329232EA6D0D73")]

        public void EncryptHexToHex(string expected, string input, string key)
        {
            var e = Converter.HexToBinary(input);
            var q = Converter.BinaryToString(e, Encoding.Unicode);

            Assert.Equal(key, q);



        }
    }
}
