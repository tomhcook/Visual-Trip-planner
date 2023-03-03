using SpaceWarp.API.Configuration;
using Newtonsoft.Json;

namespace VisualTripPlanner
{
    [JsonObject(MemberSerialization.OptOut)]
    [ModConfig]
    public class VisualTripPlannerConfig
    {
         [ConfigField("pi")] [ConfigDefaultValue(3.14159)] public double pi;
    }
}