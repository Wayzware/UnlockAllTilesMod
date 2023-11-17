using HarmonyLib;

namespace Wayz.CS2.UnlockAllTilesMod.Patches;

[HarmonyPatch(typeof(Game.Simulation.MapTilePurchaseSystem), "cost", MethodType.Getter)]
public static class MapTilePurchaseSystemPatch_Cost
{
    [HarmonyPrefix]
    public static bool Prefix(Game.Simulation.MapTilePurchaseSystem __instance, ref int __result)
    {
        __result = 0;
        return false;
    }
}