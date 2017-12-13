using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcSubmittalRevisions
    {
        public DcSubmittalRevisions()
        {
            DcSubmittalCorrespondences = new HashSet<DcSubmittalCorrespondences>();
            DcSubmittalItems = new HashSet<DcSubmittalItems>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string SubmittalPackageNo { get; set; }
        public string DcSubmittalNo { get; set; }
        public int RevisionNo { get; set; }
        public string Description { get; set; }
        public string DocStatusNo { get; set; }
        public DateTime? SentDate { get; set; }
        public DateTime? ReceivedDate { get; set; }
        public DateTime? ReturnedDate { get; set; }
        public DateTime? ForwardedDate { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcSubmittalId { get; set; }
        public string DocStatusId { get; set; }
        public string JobId { get; set; }
        public string RevisionId { get; set; }
        public string SubmittalPackageId { get; set; }

        public DcSubmittals DcSubmittals { get; set; }
        public DocStatuses DocStatuses { get; set; }
        public ICollection<DcSubmittalCorrespondences> DcSubmittalCorrespondences { get; set; }
        public ICollection<DcSubmittalItems> DcSubmittalItems { get; set; }
    }
}
