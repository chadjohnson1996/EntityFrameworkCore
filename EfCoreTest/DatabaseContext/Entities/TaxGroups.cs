using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class TaxGroups
    {
        public TaxGroups()
        {
            Customers = new HashSet<Customers>();
            Departments = new HashSet<Departments>();
            Employees = new HashSet<Employees>();
            ShipTo = new HashSet<ShipTo>();
            TaxGroupLocals = new HashSet<TaxGroupLocals>();
            TaxGroupStates = new HashSet<TaxGroupStates>();
            TimeCards = new HashSet<TimeCards>();
        }

        public int CompanyNo { get; set; }
        public string TaxPrNo { get; set; }
        public string Description { get; set; }
        public string CountyNo { get; set; }
        public string CountyPrNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CountyId { get; set; }
        public string CountyPrId { get; set; }
        public string TaxPrId { get; set; }

        public Counties Co { get; set; }
        public ICollection<Customers> Customers { get; set; }
        public ICollection<Departments> Departments { get; set; }
        public ICollection<Employees> Employees { get; set; }
        public ICollection<ShipTo> ShipTo { get; set; }
        public ICollection<TaxGroupLocals> TaxGroupLocals { get; set; }
        public ICollection<TaxGroupStates> TaxGroupStates { get; set; }
        public ICollection<TimeCards> TimeCards { get; set; }
    }
}
