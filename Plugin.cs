#if BEPINEX6
using BepInEx.Unity.Mono;
#endif
using BepInEx;
using HarmonyLib;
using System.Reflection;
using BepInEx.Logging;

namespace Wayz.CS2.UnlockAllTilesMod;

[BepInPlugin("Wayz.CS2.UnlockAllTilesMod", "Unlock All Tiles Mod", "1.1.0")]
#pragma warning disable BepInEx002
public class UnlockAllTilesMod : BaseUnityPlugin
#pragma warning restore BepInEx002
{
    public static ManualLogSource GameLogger { get; private set; }
    public static IWayzSettingsManager SettingsManager { get; private set; }
    internal static UnlockAllTilesSettings ModSettings { get; private set; }

    private void Awake()
    {
        GameLogger = Logger;
        SettingsManager = new WayzSettingsManager();

        if (SettingsManager.TryGetSettings<UnlockAllTilesSettings>("UnlockAllTiles_Wayz", "settings", out var settings))
        {
            Logger.LogInfo("Successfully loaded settings");
            ModSettings = settings;
        }
        else
        {
            ModSettings = new UnlockAllTilesSettings();
            try
            {
                SettingsManager.SaveSettings("UnlockAllTiles_Wayz", "settings", ModSettings);
                Logger.LogInfo("Created new settings file");
            }
            catch
            {
                Logger.LogWarning("Unable to save settings file, using default settings");
            }
        }

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