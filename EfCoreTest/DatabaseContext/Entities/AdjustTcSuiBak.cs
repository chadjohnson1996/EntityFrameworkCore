﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AdjustTcSuiBak
    {
        public int BackupSetId { get; set; }
        public int BackupId { get; set; }
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int SequenceNo { get; set; }
        public string AdjustingTcType { get; set; }
        public int LineNo { get; set; }
        public string State { get; set; }
        public string CountyNo { get; set; }
        public decimal? HoursEarnings { get; set; }
        public decimal? AdditionalEarnings { get; set; }
        public decimal? Hours { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CountyId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string SequenceId { get; set; }
    }
}
