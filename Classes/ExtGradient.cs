using System;
using UnityEngine;
using GorillaX.Mods;

namespace GorillaX.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(Color.black, 0f),
            //new GradientColorKey(Color.magenta, 0.5f),
            new GradientColorKey(ColorCustom.TempUseableColor, 0.5f),
            new GradientColorKey(Color.black, 1f)
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
