using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TimecardTypes
    {
        public TimecardTypes()
        {
            TimeCards = new HashSet<TimeCards>();
            TimecardImportFormats = new HashSet<TimecardImportFormats>();
        }

        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public int? Version { get; set; }
        public string PhaseTimecard { get; set; }
        public string RecurringTimecard { get; set; }
        public string DefaultTimecard { get; set; }
        public string Description { get; set; }
        public string ShortDesc { get; set; }
        public int DesignType { get; set; }
        public string DetailSyntaxP2 { get; set; }
        public string HeaderSyntax { get; set; }
        public string DetailSyntaxP1 { get; set; }
        public string EmpInHeader { get; set; }
        public string JobInHeader { get; set; }
        public string DetailSyntaxP3 { get; set; }
        public string ShiftInDetail { get; set; }
        public string DetailSyntaxP4 { get; set; }
        public string DatTimecard { get; set; }

        public ICollection<TimeCards> TimeCards { get; set; }
        public ICollection<TimecardImportFormats> TimecardImportFormats { get; set; }
    }
}
