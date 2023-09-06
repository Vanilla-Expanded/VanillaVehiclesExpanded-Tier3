using RimWorld;
using Vehicles;
using Verse;

namespace VanillaVehiclesExpanded_Tier3
{
    public class ThoughtWorker_FeelingClassyInCar : ThoughtWorker
    {
        public override ThoughtState CurrentStateInternal(Pawn p)
        {
            if (p.GetVehicle() is VehiclePawn vehiclePawn && vehiclePawn.def == VVETier3_DefOf.VVE_Lightning)
            {
                return ThoughtState.ActiveDefault;
            }
            return ThoughtState.Inactive;
        }
    }
}
