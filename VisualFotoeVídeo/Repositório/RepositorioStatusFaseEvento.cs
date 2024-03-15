using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFotoeVídeo.Model;

namespace VisualFotoeVídeo.Repositório
{
    internal class RepositorioStatusFaseEvento
    {
        public void adiciona(StatusFaseEvento sfe)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"DECLARE @codEvento INT SET @codEvento = IDENT_CURRENT('Evento')" +
                        $"DECLARE @codFase INT SET @codFase = IDENT_CURRENT('FaseEvento')" +
                        $"insert into StatusFaseEvento (codEvento, codFase, status) values (@codEvento, '{sfe.CodFase}', '{sfe.Status}')";
                    cmd.ExecuteNonQuery();
                }
            }
            finally { cmd.Dispose(); }
        }
        public IEnumerable<StatusFaseEvento> GetAll()
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = "Select * from StatusFaseEvento";
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<StatusFaseEvento> ListaStatusFase = new List<StatusFaseEvento>();

                    while (dr.Read())
                    {
                        StatusFaseEvento sfe = new StatusFaseEvento();
                        sfe.CodStatusFase = int.Parse(dr[0].ToString());
                        sfe.CodEvento = int.Parse(dr[1].ToString());
                        sfe.CodFase = int.Parse(dr[2].ToString());
                        sfe.Status = dr[3].ToString();
                        ListaStatusFase.Add(sfe);
                    }
                    return ListaStatusFase;
                }
            }
            finally { cmd.Dispose(); }

        }
        public StatusFaseEvento GetStatusFaseEvento(int id)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Select * from StatusFaseEvento where codStatusFase = {id}";
                    SqlDataReader dr = cmd.ExecuteReader();
                    StatusFaseEvento sfe = new StatusFaseEvento();
                    if (dr.Read())
                    {
                        sfe.CodStatusFase = int.Parse(dr[0].ToString());
                        sfe.CodEvento = int.Parse(dr[1].ToString());
                        sfe.CodFase = int.Parse(dr[2].ToString());
                        sfe.Status = dr[3].ToString();
                    }
                    return sfe;
                }
            }
            finally { cmd.Dispose(); }
        }
        public void altera(StatusFaseEvento visual)
        {
            Evento ev = new Evento();
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"UPDATE StatusFaseEvento SET status ='{visual.Status}', codFase='{visual.CodFase}' WHERE codEvento = {ev.CodEvento}";
                    cmd.ExecuteNonQuery();
                    //cn.Close();se der erro 
                }
            }
            finally { cmd.Dispose(); }
        }
        public void exclui(Evento evento)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Delete StatusFaseEvento where codEvento = (select codEvento from Evento where codCliente = {evento.CodCliente})";
                    cmd.ExecuteNonQuery();
                }
            }
            finally { cmd.Dispose(); }
        }
    }
}
