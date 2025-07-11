using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace Delta.Mods
{
    internal class ESP
    {
        public static void ESPMod()
        {
            foreach(VRRig target in GorillaParent.instance.vrrigs)
            {
                if(target != VRRig.LocalRig)
                {
                    Color color = target.playerColor;
                    color.a = 0.3f;
                    GameObject ESPVisualizer = GameObject.CreatePrimitive(PrimitiveType.Cube);
                    ESPVisualizer.transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
                    ESPVisualizer.transform.position = target.transform.transform.position;
                    ESPVisualizer.transform.rotation = Quaternion.identity;
                    ESPVisualizer.GetComponent<Renderer>().material.shader = Shader.Find("GUI/Text Shader");
                    ESPVisualizer.GetComponent<Renderer>().material.color = color;
                    UnityEngine.Object.Destroy(ESPVisualizer, Time.deltaTime);
                }
            }
        }
    }
}
