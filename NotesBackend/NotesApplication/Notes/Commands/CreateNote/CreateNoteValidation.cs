using FluentValidation;
using System;


namespace NotesApplication.Notes.Commands.CreateNote
{
    public class CreateNoteValidation : AbstractValidator<CreateNoteCommand>
    {
        public CreateNoteValidation() 
        {
            RuleFor(createNoteCommand => createNoteCommand.Title).NotEmpty().MinimumLength(250);
            RuleFor(createNoteCommand => createNoteCommand.UserId).NotEqual(Guid.Empty);
        }
    }
}
