using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NotesIdentity.Models;

namespace NotesIdentity.Data
{
    public class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    { 
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.HasKey(x => x.Id);
        }
    }
}
