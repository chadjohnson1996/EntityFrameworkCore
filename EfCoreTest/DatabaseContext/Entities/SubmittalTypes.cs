using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SubmittalTypes
    {
        public SubmittalTypes()
        {
            SubmittalItems = new HashSet<SubmittalItems>();
        }

        public int CompanyNo { get; set; }
        public string SubmittalTypeNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string SubmittalTypeId { get; set; }

        public ICollection<SubmittalItems> SubmittalItems { get; set; }
    }
}
