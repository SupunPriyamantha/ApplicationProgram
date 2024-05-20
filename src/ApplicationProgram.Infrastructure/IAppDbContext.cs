using ApplicationProgram.Domain.Models.Candidates;
using ApplicationProgram.Domain.Models.ProgramForms;
using Microsoft.EntityFrameworkCore;

namespace ApplicationProgram.Infrastructure
{
    public interface IAppDbContext
    {
        DbSet<ProgramForm> ProgramForms { get; set; }

        DbSet<Candidate> Candidates { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default);
    }
}
