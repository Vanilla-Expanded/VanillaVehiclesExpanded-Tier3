using HarmonyLib;
using Verse;

namespace VanillaVehiclesExpanded_Tier3
{
    [StaticConstructorOnStartup]
    public static class Startup
    {
        static Startup()
        {
            new Harmony("VanillaVehiclesExpanded_Tier3.Mod").PatchAll();
        }
    }
}
