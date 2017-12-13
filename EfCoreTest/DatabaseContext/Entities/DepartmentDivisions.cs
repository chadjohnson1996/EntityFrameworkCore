﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DepartmentDivisions
    {
        public int CompanyNo { get; set; }
        public string DeptNo { get; set; }
        public decimal DivisionNo { get; set; }
        public decimal DivisionAccountNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DeptId { get; set; }
        public string DivisionAccountId { get; set; }
        public string DivisionId { get; set; }

        public Departments Departments { get; set; }
        public GlDivisions GlDivisions { get; set; }
    }
}
