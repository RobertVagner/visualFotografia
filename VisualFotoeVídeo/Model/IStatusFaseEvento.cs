using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFotoeVídeo.Model
{
    internal interface IStatusFaseEvento
    {
        void exclui(StatusFaseEvento visual);
        void adiciona(StatusFaseEvento visual);
        void altera(StatusFaseEvento visual);
        IEnumerable<StatusFaseEvento> GetAll();
        StatusFaseEvento GetStatusFaseEvento(int id);
    }
}
