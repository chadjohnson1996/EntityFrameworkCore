using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisJcQuantity
    {
        public int CompanyNum { get; set; }
        public int TimecardXref { get; set; }
        public string JobNum { get; set; }
        public int TransactionNum { get; set; }
        public int LineNum { get; set; }
        public string TimecardType { get; set; }
        public DateTime? Dated { get; set; }
        public string PhaseNum { get; set; }
        public string CostCodeNum { get; set; }
        public decimal JcQuantity { get; set; }
    }
}
