using System;
using System.Text;
using System.Collections.Generic;
using UnityEngine;

namespace GorillaX.Mods 
{
  internal class HeadMods 
  {
    public static void Head90ZMod() 
    {
      VRRig.LocalRig.head.trackingRotationOffset.z = 90f;
    }
    public static void Head180ZMod() 
    {
      VRRig.LocalRig.head.trackingRotationOffset.z = 180f;
    }
    public static void Head180YMod() 
    {
      VRRig.LocalRig.head.trackingRotationOffset.y = 180f;
    } 
    public static void FixHead() 
    {
      VRRig.LocalRig.head.trackingRotationOffset.y = 0f;
      VRRig.LocalRig.head.trackingRotationOffset.x = 0f;
      VRRig.LocalRig.head.trackingRotationOffset.z = 0f;
    }
  } 
}