using ApplicationProgram.Domain.Models.Candidates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationProgram.Infrastructure.EntityConfigurations.Candidates
{
    public class CandidateEntityTypeConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {
            builder.ToTable(nameof(Candidate));
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.HasMany(i => i.CustomQuestionAnswers).WithOne().IsRequired();
        }
    }
}
