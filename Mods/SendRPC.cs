using System;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

namespace Delta.Mods 
{
  internal class RPCs 
  {
    private static double delay;
    private static bool RPCProtectCalledOnce = false;
    private static int max = 2147483647;
    public static void SendRPCfromPlayer(string effekt, Vector3 pos, Quaternion rot) 
    {
      try 
      {
        if(delay < Time.time) 
        {
          delay = Time.time + 0.1;
          GorillaTagger.Instance.myVRRig.SendRPC(effekt, RpcTarget.All, new object[] {
            pos,
            rot,
            3f,
            70f,
            true,
            false
          });
        }
        ProtectPlayerFromRPC();
      }
      catch { }
    }
    public static void ProtectPlayerFromRPC() 
    {
      try 
      {
        if(!RPCProtectCalledOnce) 
        {
            GorillaNot.instance.rpcCallLimit = max;
            GorillaNot.instance.logErrorMax = max;
            GorillaNot.instance.rpcErrorMax = max;
            PhotonNetwork.MaxResendsBeforeDisconnect = max;
            PhotonNetwork.QuickResends = max;
            PhotonNetwork.SendAllOutgoingCommands();
            RPCProtectCalledOnce = true;
        }
      }
      catch { }
    }
    public static void DisableRPCProtect() 
    {
      RPCProtectCalledOnce = false;
    }
  }
}
