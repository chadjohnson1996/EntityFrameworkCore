using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcFieldLogs
    {
        public DcFieldLogs()
        {
            DcFieldLogEquipment = new HashSet<DcFieldLogEquipment>();
            DcFieldLogMaterials = new HashSet<DcFieldLogMaterials>();
            DcFieldLogOnSiteContacts = new HashSet<DcFieldLogOnSiteContacts>();
            DcFieldLogTasks = new HashSet<DcFieldLogTasks>();
            DcMiscDocAttachments = new HashSet<DcMiscDocAttachments>();
            DcRfcAttachments = new HashSet<DcRfcAttachments>();
            DcRfiAttachments = new HashSet<DcRfiAttachments>();
            DcRfpAttachments = new HashSet<DcRfpAttachments>();
            DcSubmittalAttachments = new HashSet<DcSubmittalAttachments>();
            DcTransmittalAttachments = new HashSet<DcTransmittalAttachments>();
            InventoryReceiptsH = new HashSet<InventoryReceiptsH>();
        }

        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcFieldLogNo { get; set; }
        public DateTime? LogDate { get; set; }
        public string MiscNotes { get; set; }
        public int OnSiteCustomers { get; set; }
        public int OnSiteEmployees { get; set; }
        public int OnSiteVendors { get; set; }
        public int OnSiteOthers { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcFieldLogId { get; set; }
        public string JobId { get; set; }

        public Jobs Jobs { get; set; }
        public ICollection<DcFieldLogEquipment> DcFieldLogEquipment { get; set; }
        public ICollection<DcFieldLogMaterials> DcFieldLogMaterials { get; set; }
        public ICollection<DcFieldLogOnSiteContacts> DcFieldLogOnSiteContacts { get; set; }
        public ICollection<DcFieldLogTasks> DcFieldLogTasks { get; set; }
        public ICollection<DcMiscDocAttachments> DcMiscDocAttachments { get; set; }
        public ICollection<DcRfcAttachments> DcRfcAttachments { get; set; }
        public ICollection<DcRfiAttachments> DcRfiAttachments { get; set; }
        public ICollection<DcRfpAttachments> DcRfpAttachments { get; set; }
        public ICollection<DcSubmittalAttachments> DcSubmittalAttachments { get; set; }
        public ICollection<DcTransmittalAttachments> DcTransmittalAttachments { get; set; }
        public ICollection<InventoryReceiptsH> InventoryReceiptsH { get; set; }
    }
}
