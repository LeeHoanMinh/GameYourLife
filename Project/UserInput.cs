
namespace MainApp
{
    class UserInput
    {   
        public enum UserInputSematic
        {
            DisplayUserInfo,
            AddExp,
            AddTask,
            ShowTask,
            None
        }
        public UserInputSematic currentType;
        public void CheckInput(string usrString)
        {
            switch(usrString)
            {
                case "info":
                currentType = UserInputSematic.DisplayUserInfo;
                break;

                case "add":
                currentType = UserInputSematic.AddTask;
                break;

                case "show":
                currentType = UserInputSematic.ShowTask;
                break;
                default:
                currentType = UserInputSematic.None;
                break;
            }
        }
    }
}


