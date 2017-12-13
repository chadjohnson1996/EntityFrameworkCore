using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class ControlSystemPalette
    {
        public ControlSystemPalette()
        {
            ControlSystem = new HashSet<ControlSystem>();
        }

        public int RowUniqueId { get; set; }
        public int PaletteNo { get; set; }
        public string PaletteName { get; set; }
        public long Backgroundoutside { get; set; }
        public long Backgroundinside { get; set; }
        public long Backgroundpopup { get; set; }
        public long Backgroundspecial1 { get; set; }
        public long Backgroundspecial2 { get; set; }
        public long Backgroundcontrol { get; set; }
        public long Backgrounddwcontrol { get; set; }
        public long Backgroundheadingtitle { get; set; }
        public long Backgroundheadingtitletext { get; set; }
        public long Backgroundheading { get; set; }
        public long Backgroundsummary { get; set; }
        public long Backgroundsummarytext { get; set; }
        public long Backgroundbutton { get; set; }
        public long Textnormal { get; set; }
        public long Textheadingspecial { get; set; }
        public long Fieldreadwrite { get; set; }
        public long Fieldreadonly { get; set; }
        public long Textreadwrite { get; set; }
        public long Textreadonly { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public string PaletteId { get; set; }

        public ICollection<ControlSystem> ControlSystem { get; set; }
    }
}
