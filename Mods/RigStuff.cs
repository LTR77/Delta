using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;
using System.Threading.Tasks;
using UnityEngine;

namespace Delta.Mods
{
    internal class RigStuff
    {
        private static bool GhostMonkeyToggled = false;
        private static bool InvisMonkeyToggled = false;

        public static void GhostMonkeyMod()
        {
            if(ControllerInputPoller.instance.leftControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        public static void InvisMonkeyMod()
        {
            if(ControllerInputPoller.instance.rightControllerSecondaryButton)
            {
                GorillaTagger.Instance.offlineVRRig.enabled = false;
                GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(5555, 5555, 5555);
            }
            else
            {
                GorillaTagger.Instance.offlineVRRig.enabled = true;
            }
        }
        public static void FixRig()
        {
            GorillaTagger.Instance.offlineVRRig.enabled = true;
        }
    }
}
