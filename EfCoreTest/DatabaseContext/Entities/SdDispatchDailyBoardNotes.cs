using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdDispatchDailyBoardNotes
    {
        public int CompanyNo { get; set; }
        public int TechnicianNo { get; set; }
        public int TimeCalled { get; set; }
        public DateTime DailyDate { get; set; }
        public string RowAddedBy { get; set; }
        public DateTime RowAddedOn { get; set; }
        public int SequenceNumber { get; set; }
        public string UserNo { get; set; }
        public int? Backgroundcolor { get; set; }
        public int? Foregroundcolor { get; set; }
        public string CellNote { get; set; }
    }
}
