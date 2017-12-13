using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class DsgDesignerObjects
    {
        public int DesignNo { get; set; }
        public string DesignerNo { get; set; }
        public string ObjectNo { get; set; }
        public string Class { get; set; }
        public string Source { get; set; }
        public string Parent { get; set; }
        public string Title { get; set; }
        public string Band { get; set; }
        public string Type { get; set; }
        public string Alignment { get; set; }
        public string ShowText { get; set; }
        public string ObjText { get; set; }
        public string Border { get; set; }
        public int? Color { get; set; }
        public int? X { get; set; }
        public int? Y { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public string ObjName { get; set; }
        public int? TabPosition { get; set; }
        public string Pointer { get; set; }
        public string Filepath { get; set; }
        public string FontFace { get; set; }
        public string FontHeight { get; set; }
        public string FontWeight { get; set; }
        public string FontFamily { get; set; }
        public string FontPitch { get; set; }
        public string FontCharset { get; set; }
        public string FontItalic { get; set; }
        public string FontUnderline { get; set; }
        public string FontStrikethrough { get; set; }
        public int? BackgroundMode { get; set; }
        public int? BackgroundColor { get; set; }
        public int? X1 { get; set; }
        public int? Y1 { get; set; }
        public int? X2 { get; set; }
        public int? Y2 { get; set; }
        public int? PenStyle { get; set; }
        public int? PenWidth { get; set; }
        public int? PenColor { get; set; }
        public int? BrushHatch { get; set; }
        public int? BrushColor { get; set; }
        public string DragIcon { get; set; }
        public string NoDragIcon { get; set; }
        public string LabelVisible { get; set; }
        public int? Orientation { get; set; }
        public string RelocateLabel { get; set; }
        public string Expression { get; set; }
        public string InitialValue { get; set; }
        public string Domain { get; set; }
        public string Datatype { get; set; }
        public string AutosizeHeight { get; set; }
        public string InvertImage { get; set; }
        public string FormatData { get; set; }
        public string FormatFloat { get; set; }
        public string ShowZero { get; set; }
        public string LabelOnTop { get; set; }
        public string SuppressRepeating { get; set; }
        public string AmountInWords { get; set; }
        public string VisibleValue { get; set; }

        public DsgDesigners Design { get; set; }
    }
}
