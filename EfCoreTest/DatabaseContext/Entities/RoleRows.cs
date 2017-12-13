using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoleRows
    {
        public int RoleNo { get; set; }
        public string TableNo { get; set; }
        public string ColumnNo { get; set; }
        public string CompareValues { get; set; }
        public string CompareOperator { get; set; }
        public string CompareConnector { get; set; }

        public Roles RoleNoNavigation { get; set; }
    }
}
