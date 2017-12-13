using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdOverFlowTable
    {
        public int CompanyNo { get; set; }
        public int SequenceNumber { get; set; }
        public int TechnicianNo { get; set; }
        public int? Position { get; set; }
        public int RowUniqueNo { get; set; }
        public string RowType { get; set; }
        public string UniqueIdn { get; set; }
        public string SpecifiedNo { get; set; }
        public int? TimeCalled { get; set; }
        public DateTime? DateCalled { get; set; }
        public string BoardType { get; set; }
    }
}
