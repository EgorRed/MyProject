using FluentValidation;
using System;

namespace NotesApplication.Notes.Queries.GetNoteDetails
{
    public class GetNoteDetailsQueryValidation : AbstractValidator<GetNoteDetailsQuery>
    {
        public GetNoteDetailsQueryValidation() 
        {
            RuleFor(note => note.Id).NotEqual(Guid.Empty);
            RuleFor(note => note.UserId).NotEqual(Guid.Empty);
        }
    }
}
