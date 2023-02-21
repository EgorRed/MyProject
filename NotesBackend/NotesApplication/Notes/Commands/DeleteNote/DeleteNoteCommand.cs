using MediatR;
using System;

namespace NotesApplication.Notes.Commands.DeleteNote
{
    public class DeleteNoteCommand : IRequest<Unit>
    {
        public Guid UserId { get; set; }
        public Guid Id { get; set; }
    }
}
