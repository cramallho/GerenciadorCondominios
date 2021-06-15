using System.ComponentModel.DataAnnotations;

namespace GerenciadorCondominios.ViewModels
{
    public class RegistroViewModel
    {
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(40, ErrorMessage = "Use até 40 caracteres.")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Telefone { get; set; }

        //[Required(ErrorMessage = "O campo {0} é obrigatório.")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(40, ErrorMessage = "Use até 40 caracteres.")]
        [EmailAddress(ErrorMessage = "Email inválido.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(40, ErrorMessage = "Use até 40 caracteres.")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
                
        [Required(ErrorMessage = "O campo {0} é obrigatório.")]
        [StringLength(40, ErrorMessage = "Use até 40 caracteres.")]
        [DataType(DataType.Password)]
        [Display(Name = "Confirme sua Senha")]
        [Compare("Senha", ErrorMessage = "As Senhas não conferem.")]
        public string SenhaConfirmada { get; set; }
    }

}
