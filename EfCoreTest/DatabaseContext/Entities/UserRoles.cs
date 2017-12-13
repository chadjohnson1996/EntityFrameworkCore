using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UserRoles
    {
        public string UserNo { get; set; }
        public int RoleNo { get; set; }

        public Roles RoleNoNavigation { get; set; }
        public Users UserNoNavigation { get; set; }
    }
}
