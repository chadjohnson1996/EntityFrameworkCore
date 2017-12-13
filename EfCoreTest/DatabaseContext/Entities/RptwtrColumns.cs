using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrColumns
    {
        public RptwtrColumns()
        {
            RptwtrColumnLinkCriteria = new HashSet<RptwtrColumnLinkCriteria>();
            RptwtrColumnSortCriteria = new HashSet<RptwtrColumnSortCriteria>();
        }

        public int ReportNo { get; set; }
        public int ColumnNo { get; set; }
        public string Category { get; set; }
        public string CapsuleType { get; set; }
        public string Title { get; set; }
        public string Definition { get; set; }
        public string HeadingLine1 { get; set; }
        public string HeadingLine2 { get; set; }
        public string HeadingLine3 { get; set; }
        public int WizardSequenceNo { get; set; }
        public string FieldDwobject { get; set; }
        public string FieldDataType { get; set; }
        public int FieldX { get; set; }
        public int FieldWidth { get; set; }
        public string FieldAlignment { get; set; }
        public string FieldFormat { get; set; }
        public string FieldPrintable { get; set; }
        public int ReportSequenceNo { get; set; }
        public int? FieldUnits { get; set; }
        public string Tag { get; set; }
        public int? LinkType { get; set; }
        public int? LinkedReportNo { get; set; }
        public string LinkedWindow { get; set; }

        public RptwtrReports LinkedReportNoNavigation { get; set; }
        public RptwtrReports ReportNoNavigation { get; set; }
        public ICollection<RptwtrColumnLinkCriteria> RptwtrColumnLinkCriteria { get; set; }
        public ICollection<RptwtrColumnSortCriteria> RptwtrColumnSortCriteria { get; set; }
    }
}
