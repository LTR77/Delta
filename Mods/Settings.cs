using System.Collections.Generic;
using UnityEngine;
using static GorillaX.Menu.Main;
using static GorillaX.Settings;

namespace GorillaX.Mods


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
            for (int i = 0; i < 1; i++)
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
namespace GorillaX.Classes
{
    internal class ColorCustom
    {
        public static string ColorString = "Fade Color";
        public static Color UseableColor = Color.red;
        public static Color TempUseableColor = Color.red;
        public static void ChangeFaidToColorMod()
        {
            Color[] colors = { Color.red, Color.green, Color.blue, Color.yellow, Color.cyan, Color.magenta };

            int ColorCycler = 0;
            ColorCycler++;
            UseableColor = colors[ColorCycler];

            if(UseableColor == Color.red) 
            {
                ColorString = "red";
            }
            else if (UseableColor == Color.green)
            {
                ColorString = "green";
            }
            else if (UseableColor == Color.blue)
            {
                ColorString = "blue";
            }
            else if (UseableColor == Color.yellow)
            {
                ColorString = "yellow";
            }
            else if (UseableColor == Color.cyan)
            {
                ColorString = "cyan";
            }
            else if (UseableColor == Color.magenta)
            {
                ColorString = "magenta";
            }


            if (ColorCycler >= colors.Length)
            {
                ColorString = "Fade Color";
                ColorCycler = 0;
            }
        }
    }
}


