using DES.Realization.Lib.Helper;
using System.Text;

namespace DES.Realization.Lib.Algorithm;

public class Des
{
    private const int QuantityOfRounds = 16;
    private const int BlockSize = 64;

    public string[] RoundsXor { get; private set; } = new string[QuantityOfRounds];


    private delegate string CipherOperation(string text, string key);

    /// <summary>
    /// 
    /// </summary>
    /// <param name="text">HEX</param>
    /// <param name="key">HEX</param>
    /// <param name="encrypt"></param>
    /// <returns></returns>
    public string Cipher(string text, string key, bool encrypt = true)
    {
        text = Converter.HexToBinary(text);
        var messages = GetMessage(text);
        key = Converter.HexToBinary(key);
        var keys = GenerateKeys(key);

        if (!encrypt)
            keys = keys.Reverse().ToArray();

        var result = new StringBuilder();

        for (var j = 0; j < messages.Count(); j++)
        {
            messages[j] = Permute(EncryptionScheme.IP, messages[j]);

            var Ls = new string[17];
            var Rs = new string[17];
            Ls[0] = messages[j].Substring(0, 32);
            Rs[0] = messages[j].Substring(32);

            for (var i = 1; i < 17; i++)
            {
                Ls[i] = Rs[i - 1];
                Rs[i] = Xor(Ls[i - 1], F(Rs[i - 1], keys[i - 1]));
                RoundsXor[i - 1] = Xor(Ls[i], Rs[i]);
            }

            var L16R16 = Rs[16] + Ls[16];
            var answerBinary = Permute(EncryptionScheme.FP, L16R16);
            result.Append(Converter.BinaryToHex(answerBinary));
        }

        return result.ToString();
    }


    private string[] GetMessage(string text)
    {
        var countBlocks = (int)Math.Ceiling(1.0 * text.Length / BlockSize);
        var blocks = new string[countBlocks];
        text = text.PadRight(countBlocks*BlockSize, '0');
        for(var i = 0; i < countBlocks; i++)
            blocks[i] = text.Substring(i * BlockSize, BlockSize);


        return blocks;
    }

    public string F(string rn, string kn)
    {
        var permuteRes = Permute(EncryptionScheme.EP, rn);
        var xorResult = Xor(kn, permuteRes);
        var sBoxResult = Sbox(xorResult);

        return Permute(EncryptionScheme.P, sBoxResult);
    }


    /// <summary>
    /// generate keys by binary key
    /// </summary>
    /// <param name="key">binary string</param>
    /// <returns>keys</returns>
    private string[] GenerateKeys(string key)
    {
        key = Permute(EncryptionScheme.KP1, key);

        var C0 = key.Substring(0, 28);
        var D0 = key.Substring(28, 28);

        var Cs = new string[17];
        var Ds = new string[17];
        Cs[0] = C0;
        Ds[0] = D0;
        for (var i = 1; i < 17; i++)
        {
            Cs[i] = LeftCircularShift(Cs[i - 1], EncryptionScheme.KeyShifts[i - 1]);
            Ds[i] = LeftCircularShift(Ds[i - 1], EncryptionScheme.KeyShifts[i - 1]);
        }
        var CD = new string[16];
        for (var i = 0; i < 16; i++)
        {
            CD[i] = Cs[i + 1] + Ds[i + 1];
        }

        var keys = new string[16];
        for (var i = 0; i < 16; i++)
        {
            keys[i] = Permute(EncryptionScheme.KP2, CD[i]);
        }
        return keys;
    }


    /// <summary>
    /// xor operation
    /// </summary>
    /// <param name="a">string</param>
    /// <param name="b">string</param>
    /// <returns>result xor</returns>
    /// <exception cref="ArgumentException"></exception>
    private string Xor(string a, string b)
    {
        if (a.Length != b.Length)
            throw new ArgumentException("Different len");
        var result = new StringBuilder();
        for (var i = 0; i < a.Length; i++)
            result.Append(Convert.ToInt32(a[i].ToString()) ^
                          Convert.ToInt32(b[i].ToString()));

        return result.ToString();
    }

    private string Sbox(string input)
    {
        var binBase = 2;
        var blockSize = 6;
        var newBlockSize = 4;
        var res = new StringBuilder();

        for (var i = 0; i < input.Length; i += blockSize)
        {
            var temp = input.Substring(i, blockSize);

            var num = i / blockSize;
            var row = Convert.ToInt32(temp[0] + "" + temp[blockSize - 1], binBase);
            var col = Convert.ToInt32(temp.Substring(1, 4), binBase);

            var newBlock = Convert.ToString(EncryptionScheme.SBox[num][row][col], binBase).PadLeft(newBlockSize, '0');

            res.Append(newBlock);
        }

        return res.ToString();
    }

    private string Permute(int[] sequence, string input)
    {
        var res = new StringBuilder(sequence.Length);
        for (var i = 0; i < sequence.Length; ++i)
        {
            res.Append(input[sequence[i] - 1]);
        }
        return res.ToString();
    }

    private string LeftCircularShift(string key, int shift)
    {
        shift %= key.Length;
        return key[shift..] + key[..shift];
    }

}