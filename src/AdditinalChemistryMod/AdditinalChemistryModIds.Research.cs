using Mafi.Base;
using Mafi.Core.Research;
using ResNodeID = Mafi.Core.Research.ResearchNodeProto.ID;

namespace AdditinalChemistryMod;

public partial class AdditinalChemistryModIds
{

    public partial class Research
    {

        [ResearchCosts(4)]
        public static readonly ResNodeID UnlockCO2Capturing = Ids.Research.CreateId("UnlockCO2Capturing");

    }

}
