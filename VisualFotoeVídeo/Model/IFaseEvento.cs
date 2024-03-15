using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFotoeVídeo.Model
{
    internal interface IFaseEvento
    {
        IEnumerable<FaseEvento> GetAll();
        IEnumerable<FaseEvento> Get(string pesquisa);
        Cliente GetFaseEvento(int id);
    }
}
