using ApplicationProgram.Domain.Models.Candidates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationProgram.Infrastructure.EntityConfigurations.Candidates
{
    public class CustomQuestionAnswerEntityTypeConfiguration : IEntityTypeConfiguration<CustomQuestionAnswer>
    {
        public void Configure(EntityTypeBuilder<CustomQuestionAnswer> builder)
        {
            builder.ToTable($"{nameof(Candidate)}_CustomQuestionAnswer");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
