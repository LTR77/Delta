using System;
using System.Collections.Generic;
using System.Text;

namespace GorillaX.Mods
{
    internal class SpeedBoost
    {
        public static void FastSpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 9f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 9f;
        }
        public static void MosaSpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 3f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 3f;
        }
        public static void VeryFastSpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 20f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 20f;
        }
        public static void InsaneSpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 50f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 50f;
        }
        public static void DoNotUseSpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 100f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 100f;
        }
    }
}
