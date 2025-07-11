using System;
using System.Collections.Generic;
using System.Text;

namespace Delta.Mods
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
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 6f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 6f;
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
        public static void DontEvenTrySpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 550f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 550f;
        }
        public static void NoSpeedBoostMod()
        {
            GorillaLocomotion.GTPlayer.Instance.maxJumpSpeed = 1000f;
            GorillaLocomotion.GTPlayer.Instance.jumpMultiplier = 1000f;
        }
    }
}
