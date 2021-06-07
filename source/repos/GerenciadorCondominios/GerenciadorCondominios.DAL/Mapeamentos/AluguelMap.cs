using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class AluguelMap : IEntityTypeConfiguration<Aluguel>
    {
        public void Configure(EntityTypeBuilder<Aluguel> builder)
        {
            builder.HasKey(a => a.AluguelId);
            builder.Property(a => a.Valor).IsRequired();
            builder.Property(a => a.MesId).IsRequired();
            builder.Property(a => a.Ano).IsRequired();

            // Relacionamentos com a demais classes.

            // ALUGUELMES
            // 1 Aluguel pode estar referenciado a 1 Mês
            // 1 Mês pode estar relacionadoa a 1 ou N Aluguéis.

            builder.HasOne(a => a.Mes).WithMany(a => a.Alugueis).HasForeignKey(a => a.MesId);

            // ALUGUELPAGAMENTO
            // 1 Aluguel pode possuir váarios pagamentos
            // 1 Pagamento está relacionado a 1 Aluguel.

            builder.HasMany(a => a.Pagamentos).WithOne(a => a.Aluguel);

            builder.ToTable("Alugueis");
        }
    }
}
