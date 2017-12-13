using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchBoardDat
    {
        public string UserId { get; set; }
        public string MenuSelect { get; set; }
        public string JobDisplay { get; set; }
        public string DispatchCenter { get; set; }
        public string Quicklookupflag { get; set; }
        public string SchedulingDisplay { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string DispatchBoardStyle { get; set; }
        public int CompanyNo { get; set; }
        public string CompanyId { get; set; }
        public int BoardLineColor { get; set; }
    }
}
