using GerenciadorCondominios.BLL.Models;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace GerenciadorCondominios.DAL.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<Usuario>
    {

        int VerificarSeExisteRegistro();

        Task LogarUsuario(Usuario usuario, bool lembrar);

        Task<IdentityResult> CriarUsuario(Usuario usuario, string senha);   // retorna sucess or fail

        Task IncluirUsuarioEmFuncao(Usuario usuario, string funcao);
    }
}
