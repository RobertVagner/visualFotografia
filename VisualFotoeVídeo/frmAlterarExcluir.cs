using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualFotoeVídeo.Model;
using VisualFotoeVídeo.Repositório;

namespace VisualFotoeVídeo
{
    public partial class frmAlterarExcluir : MetroFramework.Forms.MetroForm
    {
        RepositorioUsuarioSql ru = new RepositorioUsuarioSql();
        UsuarioSqlServer u = new UsuarioSqlServer();

        Cliente c = new Cliente();
        RepositorioCliente r = new RepositorioCliente();
        private int codC;

        //var
        private int CodTipoEvento;
        private int CodEvento;

        TipoEvento t = new TipoEvento();
        RepositorioTipoEvento rte = new RepositorioTipoEvento();

        FaseEvento f = new FaseEvento();
        RepositorioFaseEvento rpf = new RepositorioFaseEvento();

        Evento ev = new Evento();
        RepositorioEvento re = new RepositorioEvento();
        private int codEv;

        StatusFaseEvento sfe = new StatusFaseEvento();
        RepositorioStatusFaseEvento rsfe = new RepositorioStatusFaseEvento();
        private int codStaFasEv;

        List<CheckBox> CB = new List<CheckBox>();
        public frmAlterarExcluir()
        {
            InitializeComponent();
        }
        private void Limpar()
        {
            txtNome.Clear();
            txtCpfCnpj.Clear();
            txtDescricao.Clear();
            txtHD.Clear();
            ckbBackup.Checked = false;
            ckbDados.Checked = false;
            ckbLegenda.Checked = false;
            txtEditor.Clear();
        }

        private void picLimpar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void rbnAlterar_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = true;
            txtCpfCnpj.Enabled = true;
            txtDescricao.Enabled = true;
            txtHD.Enabled = true;
            pnInfo.Enabled = true;
            dataEvento.Enabled = true;
            dataEntregaEdicao.Enabled = true;
            btnAlterar.Enabled = true;
            btnExcluir.Enabled = false;
            pnFaseEvento.Enabled = true;
            txtEditor.Enabled = true;
        }
        
        private void rbnExcluir_CheckedChanged(object sender, EventArgs e)
        {
            txtNome.Enabled = false;
            txtCpfCnpj.Enabled = false;
            txtDescricao.Enabled = false;
            txtHD.Enabled = false;
            pnInfo.Enabled = false;
            dataEvento.Enabled = false;
            dataEntregaEdicao.Enabled = false;
            btnAlterar.Enabled = false;
            btnExcluir.Enabled = true;
            txtEditor.Enabled = false;
            pnFaseEvento.Enabled = false;
        }

