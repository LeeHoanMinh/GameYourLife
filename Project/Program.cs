using System;
namespace MainApp
{
    static class Program
    {   
        private static PlayerManager playerManager;
        static void Main(string[] args)
        {
            playerManager = new PlayerManager(Enums.PlayerInfoDirectory);
            UserInput userInput = new UserInput();
            string userString;
            do
            {
                Console.Write(">>> ");
                userString = Console.ReadLine();
                userInput.CheckInput(userString);
                Navigator(userInput);
                playerManager.SavePlayerData();
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
            }
        }

    }
}


