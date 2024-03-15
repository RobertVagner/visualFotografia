using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFotoeVídeo.Model;
using System.Data.SqlClient;

namespace VisualFotoeVídeo.Repositório
{
    internal class RepositorioTipoEvento
    {
        public IEnumerable<TipoEvento> GetAll()
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = "Select * from TipoEvento";
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<TipoEvento> ListaEvento = new List<TipoEvento>();

                    while (dr.Read())
                    {
                        TipoEvento e = new TipoEvento();
                        e.CodTipoEvento = int.Parse(dr[0].ToString());
                        e.Descricao = dr[1].ToString();


                        ListaEvento.Add(e);
                    }
                    return ListaEvento;
                }
            }
            finally { cmd.Dispose(); }

        }
        public IEnumerable<TipoEvento> GetDataEvento(string pesquisa)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Select * from TipoEvento where descricao like '{pesquisa}%'";

                    SqlDataReader dr = cmd.ExecuteReader();
                    List<TipoEvento> ListaEvento = new List<TipoEvento>();

                    while (dr.Read())
                    {
                        TipoEvento e = new TipoEvento();
                        e.CodTipoEvento = int.Parse(dr[0].ToString());
                        e.Descricao = dr[1].ToString();

                        ListaEvento.Add(e);
                    }
                    return ListaEvento;
                }
            }
            finally { cmd.Dispose(); }
        }
        public TipoEvento GetEvento(int id)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Select * from TipoEvento where codTipoEvento = {id}";
                    SqlDataReader dr = cmd.ExecuteReader();
                    TipoEvento e = new TipoEvento();
                    if (dr.Read())
                    {
                        e.CodTipoEvento = int.Parse(dr[0].ToString());
                        e.Descricao = dr[1].ToString();
                    }
                    return e;
                }
            }
            finally { cmd.Dispose(); }
        }

    }
}
