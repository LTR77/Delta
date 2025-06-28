using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
using BepInEx.Logging;
using System.IO;
using Photon.Pun;

namespace GorillaX.Mods
{
    internal class IronMonkey
    {
        private static readonly ManualLogSource Logger = BepInEx.Logging.Logger.CreateLogSource("IronMonkey");
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
            string bundlePath = Path.Combine(Application.dataPath, "StreamingAssets/aa/WindowsStandalone64");
            foreach (var path in Directory.GetFiles(bundlePath, "*.bundle"))
            {
                var bundle = AssetBundle.LoadFromFile(path);
                var prefabPath = bundle.GetAllAssetNames().FirstOrDefault(containing => containing.Contains("fireballanchor"));
                if (prefabPath != null)
                {
                    fireprefabparticle = bundle.LoadAsset<GameObject>(prefabPath);
                    break;
                }
            }
        }

        
        public static void IronMonkeyMod()
        {
            Vector3 FireSpawnPosititition = GorillaTagger.Instance.offlineVRRig.transform.position + Vector3.down * 0.5f;
            if(ControllerInputPoller.instance.rightGrab)
            {
                GorillaTagger.Instance.rigidbody.AddForce(GorillaTagger.Instance.offlineVRRig.rightHandTransform.right * 8.0f, ForceMode.Acceleration);
                var obj = UnityEngine.Object.Instantiate(fireprefabparticle, GorillaTagger.Instance.offlineVRRig.transform.position + Vector3.down * 0.5f, Quaternion.identity);
                var particleSystem = obj.GetComponent<ParticleSystem>();
                particleSystem.Play();
                UnityEngine.Object.Destroy(obj, particleSystem.main.duration + particleSystem.main.startLifetime.constantMax);
            }
            if(ControllerInputPoller.instance.leftGrab)
            {
                GorillaTagger.Instance.rigidbody.AddForce(GorillaTagger.Instance.leftHandTransform.right * 8.0f, ForceMode.Acceleration);
                var obj = UnityEngine.Object.Instantiate(fireprefabparticle, GorillaTagger.Instance.offlineVRRig.transform.position + Vector3.down * 0.5f, Quaternion.identity);
                var particleSystem = obj.GetComponent<ParticleSystem>();
                particleSystem.Play();
                UnityEngine.Object.Destroy(obj, particleSystem.main.duration + particleSystem.main.startLifetime.constantMax);
            }
        }
    }
}
