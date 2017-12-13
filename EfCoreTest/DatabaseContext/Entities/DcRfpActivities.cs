using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcRfpActivities
    {
        public DcRfpActivities()
        {
            DcRfpActivityCorrespondences = new HashSet<DcRfpActivityCorrespondences>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcRfpNo { get; set; }
        public int LineNo { get; set; }
        public string CmContactNo { get; set; }
        public int PersonLineNo { get; set; }
        public DateTime FwdDate { get; set; }
        public DateTime RespondByDate { get; set; }
        public string RepliedFlag { get; set; }
        public DateTime? RepliedDate { get; set; }
        public string DocStatusNo { get; set; }
        public string NotifiedFlag { get; set; }
        public DateTime? NotifiedDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CmContactId { get; set; }
        public string CompanyId { get; set; }
        public string DcRfpId { get; set; }
        public string DocStatusId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PersonLineId { get; set; }

        public CmContacts CmContactNoNavigation { get; set; }
        public CmContactPersons CmContactPersons { get; set; }
        public DcRfps DcRfps { get; set; }
        public DocStatuses DocStatuses { get; set; }
        public ICollection<DcRfpActivityCorrespondences> DcRfpActivityCorrespondences { get; set; }
    }
}
