using MegaFilmes.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace MegaFilmes.Infra.Mappings;

public class AvaliacaoMap : IEntityTypeConfiguration<Avaliacao>
{
    public void Configure(EntityTypeBuilder<Avaliacao> builder)
    {
        builder.ToTable("avaliacoes");

        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id)
            .UseIdentityColumn()
            .HasColumnName("id")
            .IsRequired();

        builder.Property(x => x.Criterio)
            .HasColumnName("criterio")
            .IsRequired();

        builder.Property(x => x.Comentario)
            .HasColumnName("comentario");
          
        builder.Property(x => x.FilmeId)
            .HasColumnName("filme_id")
            .IsRequired();
    }
}