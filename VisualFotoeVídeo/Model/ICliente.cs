using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFotoeVídeo.Model
{
    internal interface ICliente
    {
        void exclui(Cliente visual);
        void adiciona(Cliente visual);
        void altera(Cliente visual);
        IEnumerable<Cliente> GetAll();
        IEnumerable<Cliente> Get(string pesquisa);
        Cliente GetCliente(int id);
    }
}
