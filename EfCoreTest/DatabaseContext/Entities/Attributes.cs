using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Attributes
    {
        public Attributes()
        {
            AttributeValues = new HashSet<AttributeValues>();
        }

        public int CompanyNo { get; set; }
        public string AttributeName { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DefaultAttributeNameFlag { get; set; }

        public ICollection<AttributeValues> AttributeValues { get; set; }
    }
}
