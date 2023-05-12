using System.Text;

namespace DES.Realization.Lib.Helper
{
    public static class KeyGeneration
    {
        
        public static string GetKey()
        {
            var dict = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', 
                '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
            var rnd = new Random();
            var str = new StringBuilder();

            for(var i = 0; i < 16; i++)
                str.Append(dict[rnd.Next(0, 16)]);

            return str.ToString();
            
        }
    }
}
