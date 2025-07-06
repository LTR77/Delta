using GorillaX.Mods;
using GorillaX.Classes;
using static GorillaX.Settings;
using UnityEngine;

namespace GorillaX.Menu
{
    internal class Buttons : MonoBehaviour
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
                new ButtonInfo { buttonText = "SDT", method =() => Global.EnterFun(), isTogglable = false, toolTip = "Opens the Fun mods page for the menu."},

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
                new ButtonInfo { buttonText = ColorCustom.ColorString, enableMethod =() => ColorCustom.ChangeFaidToColorMod(), isTogglable = false, toolTip = "Change Fade Color of the Menu"},
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
                new ButtonInfo { buttonText = "Speedboosts", method =() => Global.EnterSpeedboosts(), isTogglable = false, toolTip = "Opens the Speedboosts page for the menu"},
                new ButtonInfo { buttonText = "Fly [UND] [W]", method =() => Fly.FlyMod(), isTogglable = true, toolTip = "Toggle Fly."},
                new ButtonInfo { buttonText = "Ghost Monkey [UND] [W]", method =() => RigStuff.GhostMonkeyMod(), isTogglable = true, toolTip = "Go outside of your Body"},
                new ButtonInfo { buttonText = "Invis Monkey [UND] [W]", method =() => RigStuff.InvisMonkeyMod(), isTogglable = true, toolTip = "disappear or something"},
                new ButtonInfo { buttonText = "Fix Rig [UND] [W]", method =() => RigStuff.InvisMonkeyMod(), isTogglable = true, toolTip = "disappear or something"},
                new ButtonInfo { buttonText = "0 Gravity [UND] [W]", method =() => Gravity.ZeroGravityMod(), isTogglable = true, toolTip = "No Gravity"},
                new ButtonInfo { buttonText = "Low Gravity [UND] [W]", method =() => Gravity.LowGravityMod(), isTogglable = true, toolTip = "Low Gravity"},
                new ButtonInfo { buttonText = "High Gravity [UND] [W]", method =() => Gravity.HighGravityMod(), isTogglable = true, toolTip = "High Gravity"},
                new ButtonInfo { buttonText = "Backwards Gravity [UND] [W]", method =() => Gravity.BackwardsGravityMod(), isTogglable = true, toolTip = "Backwards Gravity (you fly up)"},
                new ButtonInfo { buttonText = "TP Gun [UND?] [SW]", method =() => TPGun.TPGunMod(), isTogglable = true, toolTip = "Ass Teleport Gun Probs D"},
                new ButtonInfo { buttonText = "Noclip [UND] [W]", method =() => Noclip.NoclipNod(), isTogglable = true, toolTip = "Go Through Walls!"},
                new ButtonInfo { buttonText = "Platforms [UND] [W]", method =() => Platforms.platformMOD(), isTogglable = true, toolTip = "Good ol' Platforms"},
                new ButtonInfo { buttonText = "Car Monkey [UND] [W]", method =() => CarMonkey.CarMonkeyMod(), isTogglable = true, toolTip = "Drive like a car"},
                new ButtonInfo { buttonText = "Iron Monkey [UND] [W]", method =() => IronMonkey.IronMonkeyMod(), isTogglable = true, toolTip = "Become ------ Iron Man"},
                new ButtonInfo { buttonText = "Frozone [UND] [W]", method =() => Platforms.Frozone(), isTogglable = true, toolTip = "Frozone"},
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
                new ButtonInfo { buttonText = "Water Hands [W] [UND]", enableMethod =() => WaterSpammers.WaterHandsSpamMod(), disableMethod =() => RPCs.DisableRPCProtect(), isTogglable = true, toolTip = "Become water Benderr"},
                new ButtonInfo { buttonText = "Water Gun [W?] [UND?]", method =() => WaterSpammers.WaterGunMod(), isTogglable = true, toolTip = "Water Spawns where Gun is shot"}
            },
            new ButtonInfo[] { // Useful Mods
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Accept TOS [NW]", method =() => Useful.AcceptTOSMod(), isTogglable = false, toolTip = "Accepts the annoying ass tos"},
                new ButtonInfo { buttonText = "Anti Report [UND] [W]", enableMethod =() => AntiReport.AntiReportMod(), disableMethod =() => RPCs.DisableRPCProtect(), isTogglable = false, toolTip = "anti report thingymaboboobobo"},
            },
            new ButtonInfo[] // Visual
            {
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "ESP [W]", method =() => ESP.ESPMod(), isTogglable=true, toolTip = "ESP on Everybody"},
                new ButtonInfo { buttonText = "Tracers [W]", method =() => Tracer.TracersMod(), isTogglable = true, toolTip = "Enables Tracers to everybody"},
            },
            new ButtonInfo[] // Super Duper Tank
            {
                new ButtonInfo { buttonText = "Return to Main", method =() => Global.ReturnHome(), isTogglable = false, toolTip = "Returns to the main page of the menu."},
                new ButtonInfo { buttonText = "Platforms Draw [UND] [CS] [W]", method =() => Platforms.PlatformDrawMod(), isTogglable = true, toolTip = "Draw with Platforms"},
                //new ButtonInfo { buttonText = "Download SOSD", method =() => StoryOfSuperDUper.Download(, "https://github.com/LTR77/GorillaX/raw/refs/heads/master/Mods/Sounds/ElevenLabs_2025-06-25T17_31_30_Wyatt-%20Wise%20Rustic%20Cowboy_pvc_sp100_s84_sb100_v3.mp3", "SOSD.mp3", "GorillaX/Sounds"), isTogglable = false, toolTip = "Download needed for Story of Super Duper to play"},
                new ButtonInfo { buttonText = "Story of Super Duper", method =() => StoryOfSuperDUper.SoundPlayer.PlaySound(StoryOfSuperDUper.audioClip), isTogglable = false, toolTip = "Play Story of SUper DUper"},
	    },
            new ButtonInfo[] // Speedboost
            {
                new ButtonInfo { buttonText = "Return to Movement", method =() => Global.EnterMovement(), isTogglable = false, toolTip = "Returns to the Movement page of the menu."},
                new ButtonInfo { buttonText = "Mosa Speedboost [UND] [W]", method =() => SpeedBoost.MosaSpeedBoostMod(), isTogglable = true, toolTip = "Slight Speedboost."},
                new ButtonInfo { buttonText = "Fast Speedboost [UND] [W]", method =() => SpeedBoost.FastSpeedBoostMod(), isTogglable = true, toolTip = "fast Speedboost"},
                new ButtonInfo { buttonText = "Very Fast Speedboost [UND?] [W]", method =() => SpeedBoost.VeryFastSpeedBoostMod(), isTogglable = true, toolTip = "VERY Fast Speedboost."},
                new ButtonInfo { buttonText = "Insane Speedboost [UND?] [W]", method =() => SpeedBoost.InsaneSpeedBoostMod(), isTogglable = true, toolTip = "VERY VERY fast Speedboost"},
                new ButtonInfo { buttonText = "Do Not Use Speedboost [UND?] [W]", method =() => SpeedBoost.DoNotUseSpeedBoostMod(), isTogglable = true, toolTip = "You better not"},
                new ButtonInfo { buttonText = "Dont Even Try Speedboost [UND?] [W]", method =() => SpeedBoost.DontEvenTrySpeedBoostMod(), isTogglable = true, toolTip = "You really shouldnt"},
                new ButtonInfo { buttonText = "'no' Speedboost [UND?] [W]", method =() => SpeedBoost.NoSpeedBoostMod(), isTogglable = true, toolTip = "no, just no"},
            }
        };
    }
}
