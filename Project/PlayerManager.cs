using System;
namespace MainApp
{
    
    public class PlayerManager
    {   
        public Player player;
        public PlayerManager(string playerInfoDirectory)
        {
            if(File.Exists(playerInfoDirectory))
            {
                player = JSONSaveLoad.ReadFromJsonFile<Player>(playerInfoDirectory);
            }
            else 
            {
                player = new Player();
                JSONSaveLoad.WriteToJsonFile<Player>(playerInfoDirectory, player);
            }
        }

        public void SavePlayerData()
        {
            JSONSaveLoad.WriteToJsonFile<Player>(Enums.PlayerInfoDirectory, player);
        }
    }

}


