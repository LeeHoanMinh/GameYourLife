using System;
namespace MainApp
{
    public static class Enums
    {
        public static string PlayerInfoDirectory = System.IO.Directory.GetCurrentDirectory() + "\\Data\\PlayerInfo.json";
        public static readonly int[] ExperienceToPastLevel = {10, 20, 30, 40, 50, 60, 70, 80, 90, 10000};
    }
}
