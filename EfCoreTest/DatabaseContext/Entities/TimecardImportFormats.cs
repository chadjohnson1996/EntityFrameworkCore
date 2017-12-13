using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TimecardImportFormats
    {
        public TimecardImportFormats()
        {
            TimecardImportFormatColumns = new HashSet<TimecardImportFormatColumns>();
            TimecardImportFormatSort = new HashSet<TimecardImportFormatSort>();
        }

        public int DesignType { get; set; }
        public int FormatNo { get; set; }
        public string Description { get; set; }
        public string DefaultFormat { get; set; }
        public string ImportFilename { get; set; }
        public string ContinueImportOnError { get; set; }
        public int LinesToSkip { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string FormatId { get; set; }

        public TimecardTypes DesignTypeNavigation { get; set; }
        public ICollection<TimecardImportFormatColumns> TimecardImportFormatColumns { get; set; }
        public ICollection<TimecardImportFormatSort> TimecardImportFormatSort { get; set; }
    }
}
