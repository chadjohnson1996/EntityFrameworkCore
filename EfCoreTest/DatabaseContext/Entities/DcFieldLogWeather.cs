using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DcFieldLogWeather
    {
        public int CompanyNo { get; set; }
        public string JobNo { get; set; }
        public string DcFieldLogNo { get; set; }
        public int LineNo { get; set; }
        public DateTime TimeOfDay { get; set; }
        public string GeneralConditions { get; set; }
        public int? Temperature { get; set; }
        public int? Humidity { get; set; }
        public string WeatherNotes { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public DateTime RowCreatedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CompanyId { get; set; }
        public string DcFieldLogId { get; set; }
        public string JobId { get; set; }
        public string LineId { get; set; }
        public int? WindSpeed { get; set; }
        public string WindUnits { get; set; }
        public string WindDirection { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }

        public Jobs Jobs { get; set; }
    }
}
