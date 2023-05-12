using System.Text;
using System.Text.RegularExpressions;

namespace DES.Realization.Lib.Helper;

/// <summary>
/// static class, converts string to binary code and back
/// </summary>
public static class Converter
{
    public static string StringToBinary(string input, Encoding encoding) =>
        string.Join(string.Empty,
            encoding.GetBytes(input)
            .Select(x => Convert.ToString(x, 2).PadLeft(8, '0')));

    public static string BinaryToString(string input, Encoding encoding)
    {
        byte[] Bytes = new byte[(input.Length / 8) - 1 + 1];
        for (int Index = 0; Index <= Bytes.Length - 1; Index++)
        {
            Bytes[Index] = Convert.ToByte(input.Substring(Index * 8, 8), 2);
        }
        return encoding.GetString(Bytes);
    }



    public static string StringToHex(string str, Encoding encoding)
    {
        var binaryString = StringToBinary(str, encoding);
        return BinaryToHex(binaryString);
    }

    public static string HexToString(string hexStr, Encoding encoding)
    {
        var binaryString = HexToBinary(hexStr);
        return BinaryToString(binaryString, encoding);

    }



    public static string HexToBinary(string hex)
    {
        var result = new StringBuilder();
        foreach (char c in hex)
        {
            result.Append(_hexCharacterToBinary[char.ToLower(c)]);
        }
        return result.ToString();
    }

    public static string BinaryToHex(string binary)
    {
        if (string.IsNullOrEmpty(binary))
            return binary;

        var result = new StringBuilder(binary.Length / 8 + 1);
        var mod = binary.Length % 8;
        if (mod != 0)
            binary = binary.PadLeft(((binary.Length / 8) + 1) * 8, '0');

        for (int i = 0; i < binary.Length; i += 8)
        {
            var eightBits = binary.Substring(i, 8);
            result.AppendFormat("{0:X2}", Convert.ToByte(eightBits, 2));
        }

        return result.ToString();
    }


    private static readonly Dictionary<char, string> _hexCharacterToBinary = new() {
    { '0', "0000" },
    { '1', "0001" },
    { '2', "0010" },
    { '3', "0011" },
    { '4', "0100" },
    { '5', "0101" },
    { '6', "0110" },
    { '7', "0111" },
    { '8', "1000" },
    { '9', "1001" },
    { 'a', "1010" },
    { 'b', "1011" },
    { 'c', "1100" },
    { 'd', "1101" },
    { 'e', "1110" },
    { 'f', "1111" }
    };

}
