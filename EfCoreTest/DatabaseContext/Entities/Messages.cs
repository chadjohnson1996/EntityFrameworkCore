using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Messages
    {
        public string Msgid { get; set; }
        public string Msgtitle { get; set; }
        public string Msgtext { get; set; }
        public string Msgicon { get; set; }
        public string Msgbutton { get; set; }
        public int Msgdefaultbutton { get; set; }
        public int Msgseverity { get; set; }
        public string Msgprint { get; set; }
        public string Msguserinput { get; set; }
    }
}
