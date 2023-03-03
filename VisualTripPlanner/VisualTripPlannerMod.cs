using SpaceWarp.API.Mods;

namespace VisualTripPlanner
{
    [MainMod]
     public class VisualTripPlannerMod : Mod
    {
        public override void OnInitialized()
        {
            Logger.Info("Mod is initialized");
        }
    }
}