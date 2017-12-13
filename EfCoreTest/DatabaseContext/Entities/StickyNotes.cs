using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class StickyNotes
    {
        public StickyNotes()
        {
            Ticklers = new HashSet<Ticklers>();
        }

        public int Id { get; set; }
        public int CompanyNo { get; set; }
        public string WindowName { get; set; }
        public string WindowTitle { get; set; }
        public string TableName { get; set; }
        public int? RowNo { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedByUserNo { get; set; }
        public string Subject { get; set; }
        public string NoteText { get; set; }
        public string MainCategoryNo { get; set; }
        public string AddCategoryNo { get; set; }
        public string Add2CategoryNo { get; set; }
        public string PriorityNo { get; set; }
        public string WindowType { get; set; }
        public int? UserId { get; set; }
        public string UserName { get; set; }

        public Users CreatedByUserNoNavigation { get; set; }
        public NoteCategories NoteCategories { get; set; }
        public NoteCategories NoteCategories1 { get; set; }
        public NoteCategories NoteCategoriesNavigation { get; set; }
        public NotePriorities NotePriorities { get; set; }
        public ICollection<Ticklers> Ticklers { get; set; }
    }
}
