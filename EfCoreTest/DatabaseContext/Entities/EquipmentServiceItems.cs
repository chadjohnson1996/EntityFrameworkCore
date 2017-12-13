﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EquipmentServiceItems
    {
        public int CompanyNo { get; set; }
        public string EquipmentNo { get; set; }
        public string ServiceCodeNo { get; set; }
        public int LineNo { get; set; }
        public string ItemNo { get; set; }
        public string Description { get; set; }
        public string UnitNo { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitCost { get; set; }
        public decimal ExtendedCost { get; set; }
        public string CompanyId { get; set; }
        public string EquipmentId { get; set; }
        public string ServiceCodeId { get; set; }
        public string ItemId { get; set; }
        public string UnitId { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string LineId { get; set; }

        public EquipmentService EquipmentService { get; set; }
        public Items Items { get; set; }
        public Units Units { get; set; }
    }
}