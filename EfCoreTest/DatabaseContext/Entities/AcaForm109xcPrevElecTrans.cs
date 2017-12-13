using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AcaForm109xcPrevElecTrans
    {
        public AcaForm109xcPrevElecTrans()
        {
            AcaForm1094cPrevElecAggAle = new HashSet<AcaForm1094cPrevElecAggAle>();
            AcaForm1095cPrevElecEmployees = new HashSet<AcaForm1095cPrevElecEmployees>();
        }

        public int CompanyNo { get; set; }
        public int ElecTransNum { get; set; }
        public DateTime DateGenerated { get; set; }
        public string TransmissionType { get; set; }
        public string RecordIdentifier { get; set; }
        public string TransmissionIdentifier { get; set; }
        public string DataFileName { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }

        public AcaForm1094cPrevElecMonthlyValues AcaForm1094cPrevElecMonthlyValues { get; set; }
        public AcaForm109xcPrevElecValues AcaForm109xcPrevElecValues { get; set; }
        public ICollection<AcaForm1094cPrevElecAggAle> AcaForm1094cPrevElecAggAle { get; set; }
        public ICollection<AcaForm1095cPrevElecEmployees> AcaForm1095cPrevElecEmployees { get; set; }
    }
}
