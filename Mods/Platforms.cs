using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

namespace GorillaX.Mods
{
    internal class Platforms
    {
        private static GameObject leftPlat = null;
        private static GameObject rightPlat = null;
        private static GameObject CreatePlatformsOnHands(Transform Handtransform, Color color)
        {
            GameObject Platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Platform.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
            Platform.transform.position = Handtransform.position + Vector3.down * 0.06f;
            Platform.transform.rotation = Handtransform.rotation;
            Platform.GetComponent<Renderer>().material.color = color;
            return Platform;
        }
        public static void platformMOD()
        { 
            if(ControllerInputPoller.instance.rightGrab && rightPlat == null)
            {
                rightPlat = CreatePlatformsOnHands(GorillaTagger.Instance.rightHandTransform, Color.red);
            }
            if(ControllerInputPoller.instance.leftGrab && leftPlat == null)
            {
                leftPlat = CreatePlatformsOnHands(GorillaTagger.Instance.leftHandTransform, Color.black);
            }
            if(ControllerInputPoller.instance.rightGrabRelease && rightPlat != null)
            {
                rightPlat.Disable();
                rightPlat = null;
            }
            if (ControllerInputPoller.instance.leftGrabRelease && leftPlat != null)
            {
                leftPlat.Disable();
                leftPlat = null;
            }
        }
    }
}
