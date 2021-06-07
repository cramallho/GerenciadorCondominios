using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class HistoricoRecurosMap : IEntityTypeConfiguration<HistoricoRecursos>

    {
        public void Configure(EntityTypeBuilder<HistoricoRecursos> builder)
        {
            builder.HasKey(hr => hr.HistoricoRecursosId);

            builder.Property(hr => hr.Valor).IsRequired();
            builder.Property(hr => hr.Tipo).IsRequired();
            builder.Property(hr => hr.Dia).IsRequired();
            builder.Property(hr => hr.MesId).IsRequired();
            builder.Property(hr => hr.Ano).IsRequired();

            // Relacionamentos com a demais classes.

            // HISTORICORECUROS COM MES
            // 1 HistoricoRecuros pode ter apenas 1 Mes
            // 1 Mes pode estar relacionado 1 ou N HistoricoRecuros .

            builder.HasOne(hr => hr.Mes).WithMany(hr => hr.HistoricoRecursos).HasForeignKey(hr => hr.MesId);

            builder.ToTable("HistoricoRecursos");
        }
    }
}
