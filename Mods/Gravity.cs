using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Delta.Mods
{
    internal class Gravity
    {
        public static void ZeroGravityMod()
        {
            GorillaTagger.Instance.rigidbody.AddForce(Vector3.up * Time.deltaTime * (9.81f / Time.deltaTime), ForceMode.Acceleration);
        }
        public static void LowGravityMod()
        {
            GorillaTagger.Instance.rigidbody.AddForce(Vector3.up * Time.deltaTime * (6.77f / Time.deltaTime), ForceMode.Acceleration);
        }
        public static void HighGravityMod()
        {
            GorillaTagger.Instance.rigidbody.AddForce(Vector3.down * Time.deltaTime * (4.44f / Time.deltaTime), ForceMode.Acceleration);
        }
        public static void BackwardsGravityMod()
        {
            GorillaTagger.Instance.rigidbody.AddForce(Vector3.up * Time.deltaTime * (13.4f / Time.deltaTime), ForceMode.Acceleration);
        }
    }
}
