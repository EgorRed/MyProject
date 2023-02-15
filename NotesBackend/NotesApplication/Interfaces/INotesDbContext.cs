
using Microsoft.EntityFrameworkCore;
using NotesDomain;
using System.Threading;
using System.Threading.Tasks;

namespace NotesApplication.Interfaces
{
    public interface INotesDbContext
    {
        DbSet<Note> Notes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
