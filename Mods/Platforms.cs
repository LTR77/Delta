using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;
using static GorillaX.Menu.Main;
using static GorillaX.Settings;


namespace GorillaX.Mods
{
    internal class Platforms
    {
        private static GameObject leftPlat = null;
        private static GameObject rightPlat = null;
        private static GameObject CreatePlatformsOnHands(Transform Handtransform, Color color, bool DelAll, bool Slippery)
        {
            float rainbowcycler = Time.time % 1f;
            Color regenbogenfarbekreislaufdings = Color.HSVToRGB(rainbowcycler, 1, 1)
            GameObject Platform = GameObject.CreatePrimitive(PrimitiveType.Cube);
            Platform.transform.localScale = new Vector3(0.025f, 0.3f, 0.4f);
            Platform.transform.position = Handtransform.position + Vector3.down * 0.04f;
            Platform.transform.rotation = Handtransform.rotation;
            if(backgroundColor.isRainbow) 
            {
              Platform.GetComponent<Renderer>().material.color = regenbogenfarbekreislaufdings;
            }
            else 
            {
              Platform.GetComponent<Renderer>().material.color = color;
            }

            if(DelAll)
            {
                GameObject[] AllPlatforms = GameObject.FindGameObjectsWithTag("Platform");
                foreach (GameObject plat in AllPlatforms)
                {
                    UnityEngine.Object.Destroy(plat);
                }
                return null;
            }
            if(Slippery)
            {
                Platform.AddComponent<GorillaSurfaceOverride>().overrideIndex = 61;
                UnityEngine.Object.Destroy(Platform, 1.0f);
            }
            return Platform;
        }
        public static void platformMOD()
        { 
            if(ControllerInputPoller.instance.rightGrab && rightPlat == null)
            {
                rightPlat = CreatePlatformsOnHands(GorillaTagger.Instance.rightHandTransform, Color.red, false, false);
            }
            if(ControllerInputPoller.instance.leftGrab && leftPlat == null)
            {
                leftPlat = CreatePlatformsOnHands(GorillaTagger.Instance.leftHandTransform, Color.black, false, false);
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
        public static void PlatformDrawMod()
        {
            if(ControllerInputPoller.instance.rightGrab)
            {
                CreatePlatformsOnHands(GorillaTagger.Instance.rightHandTransform, Color.blue, false, false);
            }
            if(ControllerInputPoller.instance.leftGrab)
            {
                CreatePlatformsOnHands(GorillaTagger.Instance.leftHandTransform, Color.red, false, false);
            }
            if(ControllerInputPoller.instance.leftControllerSecondaryButton)
            {
                CreatePlatformsOnHands(GorillaTagger.Instance.leftHandTransform, Color.white, true, false);
            }
        }
        public static void Frozone()
        {
            if(ControllerInputPoller.instance.rightGrab)
            {
                CreatePlatformsOnHands(GorillaTagger.Instance.rightHandTransform, Color.blue, false, true);
            }
            if (ControllerInputPoller.instance.leftGrab)
            {
                CreatePlatformsOnHands(GorillaTagger.Instance.leftHandTransform, Color.blue, false, true);
            }
            if(ControllerInputPoller.instance.leftControllerSecondaryButton)
            {
                CreatePlatformsOnHands(GorillaTagger.Instance.leftHandTransform, Color.white, true, false);
            }
        }
    }
}
