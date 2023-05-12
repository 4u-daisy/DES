using System.Text.Json;

namespace DES.Realization.Lib.Helper;
public static class Config
{
    public static string Constans = "Constans";

    public static int BlockSize { get; set; }
    public static int QuantityOfRounds { get; set; }
}
