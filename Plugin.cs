using BepInEx;
using BepInEx.Logging;
using HarmonyLib;

#pragma warning disable 169

namespace ActTwoBridgeSkip
{

    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "io.github.xhayper.fuckthebrokenbridge";
        private const string PluginName = "FuckTheBrokenBridge";
        private const string PluginVersion = "1.0.0.0";

        internal static ManualLogSource Log;

        private void Awake()
        {
            Plugin.Log = base.Logger;
            Harmony harmony = new Harmony(PluginGuid);
            harmony.PatchAll();
        }
    }
}