using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlApChameleonFieldMap
    {
        public int CompanyNo { get; set; }
        public string FoundationColumnName { get; set; }
        public string ChameleonCabinetName { get; set; }
        public string ChameleonFieldName { get; set; }
        public int OrdinalPosition { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }

        public ControlAp CompanyNoNavigation { get; set; }
    }
}
