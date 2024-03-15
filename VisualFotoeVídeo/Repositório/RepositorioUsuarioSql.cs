using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VisualFotoeVídeo.Model;

namespace VisualFotoeVídeo.Repositório
{
    internal class RepositorioUsuarioSql
    {
        public IEnumerable<UsuarioSqlServer> GetAll()
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = "Select * from Usuario";
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<UsuarioSqlServer> ListaUsuario = new List<UsuarioSqlServer>();

                    while (dr.Read())
                    {
                        UsuarioSqlServer u = new UsuarioSqlServer();
                        u.CodUsuario = int.Parse(dr[0].ToString());
                        u.Nome = dr[1].ToString();
                        u.Senha = dr[2].ToString();
                        u.Login = dr[3].ToString();
                        ListaUsuario.Add(u);
                    }
                    return ListaUsuario;
                }
            }
            finally { cmd.Dispose(); }

        }
        public IEnumerable<UsuarioSqlServer> Get(string pesquisa)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Select * from Usuario where Nome like '{pesquisa}%'";

                    SqlDataReader dr = cmd.ExecuteReader();
                    List<UsuarioSqlServer> ListaUsuario = new List<UsuarioSqlServer>();

                    while (dr.Read())
                    {
                        UsuarioSqlServer u = new UsuarioSqlServer();
                        u.CodUsuario = int.Parse(dr[0].ToString());
                        u.Nome = dr[1].ToString();
                        u.Senha = dr[2].ToString();
                        u.Login = dr[3].ToString();
                        ListaUsuario.Add(u);
                    }
                    return ListaUsuario;
                }
            }
            finally { cmd.Dispose(); }
        }
        public UsuarioSqlServer GetUsuarioSql(int id)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Select * from Usuario where codUsuario = {id}";
                    SqlDataReader dr = cmd.ExecuteReader();
                    UsuarioSqlServer c = new UsuarioSqlServer();
                    if (dr.Read())
                    {
                        c.CodUsuario = int.Parse(dr[0].ToString());
                        c.Nome = dr[1].ToString();
                        c.Senha = dr[2].ToString();
                        c.Login = dr[3].ToString();
                    }
                    return c;
                }
            }
            finally { cmd.Dispose(); }
        }
        public void altera(UsuarioSqlServer visual)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Update Usuario set Nome, Senha, Login = '{visual.Nome}','{visual.Senha}','{visual.Login}'where codUsuario = {visual.CodUsuario}";
                    cmd.ExecuteNonQuery();
                }
            }
            finally { cmd.Dispose(); }
        }
        public void exclui(UsuarioSqlServer visual)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Delete Usuario where codUsuario = {visual.CodUsuario}";
                    cmd.ExecuteNonQuery();
                }
            }
            finally { cmd.Dispose(); }
        }
        public void adiciona(UsuarioSqlServer visual)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"insert into Usuario (Nome, Senha, Login) values ('{visual.Nome}','{visual.Senha}','{visual.Login}')" +
                        $"set @idUsuario = SCOPE_IDENTITY()";
                    cmd.Parameters.AddWithValue("@idUsuario", 0).Direction = System.Data.ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    visual.CodUsuario = Convert.ToInt32(cmd.Parameters["@idUsuario"].Value);
                }
            }
            finally { cmd.Dispose(); }
        }
        public int adicionaa(UsuarioSqlServer visual)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"insert into Usuario (Nome, Senha, Usuario) values ('{visual.Nome}','{visual.Senha}','{visual.Login}')";
                    cmd.ExecuteNonQuery();
                    //cn.Close();
                }
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"select * from  Usuario where Login = {visual.Login}";
                    SqlDataReader dr = cmd.ExecuteReader();
                    UsuarioSqlServer u = new UsuarioSqlServer();
                    if (dr.Read())
                    {
                        u.CodUsuario = int.Parse(dr[0].ToString());
                    }
                    return u.CodUsuario;
                }
            }
            finally { cmd.Dispose(); }
        }
    }
}
