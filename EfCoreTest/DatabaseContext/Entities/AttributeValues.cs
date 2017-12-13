using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class AttributeValues
    {
        public int CompanyNo { get; set; }
        public string AttributeName { get; set; }
        public string AttributeValue { get; set; }
        public int Rank { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DefaultValue { get; set; }
        public string DefaultValueSd { get; set; }

        public Attributes Attributes { get; set; }
    }
}
