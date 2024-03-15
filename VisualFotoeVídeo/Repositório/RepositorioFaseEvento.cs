using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFotoeVídeo.Model;

namespace VisualFotoeVídeo.Repositório
{
    internal class RepositorioFaseEvento
    {
        public IEnumerable<FaseEvento> GetAll()
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
                    List<FaseEvento> ListaEvento = new List<FaseEvento>();

                    while (dr.Read())
                    {
                        FaseEvento e = new FaseEvento();
                        e.CodFase = int.Parse(dr[0].ToString());
                        e.Descricao = dr[1].ToString();


                        ListaEvento.Add(e);
                    }
                    return ListaEvento;
                }
            }
            finally { cmd.Dispose(); }

        }
        public IEnumerable<FaseEvento> GetDataEvento(string pesquisa)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Select * from FaseEvento where descricao like '{pesquisa}%'";

                    SqlDataReader dr = cmd.ExecuteReader();
                    List<FaseEvento> ListaEvento = new List<FaseEvento>();

                    while (dr.Read())
                    {
                        FaseEvento e = new FaseEvento();
                        e.CodFase = int.Parse(dr[0].ToString());
                        e.Descricao = dr[1].ToString();
                        
                        ListaEvento.Add(e);
                    }
                    return ListaEvento;
                }
            }
            finally { cmd.Dispose(); }
        }
        public FaseEvento GetEvento(int id)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Select * from FaseEvento where codFase = {id}";
                    SqlDataReader dr = cmd.ExecuteReader();
                    FaseEvento e = new FaseEvento();
                    if (dr.Read())
                    {
                        e.CodFase = int.Parse(dr[0].ToString());
                        e.Descricao = dr[1].ToString();
                    }
                    return e;
                }
            }
            finally { cmd.Dispose(); }
        }
    }
}
