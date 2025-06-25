using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

namespace GorillaX.Mods
{
    internal class Noclip
    {
        public static void NoclipNod()
        {
            MeshCollider[] colliders = Resources.FindObjectsOfTypeAll<MeshCollider>();
            bool DisableCollider = ControllerInputPoller.instance.rightControllerIndexFloat > 0.1f;
            foreach(MeshCollider collider in colliders)
            {
                collider.enabled = !DisableCollider;
            }
        }
    }
}
