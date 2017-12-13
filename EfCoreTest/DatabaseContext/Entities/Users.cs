using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Users
    {
        public Users()
        {
            CompanyUser = new HashSet<CompanyUser>();
            CustomItemUserRestrictions = new HashSet<CustomItemUserRestrictions>();
            EquipmentLocations = new HashSet<EquipmentLocations>();
            RoutingNotificationFromUserNoNavigation = new HashSet<RoutingNotification>();
            RoutingNotificationToUserNoNavigation = new HashSet<RoutingNotification>();
            RoutingRecipientSettings = new HashSet<RoutingRecipientSettings>();
            RoutingRuleEnteredBy = new HashSet<RoutingRuleEnteredBy>();
            RoutingRuleRecipient = new HashSet<RoutingRuleRecipient>();
            RoutingUserPrefs = new HashSet<RoutingUserPrefs>();
            RoutingUserPrefsApInvoiceFilterEnteredByUser = new HashSet<RoutingUserPrefsApInvoiceFilterEnteredByUser>();
            StickyNotes = new HashSet<StickyNotes>();
            TicklerRecipients = new HashSet<TicklerRecipients>();
            TicklerUserSettings = new HashSet<TicklerUserSettings>();
            Ticklers = new HashSet<Ticklers>();
            UserRoles = new HashSet<UserRoles>();
        }

        public string UserNo { get; set; }
        public string Name { get; set; }
        public int CompanyNo { get; set; }
        public string SystemAdministrator { get; set; }
        public string RecordStatus { get; set; }
        public string LogFlag { get; set; }
        public string LogInserts { get; set; }
        public string LogDeletes { get; set; }
        public string LogUpdates { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Secured { get; set; }
        public string CompanyId { get; set; }
        public string UserId { get; set; }
        public string EmailAddress { get; set; }
        public string ViewOnly { get; set; }
        public string MailServerType { get; set; }
        public int? SmtpServerId { get; set; }
        public string SmtpUsername { get; set; }
        public string SmtpPassword { get; set; }
        public string SmtpSenderAddress { get; set; }
        public string AllowSendAlerts { get; set; }

        public SmtpServers SmtpServer { get; set; }
        public ICollection<CompanyUser> CompanyUser { get; set; }
        public ICollection<CustomItemUserRestrictions> CustomItemUserRestrictions { get; set; }
        public ICollection<EquipmentLocations> EquipmentLocations { get; set; }
        public ICollection<RoutingNotification> RoutingNotificationFromUserNoNavigation { get; set; }
        public ICollection<RoutingNotification> RoutingNotificationToUserNoNavigation { get; set; }
        public ICollection<RoutingRecipientSettings> RoutingRecipientSettings { get; set; }
        public ICollection<RoutingRuleEnteredBy> RoutingRuleEnteredBy { get; set; }
        public ICollection<RoutingRuleRecipient> RoutingRuleRecipient { get; set; }
        public ICollection<RoutingUserPrefs> RoutingUserPrefs { get; set; }
        public ICollection<RoutingUserPrefsApInvoiceFilterEnteredByUser> RoutingUserPrefsApInvoiceFilterEnteredByUser { get; set; }
        public ICollection<StickyNotes> StickyNotes { get; set; }
        public ICollection<TicklerRecipients> TicklerRecipients { get; set; }
        public ICollection<TicklerUserSettings> TicklerUserSettings { get; set; }
        public ICollection<Ticklers> Ticklers { get; set; }
        public ICollection<UserRoles> UserRoles { get; set; }
    }
}
