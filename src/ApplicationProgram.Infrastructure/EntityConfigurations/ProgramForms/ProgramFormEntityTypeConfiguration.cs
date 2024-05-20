using ApplicationProgram.Domain.Models.ProgramForms;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApplicationProgram.Infrastructure.EntityConfigurations.ProgramForms
{
    public class ProgramFormEntityTypeConfiguration : IEntityTypeConfiguration<ProgramForm>
    {
        public void Configure(EntityTypeBuilder<ProgramForm> builder)
        {
            builder.ToTable(nameof(ProgramForm));
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            builder.Property(i => i.Title).IsRequired();
            builder.Property(i => i.Description).IsRequired();

            builder.HasMany(i => i.CustomQuestions).WithOne().IsRequired();
        }
    }
}
