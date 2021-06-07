using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class ServicoMap : IEntityTypeConfiguration<Servico>
    {
        public void Configure(EntityTypeBuilder<Servico> builder)
        {
            builder.Property(s => s.ServicoId); /////////////////////////////////// HASKEY ???????
            builder.Property(s => s.Nome).IsRequired().HasMaxLength(30);
            builder.Property(s => s.Valor).IsRequired();
            builder.Property(s => s.Status).IsRequired();
            builder.Property(s => s.UsuarioId).IsRequired();


            // Relacionamentos com a demais classes.

            // SERVICO com USUARIO  
            // 1 SERVICO pode estar relacionado a apenas 1 USUARIO
            // 1 USUARIO pode requisitar 1 ou N SERVICOS.

            builder.HasOne(s => s.Usuario).WithMany(s => s.Servicos).HasForeignKey(s => s.UsuarioId);

            // SERVICO com SERVICOPREDIO 
            // 1 SERVICO pode estar relacionado a 1 ou N SERVICOPREDIO 
            // 1 SERVICOPREDIO pode conter apenas 1 SERVICO.

            builder.HasMany(s => s.ServicoPredios).WithOne(s => s.Servico);

            builder.ToTable("Servicos");
        }
    }
}
