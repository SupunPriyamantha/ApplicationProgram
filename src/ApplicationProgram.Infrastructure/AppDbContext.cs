using ApplicationProgram.Domain.Models.Candidates;
using ApplicationProgram.Domain.Models.ProgramForms;
using ApplicationProgram.Infrastructure.EntityConfigurations.ProgramForms;
using Microsoft.EntityFrameworkCore;

namespace ApplicationProgram.Infrastructure
{
    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ProgramForm> ProgramForms { get; set; }

        public DbSet<Candidate> Candidates { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(ProgramFormEntityTypeConfiguration).Assembly);
        }
    }
}
