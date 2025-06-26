using static GorillaX.Menu.Main;

namespace GorillaX.Mods
{
    internal class Global
    {
        public static void ReturnHome()
        {
            buttonsType = 0;
        }
        public static void EnterSymbols()
        {
            buttonsType = 5;
        }
        public static void EnterOP()
        {
            buttonsType = 6;
        }
        public static void EnterUseful()
        {
            buttonsType = 7;
        }
        public static void EnterMovement()
        {
            buttonsType = 4;
        }
        public static void EnterVisual()
        {
            buttonsType = 8;
        }
        public static void EnterFun()
        {
            buttonsType = 9;
        }
    }
}