        private void cbmNomeEvento_SelectedIndexChanged(object sender, EventArgs e)
        {          
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    codC = int.Parse(((Cliente)cbmNomeEvento.SelectedItem).CodCliente.ToString());
                    txtNome.Text = ((Cliente)cbmNomeEvento.SelectedItem).NomeCliente.ToString();
                    txtDescricao.Text = ((Cliente)cbmNomeEvento.SelectedItem).Descricao.ToString();
                    txtCpfCnpj.Text = ((Cliente)cbmNomeEvento.SelectedItem).Cpf_cnpj.ToString();
                    codEv = ev.CodEvento;
                    if (ev.CodCliente == codC)
                    {
                        txtEditor.Text = ev.Editor;
                    }
                    cn.Open();
                    var sql = $"SELECT qualHD, dataEntrega, dataEvento, editor, fezBackup, envoiDados, statusLegenda, status " +
                        $"FROM Evento e inner join StatusFaseEvento s on e.codEvento = s.codEvento where codCliente={codC}";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    dataEvento.Text = dr["dataEvento"].ToString();
                                    dataEntregaEdicao.Text = dr["dataEntrega"].ToString();
                                    txtHD.Text = dr["qualHD"].ToString();
                                    txtEditor.Text = dr["editor"].ToString();
                                    ckbBackup.Checked = bool.Parse(dr["fezBackup"].ToString());
                                    ckbDados.Checked = bool.Parse(dr["envoiDados"].ToString());
                                    ckbLegenda.Checked = bool.Parse(dr["statusLegenda"].ToString());
                                    if (rbtSemEdicao.Text == dr["status"].ToString())
                                        rbtSemEdicao.Checked = true;
                                    else if (rbtEmAndamento.Text == dr["status"].ToString())
                                        rbtEmAndamento.Checked = true;
                                    else if (rbtFinalizada.Text == dr["status"].ToString())
                                        rbtFinalizada.Checked = true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }          
        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {        
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    //int CodEvento;
                    var sql = $"SELECT CodTipoEvento, e.CodEvento FROM Evento e inner join StatusFaseEvento s on e.codEvento = s.codEvento where codCliente={codC}";
                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.HasRows)
                            {
                                if (dr.Read())
                                {
                                    CodTipoEvento = int.Parse(dr["CodTipoEvento"].ToString());
                                    CodEvento = int.Parse(dr["CodEvento"].ToString());
                                }
                            }
                        }
                    }                  
                    c.NomeCliente = txtNome.Text;
                    c.Descricao = txtDescricao.Text;
                    c.Cpf_cnpj = txtCpfCnpj.Text;
                    ev.CodCliente = codC;
                    ev.QualHD = txtHD.Text;
                    ev.DataEntrega = dataEntregaEdicao.Value.ToString();
                    ev.DataEvento = dataEvento.Value.ToString();
                    ev.Editor = txtEditor.Text;
                    ev.CodUsuario = int.Parse(((UsuarioSqlServer)metroComboBox1.SelectedItem).CodUsuario.ToString());

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

                    if (CodTipoEvento == 1002)
                    {
                        if (rbtSemEdicao.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1024;
                            sfe.Status = "Sem Edição";
                        }
                        else if (rbtEmAndamento.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1025;
                            sfe.Status = "Em Andamento";
                        }
                        else if (rbtFinalizada.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1026;
                            sfe.Status = "Finalizada";
                        }
                    }
                    if (CodTipoEvento == 1003)
                    {
                        if (rbtSemEdicao.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1028;
                            sfe.Status = "Sem Edição";
                        }
                        else if (rbtEmAndamento.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1029;
                            sfe.Status = "Em Andamento";
                        }
                        else if (rbtFinalizada.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1030;
                            sfe.Status = "Finalizada";
                        }
                    }
                    if (CodTipoEvento == 1004)
                    {
                        if (rbtSemEdicao.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1031;
                            sfe.Status = "Sem Edição";
                        }
                        else if (rbtEmAndamento.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1032;
                            sfe.Status = "Em Andamento";
                        }
                        else if (rbtFinalizada.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1033;
                            sfe.Status = "Finalizada";
                        }
                    }
                    if (CodTipoEvento == 1005)
                    {
                        if (rbtSemEdicao.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1035;
                            sfe.Status = "Sem Edição";
                        }
                        else if (rbtEmAndamento.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1036;
                            sfe.Status = "Em Andamento";
                        }
                        else if (rbtFinalizada.Checked == true)
                        {
                            sfe.CodEvento = CodEvento;
                            sfe.CodFase = 1037;
                            sfe.Status = "Finalizada";
                        }
                    }
                    
                    re.altera(ev, c, sfe);
                    Close();
                    //rsfe.altera(sfe);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível alterar os dados!\n\n" + ex.Message);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            ev.CodCliente = codC;
            c.CodCliente = codC;
            sfe.CodFase = codC;
            rsfe.exclui(ev);
            re.exclui(ev);        
            r.exclui(c);           
            cbmNomeEvento.DataSource = r.GetAll();
            Close();
        }

        private void frmAlterarExcluir_Load(object sender, EventArgs e)
        {
            cbmNomeEvento.DataSource = r.GetAll();
            cbmNomeEvento.DisplayMember = "nomeCliente";

            metroComboBox1.DataSource = ru.GetAll();
            metroComboBox1.ValueMember = "Nome";
        }
    }
}
