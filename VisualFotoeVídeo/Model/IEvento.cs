using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFotoeVídeo.Model
{
    internal interface IEvento
    {
        void exclui(Evento visual);
        void adiciona(Evento visual);
        void altera(Evento visual, Cliente cliente, StatusFaseEvento fase);
        IEnumerable<Evento> GetAll();
        IEnumerable<Evento> GetDataEvento(string pesquisa);
        Cliente GetEvento(int id);
    }
}
