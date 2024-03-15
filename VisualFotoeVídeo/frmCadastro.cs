using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualFotoeVídeo.Model;
using VisualFotoeVídeo.Repositório;

namespace VisualFotoeVídeo
{
    public partial class frmCadastro : MetroFramework.Forms.MetroForm
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void picLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        Cliente c = new Cliente();
        RepositorioCliente rc = new RepositorioCliente();
        private int codClie;

        UsuarioSqlServer u = new UsuarioSqlServer();
        RepositorioUsuarioSql ru = new RepositorioUsuarioSql();
        int codUsuario;
        
        TipoEvento t = new TipoEvento();
        RepositorioTipoEvento rte = new RepositorioTipoEvento();

        FaseEvento f = new FaseEvento();
        RepositorioFaseEvento rpf = new RepositorioFaseEvento();

        Evento ev = new Evento();
        RepositorioEvento re = new RepositorioEvento();

        StatusFaseEvento sfe = new StatusFaseEvento();
        RepositorioStatusFaseEvento rsfe = new RepositorioStatusFaseEvento();


        private void Limpar()
        {
            txtNome.Clear();
            txtCpfCnpj.Clear();
            txtDescricao.Clear();
            txtHD.Clear();
            txtEditor.Clear();
            ckbBackup.Checked = false;
            ckbDados.Checked = false;
            ckbLegenda.Checked = false;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            codUsuario = u.CodUsuario;
            ev.CodUsuario = u.CodUsuario;
            if (rbtCasamento.Checked == true)
            {
                
                //cadastrando cliente
                c.NomeCliente = txtNome.Text;
                c.Descricao = txtDescricao.Text;
                c.Cpf_cnpj = txtCpfCnpj.Text;

              
                if (ckbDados.Checked == true)
                    ev.EnvioDados = true;
                else
                    ev.EnvioDados = false;

                if(ckbLegenda.Checked == true)
                    ev.StatusLegenda = true;
                else
                    ev.StatusLegenda = false;

                if (ckbBackup.Checked == true)
                    ev.FazerBackup = true;
                else
                    ev.FazerBackup = false;

                //pegar codigo do evento

                if (rbtSemEdicao.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1024;
                    sfe.Status = "Sem Edição";
                }
                else if (rbtEmAndamento.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1025;
                    sfe.Status = "Em Andamento";
                }
                else if (rbtFinalizada.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1026;
                    sfe.Status = "Finalizada";
                }

                //cadastrando cliente
                c.NomeCliente = txtNome.Text;
                c.Descricao = txtDescricao.Text;
                c.Cpf_cnpj = txtCpfCnpj.Text;
                rc.adiciona(c);
                codClie = c.CodCliente;
                //tabelaEvento
                ev.CodCliente = codClie;
                ev.CodTipoEvento = 1002;
                ev.DataEntrega = dataEntregaEdicao.Value.ToString();
                ev.DataEvento = dataEvento.Value.ToString();
                ev.QualHD = txtHD.Text;
                ev.Editor = txtEditor.Text;
                ev.CodUsuario = int.Parse(((UsuarioSqlServer)metroComboBox1.SelectedItem).CodUsuario.ToString());

                re.adiciona(ev);

                rsfe.adiciona(sfe);


                MessageBox.Show("Cadastrado!");
                Close();
            }
            else if (rbtAniversario.Checked == true)
            {

                //cadastrando cliente
                c.NomeCliente = txtNome.Text;
                c.Descricao = txtDescricao.Text;
                c.Cpf_cnpj = txtCpfCnpj.Text;

                //cadastrando evento


                if (ckbDados.Checked == true)
                    ev.EnvioDados = true;
                else
                    ev.EnvioDados = false;

                if (ckbLegenda.Checked == true)
                    ev.StatusLegenda = true;
                else
                    ev.StatusLegenda = false;

                if (ckbBackup.Checked == true)
                    ev.FazerBackup = true;
                else
                    ev.FazerBackup = false;

                //pegar codigo do evento

                if (rbtSemEdicao.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1028;
                    sfe.Status = "Sem Edição";
                }
                else if (rbtEmAndamento.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1029;
                    sfe.Status = "Em Andamento";
                }
                else if (rbtFinalizada.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1030;
                    sfe.Status = "Finalizada";
                }

                //cadastrando cliente
                c.NomeCliente = txtNome.Text;
                c.Descricao = txtDescricao.Text;
                c.Cpf_cnpj = txtCpfCnpj.Text;
                rc.adiciona(c);
                codClie = c.CodCliente;

                //tabelaEvento
                c.CodCliente = codClie;
                ev.CodTipoEvento = 1003;
                ev.DataEntrega = dataEntregaEdicao.Value.ToString();
                ev.DataEvento = dataEvento.Value.ToString();
                ev.QualHD = txtHD.Text;
                ev.Editor = txtEditor.Text;
                ev.CodUsuario = int.Parse(((UsuarioSqlServer)metroComboBox1.SelectedItem).CodUsuario.ToString());

                re.adiciona(ev);

                rsfe.adiciona(sfe);


                MessageBox.Show("Cadastrado!");
                Close();
            }
            else if (rbtInstitucional.Checked == true)
            {

                //cadastrando cliente
                c.NomeCliente = txtNome.Text;
                c.Descricao = txtDescricao.Text;
                c.Cpf_cnpj = txtCpfCnpj.Text;


                //cadastrando evento

                //pegar cod usuario
                //pegar cod cliente


                if (ckbDados.Checked == true)
                    ev.EnvioDados = true;
                else
                    ev.EnvioDados = false;

                if (ckbLegenda.Checked == true)
                    ev.StatusLegenda = true;
                else
                    ev.StatusLegenda = false;

                if (ckbBackup.Checked == true)
                    ev.FazerBackup = true;
                else
                    ev.FazerBackup = false;

                //pegar codigo do evento

                if (rbtSemEdicao.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1031;
                    sfe.Status = "Sem Edição";
                }
                else if (rbtEmAndamento.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1032;
                    sfe.Status = "Em Andamento";
                }
                else if (rbtFinalizada.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1033;
                    sfe.Status = "Finalizada";
                }

                //cadastrando cliente
                c.NomeCliente = txtNome.Text;
                c.Descricao = txtDescricao.Text;
                c.Cpf_cnpj = txtCpfCnpj.Text;
                rc.adiciona(c);
                codClie = c.CodCliente;

                //tabelaEvento
                c.CodCliente = codClie;
                ev.CodTipoEvento = 1004;
                ev.DataEntrega = dataEntregaEdicao.Value.ToString();
                ev.DataEvento = dataEvento.Value.ToString();
                ev.QualHD = txtHD.Text;
                ev.Editor = txtEditor.Text;
                ev.CodUsuario = int.Parse(((UsuarioSqlServer)metroComboBox1.SelectedItem).CodUsuario.ToString());

                re.adiciona(ev);

                rsfe.adiciona(sfe);


                MessageBox.Show("Cadastrado!");
                Close();
                
            }
            else if (rbtFormatura.Checked == true)
            {

                //cadastrando cliente
                c.NomeCliente = txtNome.Text;
                c.Descricao = txtDescricao.Text;
                c.Cpf_cnpj = txtCpfCnpj.Text;


                //cadastrando evento

                //pegar cod usuario
                //pegar cod cliente


                if (ckbDados.Checked == true)
                    ev.EnvioDados = true;
                else
                    ev.EnvioDados = false;

                if (ckbLegenda.Checked == true)
                    ev.StatusLegenda = true;
                else
                    ev.StatusLegenda = false;

                if (ckbBackup.Checked == true)
                    ev.FazerBackup = true;
                else
                    ev.FazerBackup = false;

                //pegar codigo do evento

                if (rbtSemEdicao.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1035;
                    sfe.Status = "Sem Edição";
                }
                else if (rbtEmAndamento.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1036;
                    sfe.Status = "Em Andamento";
                }
                else if (rbtFinalizada.Checked == true)
                {
                    sfe.CodEvento = ev.CodEvento;
                    sfe.CodFase = 1037;
                    sfe.Status = "Finalizada";
                }

                //cadastrando cliente
                c.NomeCliente = txtNome.Text;
                c.Descricao = txtDescricao.Text;
                c.Cpf_cnpj = txtCpfCnpj.Text;
                rc.adiciona(c);
                codClie = c.CodCliente;

                //tabelaEvento
                c.CodCliente = codClie;
                ev.CodTipoEvento = 1002;
                ev.DataEntrega = dataEntregaEdicao.Value.ToString();
                ev.DataEvento = dataEvento.Value.ToString();
                ev.QualHD = txtHD.Text;
                ev.Editor = txtEditor.Text;
                ev.CodUsuario = int.Parse(((UsuarioSqlServer)metroComboBox1.SelectedItem).CodUsuario.ToString());

                re.adiciona(ev);

                rsfe.adiciona(sfe);


                MessageBox.Show("Cadastrado!");
                Close();
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            metroComboBox1.DataSource = ru.GetAll();
            metroComboBox1.ValueMember = "Nome";
        }
    }
}
