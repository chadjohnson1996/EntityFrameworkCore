using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class JobWeather
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public DateTime LogDate { get; set; }
        public string Location { get; set; }
        public string Conditions { get; set; }
        public int? Temperature { get; set; }
        public int? Humidity { get; set; }
        public string Notes { get; set; }
        public string MdUser { get; set; }
        public string RecordStatus { get; set; }
        public string RowCreatedBy { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string JobId { get; set; }
        public int? WindSpeed { get; set; }
        public string WindUnits { get; set; }
        public string WindDirection { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }

        public Jobs Jobs { get; set; }
    }
}
