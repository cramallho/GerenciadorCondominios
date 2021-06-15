using GerenciadorCondominios.BLL.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GerenciadorCondominios.DAL.Mapeamentos
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            // gerar ID automático. Chave primária. f-Tabela Funcao ID-Chave primária
            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.CPF).IsRequired().HasMaxLength(30);
            // determina que CPF é único na base
            builder.HasIndex(u => u.CPF).IsUnique();

            builder.Property(u => u.Foto); //.IsRequired();

            builder.Property(u => u.PrimeiroAcesso).IsRequired();

            builder.Property(u => u.Status).IsRequired();


            // Relacionamentos com a demais classes.

            // PROPRIETARIOSAPARTAMENTOS
            // 1 Proprietário pode ter 1 ou N Apartamentos
            // 1 Apartamento só tem 1 Proprietário.

            builder.HasMany(u => u.ProprietariosApartamentos).WithOne(u => u.Proprietario);

            // MORADORESAPARTAMENTOS
            // 1 Morador pode ter 1 ou N Apartamentos Alugados
            // 1 Apartamento só pode estar vinculado a 1 Morador.

            builder.HasMany(u => u.MoradoresApartamentos).WithOne(u => u.Morador);

            // VEICULOS
            // 1 Usuário pode ter 1 ou N Veículos
            // 1 Veículo só pode estar vinculado a 1 Usuário.

            builder.HasMany(u => u.Veiculos).WithOne(u => u.Usuario);

            // EVENTOS
            // 1 Usuário pode fazer 1 ou N Eventos
            // 1 Evento só pode estar vinculado a 1 Usuário.

            builder.HasMany(u => u.Eventos).WithOne(u => u.Usuario);

            // PAGAMENTOS
            // 1 Usuário pode fazer 1 ou N Pagamentos
            // 1 Pagamento só pode estar vinculado a 1 Usuário.

            builder.HasMany(u => u.Pagamentos).WithOne(u => u.Usuario);

            // SERVICOS
            // 1 Usuário pode requisitar 1 ou N Serviços
            // 1 Serviço só pode estar vinculado a 1 Usuário.

            builder.HasMany(u => u.Servicos).WithOne(u => u.Usuario);

            builder.ToTable("Usuarios");
        }
    }
}
