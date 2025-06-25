using GorillaX.Mods;
using GorillaX.Classes;
using static GorillaX.Settings;

namespace GorillaX.Menu
{
    internal class Buttons
    {
        public static ButtonInfo[][] buttons = new ButtonInfo[][]
        {
            new ButtonInfo[] { // Main Mods
                new ButtonInfo { buttonText = "Try to Update", method =() => AutoUpd.AutoUpdater.Start(), isTogglable = false, toolTip = "Trys to Update the mod menu"},
                new ButtonInfo { buttonText = "Symbols", method =() => Global.EnterSymbols(), isTogglable = false, toolTip = "Opens the Symbol meanings page for the menu"},
                new ButtonInfo { buttonText = "Settings", method =() => SettingsMods.EnterSettings(), isTogglable = false, toolTip = "Opens the main settings page for the menu."},
                new ButtonInfo { buttonText = "Movement", method =() => Global.EnterMovement(), isTogglable = false, toolTip = "Opens the movement mods page for the menu."},
                new ButtonInfo { buttonText = "Useful", method =() => Global.EnterUseful(), isTogglable = false, toolTip = "Opens the Useful mods page for the menu."},
                new ButtonInfo { buttonText = "Visual", method =() => Global.EnterVisual(), isTogglable = false, toolTip = "Opens the Visual mods page for the menu."},


                new ButtonInfo { buttonText = "OP Mods", method =() => Global.EnterOP(), isTogglable = false, toolTip = "Opens the Overpowered mods page for the menu."},

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
                new ButtonInfo { buttonText = "Speedboost [UND] [W]", method =() => SpeedBoost.SpeedBoostMod(), isTogglable = true, toolTip = "Toggle Speedboost."},
                new ButtonInfo { buttonText = "Fly [U] [W]", method =() => Fly.FlyMod(), isTogglable = true, toolTip = "Toggle Fly."},
                new ButtonInfo { buttonText = "Bounce Fly [U] [SDT] [W]", method =() => Fly.SlingshotFlyMod(), isTogglable = true, toolTip = "Fly with a Twist."},
                new ButtonInfo { buttonText = "Ghost Monkey [D] [SW]", method =() => RigStuff.GhostMonkeyMod(), isTogglable = true, toolTip = "Go outside of your Body"},
                new ButtonInfo { buttonText = "Invis Monkey [D] [SW]", method =() => RigStuff.InvisMonkeyMod(), isTogglable = true, toolTip = "dissappear or something"},
                new ButtonInfo { buttonText = "Fix Rig [U] [W]", method =() => RigStuff.InvisMonkeyMod(), isTogglable = true, toolTip = "dissappear or something"},
                new ButtonInfo { buttonText = "0 Gravity [UND] [W]", method =() => Gravity.ZeroGravityMod(), isTogglable = true, toolTip = "No Gravity"},
                new ButtonInfo { buttonText = "Low Gravity [UND] [W]", method =() => Gravity.LowGravityMod(), isTogglable = true, toolTip = "Low Gravity"},
                new ButtonInfo { buttonText = "High Gravity [UND] [W]", method =() => Gravity.HighGravityMod(), isTogglable = true, toolTip = "High Gravity"},
                new ButtonInfo { buttonText = "Backwards Gravity [UND] [W]", method =() => Gravity.BackwardsGravityMod(), isTogglable = true, toolTip = "Backwards Gravity (you fly up)"},
                new ButtonInfo { buttonText = "Cursed TP Gun [UND?] [SW]", method =() => TPGun.TPGunMod(), isTogglable = true, toolTip = "Ass Teleport Gun Probs D"},
                new ButtonInfo { buttonText = "Noclip [UND] [W]", method =() => SuperBasicMods.NoclipNod(), isTogglable = true, toolTip = "Go Through Walls!"},
                new ButtonInfo { buttonText = "Platforms [UND] [W]", method =() => Platforms.platformMOD(), isTogglable = true, toolTip = "Good ol' Platforms"},
            },
            new ButtonInfo[] { // Symbols
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},

                new ButtonInfo { buttonText = "UND = Undetected", isTogglable = false },
                new ButtonInfo { buttonText = "D = Detected", isTogglable = false },
                new ButtonInfo { buttonText = "UND? = might be D", isTogglable = false },
                new ButtonInfo { buttonText = "DB = Delay Ban!", isTogglable = false },
                new ButtonInfo { buttonText = "IB = Insta Ban!", isTogglable = false },
                new ButtonInfo { buttonText = "U = Unknown", isTogglable = false },
                new ButtonInfo { buttonText = "BETA = Beta WIP", isTogglable = false },
                new ButtonInfo { buttonText = "W = Working", isTogglable = false },
                new ButtonInfo { buttonText = "SW = Somewhat Working", isTogglable = false },
                new ButtonInfo { buttonText = "NW = Not Working", isTogglable = false },
                new ButtonInfo { buttonText = "W? = might be W", isTogglable = false },
                new ButtonInfo { buttonText = "SS = Serversided", isTogglable = false },
                new ButtonInfo { buttonText = "CS = Clientsided", isTogglable = false },
                new ButtonInfo { buttonText = "SDT = Super Duper Tank", isTogglable = false},
            },
            new ButtonInfo[] {               // OP Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Unlock Cosmetics [Cant Disable] [CS] [UND] [W]", method =() => UnlockCosmetics.UnlockCosmeticsMod(), isTogglable = false, toolTip = "Unlocks All Cosmetics in the game"},
            },
            new ButtonInfo[] { // Useful Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Accept TOS", method =() => Useful.AcceptTOSMod(), isTogglable = false, toolTip = "Accepts the annoying ass tos"},
            },
            new ButtonInfo[] // Visual
            {
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Tracers", method =() => Tracer.TracersMod(), isTogglable = true, toolTip = "Enables Tracers to everybody"},
            }
        };
    }
}
