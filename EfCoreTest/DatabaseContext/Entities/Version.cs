using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Version
    {
        public string VersionNo { get; set; }
        public int BuildNo { get; set; }
        public int SchemaNo { get; set; }
        public int MajorRevision { get; set; }
        public int MinorRevision { get; set; }
        public string CdKey { get; set; }
        public string AutoIndex { get; set; }
        public string AutoDownload { get; set; }
        public string IpAddress { get; set; }
        public string Port { get; set; }
        public string FsiClientNo { get; set; }
        public string FsiWebPassword { get; set; }
        public string SaasSc { get; set; }
        public string SaasEd { get; set; }
        public string TaxTableUrl { get; set; }
        public string SaasDi { get; set; }
        public string AllowFilestreamWinauthAccess { get; set; }
        public string VersionSc { get; set; }
        public string FsiContained { get; set; }
        public string Odbc { get; set; }
    }
}
