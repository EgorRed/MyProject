using AutoMapper;
using NotesApplication.Common.Mapping;
using NotesDomain;
using System;


namespace NotesApplication.Notes.Queries.GetNoteList
{
    public class NoteLockupDto : IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteLockupDto>()
                .ForMember(noteDto => noteDto.Id,
                opt => opt.MapFrom(note => note.Id))
                .ForMember(noteDto => noteDto.Title,
                opt => opt.MapFrom(note => note.Title));
        }
    }
}
