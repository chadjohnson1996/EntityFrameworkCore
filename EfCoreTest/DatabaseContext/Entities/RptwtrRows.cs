using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrRows
    {
        public int ReportNo { get; set; }
        public int RowNo { get; set; }
        public string Category { get; set; }
        public string CapsuleType { get; set; }
        public string Title { get; set; }
        public string Definition { get; set; }
        public string HeadingLine1 { get; set; }
        public string HeadingLine2 { get; set; }
        public string HeadingLine3 { get; set; }
        public int WizardSequenceNo { get; set; }
        public int FieldHeight { get; set; }
        public string FieldPrintable { get; set; }
        public int? FieldLineBefore { get; set; }
        public int? FieldLineAfter { get; set; }
        public string FieldPageBreak { get; set; }
        public string FieldDollarSign { get; set; }
        public string FieldShowNegativeAs { get; set; }

        public RptwtrReports ReportNoNavigation { get; set; }
    }
}
