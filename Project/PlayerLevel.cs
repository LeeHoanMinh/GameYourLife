using System;
using Newtonsoft.Json;
namespace MainApp
{
    [JsonObject(MemberSerialization.OptIn)]
    public class PlayerLevel
    {
        [JsonProperty] private int _currentLevel;
        public int CurrentLevel{get{return _currentLevel;}}

        [JsonProperty] private int _currentExp;
        
        public PlayerLevel()
        {
            _currentLevel = 0;
            _currentExp = 0;
        }
        public int GetCurrentLevel{get{return _currentLevel;}}
        public string GetExpExpression{get{return _currentExp.ToString() + "/" + Enums.ExperienceToPastLevel[_currentLevel];}}
        
        public void AddExp(int exp)
        {
            // Add exp for user, and if level up, do something
            _currentExp += 5;
            if(_currentExp >= Enums.ExperienceToPastLevel[_currentLevel])
            {
                LevelUp();
                Console.WriteLine("Level Up");
            }
        }

        private void LevelUp()
        {
            // Activate some actions required to thi level
            _currentExp = 0;
            _currentLevel += 1;
        }

    }
}