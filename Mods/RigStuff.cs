using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;

namespace GorillaX.Mods
{
    internal class RigStuff
    {
        private static bool GMToggled = false;
        private static bool IMToggled = false;
        public static void GhostMonkeyMod() 
        {
            if(ControllerInputPoller.instance.leftControllerPrimaryButton || UnityInput.Current.GetKey(UnityEngine.KeyCode.Z))
            {
                GMToggled = !GMToggled;
                GorillaTagger.Instance.offlineVRRig.enabled = !GMToggled;
            }
        }
        public static void InvisMonkeyMod()
        {
            if (ControllerInputPoller.instance.leftControllerPrimaryButton || UnityInput.Current.GetKey(UnityEngine.KeyCode.X))
            {
                IMToggled = !IMToggled;
                GorillaTagger.Instance.offlineVRRig.enabled = !IMToggled;
                if(IMToggled)
                {
                    GorillaTagger.Instance.offlineVRRig.transform.position = new UnityEngine.Vector3(0, 0, 0);
                }
            }
        }
        public static void FixRig()
        {
            GMToggled = false;
            IMToggled = false;
            GorillaTagger.Instance.offlineVRRig.enabled = true;
        }
    }
}
