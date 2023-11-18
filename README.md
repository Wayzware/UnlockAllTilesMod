# UnlockAllTilesMod
 
Unlocks all 529 tiles for Cities Skylines II maps and reduces their cost to $0.

The tiles will be available for "purchase" after hitting the first XP milestone.

## Installation - Thunderstore
If you wish to use a mod manager, you can go to the [Unlock All Tiles mod Thunderstore page](https://thunderstore.io/c/cities-skylines-ii/p/Wayzware/UnlockAllTiles/), to automatically install the mod with their mod manager.

## Installation - Manual
1. Install [BepInEx 6 Bleeding Edge build](https://builds.bepinex.dev/projects/bepinex_be) or BepInEx 5. 

   The pre-release version of BepInEx 6 available on their GitHub release page is quite outdated (dated August 2022) and may not support loading this mod. Please download the Bleeding Edge version from [their website](https://builds.bepinex.dev/projects/bepinex_be)

   * Download `BepInEx-Unity.Mono-win-x64-6.0.0-be.674+82077ec.zip` (or a newer version), and unzip all of its contents into the game's installation directory, typically `C:/Program Files (x86)/Steam/steamapps/common/Cities Skylines II`

   * The installation directory should now have the `BepInEx` folder, the `doorstop_config.ini` file, and the `winhttp.dll` file

2. Run the game once, then close it. You can close it when the main menu appears

3. Download the mod from the [release page](https://github.com/Wayzware/UnlockAllTilesMod/releases). Make sure you select the download that is compatible with your version of BepInEx. Unzip it into the `Cities Skylines II/BepInEx/plugins` folder.

4. Launch the game, and your mods should be loaded automatically

## Compiling the Mod Yourself
The project should be able to build without extra work after cloning if you are using BepInEx 6.

You will need to add references to Unity yourself if using BepInEx 5 and wish to compile the project.

In the .csproj, you can set the location of your game install and enable the PostBuild install step, to automatically install the mod after build.

## Thank You
* optimus-code for their [template mod repo](https://github.com/optimus-code/Cities2Modding/tree/main), especially the .csproj
* [slyh](https://github.com/slyh) for their installation instructions
* The creators of Harmony and BepInEx
* The Cities Skylines II modding discord in general

(This mod is largely untested and I take absolutely no responsibility if it somehow ends up breaking your saves)
