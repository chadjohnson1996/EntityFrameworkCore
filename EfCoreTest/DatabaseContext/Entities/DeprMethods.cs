using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DeprMethods
    {
        public DeprMethods()
        {
            AssetBooks = new HashSet<AssetBooks>();
            AssetCategories = new HashSet<AssetCategories>();
            AssetCategoriesBooks = new HashSet<AssetCategoriesBooks>();
            DeprJournalD = new HashSet<DeprJournalD>();
            DeprPercents = new HashSet<DeprPercents>();
            Equipment = new HashSet<Equipment>();
        }

        public int CompanyNo { get; set; }
        public string DeprCode { get; set; }
        public string DeprMethod { get; set; }
        public string Description { get; set; }
        public string BasedOn { get; set; }
        public decimal NbrOfYears { get; set; }
        public decimal AnnualPerc { get; set; }
        public string DeprBase { get; set; }
        public string PercentType { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string PctDeprBase { get; set; }
        public string CompanyId { get; set; }
        public decimal NbrOfMonths { get; set; }
        public string UsefulLifeType { get; set; }

        public ICollection<AssetBooks> AssetBooks { get; set; }
        public ICollection<AssetCategories> AssetCategories { get; set; }
        public ICollection<AssetCategoriesBooks> AssetCategoriesBooks { get; set; }
        public ICollection<DeprJournalD> DeprJournalD { get; set; }
        public ICollection<DeprPercents> DeprPercents { get; set; }
        public ICollection<Equipment> Equipment { get; set; }
    }
}
