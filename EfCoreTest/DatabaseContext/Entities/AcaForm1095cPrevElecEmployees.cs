using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AcaForm1095cPrevElecEmployees
    {
        public int CompanyNo { get; set; }
        public int ElecTransNum { get; set; }
        public string EmployeeNo { get; set; }
        public int? EmpRecordId { get; set; }
        public string CorrectedInd { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }

        public AcaForm109xcPrevElecTrans AcaForm109xcPrevElecTrans { get; set; }
    }
}
