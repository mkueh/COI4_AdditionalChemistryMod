using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Research;

namespace AdditinalChemistryMod;

internal class AdditinalChemistryModResearchData : IResearchNodesData
{

    public void RegisterData(ProtoRegistrator registrator)
    {

        ResearchNodeProto nodeProto = registrator.ResearchNodeProtoBuilder
            .Start("Unlock MyMod stuff!", AdditinalChemistryModIds.Research.UnlockCO2Capturing)
            .Description("This unlocks all the awesome stuff in AdditinalChemistryMod!")
            .SetCosts(new ResearchCostsTpl(4))
            .AddRecipeToUnlock(AdditinalChemistryModIds.Recipes.CO2Capturing)
            .BuildAndAdd();

        nodeProto.GridPosition = new Vector2i(96, 16);
        nodeProto.AddParent(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.CarbonDioxideRecycling));

    }

}
