using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RptwtrExpDsgColumns
    {
        public int ReportNo { get; set; }
        public int ColumnNo { get; set; }
        public string Category { get; set; }
        public string CapsuleType { get; set; }
        public int WizardSequenceNo { get; set; }
        public string FieldDwobject { get; set; }
        public string FieldDataType { get; set; }
        public string ExpValue { get; set; }
        public string ExpValue2 { get; set; }
        public int? ExpType { get; set; }
        public int? ExpFormat { get; set; }
        public int? ExpSize { get; set; }
        public int? ExpAlign { get; set; }

        public RptwtrExpDsg ReportNoNavigation { get; set; }
    }
}
