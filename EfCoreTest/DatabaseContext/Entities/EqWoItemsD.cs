﻿using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class EqWoItemsD
    {
        public int CompanyNo { get; set; }
        public string EqWoNo { get; set; }
        public int LineNo { get; set; }
        public int UsedLineNo { get; set; }
        public int TransferLineNo { get; set; }
        public string TransferType { get; set; }
        public string PostedFlag { get; set; }
        public DateTime? DatePosted { get; set; }
        public decimal DeliveryQuantity { get; set; }
        public decimal ExtendedCost { get; set; }
        public decimal StockingQuantity { get; set; }
        public string MoveFromTo { get; set; }
        public string JobNo { get; set; }
        public string WarehouseNo { get; set; }
        public string PhaseNo { get; set; }
        public string CostCodeNo { get; set; }
        public string CostClassNo { get; set; }
        public string TaxNo { get; set; }
        public string PriceLevelNo { get; set; }
        public decimal UnitPrice { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string CostClassId { get; set; }
        public string CostCodeId { get; set; }
        public string EqWoId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public string PhaseId { get; set; }
        public string PriceLevelId { get; set; }
        public string TaxId { get; set; }
        public string TransferLineId { get; set; }
        public string UsedLineId { get; set; }
        public string WarehouseId { get; set; }

        public CostClasses Co { get; set; }
        public CostCodes CoNavigation { get; set; }
        public EqWo EqWo { get; set; }
        public EqWoItemsUsed EqWoItemsUsed { get; set; }
        public Jobs Jobs { get; set; }
        public PriceLevels PriceLevels { get; set; }
        public SalesTaxes SalesTaxes { get; set; }
        public Warehouses Warehouses { get; set; }
    }
}