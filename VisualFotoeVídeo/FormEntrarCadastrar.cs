using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualFotoeVídeo.Model;
using VisualFotoeVídeo.Repositório;
using VisualFotoeVídeo.Acesso;

namespace VisualFotoeVídeo
{
    public partial class FormEntrarCadastrar : MetroFramework.Forms.MetroForm
    {
        public FormEntrarCadastrar()
        {
            InitializeComponent();
        }
        RepositorioUsuarioSql ru = new RepositorioUsuarioSql();
        UsuarioSqlServer u = new UsuarioSqlServer();
        private void btnEntrarCriar_Click(object sender, EventArgs e)
        {
            Controle controle = new Controle();
            controle.acessar(txtLoginEmail.Text, txtSenha.Text);
            if (controle.mensagem.Equals(""))
            {
                if (txtSenha.Text == "" || txtLoginEmail.Text == "")
                {
                    MessageBox.Show("Campo obrigatório não preenchido!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (controle.tem)
                {
                    u.Login = txtLoginEmail.Text;
                    u.Senha = txtSenha.Text;
                    Program.listaUsuario.Add(u);
                    MessageBox.Show("Logado com sucesso!", "Entrando", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    FrmPrincipal fr = new FrmPrincipal();
                    fr.ShowDialog();                    
                }
                else
                {
                    MessageBox.Show("Login não encontrado!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void rbtCriarLogin_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            btn_cadastro.Visible = true;
            btn_entrar.Visible = false;
            label1.Enabled = true;
            txtNome.Enabled = true;

        }

        private void rbtEntrar_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            btn_entrar.Visible = true;
            btn_cadastro.Visible = false;
            label1.Enabled = false;
            txtNome.Enabled = false;
            txtNome.Clear();
            txtSenha.Clear();
            txtLoginEmail.Clear();

        }
        public void Cadastro()
        {
            try
            {
                if (txtLoginEmail.Text == "" || txtNome.Text == "" || txtSenha.Text == "")
                {
                    MessageBox.Show("Campo obrigatório não preenchido!");
                }
                else
                {
                    u.Nome = txtNome.Text;
                    u.Senha = txtSenha.Text;
                    u.Login = txtLoginEmail.Text;
                    ru.adiciona(u);
                    MessageBox.Show("Cadastrado!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormEntrarCadastrar_Load(object sender, EventArgs e)
        {
            if (rbtCriarLogin.Checked)
                btn_cadastro.Visible = true;       
        }

        private void btn_cadastro_Click(object sender, EventArgs e)
        {
            Cadastro();
        }
    }
}
