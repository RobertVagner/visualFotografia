using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualFotoeVídeo.Model;
using VisualFotoeVídeo.Repositório;

namespace VisualFotoeVídeo
{
    public partial class frmLogin : MetroFramework.Forms.MetroForm
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        RepositorioUsuarioSql ru = new RepositorioUsuarioSql();
        UsuarioSqlServer u = new UsuarioSqlServer();
        int codUs;

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            comboBox1.DataSource = ru.GetAll();
            comboBox1.DisplayMember = "Nome";
            comboBox1.ValueMember = "Nome";
        }

        private void btn_excluir_Click(object sender, EventArgs e)
        {
            u.CodUsuario = codUs;
            u.Nome = txtNome.Text;
            u.Senha = txtSenha.Text;
            u.Login = txtLoginEmail.Text;
            ru.exclui(u);
            MessageBox.Show("Alterado com sucesso!");
            comboBox1.DataSource = ru.GetAll();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            codUs = int.Parse(((UsuarioSqlServer)comboBox1.SelectedItem).CodUsuario.ToString());
        
            txtNome.Text = ((UsuarioSqlServer)comboBox1.SelectedItem).Nome.ToString();
            txtSenha.Text = ((UsuarioSqlServer)comboBox1.SelectedItem).Senha.ToString();
            txtLoginEmail.Text = ((UsuarioSqlServer)comboBox1.SelectedItem).Login.ToString();
        }

        private void btn_alterar_Click(object sender, EventArgs e)
        {
            u.CodUsuario = codUs;
            u.Nome = txtNome.Text;
            u.Senha = txtSenha.Text;
            u.Login = txtLoginEmail.Text;
            ru.altera(u);
            MessageBox.Show("Alterado com sucesso!");
            comboBox1.DataSource = ru.GetAll();
        }
    }
}
