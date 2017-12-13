using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EquipmentService
    {
        public EquipmentService()
        {
            EquipmentServiceItems = new HashSet<EquipmentServiceItems>();
            EquipmentServiceNonInv = new HashSet<EquipmentServiceNonInv>();
        }

        public int CompanyNo { get; set; }
        public string EquipmentNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public string MeterType { get; set; }
        public decimal MeterIncrement { get; set; }
        public decimal UsageIncrement { get; set; }
        public string Enabled { get; set; }
        public DateTime? LastServiceDate { get; set; }
        public decimal LastServiceMeter { get; set; }
        public decimal LastServiceUsage { get; set; }
        public string Comments { get; set; }
        public string Daily { get; set; }
        public string Weekly { get; set; }
        public string Monthly { get; set; }
        public string Annual { get; set; }
        public int NoOfDays { get; set; }
        public int NoOfWeeks { get; set; }
        public int NoOfMonths { get; set; }
        public int NoOfYears { get; set; }
        public string Selected { get; set; }
        public string EmployeeNo { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }
        public string ServiceCodeId { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string EmployeeId { get; set; }
        public string GroupWos { get; set; }

        public Employees Employees { get; set; }
        public EqServiceCodes EqServiceCodes { get; set; }
        public Equipment Equipment { get; set; }
        public ICollection<EquipmentServiceItems> EquipmentServiceItems { get; set; }
        public ICollection<EquipmentServiceNonInv> EquipmentServiceNonInv { get; set; }
    }
}
