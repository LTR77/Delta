using System;
using System.Collections.Generic;
using System.Text;

namespace GorillaX.Mods
{
    internal class RigStuff
    {
        public static bool GMToggled = false;
        public static void GhostMonkeyMod() 
        {
            if(ControllerInputPoller.instance.leftControllerPrimaryButton)
            {
                GMToggled = true;
                if(GMToggled)
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    GMToggled = false;
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                    GMToggled = true;
                }
            }
        }
        public static void InvisMonkeyMod()
        {
            if (ControllerInputPoller.instance.leftControllerPrimaryButton)
            {
                GMToggled = true;
                if (GMToggled)
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = false;
                    GorillaTagger.Instance.offlineVRRig.transform.position = new UnityEngine.Vector3(0, 0, 0);
                    GMToggled = false;
                }
                else
                {
                    GorillaTagger.Instance.offlineVRRig.enabled = true;
                    GMToggled = true;
                }
            }
        }
    }
}
