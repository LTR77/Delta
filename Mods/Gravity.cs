using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace GorillaX.Mods
{
    internal class Gravity
    {
        public static void ZeroGravityMod()
        {
            GorillaTagger.Instance.rigidbody.AddForce(Vector3.up * 9.81f, ForceMode.Acceleration);
        }
        public static void LowGravityMod()
        {
            GorillaTagger.Instance.rigidbody.AddForce(Vector3.up * 6.77f, ForceMode.Acceleration);
        }
        public static void HighGravityMod()
        {
            GorillaTagger.Instance.rigidbody.AddForce(Vector3.down * 4.44f, ForceMode.Acceleration);
        }
        public static void BackwardsGravityMod()
        {
            GorillaTagger.Instance.rigidbody.AddForce(Vector3.up * 13.4f, ForceMode.Acceleration);
        }
    }
}
