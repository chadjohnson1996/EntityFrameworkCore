using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobScheduleLayout
    {
        public int CompanyNo { get; set; }
        public int JobsTableLen { get; set; }
        public int JobNoColLen { get; set; }
        public int JobNameColLen { get; set; }
        public int JobsStartColLen { get; set; }
        public int JobsDurationColLen { get; set; }
        public int JobsActualColLen { get; set; }
        public int JobsManualColLen { get; set; }
        public int JobsResetFlag { get; set; }
        public int ResourcesTableLen { get; set; }
        public int ResourceNoColLen { get; set; }
        public int ResourceNameColLen { get; set; }
        public int ResourceQtyColLen { get; set; }
        public int ResourcesResetFlag { get; set; }
        public int JobTableLen { get; set; }
        public int TaskNoColLen { get; set; }
        public int TaskNameColLen { get; set; }
        public int StartColLen { get; set; }
        public int DurationColLen { get; set; }
        public int ActualColLen { get; set; }
        public int ManualColLen { get; set; }
        public int JobResetFlag { get; set; }
        public int JobNoColPrint { get; set; }
        public int JobNameColPrint { get; set; }
        public int JobsStartColPrint { get; set; }
        public int JobsDurationColPrint { get; set; }
        public int JobsActualColPrint { get; set; }
        public int JobsManualColPrint { get; set; }
        public int ResourceNoColPrint { get; set; }
        public int ResourceNameColPrint { get; set; }
        public int ResourceQtyColPrint { get; set; }
        public int TaskNoColPrint { get; set; }
        public int TaskNameColPrint { get; set; }
        public int StartColPrint { get; set; }
        public int DurationColPrint { get; set; }
        public int ActualColPrint { get; set; }
        public int ManualColPrint { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public int JobsStopColLen { get; set; }
        public int StopColLen { get; set; }
        public int JobsStopColPrint { get; set; }
        public int StopColPrint { get; set; }
        public int LeadLagOption { get; set; }

        public Companies CompanyNoNavigation { get; set; }
    }
}
