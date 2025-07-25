﻿using Delta.Classes;
using UnityEngine;
using static Delta.Menu.Main;

namespace Delta
{
    internal class Settings
    {
        public static ExtGradient backgroundColor = new ExtGradient{isRainbow = true};
        public static ExtGradient[] buttonColors = new ExtGradient[]
        {
            backgroundColor, // Disabled
            new ExtGradient{colors = GetSolidGradient(Color.yellow)} // Enabled
        };
        public static Color[] textColors = new Color[]
        {
            Color.white, // Disabled
            Color.white // Enabled
        };

        public static Font currentFont = (Resources.GetBuiltinResource(typeof(Font), "Arial.ttf") as Font);

        public static bool fpsCounter = true;
        public static bool disconnectButton = true;
        public static bool rightHanded = false;
        public static bool disableNotifications = false;

        public static KeyCode keyboardButton = KeyCode.E;

        public static Vector3 menuSize = new Vector3(0.1f, 1f, 1f); // Depth, Width, Height
        public static int buttonsPerPage = 8;
    }
}
