using System;
using System.IO;
using CommandLine;
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

        public void ReceiveCommand(PlayerOptions opts)
        {
            Parser.Default.ParseArguments<InfoOption, object>(opts.Parameters)
                .WithParsed<InfoOption>(ShowPlayerInfoCallback);
        }

        public void ShowPlayerInfoCallback(InfoOption opts)
        {
            player.DisplayInfo();
        }
        public void AddPlayerActionToTask(Task task)
        {
            Console.Write("Add Task");
            task.taskDone += player.AddValuesBasedOnTask;
        }

    }


}


