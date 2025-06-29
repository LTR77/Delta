using BepInEx;
using BepInEx.Logging;
using HarmonyLib;
using System.Reflection;
using UnityEngine;
using GorillaX.Mods;

[BepInPlugin(GorillaX.PluginInfo.GUID, GorillaX.PluginInfo.Name, GorillaX.PluginInfo.Version)]
public class PluginLoader : BaseUnityPlugin
{
    private void Awake()
    {
        var harmony = new Harmony(GorillaX.PluginInfo.GUID);
        harmony.PatchAll(Assembly.GetExecutingAssembly());
        GorillaX.Menu.Main.Logger.LogInfo("Loading IronMonkey assets...");
        IronMonkey.Load();
        GorillaX.Menu.Main.Logger.LogInfo("IronMonkey assets loaded!");
    }
}