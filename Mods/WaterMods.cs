using System;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using static GorillaX.Mods.GunRenderer;

namespace GorillaX.Mods 
{
  internal class WaterSpammers 
  {
    public static void WaterHandsSpamMod() 
    {
      if(ControllerInputPoller.instance.rightGrab) {
        RPCs.SendRPCfromPlayer("RPC_PlaySpashEffect", GorillaTagger.Instance.rightHandTransform.position, GorillaTagger.Instance.rightHandTransform.rotation);
      }
      if(ControllerInputPoller.instance.leftGrab) {
        RPCs.SendRPCfromPlayer("RPC_PlaySplashEffect", GorillaTagger.Instance.leftHandTransform.position, GorillaTagger.Instance.leftHandTransform.rotation);
      }
    }
    public static void WaterGunMod() 
    {
      if(ControllerInputPoller.instance.rightGrab) 
      {
        RaycastHit hit;
        var GunData = RenderGun(GorillaTagger.Instance.rightHandTransform, out hit);
        RaycastHit Ray = GunData.Ray;
        GameObject NewPointer = GunData.NewPointer;
      }
      
      if(ControllerInputPoller.instance.rightControllerIndexFloat >= 0.5f) 
      {
        RPCs.SendRPCfromPlayer("RPC_PlaySplashEffect", NewPointer.transform.position, NewPointer.transform.rotation);
      }
    }
  }
}
