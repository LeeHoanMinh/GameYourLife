using System;
using System.IO;
using Newtonsoft.Json;

namespace MainApp
{
    public class Player
    {
        [JsonProperty] private PlayerLevel _playerLevel;
        [JsonProperty] private int _playerDiamonds;
        public Player()
        {
            //Input player info from directory storage
            _playerLevel = new PlayerLevel();
            _playerDiamonds = 0;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Player");
            Console.WriteLine("Level: " + _playerLevel.CurrentLevel);
            Console.WriteLine("Exp: " + _playerLevel.GetExpExpression);
            Console.WriteLine("Diamond: " + _playerDiamonds);
        }

        public void AddExp(int exp)
        {
            _playerLevel.AddExp(exp);
            Console.WriteLine("Exp Added!");
        }
    }
}