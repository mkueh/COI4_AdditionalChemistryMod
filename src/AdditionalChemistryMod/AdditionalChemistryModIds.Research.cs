using Mafi.Base;
using Mafi.Core.Research;
using ResNodeID = Mafi.Core.Research.ResearchNodeProto.ID;

namespace AdditionalChemistryMod;

public partial class AdditionalChemistryModIds
{

    public partial class Research
    {

        [ResearchCosts(4)]
        public static readonly ResNodeID UnlockCO2Capturing = Ids.Research.CreateId("UnlockCO2Capturing");

    }

}
