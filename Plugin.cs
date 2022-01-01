using BepInEx;
using HarmonyLib;

#pragma warning disable 169

namespace FuckTheBrokeBridge
{

    [BepInPlugin(PluginGuid, PluginName, PluginVersion)]
    public class Plugin : BaseUnityPlugin
    {
        private const string PluginGuid = "io.github.xhayper.fuckthebrokenbridge";
        private const string PluginName = "FuckTheBrokenBridge";
        private const string PluginVersion = "1.0.0.0";

        private void Awake()
        {
            Harmony harmony = new Harmony(PluginGuid);
            harmony.PatchAll();
        }
    }
}