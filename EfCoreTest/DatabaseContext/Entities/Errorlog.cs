using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class Errorlog
    {
        public decimal Errorid { get; set; }
        public DateTime Errordatetime { get; set; }
        public string Title { get; set; }
        public string Errormessage { get; set; }
        public string Erroruser { get; set; }
        public string Comments { get; set; }
        public int? Line { get; set; }
        public int? Number { get; set; }
        public string Object { get; set; }
        public string Objectevent { get; set; }
        public string Text { get; set; }
        public string Windowmenu { get; set; }
        public int? CompanyNo { get; set; }
    }
}
