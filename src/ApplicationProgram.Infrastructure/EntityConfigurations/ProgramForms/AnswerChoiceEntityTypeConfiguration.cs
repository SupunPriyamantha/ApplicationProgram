using ApplicationProgram.Domain.Models.ProgramForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationProgram.Infrastructure.EntityConfigurations.ProgramForms
{
    public class AnswerChoiceEntityTypeConfiguration : IEntityTypeConfiguration<AnswerChoice>
    {
        public void Configure(EntityTypeBuilder<AnswerChoice> builder)
        {
            builder.ToTable($"Question_AnswerChoice");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();
        }
    }
}
