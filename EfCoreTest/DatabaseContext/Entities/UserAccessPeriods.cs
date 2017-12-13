﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class UserAccessPeriods
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public string UserType { get; set; }
        public string PayCycle { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string UserId { get; set; }

        public CompanyUser CompanyUser { get; set; }
    }
}
