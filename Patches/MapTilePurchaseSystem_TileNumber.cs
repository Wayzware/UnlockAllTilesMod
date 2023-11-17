using Game.Simulation;
using HarmonyLib;
using System.Reflection;

namespace Wayz.CS2.UnlockAllTilesMod.Patches;

[HarmonyPatch(typeof(Game.Simulation.MapTilePurchaseSystem), "OnCreate")]
public static class MapTilePurchaseSystemPatch_TileNumber
{
    [HarmonyPrefix]
    public static bool Prefix(Game.Simulation.MapTilePurchaseSystem __instance)
    {
        var field = typeof(MapTilePurchaseSystem).GetField("kAutoUnlockedTiles", BindingFlags.Static | BindingFlags.NonPublic);
        field?.SetValue(null, 526); // some tiles are automatically unlocked, so this isnt 529
        return true;
    }
}