using BepInEx;
using System.ComponentModel;

namespace GorillaX.Patches
{
    [Description(GorillaX.PluginInfo.Description)]
    [BepInPlugin(GorillaX.PluginInfo.GUID, GorillaX.PluginInfo.Name, GorillaX.PluginInfo.Version)]
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
