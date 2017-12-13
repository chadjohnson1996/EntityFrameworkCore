using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class RoleSecurity
    {
        public int RoleNo { get; set; }
        public string MenuNo { get; set; }
        public string WindowNo { get; set; }
        public string ParameterNo { get; set; }
        public int EnableFlag { get; set; }
        public string UpdateAccess { get; set; }
        public string InsertAccess { get; set; }
        public string DeleteAccess { get; set; }
        public string ObjectType { get; set; }

        public Roles RoleNoNavigation { get; set; }
    }
}
