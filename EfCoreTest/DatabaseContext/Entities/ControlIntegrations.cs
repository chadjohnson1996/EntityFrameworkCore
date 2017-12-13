using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlIntegrations
    {
        public int CompanyNo { get; set; }
        public string ProestPartnerKey { get; set; }
        public string ProestCompanyKey { get; set; }
        public string ProestLaborClass { get; set; }
        public string ProestMaterialsClass { get; set; }
        public string ProestSubsClass { get; set; }
        public string ProestEquipmentClass { get; set; }
        public string ProestOtherClass { get; set; }
        public string ProestSortTypePhase { get; set; }
    }
}
