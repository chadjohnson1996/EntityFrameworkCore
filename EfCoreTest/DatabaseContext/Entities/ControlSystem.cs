using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlSystem
    {
        public int CompanyNo { get; set; }
        public string WindowTitle { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string AlwaysShowReportsAsPdf { get; set; }
        public string MntAutoRetrieveFlag { get; set; }
        public string ShowPdfTabInReports { get; set; }
        public string CompanyId { get; set; }
        public string DDddwDescriptionSearch { get; set; }
        public string AutofillAsOfDate { get; set; }
        public string PbPrintDialog { get; set; }
        public string RefreshDropdowns { get; set; }
        public DateTime? LiveDate { get; set; }
        public int? ColorNo { get; set; }
        public int? PaletteNo { get; set; }
        public string ColorId { get; set; }
        public string PaletteId { get; set; }

        public ControlSystemColor ColorNoNavigation { get; set; }
        public ControlSystemPalette PaletteNoNavigation { get; set; }
    }
}
