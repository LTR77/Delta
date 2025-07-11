using ModIOBrowser;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using UnityEngine.Networking;

namespace Delta.Mods
{
    internal class StoryOfSuperDUper
    {
         public static AudioClip audioClip;
         public class SoundPlayer : MonoBehaviour
         {
            public static MonoBehaviour instance;
            private void Awake()
            {
                instance = this;
            }
            public static void PlaySound(AudioClip clip, float volume = 10f)
            {
                if (clip == null)
                {
                    Debug.LogWarning("SoundPlayer: AudioClip is null!");
                    return;
                }

                GameObject tempGO = new GameObject("Sounds/ElevenLabs_2025-06-25T17_31_30_Wyatt- Wise Rustic Cowboy_pvc_sp100_s84_sb100_v3.mp3");
                AudioSource aSource = tempGO.AddComponent<AudioSource>();

                aSource.clip = clip;
                aSource.volume = volume;
                aSource.Play();

                UnityEngine.Object.Destroy(tempGO, clip.length);
            }
        }
        public void Download(MonoBehaviour mb, string url, string name, string path)
        {
            mb.StartCoroutine(DownloadSOSDCoro(url, name, path));
        }
        public static IEnumerator DownloadSOSDCoro(string url, string name, string path)
        {
            UnityWebRequest download = UnityWebRequest.Get(url);
            yield return download.SendWebRequest();
            if(download.result != UnityWebRequest.Result.Success)
            {
                Debug.LogError("Failed to Download");
                yield break;
            }
            else Debug.Log("Successfully Downloaded");
            byte[] data = download.downloadHandler.data;
            string fullPath = Path.Combine(path, name);
            if(!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            File.WriteAllBytes(fullPath, data);
        }
    }
}
