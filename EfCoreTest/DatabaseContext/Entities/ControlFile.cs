using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlFile
    {
        public int CompanyNo { get; set; }
        public string DefaultFileFolder { get; set; }
        public string GlFileFolder { get; set; }
        public string JcFileFolder { get; set; }
        public string PrFileFolder { get; set; }
        public string ApFileFolder { get; set; }
        public string ArFileFolder { get; set; }
        public string EqFileFolder { get; set; }
        public string InFileFolder { get; set; }
        public string TmFileFolder { get; set; }
        public string PcFileFolder { get; set; }
        public string UpFileFolder { get; set; }
        public string PsFileFolder { get; set; }
        public string ScFileFolder { get; set; }
        public string DcFileFolder { get; set; }
        public string FaFileFolder { get; set; }
        public string OtFileFolder { get; set; }
        public string ReportViewOption { get; set; }
        public string AllowNameOverride { get; set; }
        public string AllowDateOverride { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime? RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string CreateModuleSubfolders { get; set; }
        public string CompanyId { get; set; }
        public string SelectFileType { get; set; }
        public string SdFileFolder { get; set; }
    }
}
