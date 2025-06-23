using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace GorillaX.Mods
{
    internal class BlindGun
    {
        public static void Projectiler(string projectileName, Vector3 position, Vector3 velocity, Color color)
        {
            //Royal999 should put his code here
        }
        public static void BlindGunMod()
        {
            if(ControllerInputPoller.instance.rightGrab)
            {
                RaycastHit hit;
                var GunData = GunRenderer.RenderGun(GorillaTagger.Instance.rightHandTransform, out hit);
                RaycastHit Ray = GunData.Ray;
                GameObject NewPointer = GunData.NewPointer;
                if (ControllerInputPoller.instance.rightControllerIndexFloat > 0.2f || UnityInput.Current.GetKey(KeyCode.G) && NewPointer != null)
                {
                    //Royal999 should put his other code here
                }
            }
        }
    }
}
