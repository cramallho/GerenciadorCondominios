using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace GerenciadorCondominios.BLL.Models
{
    public class Funcao : IdentityRole<string>
    {
        //[Required(ErrorMessage = "O campo {0} é obrigatório.")]
        //[StringLength(30, ErrorMessage = "Use até 30 cacacters.")]
        public string Descricao { get; set; }
    }
}
