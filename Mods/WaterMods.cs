using System;
using System.Text;
using System.Collections.Generic;
using UnityEngine;

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
  }
}
