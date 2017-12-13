using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdBoardUserSession
    {
        public int CompanyNo { get; set; }
        public string UserName { get; set; }
        public int UniqueNo { get; set; }
        public string BoardType { get; set; }
        public int MonthlyVisible { get; set; }
        public int WeeklyVisilbe { get; set; }
        public int UnassignedVisible { get; set; }
        public int DwRtrVisible { get; set; }
        public int FinderVisible { get; set; }
        public int BottomHeight { get; set; }
        public int RightWidth { get; set; }
        public string ViewReport { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int MobileActivityVisible { get; set; }
        public string CompanyId { get; set; }
        public string UniqueId { get; set; }
    }
}
