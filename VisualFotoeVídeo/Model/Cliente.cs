using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFotoeVídeo.Model
{
    internal class Cliente
    {
        private int codCliente;
        private string nomeCliente;
        private string descricao;
        private string cpf_cnpj;

        public int CodCliente { get => codCliente; set => codCliente = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Cpf_cnpj { get => cpf_cnpj; set => cpf_cnpj = value; }
        public bool enable { get; set; }
    }
}
