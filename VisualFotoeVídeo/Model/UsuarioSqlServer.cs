using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFotoeVídeo.Model
{
    internal class UsuarioSqlServer
    {
        private int codUsuario;
        private string nome;
        private string senha;
        private string login;

        public int CodUsuario { get => codUsuario; set => codUsuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Login { get => login; set => login = value; }
    }
}
