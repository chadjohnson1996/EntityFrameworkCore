using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgRibbonSettings
    {
        public int Id { get; set; }
        public string UserNo { get; set; }
        public byte[] RibbonLayoutData { get; set; }
        public int? RibbonLayoutDataLength { get; set; }
    }
}
