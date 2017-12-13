using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TimecardImportFormatColumns
    {
        public int DesignType { get; set; }
        public int FormatNo { get; set; }
        public int ImportPosition { get; set; }
        public string ColumnDwobject { get; set; }

        public TimecardImportFormats TimecardImportFormats { get; set; }
    }
}
