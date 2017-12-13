using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class BookTypes
    {
        public BookTypes()
        {
            AssetBooks = new HashSet<AssetBooks>();
            AssetCategoriesBooks = new HashSet<AssetCategoriesBooks>();
            ControlFa = new HashSet<ControlFa>();
            DeprJournalD = new HashSet<DeprJournalD>();
            DeprJournalH = new HashSet<DeprJournalH>();
        }

        public int CompanyNo { get; set; }
        public string BookType { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string DeprInterval { get; set; }
        public string FirstYearDepr { get; set; }
        public string StartDepr { get; set; }
        public string LastYearDepr { get; set; }
        public string EndDepr { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }

        public ICollection<AssetBooks> AssetBooks { get; set; }
        public ICollection<AssetCategoriesBooks> AssetCategoriesBooks { get; set; }
        public ICollection<ControlFa> ControlFa { get; set; }
        public ICollection<DeprJournalD> DeprJournalD { get; set; }
        public ICollection<DeprJournalH> DeprJournalH { get; set; }
    }
}
