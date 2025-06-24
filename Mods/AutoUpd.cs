using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace GorillaX.Mods
{
    internal class AutoUpd
    {
        public class AutoUpdater : MonoBehaviour
        {
            private string versionUrl = "https://yourserver.com/version.txt";
            private string downloadUrl = "https://github.com/LTR77/GorillaX/releases/download/0.1/GorillaX.dll";
            private string dllPath = "C:/Program Files (x86)/Steam/steamapps/common/Gorilla Tag/GorillaX.dll";
            void Start()
            {
                CheckForUpdates();
            }
            async void CheckForUpdates()
            {
                try
                {
                    using WebClient client = new WebClient();
                    string latestVersion = await client.DownloadStringTaskAsync(versionUrl);

                    if (latestVersion.Trim() != PluginInfo.Version)
                    {
                        Debug.Log($"New version {latestVersion} available. Updating...");
                        byte[] newDll = await client.DownloadDataTaskAsync(downloadUrl);
                        File.WriteAllBytes(dllPath, newDll);

                        Debug.Log("Update complete. Please restart the game.");
                    }
                }
                catch (Exception e)
                {
                    Debug.LogError($"Update check failed: {e.Message}");
                }
            }
        }
    }
}
