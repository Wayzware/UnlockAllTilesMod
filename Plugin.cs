#define BEPINEX6
#if BEPINEX6

using BepInEx.Unity.Mono;

#endif

using BepInEx;
using HarmonyLib;
using System.Reflection;

namespace Wayz.CS2.UnlockAllTilesMod;

[BepInPlugin("Wayz.C2.UnlockAllTilesMod", "Unlock All Tiles Mod", "1.0.0")]
public class UnlockAllTilesMod : BaseUnityPlugin
{
    private void Awake()
    {
        var harmony = Harmony.CreateAndPatchAll(Assembly.GetExecutingAssembly(), MyPluginInfo.PLUGIN_GUID + "_Cities2Harmony");

        var patchedMethods = harmony.GetPatchedMethods();

        // Plugin startup logic
        Logger.LogInfo($"Plugin {MyPluginInfo.PLUGIN_GUID} {MyPluginInfo.PLUGIN_VERSION} is loaded! Patched methods: " + patchedMethods.Count());

        foreach (var patchedMethod in patchedMethods)
        {
            Logger.LogInfo($"Patched method: {patchedMethod.Module.Name}:{patchedMethod.Name}");
        }
    }
}