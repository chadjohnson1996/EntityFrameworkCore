﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Supplies
    {
        public Supplies()
        {
            CustomerSupplies = new HashSet<CustomerSupplies>();
            VendorSupplies = new HashSet<VendorSupplies>();
        }

        public int CompanyNo { get; set; }
        public string SupplyNo { get; set; }
        public string Description { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string SupplyId { get; set; }

        public ICollection<CustomerSupplies> CustomerSupplies { get; set; }
        public ICollection<VendorSupplies> VendorSupplies { get; set; }
    }
}