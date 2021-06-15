using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebCrudLogAuditoria.Models
{
    [Table("LogAuditoria")]

    public class LogAuditoria
    {
        [Column("Id")]
        [Display(Name = "Código")]

        public string Id { get; set; }

        [Column("DetalhesAuditoria")]
        [Display(Name = "Detalhes Autidoria")]

        public string DetalhesAuditoria { get; set; }

        [Column("EmailUsuario")]
        [Display(Name = "Email Usuário")]

        public string EmailUsuario { get; set; }
    }
}
