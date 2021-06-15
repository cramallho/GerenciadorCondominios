using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
    {
        public void Configure(EntityTypeBuilder<Funcao> builder)
        {
            builder.Property(f => f.Id).ValueGeneratedOnAdd();
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(30);

            builder.HasData(
                new Funcao
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Morador",
                    NormalizedName = "MORADOR",
                    Descricao = "Morador do Prédio"
                },

                new Funcao
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Sindico",
                    NormalizedName = "SINDICO",
                    Descricao = "Síndico do Prédio"
                },

                new Funcao
                {
                    Id = Guid.NewGuid().ToString(),
                    Name = "Administrador",
                    NormalizedName = "ADMINISTRADOR",
                    Descricao = "Administrador do Prédio"
                });

            builder.ToTable("Funcoes");

        }
    }
}
//using GerenciadorCondominios.BLL.Models;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using System;

//namespace GerenciadorCondominios.DAL.Mapeamentos
//{
//    public class FuncaoMap : IEntityTypeConfiguration<Funcao>
//    {
//        public void Configure(EntityTypeBuilder<Funcao> builder)
//        {
//            // gerar ID automático. Chave primária. f-Tabela Funcao ID-Chave primária
//            builder.Property(f => f.Id).ValueGeneratedOnAdd();

//            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(30);

//            builder.HasData(
//                new Funcao
//                {
//                    Id = Guid.NewGuid().ToString(),
//                    Name = "Morador",
//                    NormalizedName = "MORADOR",
//                    Descricao = "Morador do prédio"
//                },

//                new Funcao
//                {
//                    Id = Guid.NewGuid().ToString(),
//                    Name = "Sindico",
//                    NormalizedName = "SINDICO",
//                    Descricao = "Síndico do prédio"
//                },

//                new Funcao
//                {
//                    Id = Guid.NewGuid().ToString(),
//                    Name = "Administrador",
//                    NormalizedName = "ADMINISTRADOR",
//                    Descricao = "Administrador do prédio"
//                });

//            builder.ToTable("Funcoes");
//        }
//    }
//}
