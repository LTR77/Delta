using System;
using System.Collections.Generic;
using System.Text;
using System.Net;
using System.IO;
using System.Reflection;
using UnityEngine;

namespace Delta.Mods
{
    internal class AutoUpd
    {
        public class AutoUpdater : MonoBehaviour
        { 
            private static string versionUrl = "https://raw.githubusercontent.com/LTR77/Delta/refs/heads/master/version.txt";
            private static string dllPath = Assembly.GetExecutingAssembly().Location;
            public static void Start()
            {
                CheckForUpdates();
            }
            async static void CheckForUpdates()
            {
                try
                {
                    using WebClient client = new WebClient();
                    string latestVersion = await client.DownloadStringTaskAsync(versionUrl);
                    string downloadUrl = $"https://github.com/LTR77/Delta/releases/download/{latestVersion.Trim()}/Delta.dll";

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
