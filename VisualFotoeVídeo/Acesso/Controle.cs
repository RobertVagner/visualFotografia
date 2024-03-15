using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFotoeVídeo.Acesso
{
    public class Controle
    {
        public bool tem;
        public string mensagem = "";
        public bool acessar(string login, string senha)
        {
            LoginDaoComando loginDao = new LoginDaoComando();
            tem = loginDao.verificarLogin(login, senha);
            if(!loginDao.mensagem.Equals(""))
            {
                this.mensagem = loginDao.mensagem;
            }
            return tem;
        }

    }
}
