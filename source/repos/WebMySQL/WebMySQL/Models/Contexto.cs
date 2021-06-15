using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMySQL.Models
{
    public class Contexto : DbContext
    {

        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
            Database.EnsureCreated();  //  Caso não exista a tabela, será criada no DBSet conforme definido abaixo
        }

        public DbSet<Usuario> Usuario { get; set; }

    }
}
