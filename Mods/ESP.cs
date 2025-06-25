using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace GorillaX.Mods
{
    internal class ESP
    {
        public static void ESPMod()
        {
            foreach(VRRig target in GorillaParent.instance.vrrigs)
            {
                if(target != VRRig.LocalRig)
                {
                    GameObject ESPVisualizer = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    ESPVisualizer.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
                    ESPVisualizer.transform.position = target.transform.transform.position + Vector3.up * 0.1f;
                    ESPVisualizer.transform.rotation = Quaternion.identity;
                    ESPVisualizer.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    ESPVisualizer.GetComponent<Renderer>().material.color = target.playerColor;
                    UnityEngine.Object.Destroy(ESPVisualizer, Time.deltaTime);
                }
            }
        }
    }
}
