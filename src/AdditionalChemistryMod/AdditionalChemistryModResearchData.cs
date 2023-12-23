using Mafi;
using Mafi.Base;
using Mafi.Core.Mods;
using Mafi.Core.Research;

namespace AdditionalChemistryMod;

internal class AdditionalChemistryModResearchData : IResearchNodesData
{

    public void RegisterData(ProtoRegistrator registrator)
    {

        ResearchNodeProto nodeProto = registrator.ResearchNodeProtoBuilder
            .Start("Unlock MyMod stuff!", AdditionalChemistryModIds.Research.UnlockCO2Capturing)
            .Description("This unlocks all the awesome stuff in AdditionalChemistryMod!")
            .SetCosts(new ResearchCostsTpl(4))
            .AddRecipeToUnlock(AdditionalChemistryModIds.Recipes.CO2Capturing)
            .BuildAndAdd();

        nodeProto.GridPosition = new Vector2i(96, 16);
        nodeProto.AddParent(registrator.PrototypesDb.GetOrThrow<ResearchNodeProto>(Ids.Research.CarbonDioxideRecycling));

    }

}
