﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AcaOngoingPeriods
    {
        public int CompanyNo { get; set; }
        public string MeasurementGroupNo { get; set; }
        public int OngoingPeriodNum { get; set; }
        public DateTime? MeasurementStartDate { get; set; }
        public DateTime? MeasurementEndDate { get; set; }
        public DateTime? AdminStartDate { get; set; }
        public DateTime? AdminEndDate { get; set; }
        public DateTime? StabilityStartDate { get; set; }
        public DateTime? StabilityEndDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string MeasurementGroupId { get; set; }

        public AcaMeasurementGroups AcaMeasurementGroups { get; set; }
    }
}
