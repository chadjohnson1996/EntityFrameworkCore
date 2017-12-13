using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AdjustTc
    {
        public AdjustTc()
        {
            AdjustTcEarnings = new HashSet<AdjustTcEarnings>();
            AdjustTcMisc = new HashSet<AdjustTcMisc>();
            AdjustTcSui = new HashSet<AdjustTcSui>();
            AdjustTcSuta = new HashSet<AdjustTcSuta>();
            AdjustTcTaxes = new HashSet<AdjustTcTaxes>();
            AdjustTcUniEarn = new HashSet<AdjustTcUniEarn>();
            AdjustTcUniFrng = new HashSet<AdjustTcUniFrng>();
            AdjustTcUnions = new HashSet<AdjustTcUnions>();
            AdjustTcWc = new HashSet<AdjustTcWc>();
        }

        public int CompanyNo { get; set; }
        public string EmployeeNo { get; set; }
        public int SequenceNo { get; set; }
        public string AdjustingTcType { get; set; }
        public string PayPeriodNo { get; set; }
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
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeptId { get; set; }
        public string EmployeeId { get; set; }
        public string PayPeriodId { get; set; }
        public string SequenceId { get; set; }
        public string ThirdParty { get; set; }
        public string ThirdPartyWage { get; set; }
        public string PaymentGroupNo { get; set; }
        public string PaymentGroupId { get; set; }
        public string FutaState { get; set; }
        public decimal MedEmployeeAboveThreshold { get; set; }
        public decimal MedEarningsAboveThreshold { get; set; }
        public int? InternalBatchNumber { get; set; }

        public Employees Employees { get; set; }
        public ICollection<AdjustTcEarnings> AdjustTcEarnings { get; set; }
        public ICollection<AdjustTcMisc> AdjustTcMisc { get; set; }
        public ICollection<AdjustTcSui> AdjustTcSui { get; set; }
        public ICollection<AdjustTcSuta> AdjustTcSuta { get; set; }
        public ICollection<AdjustTcTaxes> AdjustTcTaxes { get; set; }
        public ICollection<AdjustTcUniEarn> AdjustTcUniEarn { get; set; }
        public ICollection<AdjustTcUniFrng> AdjustTcUniFrng { get; set; }
        public ICollection<AdjustTcUnions> AdjustTcUnions { get; set; }
        public ICollection<AdjustTcWc> AdjustTcWc { get; set; }
    }
}
