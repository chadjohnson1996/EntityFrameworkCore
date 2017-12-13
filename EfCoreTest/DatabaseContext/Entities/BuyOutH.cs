using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class BuyOutH
    {
        public BuyOutH()
        {
            BuyOutD = new HashSet<BuyOutD>();
        }

        public int CompanyNo { get; set; }
        public int BuyOutNo { get; set; }
        public DateTime BuyOutDate { get; set; }
        public string JobNo { get; set; }
        public string VendorNo { get; set; }
        public string ItemCategoryNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string BuyOutId { get; set; }
        public string CompanyId { get; set; }
        public string ItemCategoryId { get; set; }
        public string JobId { get; set; }
        public string VendorId { get; set; }

        public ItemCategories ItemCategories { get; set; }
        public Jobs Jobs { get; set; }
        public Vendors Vendors { get; set; }
        public ICollection<BuyOutD> BuyOutD { get; set; }
    }
}
