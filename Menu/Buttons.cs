using GorillaX.Mods;
using StupidTemplate.Classes;
using StupidTemplate.Mods;
using static StupidTemplate.Settings;

namespace GorillaX.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Symbols", method =() => SettingsMods.EnterSymbols(), isTogglable = false, toolTip = "Opens the Symbol meanings page for the menu"},
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => SettingsMods.EnterMovement(), isTogglable = false, toolTip = "Opens the movement page for the menu."},

                new ButtonInfo { buttonText = "OP Mods", method =() => SettingsMods.EnterOP(), isTogglable = false, toolTip = "Opens the Overpowered mods page for the menu."},

                // new ButtonInfo { buttonText = "regular placeholder 6", isTogglable = false},
                // new ButtonInfo { buttonText = "togglable placeholder 6"},

            },



            new ButtonInfo[] { // Settings
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Menu Settings", method =() => SettingsMods.MenuSettings(), isTogglable = false, toolTip = "Opens the settings for the menu."},
                new ButtonInfo { buttonText = "Movement Settings", method =() => SettingsMods.MovementSettings(), isTogglable = false, toolTip = "Opens the movement settings for the menu."},
            },

            new ButtonInfo[] { // Menu Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
                new ButtonInfo { buttonText = "Rainbow", method =() =>SettingsMods.SetRainbow(), isTogglable = false, toolTip = "sets the menu color to rainbow" },
                new ButtonInfo { buttonText = "Right Hand", enableMethod =() => SettingsMods.RightHand(), disableMethod =() => SettingsMods.LeftHand(), toolTip = "Puts the menu on your right hand."},
                new ButtonInfo { buttonText = "Notifications", enableMethod =() => SettingsMods.EnableNotifications(), disableMethod =() => SettingsMods.DisableNotifications(), enabled = !disableNotifications, toolTip = "Toggles the notifications."},
                new ButtonInfo { buttonText = "FPS Counter", enableMethod =() => SettingsMods.EnableFPSCounter(), disableMethod =() => SettingsMods.DisableFPSCounter(), enabled = fpsCounter, toolTip = "Toggles the FPS counter."},
                new ButtonInfo { buttonText = "Disconnect Button", enableMethod =() => SettingsMods.EnableDisconnectButton(), disableMethod =() => SettingsMods.DisableDisconnectButton(), enabled = disconnectButton, toolTip = "Toggles the disconnect button."},
            },

            new ButtonInfo[] { // Movement Settings
                new ButtonInfo { buttonText = "Return to Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Returns to the main settings page for the menu."},
            },


            new ButtonInfo[] { // Movement Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Speedboost [U] [W]", method =() => SpeedBoost.SpeedBoostMod(), isTogglable = true, toolTip = "Toggle Speedboost."},
                new ButtonInfo { buttonText = "Fly [U] [W]", method =() => Fly.FlyMod(), isTogglable = true, toolTip = "Toggle Fly."},
                new ButtonInfo { buttonText = "Slingshot Fly [U] [W]", method =() => Fly.SlingshotFlyMod(), isTogglable = true, toolTip = "Fly with a Twist."},
                new ButtonInfo { buttonText = "Ghost Monkey [U] [W]", method =() => RigStuff.GhostMonkeyMod(), isTogglable = true, toolTip = "Go outside of your Body"},
                new ButtonInfo { buttonText = "Invis Monkey [U] [W]", method =() => RigStuff.InvisMonkeyMod(), isTogglable = true, toolTip = "dissappear or something"},
            },
            new ButtonInfo[] {
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},

                new ButtonInfo { buttonText = "UND = Undetected", isTogglable = false },
                new ButtonInfo { buttonText = "D = Detected", isTogglable = false },
                new ButtonInfo { buttonText = "UND? = might be D", isTogglable = false },
                new ButtonInfo { buttonText = "DB = Delay Ban!", isTogglable = false },
                new ButtonInfo { buttonText = "IB = Insta Ban!", isTogglable = false },
                new ButtonInfo { buttonText = "U = Unknown", isTogglable = false },
                new ButtonInfo { buttonText = "BETA = Beta WIP", isTogglable = false },
                new ButtonInfo { buttonText = "W = Working", isTogglable = false },
                new ButtonInfo { buttonText = "NW = Not Working", isTogglable = false },
                new ButtonInfo { buttonText = "W? = might be W", isTogglable = false },
                new ButtonInfo { buttonText = "SS = Serversided", isTogglable = false },
                new ButtonInfo { buttonText = "CS = Clientsided", isTogglable = false },


            },
            new ButtonInfo[] {               
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Unlock All Cosmetics", method =() => OP.UnlockCosmeticsMod(), isTogglable = false, toolTip = "Unlocks all cosmetics in the game."},
            }
        };
    }
}
