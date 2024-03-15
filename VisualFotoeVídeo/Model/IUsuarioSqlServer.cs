using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFotoeVídeo.Model
{
    internal interface IUsuarioSqlServer
    {
        void exclui(UsuarioSqlServer visual);
        void adiciona(UsuarioSqlServer visual);
        void altera(UsuarioSqlServer visual);
        IEnumerable<UsuarioSqlServer> GetAll();
        IEnumerable<UsuarioSqlServer> Get(string pesquisa);
        UsuarioSqlServer GetUsuarioSql(int id);
        void entrar(UsuarioSqlServer visual);
    }
}
