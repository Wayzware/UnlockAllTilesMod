using Game.Simulation;
using HarmonyLib;
using System.Reflection;

namespace Wayz.CS2.UnlockAllTilesMod.Patches;

[HarmonyPatch(typeof(MapTilePurchaseSystem), "GetAvailableTiles")]
public static class MapTilePurchaseSystemPatch_TileNumber
{
    [HarmonyPrefix]
    public static bool Prefix(MapTilePurchaseSystem __instance, out int __result)
    {
        var ownedTiles = typeof(MapTilePurchaseSystem).GetMethod("CalculateOwnedTiles", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(__instance, []);
        if (ownedTiles == null)
        {
            __result = 0;
            return true;
        }
        __result = 529 - (int)ownedTiles;
        return false;
    }
}