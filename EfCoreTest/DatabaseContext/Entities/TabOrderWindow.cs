using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TabOrderWindow
    {
        public TabOrderWindow()
        {
            TabOrderSequence = new HashSet<TabOrderSequence>();
        }

        public int Id { get; set; }
        public string WindowName { get; set; }
        public string UserNo { get; set; }
        public string CtrlJkJump { get; set; }
        public DateTime DateCreated { get; set; }

        public ICollection<TabOrderSequence> TabOrderSequence { get; set; }
    }
}
