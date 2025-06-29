using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using BepInEx.Logging;
using System.IO;
using Photon.Pun;
using GorillaX.Menu;

namespace GorillaX.Mods
{
    internal class IronMonkey
    {
        public static void IronMonkeyMod()
        {
            Vector3 FireSpawnPosititition = GorillaTagger.Instance.offlineVRRig.transform.position + Vector3.down * 0.5f;
            if(ControllerInputPoller.instance.rightGrab)
            {
                GorillaTagger.Instance.rigidbody.AddForce(GorillaTagger.Instance.rightHandTransform.right * 8.0f, ForceMode.Impulse);
            }
            if(ControllerInputPoller.instance.leftGrab)
            {
                GorillaTagger.Instance.rigidbody.AddForce(GorillaTagger.Instance.leftHandTransform.right * 8.0f, ForceMode.Impulse);
            }
        }
    }
}
