using System;
namespace MainApp
{
    public class Player
    {
        private PlayerLevel _playerLevel;
        public Player(string playerInfoDirectory)
        {
            // Input player info from directory storage
            _playerLevel = new PlayerLevel();
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Player");
            Console.WriteLine("Level: " + _playerLevel.CurrentLevel);
            Console.WriteLine("Exp: " + _playerLevel.GetExpExpression);
        }

        public void AddExp(int exp)
        {
            _playerLevel.AddExp(exp);
            Console.WriteLine("Exp Added!");
        }
    }
}