using BepInEx;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Delta.Mods
{
    internal class Fly
    {
        public static float flySpeed = 15f;

        public static void FlyMod()
        {
            if(ControllerInputPoller.instance.rightControllerPrimaryButton)
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime * flySpeed;
                GorillaLocomotion.GTPlayer.Instance.GetComponent<Rigidbody>().velocity = Vector3.zero;
            }
        }

        public static void SlingshotFlyMod()
        {
            if (ControllerInputPoller.instance.rightGrab || UnityInput.Current.GetKey(KeyCode.W))
            {
                GorillaLocomotion.GTPlayer.Instance.transform.position += GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime * flySpeed;
            }
        }
	public static void RealSlingshotFlyMod() 

	{
		if(ControllerInputPoller.instance.rightGrab)
		{
			GorillaTagger.Instance.rigidbody.velocity += GorillaLocomotion.GTPlayer.Instance.headCollider.transform.forward * Time.deltaTime * 20.0f;
		}
	}
    }
}

     
