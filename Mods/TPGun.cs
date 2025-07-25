﻿using System;
using System.Collections.Generic;
using System.Text;
using static Delta.Mods.GunRenderer;
using UnityEngine;
using BepInEx;

namespace Delta.Mods
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
                    GorillaLocomotion.GTPlayer.Instance.transform.position = NewPointer.transform.position;
                    GorillaTagger.Instance.rigidbody.velocity = Vector3.zero;
                }
            }
        }
    }
}
