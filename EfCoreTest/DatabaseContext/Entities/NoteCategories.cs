using System;
using System.Collections.Generic;

namespace FSI.ClientMgmtTool.Backend.Foundation.DatabaseContext.Entities
{
    public partial class NoteCategories
    {
        public NoteCategories()
        {
            StickyNotesNoteCategories = new HashSet<StickyNotes>();
            StickyNotesNoteCategories1 = new HashSet<StickyNotes>();
            StickyNotesNoteCategoriesNavigation = new HashSet<StickyNotes>();
        }

        public int CompanyNo { get; set; }
        public string NoteCategoryNo { get; set; }
        public string RecordStatus { get; set; }
        public string RowModifiedBy { get; set; }
        public DateTime RowModifiedOn { get; set; }
        public int RowUniqueId { get; set; }
        public string Description { get; set; }
        public string CompanyId { get; set; }
        public string NoteCategoryId { get; set; }

        public ICollection<StickyNotes> StickyNotesNoteCategories { get; set; }
        public ICollection<StickyNotes> StickyNotesNoteCategories1 { get; set; }
        public ICollection<StickyNotes> StickyNotesNoteCategoriesNavigation { get; set; }
    }
}
