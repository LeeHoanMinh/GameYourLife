
namespace MainApp
{
    static class Program
    {   
        private static Player player;
        static void Main(string[] args)
        {
            player = new Player(Enums.PlayerInfoDirectory);
            UserInput userInput =  new UserInput();
            string userString;
            do
            {
                Console.Write(">>> ");
                userString = Console.ReadLine();
                userInput.CheckInput(userString);
                Navigator(userInput);
                Console.Write("\n");

            }while(userString != "exit");
        }

        private static void Navigator(UserInput userInput)
        {
            switch(userInput.currentType)
            {
                case UserInput.UserInputSematic.DisplayUserInfo:
                player.DisplayInfo();
                break;

                case UserInput.UserInputSematic.AddExp:
                player.AddExp(5);
                break;

        
            }
        }
    }
}


