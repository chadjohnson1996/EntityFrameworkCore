﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AdjustTcUnionsBak
    {
        public int BackupSetId { get; set; }
        public int BackupId { get; set; }
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int SequenceNo { get; set; }
        public string AdjustingTcType { get; set; }
        public int LineNo { get; set; }
        public string UnionNo { get; set; }
        public string TradeNo { get; set; }
        public string DeductionFringeNo { get; set; }
        public decimal? Amount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Taxable { get; set; }
        public string CompanyId { get; set; }
        public string DeductionFringeId { get; set; }
        public string EmployeeId { get; set; }
        public string LineId { get; set; }
        public string SequenceId { get; set; }
        public string TradeId { get; set; }
        public string UnionId { get; set; }
    }
}
