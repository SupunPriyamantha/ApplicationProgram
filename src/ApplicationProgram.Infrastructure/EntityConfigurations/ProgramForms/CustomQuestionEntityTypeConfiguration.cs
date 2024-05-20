using ApplicationProgram.Domain.Models.ProgramForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationProgram.Infrastructure.EntityConfigurations.ProgramForms
{
    public class CustomQuestionEntityTypeConfiguration : IEntityTypeConfiguration<CustomQuestion>
    {
        public void Configure(EntityTypeBuilder<CustomQuestion> builder)
        {
            builder.ToTable($"{nameof(ProgramForm)}_CustomQuestion");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).ValueGeneratedOnAdd();

            builder.HasMany(i => i.Choices).WithOne().IsRequired();
        }
    }
}
