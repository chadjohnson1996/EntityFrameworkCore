using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Roles
    {
        public Roles()
        {
            RoleRows = new HashSet<RoleRows>();
            RoleSecurity = new HashSet<RoleSecurity>();
            UserRoles = new HashSet<UserRoles>();
        }

        public int RoleNo { get; set; }
        public string Description { get; set; }

        public ICollection<RoleRows> RoleRows { get; set; }
        public ICollection<RoleSecurity> RoleSecurity { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
