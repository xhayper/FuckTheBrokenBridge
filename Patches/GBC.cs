using HarmonyLib;

namespace FuckTheBrokeBridge
{
    [HarmonyPatch(typeof(GBC.BrokenBridgeEntrance), "BridgeFixed")]
    public class GBC_BrokenBridgeEntrance_BridgeFixed
    {
        [HarmonyPostfix]
        public static void Postfix(ref bool __result)
        {
            __result = true;
        }
    }
}