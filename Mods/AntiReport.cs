using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using GorillaX.Menu;

namespace GorillaX.Mods
{
    internal class AntiReport
    {
        public static void AntiReportMod()
        {
            try
            {
                Main.ProtectPlayerFromRPC(); 
                foreach(GorillaPlayerScoreboardLine line in GorillaScoreboardTotalUpdater.allScoreboardLines)
                {
                    Transform scoreboardTransform = line.reportButton.gameObject.transform;
                    foreach(VRRig vrrig in GorillaParent.instance.vrrigs)
                    {
                        if(vrrig != VRRig.LocalRig)
                        {
                            float GorillaRHandDistance = Vector3.Distance(vrrig.rightHandTransform.position, scoreboardTransform.position);
                            float GorillaLHandDistance = Vector3.Distance(vrrig.leftHandTransform.position, scoreboardTransform.position);
                            if (GorillaRHandDistance < 0.5f || GorillaLHandDistance < 0.5f)
                            {
                                PhotonNetwork.Disconnect();
                            }
                        }
                    }
                }
            }
            catch { }
        }
    }
}
