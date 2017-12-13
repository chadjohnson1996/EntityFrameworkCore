using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlQb
    {
        public int CompanyNo { get; set; }
        public string EnableQbIntegration { get; set; }
        public string PreventBlankQbJobField { get; set; }
        public string PreventBlankGlAccounts { get; set; }
        public string QbGlPrefixN { get; set; }
        public string IntegrationBasedOnAccountNumbers { get; set; }
        public string DefaultLaborAcctN { get; set; }
        public string DefaultBurdenAcctN { get; set; }
        public string DefaultFicaExpenseAcctN { get; set; }
        public string DefaultFutaSutaExpenseAcctN { get; set; }
        public string DefaultWCExpenseAcctN { get; set; }
        public string DefaultFringeExpenseAcctN { get; set; }
        public string Default401kMatchExpenseAcctN { get; set; }
        public string DefaultExtraBurdenExpenseAcctN { get; set; }
        public string DefaultImpoundAcctN { get; set; }
        public string DefaultPayrollFeesAcctN { get; set; }
        public string DefaultWCPayableAcctN { get; set; }
        public string DefaultUniDedPayableAcctN { get; set; }
        public string DefaultUniFrgPayableAcctN { get; set; }
        public string DefaultMiscDedPayableAcctN { get; set; }
        public string Default401kMatchPayableAcctN { get; set; }
        public string DefaultOtherPayableAcctN { get; set; }
        public string DefaultLaborAcctName { get; set; }
        public string DefaultBurdenAcctName { get; set; }
        public string DefaultFicaExpenseAcctName { get; set; }
        public string DefaultFutaSutaExpenseAcctName { get; set; }
        public string DefaultWCExpenseAcctName { get; set; }
        public string DefaultFringeExpenseAcctName { get; set; }
        public string Default401kMatchExpenseAcctName { get; set; }
        public string DefaultExtraBurdenExpenseAcctName { get; set; }
        public string DefaultImpoundAcctName { get; set; }
        public string DefaultPayrollFeesAcctName { get; set; }
        public string DefaultWCPayableAcctName { get; set; }
        public string DefaultUniDedPayableAcctName { get; set; }
        public string DefaultUniFrgPayableAcctName { get; set; }
        public string DefaultMiscDedPayableAcctName { get; set; }
        public string Default401kMatchPayableAcctName { get; set; }
        public string DefaultOtherPayableAcctName { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public int QbSequenceN { get; set; }
    }
}
