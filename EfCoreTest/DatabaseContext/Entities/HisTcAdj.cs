﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class HisTcAdj
    {
        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public DateTime Dated { get; set; }
        public string PayPeriodNo { get; set; }
        public string PayMethod { get; set; }
        public int TimecardXref { get; set; }
        public int SequenceNo { get; set; }
        public string TcAdjType { get; set; }
        public string ThirdParty { get; set; }
        public string ThirdPartyWage { get; set; }
        public int ComputeSequence { get; set; }
        public decimal? FicaEarnings { get; set; }
        public decimal? FicaEmployee { get; set; }
        public decimal? FicaEmployer { get; set; }
        public decimal? MedOnlyEarnings { get; set; }
        public decimal? MedEmployee { get; set; }
        public decimal? MedEmployer { get; set; }
        public decimal? FutaEligible { get; set; }
        public decimal? FutaBase { get; set; }
        public decimal? FutaAmount { get; set; }
        public decimal? FicaGross { get; set; }
        public decimal? MedicareGross { get; set; }
        public string DeptNo { get; set; }
        public string PaymentGroupNo { get; set; }
        public DateTime? DateWeekEnded { get; set; }
        public DateTime? DatePosted { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeptId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }
        public string PaymentGroupId { get; set; }
        public string SequenceId { get; set; }
        public string FutaState { get; set; }
        public decimal MedEmployeeAboveThreshold { get; set; }
        public decimal MedEarningsAboveThreshold { get; set; }
        public int? AuditNumber { get; set; }

        public Employees Employees { get; set; }
    }
}
