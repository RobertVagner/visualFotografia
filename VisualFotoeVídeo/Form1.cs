using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualFotoeVídeo.Acesso;
using VisualFotoeVídeo.Model;
using VisualFotoeVídeo.Repositório;

namespace VisualFotoeVídeo
{
    public partial class FrmPrincipal : MetroFramework.Forms.MetroForm
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
        UsuarioSqlServer u = new UsuarioSqlServer();

        private void picLogin_Click(object sender, EventArgs e)
        {
            foreach (UsuarioSqlServer item in Program.listaUsuario)
            {
                if (item.Login == "admin" && item.Senha == "admin")
                {
                    frmLogin log = new frmLogin();
                    log.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Você não é um administrador!");
                }
            }           
        }

        private void picCadastro_Click(object sender, EventArgs e)
        {
            frmCadastro cad = new frmCadastro();
            cad.ShowDialog();
        }

        private void picEvento_Click(object sender, EventArgs e)
        {
            frmEvento ev = new frmEvento();
            ev.ShowDialog();
        }

        private void picPesquisa_Click(object sender, EventArgs e)
        {
            frmPesquisa pesq = new frmPesquisa();
            pesq.ShowDialog();
        }

        private void picAlterar_Click(object sender, EventArgs e)
        {
            frmAlterarExcluir altExc = new frmAlterarExcluir();
            altExc.ShowDialog();
        }
    }
}
