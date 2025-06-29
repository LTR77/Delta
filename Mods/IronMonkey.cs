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
        public static GameObject fireprefabparticle;
        /* CHATGPT HELPER THINGYGYGYYG
        public static void LogPossibleFireAssets()
        {
            foreach (var bundle in Resources.FindObjectsOfTypeAll<AssetBundle>())
            {
                foreach (var name in bundle.GetAllAssetNames())
                {
                    if (name.ToLower().Contains("flame") || name.ToLower().Contains("fire") || name.ToLower().Contains("thrower"))
                    {
                        Logger.LogInfo($"Found asset: {name}");
                    }
                }
            }
        }
        */
        public static void Load()
        {
            string bundlePath = Path.Combine(Application.dataPath, "StreamingAssets/aa/StandaloneWindows64");
            foreach (var path in Directory.GetFiles(bundlePath, "*.bundle"))
            {
                var bundle = AssetBundle.LoadFromFile(path);
                var prefabPath = bundle.GetAllAssetNames().FirstOrDefault(containing => containing.Contains("fireballanchor"));
                if (prefabPath != null)
                {
                    fireprefabparticle = bundle.LoadAsset<GameObject>(prefabPath);
                    for(int i = 0;i<50;i++)
                    {
                        Main.Logger.LogInfo($"Loaded fire prefab particle from: {prefabPath}");
                    }
                    break;
                }
                else
                {
                    for(int i = 0;i<50;i++)
                    {
                        Main.Logger.LogWarning("Failed");
                    }
                    break;
                }
            }
        }

        
        public static void IronMonkeyMod()
        {
            if(fireprefabparticle == null)
            {
                Load();
                Main.Logger.LogInfo("Loadededededed!!!!");
            }
            Vector3 FireSpawnPosititition = GorillaTagger.Instance.offlineVRRig.transform.position + Vector3.down * 0.5f;
            if(ControllerInputPoller.instance.rightGrab)
            {
                GorillaTagger.Instance.rigidbody.AddForce(GorillaTagger.Instance.rightHandTransform.right * 8.0f, ForceMode.Impulse);
                var obj = UnityEngine.Object.Instantiate(fireprefabparticle, GorillaTagger.Instance.rightHandTransform.position + Vector3.down * 0.5f, Quaternion.identity);
                var particleSystem = obj.GetComponent<ParticleSystem>();
                particleSystem.Play();
                UnityEngine.Object.Destroy(obj, particleSystem.main.duration + particleSystem.main.startLifetime.constantMax);
            }
            if(ControllerInputPoller.instance.leftGrab)
            {
                GorillaTagger.Instance.rigidbody.AddForce(GorillaTagger.Instance.leftHandTransform.right * 8.0f, ForceMode.Impulse);
                var obj = UnityEngine.Object.Instantiate(fireprefabparticle, GorillaTagger.Instance.offlineVRRig.transform.position + Vector3.down * 0.5f, Quaternion.identity);
                var particleSystem = obj.GetComponent<ParticleSystem>();
                particleSystem.Play();
                UnityEngine.Object.Destroy(obj, particleSystem.main.duration + particleSystem.main.startLifetime.constantMax);
            }
        }
    }
}
