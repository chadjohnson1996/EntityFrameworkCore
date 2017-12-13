using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisGl
    {
        public int CompanyNum { get; set; }
        public int TimecardXref { get; set; }
        public decimal AccountNum { get; set; }
        public string JobNum { get; set; }
        public decimal? AmountDb { get; set; }
        public decimal? AmountCr { get; set; }
        public decimal? BaseAccount { get; set; }
        public decimal? DivAccount1 { get; set; }
        public decimal? DivAccount2 { get; set; }
        public decimal? DivAccount3 { get; set; }
        public decimal? DivAccount4 { get; set; }
    }
}
