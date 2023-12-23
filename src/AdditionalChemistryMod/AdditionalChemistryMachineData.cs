using Mafi;
using Mafi.Base;
using Mafi.Core.Entities.Animations;
using Mafi.Core.Entities.Static.Layout;
using Mafi.Core.Mods;

namespace AdditionalChemistryMod;

internal class AdditionalChemistryData : IModData
{

    public void RegisterData(ProtoRegistrator registrator)
    {

        // Example of a new recipe.
        registrator.RecipeProtoBuilder
            .Start(name: "Air Caption",
                recipeId: AdditionalChemistryModIds.Recipes.CO2Capturing,
                machineId: Ids.Machines.AirSeparator)
            .SetDuration(60.Seconds())
            .AddOutput(72, Ids.Products.CarbonDioxide)
            .BuildAndAdd();
    }
}
