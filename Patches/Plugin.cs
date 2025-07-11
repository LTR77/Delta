using BepInEx;
using System.ComponentModel;

namespace Delta.Patches
{
    [Description(Delta.PluginInfo.Description)]
    [BepInPlugin(Delta.PluginInfo.GUID, Delta.PluginInfo.Name, Delta.PluginInfo.Version)]
    public class HarmonyPatches : BaseUnityPlugin
    {
        private void OnEnable()
        {
            Menu.ApplyHarmonyPatches();
        }

        private void OnDisable()
        {
            Menu.RemoveHarmonyPatches();
        }
    }
}
