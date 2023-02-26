using FluentValidation;
using System;

namespace NotesApplication.Notes.Commands.DeleteNote
{
    public class DeleteNoteCommandValidation : AbstractValidator<DeleteNoteCommand>
    {
        public DeleteNoteCommandValidation() 
        {
            RuleFor(deleteNoteCommand => deleteNoteCommand.Id).NotEqual(Guid.Empty);
            RuleFor(deleteNoteCommand => deleteNoteCommand.UserId).NotEqual(Guid.Empty);
        }
    }
}
