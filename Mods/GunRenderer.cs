using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using UnityEngine.InputSystem;
using static UnityEngine.LightAnchor;

namespace GorillaX.Mods
{
    internal class GunRenderer
    {
        public struct GunData
        {
            public RaycastHit Ray;
            public GameObject NewPointer;
        }
        public static GunData RenderGun(Transform handTransform, out RaycastHit hit)
        {
            Vector3 origin = handTransform.position;
            Vector3 direction = handTransform.forward;
            int maxDistance = 80;

            bool checkhit = Physics.Raycast(origin, direction, out hit, maxDistance);
            GameObject GunShootPointer = null;
            if(checkhit)
            {
                GunShootPointer = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                GunShootPointer.transform.position = hit.point;
                GunShootPointer.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                GunShootPointer.GetComponent<Renderer>().material.color = Color.green;
                UnityEngine.Object.Destroy(GunShootPointer, 0.01f);
            }
            return new GunData { Ray = hit, NewPointer = GunShootPointer };
        }
    }
}
