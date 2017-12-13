using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SmtpServers
    {
        public SmtpServers()
        {
            SmtpServerSettings = new HashSet<SmtpServerSettings>();
            Users = new HashSet<Users>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<SmtpServerSettings> SmtpServerSettings { get; set; }
        public ICollection<Users> Users { get; set; }
    }
}
