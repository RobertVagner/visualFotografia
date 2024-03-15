using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFotoeVídeo.Model;
using System.Windows.Forms;
using System.Linq.Expressions;
using MetroFramework.Controls;
using System.Collections.ObjectModel;

namespace VisualFotoeVídeo.Repositório
{
    internal class RepositorioEvento
    {
        public void adiciona(Evento evento)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"DECLARE @codTipoEvento INT SET @codTipoEvento = IDENT_CURRENT('TipoEvento')" +
                        $"DECLARE @codCliente INT SET @codCliente = IDENT_CURRENT('Cliente')" +
                        $"insert into Evento (codCliente, codTipoEvento, envoiDados, statusLegenda, dataEntrega, codUsuario, dataEvento, fezBackup, qualHD, editor) " +
                        $"values (@codCliente,'{evento.CodTipoEvento}', '{evento.EnvioDados}', " +
                        $"'{evento.StatusLegenda}', '{evento.DataEntrega}', '{evento.CodUsuario}', '{evento.DataEvento}', '{evento.FazerBackup}', '{evento.QualHD}','{evento.Editor}')";
                    cmd.ExecuteNonQuery();
                }
            }
            finally { cmd.Dispose(); }
        }
        public IEnumerable<Evento> GetAll()
        {        
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = "Select * from Evento";
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Evento> ListaEvento = new List<Evento>();

                    while (dr.Read())
                    {
                        Evento e = new Evento();
                        e.CodEvento = int.Parse(dr[0].ToString());
                        e.CodCliente = int.Parse(dr[1].ToString());
                        e.CodTipoEvento = int.Parse(dr[2].ToString());
                        e.EnvioDados = bool.Parse(dr[3].ToString());
                        e.StatusLegenda = bool.Parse(dr[4].ToString());
                        e.DataEntrega = dr[5].ToString();
                        e.CodUsuario = int.Parse(dr[6].ToString());
                        e.DataEvento = dr[7].ToString();
                        e.FazerBackup = bool.Parse(dr[8].ToString());
                        e.QualHD = dr[9].ToString();
                        e.Editor = dr[10].ToString();
                        ListaEvento.Add(e);
                    }
                    return ListaEvento;
                }
            }
            finally { cmd.Dispose(); }

        }
            public IEnumerable<Evento> GetDataEvento(string pesquisa)
            {
                SqlCommand cmd = new SqlCommand();
                try
                {
                    using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                    {
                        cn.Open();
                        cmd.Connection = cn;
                        cmd.CommandText = $"Select * from Evento where dataEvento like '{pesquisa}%'";

                        SqlDataReader dr = cmd.ExecuteReader();
                        List<Evento> ListaEvento = new List<Evento>();

                        while (dr.Read())
                        {
                            Evento e = new Evento();
                            e.CodEvento = int.Parse(dr[0].ToString());
                            e.CodCliente = int.Parse(dr[1].ToString());
                            e.CodTipoEvento = int.Parse(dr[2].ToString());
                            e.EnvioDados = bool.Parse(dr[3].ToString());
                            e.StatusLegenda = bool.Parse(dr[4].ToString());
                            e.DataEntrega = dr[5].ToString();
                            e.CodUsuario = int.Parse(dr[6].ToString());
                            e.DataEvento = dr[7].ToString();
                            e.FazerBackup = bool.Parse(dr[8].ToString());
                            e.QualHD = dr[9].ToString();
                            ListaEvento.Add(e);
                        }
                        return ListaEvento;
                    }
                }
                finally { cmd.Dispose(); }
            }
        public Evento GetEvento(int id)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Select * from Evento where codEvento = {id}";
                    SqlDataReader dr = cmd.ExecuteReader();
                    Evento e = new Evento();
                    if (dr.Read())
                    {
                        e.CodEvento = int.Parse(dr[0].ToString());
                        e.CodCliente = int.Parse(dr[1].ToString());
                        e.CodTipoEvento = int.Parse(dr[2].ToString());
                        e.EnvioDados = bool.Parse(dr[3].ToString());
                        e.StatusLegenda = bool.Parse(dr[4].ToString());
                        e.DataEntrega = dr[5].ToString();
                        e.CodUsuario = int.Parse(dr[6].ToString());
                        e.DataEvento = dr[7].ToString();
                        e.FazerBackup = bool.Parse(dr[8].ToString());
                        e.QualHD = dr[9].ToString();
                    }
                    return e;
                }
            }
            finally { cmd.Dispose(); }
        }
        public void altera(Evento visual, Cliente cliente, StatusFaseEvento stf)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"UPDATE Evento SET dataEntrega='{visual.DataEntrega}', dataEvento='{visual.DataEvento}', qualHD='{visual.QualHD}', envoiDados='{visual.EnvioDados}',statusLegenda='{visual.StatusLegenda}',fezBackup='{visual.FazerBackup}',editor='{visual.Editor}' WHERE codCliente = {visual.CodCliente}" +
                        $"UPDATE Cliente SET nomeCliente='{cliente.NomeCliente}', descricaoc='{cliente.Descricao}', cpfCnpj='{cliente.Cpf_cnpj}' WHERE codCliente ={visual.CodCliente}" +
                        $"UPDATE StatusFaseEvento SET status ='{stf.Status}', codFase='{stf.CodFase}' WHERE codEvento = {stf.CodEvento}";
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Alterado!!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Não foi possível alterar os dados!\n\n" + ex.Message);
            }
        }
        public void exclui(Evento visual)

        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Delete Evento where codCliente = {visual.CodCliente}";
                    cmd.ExecuteNonQuery();                  
                    MessageBox.Show("Excluido!!!");
                }
            }
            finally { cmd.Dispose(); }
        }
    }
}
