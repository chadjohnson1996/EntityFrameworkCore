using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcSubmittalItems
    {
        public DcSubmittalItems()
        {
            DcSubmittalCorrespondences = new HashSet<DcSubmittalCorrespondences>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string SubmittalPackageNo { get; set; }
        public string DcSubmittalNo { get; set; }
        public int RevisionNo { get; set; }
        public int LineNo { get; set; }
        public decimal Quantity { get; set; }
        public string InventoryFlag { get; set; }
        public string ItemNo { get; set; }
        public string NonInvNo { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
        public string ItemActionFlag { get; set; }
        public string DocActivityNo { get; set; }
        public string ItemActionDescNo { get; set; }
        public DateTime? ActionDate { get; set; }
        public string DrawSpecNumber { get; set; }
        public string SectionNumber { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string DocStatusNo { get; set; }
        public string CompanyId { get; set; }
        public string DcSubmittalId { get; set; }
        public string DocActivityId { get; set; }
        public string DocStatusId { get; set; }
        public string ItemActionDescId { get; set; }
        public string ItemId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string NonInvId { get; set; }
        public string RevisionId { get; set; }
        public string SubmittalPackageId { get; set; }
        public int OrdinalPosition { get; set; }

        public DcSubmittalRevisions DcSubmittalRevisions { get; set; }
        public DcSubmittals DcSubmittals { get; set; }
        public DocActivities DocActivities { get; set; }
        public DocStatuses DocStatuses { get; set; }
        public Items Items { get; set; }
        public ICollection<DcSubmittalCorrespondences> DcSubmittalCorrespondences { get; set; }
    }
}
