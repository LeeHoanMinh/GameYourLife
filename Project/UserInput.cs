
namespace MainApp
{
    class UserInput
    {   
        public enum UserInputSematic
        {
            DisplayUserInfo,
            AddExp,
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
                currentType = UserInputSematic.AddExp;
                break;

                default:
                currentType = UserInputSematic.None;
                break;
            }
        }
    }
}


