using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine.InputSystem;
using System.Threading.Tasks;
using UnityEngine;

namespace GorillaX.Mods
{
    internal class RigStuff
    {
        private static bool GMToggled = false;
        private static bool IMToggled = false;
        public async static void GhostMonkeyMod() 
        {
            if(ControllerInputPoller.instance.leftControllerPrimaryButton || UnityInput.Current.GetKey(UnityEngine.KeyCode.Z))
            {
                GMToggled = !GMToggled;
                VRRig.LocalRig.enabled = !GMToggled;
                GorillaTagger.Instance.offlineVRRig.enabled = !GMToggled;
                await Task.Delay(100);
            }
        }
        public async static void InvisMonkeyMod()
        {
            if (ControllerInputPoller.instance.leftControllerPrimaryButton || UnityInput.Current.GetKey(UnityEngine.KeyCode.X))
            {
                IMToggled = !IMToggled;
                VRRig.LocalRig.enabled = !GMToggled;
                GorillaTagger.Instance.offlineVRRig.enabled = !IMToggled;
                if(IMToggled)
                {
                    GorillaTagger.Instance.offlineVRRig.transform.position = new Vector3(0f, 0f, 4949f);
                }
                await Task.Delay(100);
            }
        }
        public static void FixRig()
        {
            GMToggled = false;
            IMToggled = false;
            GorillaTagger.Instance.offlineVRRig.enabled = true;
            VRRig.LocalRig.enabled = true;
        }
    }
}
