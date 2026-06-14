// Full VRFS Mod Menu Code (copy into your BepInEx project)
// Update class/method names from your dnSpy dump

using BepInEx;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;
using UnityEngine;

[BepInPlugin("com.sided.vrfsmodmenu", "VRFS Mod Menu", "1.0")]
public class VRFSModMenu : BasePlugin
{
    public static bool SuperKicks = false;
    public static float KickMultiplier = 4f;
    public static bool Fly = false;
    public static float FlySpeed = 15f;
    public static bool Noclip = false;
    public static bool LagAll = false;
    public static bool FootballGun = false;

    public override void Load()
    {
        Harmony.CreateAndPatchAll(typeof(VRFSModMenu));
        GameObject menu = new GameObject("VRFSModMenuGUI");
        menu.AddComponent<ModMenu>();
        Debug.Log("[VRFS Mod Menu] Loaded successfully");
    }

    // Update these patches with real names from dnSpy
    [HarmonyPatch(typeof(Ball), "Kick")]
    public static class SuperKickPatch { /* full patch code as in README */ }

    [HarmonyPatch(typeof(PlayerController), "Update")]
    public static class FlyPatch { /* full patch code */ }

    // ... (full code from main README)
}

public class ModMenu : MonoBehaviour { /* GUI code from main README */ }