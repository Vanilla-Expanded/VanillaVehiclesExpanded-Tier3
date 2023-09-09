using HarmonyLib;
using RimWorld;
using Vehicles;
using Verse;

namespace VanillaVehiclesExpanded_Tier3
{
    [HarmonyPatch(typeof(SteadyEnvironmentEffects), "TryDoDeteriorate")]
    public static class SteadyEnvironmentEffects_TryDoDeteriorate_Patch
    {
        public static bool Prefix(Thing t)
        {
            if (t.ParentHolder is Pawn_InventoryTracker tracker
                && tracker.pawn is VehiclePawn vehicle && vehicle.Drafted && vehicle.def == VVETier3_DefOf.VVE_Hermano
                && vehicle.CompFueledTravel.Fuel > 0)
            {
                return false;
            }
            return true;
        }
    }
}
