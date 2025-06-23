using System;
using System.Collections.Generic;
using System.Text;
using static GorillaX.Mods.GunRenderer;
using UnityEngine;
using BepInEx;

namespace GorillaX.Mods
{
    internal class TPGun
    {
        public static void TPGunMod()
        {
            if(ControllerInputPoller.instance.rightGrab)
            {
                RaycastHit hit;
                var GunData = RenderGun(GorillaTagger.Instance.rightHandTransform, out hit);
                RaycastHit Ray = GunData.Ray;
                GameObject NewPointer = GunData.NewPointer;
                if(ControllerInputPoller.instance.rightControllerIndexFloat > 0.2f || UnityInput.Current.GetKey(KeyCode.G) && NewPointer != null)
                {
                    GorillaLocomotion.GTPlayer.Instance.TeleportTo(NewPointer.transform.position, GorillaLocomotion.GTPlayer.Instance.transform.rotation);
                    GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;
                }
            }
        }
    }
}
