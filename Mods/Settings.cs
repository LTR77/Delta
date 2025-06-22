using static StupidTemplate.Menu.Main;
using static StupidTemplate.Settings;

namespace StupidTemplate.Mods

{
    internal class SettingsMods
    {
        public static void EnterSettings()
        {
            buttonsType = 1;
        }

        public static void MenuSettings()
        {
            buttonsType = 2;
        }

        public static void MovementSettings()
        {
            buttonsType = 3;
        }
        public static void EnterMovement()
        {
            buttonsType = 4;
        }
        public static void EnterSymbols()
        {
            buttonsType = 5;
        }


        public static void RightHand()
        {
            rightHanded = true;
        }

        public static void LeftHand()
        {
            rightHanded = false;
        }

        public static void EnableFPSCounter()
        {
            fpsCounter = true;
        }

        public static void DisableFPSCounter()
        {
            fpsCounter = false;
        }

        public static void EnableNotifications()
        {
            disableNotifications = false;
        }

        public static void DisableNotifications()
        {
            disableNotifications = true;
        }

        public static void EnableDisconnectButton()
        {
            disconnectButton = true;
        }

        public static void DisableDisconnectButton()
        {
            disconnectButton = false;
        }
        public static void SetRainbow()
        {
            for(int i = 0;i<1;i++)
            {
                if (backgroundColor.isRainbow)
                {
                    backgroundColor.isRainbow = false;
                }
                else
                {
                    backgroundColor.isRainbow = true;
                }
            }
        }
    }
}
