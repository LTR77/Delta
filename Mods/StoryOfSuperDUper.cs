using ModIOBrowser;
using System;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

namespace GorillaX.Mods
{
    internal class StoryOfSuperDUper
    {
        public static AudioClip audioClip;
        public class SoundPlayer : MonoBehaviour
        {
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
    }
}
