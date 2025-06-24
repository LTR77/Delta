using Photon.Pun;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace GorillaX.Mods
{
    internal class Tracer
    {
        public static void TracersMod()
        {
            foreach (VRRig player in GorillaParent.instance.vrrigs)
            {
                GameObject tracer = new GameObject("Tracer");
                LineRenderer linerender = tracer.AddComponent<LineRenderer>();
                UnityEngine.Color color = player.playerColor;
                linerender.startColor = color;
                linerender.endColor = color;
                linerender.startWidth = 0.03f;
                linerender.endWidth = 0.03f;
                linerender.SetPosition(0, GorillaTagger.Instance.rightHandTransform.position);
                linerender.SetPosition(1, player.transform.position);
            }
        }
    }
}
