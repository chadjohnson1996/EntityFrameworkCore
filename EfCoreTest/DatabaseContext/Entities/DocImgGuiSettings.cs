using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DocImgGuiSettings
    {
        public int Id { get; set; }
        public string UserNo { get; set; }
        public int LayoutType { get; set; }
        public int LayoutStyle { get; set; }
        public int MainFormLeft { get; set; }
        public int MainFormTop { get; set; }
        public int MainFormWidth { get; set; }
        public int MainFormHeight { get; set; }
        public int CurrentBatchResolution { get; set; }
        public int CurrentDocumentResolution { get; set; }
        public int CurrentPageResolution { get; set; }
        public int PreviewPinned { get; set; }
        public int BatchPinned { get; set; }
        public int DocumentsPinned { get; set; }
        public int PagesPinned { get; set; }
        public string SkinName { get; set; }
        public byte[] RibbonLayoutData { get; set; }
        public int? RibbonLayoutDataLength { get; set; }
        public byte[] DockingLayoutData { get; set; }
        public int? DockingLayoutDataLength { get; set; }
        public string PdfViewer { get; set; }
        public string UserArrangedLabels { get; set; }
        public string BatchViewMode { get; set; }
    }
}
