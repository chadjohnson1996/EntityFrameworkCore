using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class FieldLogs
    {
        public FieldLogs()
        {
            FieldLogEquipment = new HashSet<FieldLogEquipment>();
            FieldLogMaterials = new HashSet<FieldLogMaterials>();
            FieldLogOnSiteContacts = new HashSet<FieldLogOnSiteContacts>();
            FieldLogTasks = new HashSet<FieldLogTasks>();
            MeetingAgendaTopics = new HashSet<MeetingAgendaTopics>();
            MiscDocAttachments = new HashSet<MiscDocAttachments>();
            RfcAttachments = new HashSet<RfcAttachments>();
            RfiAttachments = new HashSet<RfiAttachments>();
            RfpAttachments = new HashSet<RfpAttachments>();
            SubmittalAttachments = new HashSet<SubmittalAttachments>();
            TransmittalAttachments = new HashSet<TransmittalAttachments>();
        }

        public int CompanyNo { get; set; }
        public string FieldLogNo { get; set; }
        public string JobNo { get; set; }
        public DateTime LogDate { get; set; }
        public string GeneralConditions { get; set; }
        public decimal? Temperature { get; set; }
        public decimal? Humidity { get; set; }
        public string WeatherNotes { get; set; }
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
        public string FieldLogId { get; set; }
        public string JobId { get; set; }

        public Jobs Jobs { get; set; }
        public ICollection<FieldLogEquipment> FieldLogEquipment { get; set; }
        public ICollection<FieldLogMaterials> FieldLogMaterials { get; set; }
        public ICollection<FieldLogOnSiteContacts> FieldLogOnSiteContacts { get; set; }
        public ICollection<FieldLogTasks> FieldLogTasks { get; set; }
        public ICollection<MeetingAgendaTopics> MeetingAgendaTopics { get; set; }
        public ICollection<MiscDocAttachments> MiscDocAttachments { get; set; }
        public ICollection<RfcAttachments> RfcAttachments { get; set; }
        public ICollection<RfiAttachments> RfiAttachments { get; set; }
        public ICollection<RfpAttachments> RfpAttachments { get; set; }
        public ICollection<SubmittalAttachments> SubmittalAttachments { get; set; }
        public ICollection<TransmittalAttachments> TransmittalAttachments { get; set; }
    }
}
