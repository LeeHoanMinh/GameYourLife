using System;
using System.Threading;
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
            UserInput userInput = new UserInput();
            string userString;
            do
            {
                Console.Write(">>> ");
                userString = Console.ReadLine();
                Thread.Sleep(20);
                userInput.CheckInput(userString);
                Navigator(userInput);
                playerManager.SavePlayerData();
                taskManager.SaveTaskData();
                Console.Write("\n");

            }while(userString != "exit");
        }
    
        private static void Navigator(UserInput userInput)
        {
            switch(userInput.currentType)
            {
                case UserInput.UserInputSematic.DisplayUserInfo:
                playerManager.player.DisplayInfo();
                break;

                case UserInput.UserInputSematic.AddExp:
                playerManager.player.AddExp(5);
                break;

                case UserInput.UserInputSematic.AddTask:
                taskManager.AddTask(new Task(0, 2, "Readbook", 1, true));
                break;

                case UserInput.UserInputSematic.ShowTask:
                taskManager.ShowTask();
                break;   
            }
        }

    }
}


