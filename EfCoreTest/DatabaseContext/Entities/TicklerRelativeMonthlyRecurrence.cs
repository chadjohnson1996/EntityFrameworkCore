﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TicklerRelativeMonthlyRecurrence
    {
        public int Id { get; set; }
        public int TicklerId { get; set; }
        public int RelativePositionInMonth { get; set; }
        public int RelativeDay { get; set; }

        public Ticklers Tickler { get; set; }
    }
}
