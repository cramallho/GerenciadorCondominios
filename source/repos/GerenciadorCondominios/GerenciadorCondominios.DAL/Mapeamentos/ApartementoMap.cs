using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class ApartementoMap : IEntityTypeConfiguration<Apartamento>
    {
        public void Configure(EntityTypeBuilder<Apartamento> builder)
        {
            builder.HasKey(a => a.ApartamentoId);
            builder.Property(a => a.Numero).IsRequired();
            builder.Property(a => a.Andar).IsRequired();
            builder.Property(a => a.Foto).IsRequired();
            builder.Property(a => a.ProprietarioId).IsRequired();
            builder.Property(a => a.MoradorId).IsRequired(false);

            // Relacionamentos com a demais classes.

            // APARTAMENTOPROPRIETARIO
            // 1 Proprietário pode ter 1 ou N Apartamentos
            // 1 Apartamento só tem 1 Proprietário.

            builder.HasOne(a => a.Proprietario)
                   .WithMany(a => a.ProprietariosApartamentos)
                   .HasForeignKey(a => a.ProprietarioId).OnDelete(DeleteBehavior.NoAction);

            // APARTAMENTOMORADOR
            // 1 Morador pode estar associado a 1 ou N Apartamentos
            // 1 Apartamento só tem 1 Morador.

            builder.HasOne(a => a.Morador).
                    WithMany(a => a.MoradoresApartamentos).
                    HasForeignKey(a => a.MoradorId).OnDelete(DeleteBehavior.NoAction);

            builder.ToTable("Apartamentos");
        }
    }
}
