using System;
using System.Threading;
using System.Threading.Tasks;
using CommandLine;
namespace MainApp
{
    static class Program
    {   
        private static PlayerManager playerManager;
        private static TaskManager taskManager;
    
        static void Main(string[] args)
        {
            playerManager = new PlayerManager();
            taskManager = new TaskManager();
            LinkManagersEvent();
            string userString;
            do
            {
                Console.Write(">>> ");
                userString = Console.ReadLine();
                Thread.Sleep(20); //For interrupt process not cut down the app
                var parser = new Parser(
                    with=>
                    {
                        with.EnableDashDash = true;
                    }
                );
                parser.ParseArguments<PlayerOptions, TaskOptions>(userString.Split())
                .WithParsed<PlayerOptions>(playerManager.ReceiveCommand)
                .WithParsed<TaskOptions>(taskManager.ReceiveCommand);

                playerManager.SavePlayerData();
                taskManager.SaveTaskData();
                Console.Write("\n");

            }while(userString != "exit");
        }

        public static void LinkManagersEvent()
        {
            foreach(Task task in taskManager.tasks)
            {
                task.taskDone += playerManager.player.AddValuesBasedOnTask;
            }
            taskManager.taskAdded += playerManager.AddPlayerActionToTask;
        }

    }
}


