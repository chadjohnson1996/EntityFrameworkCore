using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcPunchListItems
    {
        public DcPunchListItems()
        {
            DcPunchListItemActivities = new HashSet<DcPunchListItemActivities>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcPunchListNo { get; set; }
        public int LineNo { get; set; }
        public string DocItemNo { get; set; }
        public string DrawSpecNumber { get; set; }
        public string SectionNumber { get; set; }
        public string Description { get; set; }
        public string PerformingContactNo { get; set; }
        public int? PerformingContactLineNo { get; set; }
        public DateTime TargetDate { get; set; }
        public string DocStatusNo { get; set; }
        public DateTime? ClosedDate { get; set; }
        public int OrdinalPosition { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcPunchListId { get; set; }
        public string DocItemId { get; set; }
        public string DocStatusId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PerformingContactLineId { get; set; }
        public string PerformingContactId { get; set; }

        public DcPunchLists DcPunchLists { get; set; }
        public DocStatuses DocStatuses { get; set; }
        public Jobs Jobs { get; set; }
        public CmContactPersons PerformingContact { get; set; }
        public CmContacts PerformingContactNoNavigation { get; set; }
        public ICollection<DcPunchListItemActivities> DcPunchListItemActivities { get; set; }
    }
}
