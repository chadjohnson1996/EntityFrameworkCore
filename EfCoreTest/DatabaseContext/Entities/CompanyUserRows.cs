using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class CompanyUserRows
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string TableNo { get; set; }
        public string ColumnNo { get; set; }
        public string CompareValues { get; set; }
        public string CompareOperator { get; set; }
        public string CompareConnector { get; set; }

        public CompanyUser CompanyUser { get; set; }
    }
}
