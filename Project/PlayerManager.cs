using System;
using System.IO;
namespace MainApp
{
    public class PlayerManager
    {   
        public Player player;
        public PlayerManager()
        {
            if(File.Exists(Enums.PlayerInfoDirectory))
            {
                player = JSONSaveLoad.ReadFromJsonFile<Player>(Enums.PlayerInfoDirectory);
            }
            else 
            {
                player = new Player();
                JSONSaveLoad.WriteToJsonFile<Player>(Enums.PlayerInfoDirectory, player);
            }
        }

        public void SavePlayerData()
        {
            JSONSaveLoad.WriteToJsonFile<Player>(Enums.PlayerInfoDirectory, player);
        }


    }


}


