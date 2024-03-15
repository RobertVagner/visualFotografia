using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFotoeVídeo.Model
{
    internal class Evento
    {
        public int CodEvento { get; set; }
        public int CodCliente { get; set; }
        public int CodTipoEvento { get; set; }
        public int CodUsuario { get; set; }
        public string DataEntrega { get; set; }
        public bool EnvioDados { get; set; }
        public bool StatusLegenda { get; set; }
        public string DataEvento { get; set; }
        public bool FazerBackup { get; set; }
        public string QualHD { get; set; }
        public string Editor { get; set; }
    }
}
