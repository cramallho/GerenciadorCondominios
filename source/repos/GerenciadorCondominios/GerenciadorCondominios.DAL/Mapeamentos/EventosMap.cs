using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class EventosMap : IEntityTypeConfiguration<Evento>
    {
        public void Configure(EntityTypeBuilder<Evento> builder)
        {
            builder.HasKey(e => e.EventoId);
            builder.Property(e => e.Nome).IsRequired().HasMaxLength(50);
            builder.Property(e => e.Data).IsRequired();
            builder.Property(e => e.UsuarioId).IsRequired();

            // Relacionamentos com a demais classes.

            // EVENTO COM SUARIO
            // 1 Evento pode estar relacionado apenas a 1 Usuário
            // 1 Usuário pode ter marcado 1 ou N Eventos.

            builder.HasOne(e => e.Usuario).WithMany(e => e.Eventos).HasForeignKey(e => e.UsuarioId);

            builder.ToTable("Eventos");

        }
    }
}
