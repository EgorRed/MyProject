using System.Collections.Generic;

namespace NotesApplication.Notes.Queries.GetNoteList
{
    public class NoteListVm
    {
        public IList<NoteLockupDto> Notes { get; set; }
    }
}
