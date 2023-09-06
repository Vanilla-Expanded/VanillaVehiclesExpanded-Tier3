using HarmonyLib;
using RimWorld;
using VanillaVehiclesExpanded;
using Vehicles;
using Verse;

namespace VanillaVehiclesExpanded_Tier3
{
    [HarmonyPatch(typeof(VehiclePawn), "DisembarkPawn")]
    public static class VehiclePawn_DisembarkPawn_Pawn
    {
        public static void Postfix(VehiclePawn __instance, Pawn pawn)
        {
            if (__instance.VehicleDef == VVETier3_DefOf.VVE_Lightning && pawn.needs?.mood?.thoughts?.memories != null)
            {
                var tracker = pawn.GetVehicleTracker(__instance.VehicleDef);
                int spentTime = tracker.disembarkedFromTicks - tracker.boardedToTicks;
                var thought = ThoughtMaker.MakeThought(VVETier3_DefOf.VVE_FeelingClassy) as Thought_Memory;
                thought.durationTicksOverride = spentTime / 10;
                pawn.needs.mood.thoughts.memories.TryGainMemory(thought);
                pawn.needs.mood.thoughts.situational.Notify_SituationalThoughtsDirty();
            }
        }
    }
}
