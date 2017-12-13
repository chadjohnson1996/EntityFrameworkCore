using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class SdBoardUserSettings
    {
        public int CompanyNo { get; set; }
        public string UserNo { get; set; }
        public int FirstColumnWidth { get; set; }
        public int ColumnWidth { get; set; }
        public int ColumnHeight { get; set; }
        public int? LayoutStyle { get; set; }
        public string MouseEffects { get; set; }
        public int Gridlinecontrast { get; set; }
        public int MarkFore1 { get; set; }
        public int MarkBack1 { get; set; }
        public int MarkFore2 { get; set; }
        public int MarkBack2 { get; set; }
        public int MarkFore3 { get; set; }
        public int MarkBack3 { get; set; }
        public int MarkFore4 { get; set; }
        public int MarkBack4 { get; set; }
        public int MarkFore5 { get; set; }
        public int MarkBack5 { get; set; }
        public int SundayFore { get; set; }
        public int SundayBack { get; set; }
        public int MondayFore { get; set; }
        public int MondayBack { get; set; }
        public int TuesdayFore { get; set; }
        public int TuesdayBack { get; set; }
        public int WednesdayFore { get; set; }
        public int WednesdayBack { get; set; }
        public int ThursdayFore { get; set; }
        public int ThursdayBack { get; set; }
        public int FridayFore { get; set; }
        public int FridayBack { get; set; }
        public int SaturdayFore { get; set; }
        public int SaturdayBack { get; set; }
        public string ButtonUpleftText { get; set; }
        public string ButtonUpleftFile { get; set; }
        public int HeaderColorStyle { get; set; }
        public string PrevDayVis { get; set; }
        public string PrevWeekVis { get; set; }
        public string PrevMonthVis { get; set; }
        public string PrevCustVis { get; set; }
        public string PrevCustCalc { get; set; }
        public string NextDayVis { get; set; }
        public string NextWeekVis { get; set; }
        public string NextMonthVis { get; set; }
        public string NextCustVis { get; set; }
        public string NextCustCalc { get; set; }
        public string DateTextVis { get; set; }
        public string CalendarStyle { get; set; }
        public int CalendarRows { get; set; }
        public int CalendarColumns { get; set; }
        public int RowUniqueNo { get; set; }
    }
}
