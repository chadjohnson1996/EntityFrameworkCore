using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Helpdb
    {
        public decimal Increment { get; set; }
        public string ApplicationName { get; set; }
        public string WindowName { get; set; }
        public string ControlName { get; set; }
        public string DataobjectName { get; set; }
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string HelpTopic { get; set; }
    }
}
