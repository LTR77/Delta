using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.Rendering.Universal.Internal;

namespace GorillaX.Mods
{
    internal class SuperBasicMods
    {
        public static GameObject leftPlat = null;
        public static GameObject rightPlat = null;

        private static GameObject CreatePlatformsOnHands(Transform HandTransform)
        {
            GameObject platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
            platform.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
            platform.transform.position = HandTransform.position;
            platform.transform.rotation = HandTransform.rotation;
            platform.GetComponent<Renderer>().material.color = Color.red;
            return platform;
        }
        public static void PlatformsMod()
        {

            if(ControllerInputPoller.instance.leftGrab && leftPlat == null)
            {
                leftPlat = CreatePlatformsOnHands(GorillaTagger.Instance.offlineVRRig.leftHandTransform);
            }
            if(ControllerInputPoller.instance.rightGrab && rightPlat == null)
            {
                rightPlat = CreatePlatformsOnHands(GorillaTagger.Instance.offlineVRRig.rightHandTransform);
            }
            if(ControllerInputPoller.instance.rightGrabRelease && rightPlat != null)
            {
                rightPlat.Disable();
                rightPlat = null;
            }
            if(ControllerInputPoller.instance.leftGrabRelease && leftPlat != null)
            {
                leftPlat.Disable();
                leftPlat = null;
            }
        }
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
