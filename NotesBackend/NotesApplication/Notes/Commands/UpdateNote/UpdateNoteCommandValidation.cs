using FluentValidation;
using System;

namespace NotesApplication.Notes.Commands.UpdateNote
{
    public class UpdateNoteCommandValidation : AbstractValidator<UpdateNoteCommand>
    {
        public UpdateNoteCommandValidation() 
        {
            RuleFor(updateNoteCommand => updateNoteCommand.UserId).NotEqual(Guid.Empty);            
            RuleFor(updateNoteCommand => updateNoteCommand.Id).NotEqual(Guid.Empty);
            RuleFor(updateNoteCommand => updateNoteCommand.Title).NotEmpty().MaximumLength(250);
        }
    }
}
