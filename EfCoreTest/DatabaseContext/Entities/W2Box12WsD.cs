using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class W2Box12WsD
    {
        public int CompanyNo { get; set; }
        public string W2Box12CodeNo { get; set; }
        public DateTime DateBooked { get; set; }
        public string EmployeeNo { get; set; }
        public decimal Box12Amount { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string EmployeeId { get; set; }
        public string W2Box12CodeId { get; set; }

        public Employees Employees { get; set; }
        public W2Box12WsH W2Box12WsH { get; set; }
    }
}
