using Game.Simulation;
using HarmonyLib;

namespace Wayz.CS2.UnlockAllTilesMod.Patches;

[HarmonyPatch(typeof(MapTilePurchaseSystem), "get_cost")]
public static class MapTilePurchaseSystemPatch_Cost
{
    [HarmonyPrefix]
    public static bool Prefix(object __instance, ref int __result)
    {
        __result = 0;
        return false;
    }
}