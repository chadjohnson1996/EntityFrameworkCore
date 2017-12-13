using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class FedTaxAmounts
    {
        public FedTaxAmounts()
        {
            FedTaxBrackets = new HashSet<FedTaxBrackets>();
        }

        public int CompanyNo { get; set; }
        public DateTime EffectiveDate { get; set; }
        public decimal? FicaRateEe { get; set; }
        public decimal? FicaRateEr { get; set; }
        public decimal? FicaLimit { get; set; }
        public decimal? FutaLimit { get; set; }
        public decimal? AmountPerExemption { get; set; }
        public decimal? FutaRate { get; set; }
        public decimal? MedicareRateEe { get; set; }
        public decimal? MedicareRateEr { get; set; }
        public decimal? MedicareOnlyLimit { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public decimal NonresidentAlienAnnualAmount { get; set; }
        public decimal EmployeeMedicareEarningsThreshold { get; set; }
        public decimal MedicareRateEeAboveThreshold { get; set; }

        public FedTaxTable CompanyNoNavigation { get; set; }
        public ICollection<FedTaxBrackets> FedTaxBrackets { get; set; }
    }
}
