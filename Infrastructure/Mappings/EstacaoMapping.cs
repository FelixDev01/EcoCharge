using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Mappings
{
    public class EstacaoMapping : IEntityTypeConfiguration<EstacaoRecarga>
    {
        public void Configure(EntityTypeBuilder<EstacaoRecarga> builder)
        {
            builder.ToTable("EstacoesRecarga");

            builder.HasKey(e => e.Id);

            builder.Property(e => e.Identificador)
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(e => e.PotenciaKw)
                .HasPrecision(10, 2);

            builder.Property(e => e.EstaOcupada)
                .IsRequired();
        }
    }

}
