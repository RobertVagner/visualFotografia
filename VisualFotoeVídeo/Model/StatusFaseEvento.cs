using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFotoeVídeo.Model
{
    internal class StatusFaseEvento
    {
        private int codEvento;
        private int codFase;
        public int CodStatusFase { get; set; }
        public string Status { get; set; }
        public int CodEvento { get => codEvento; set => codEvento = value; }
        public int CodFase { get => codFase; set => codFase = value; }

        
    }
}
