using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualFotoeVídeo.Model;

namespace VisualFotoeVídeo.Repositório
{
    internal class RepositorioCliente
    {
        public IEnumerable<Cliente> GetAll()
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = "Select * from Cliente";
                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Cliente> ListaCliente = new List<Cliente>();

                    while (dr.Read())
                    {
                        Cliente c = new Cliente();
                        c.CodCliente = int.Parse(dr[0].ToString());
                        c.NomeCliente = dr[1].ToString();
                        c.Descricao = dr[2].ToString();
                        c.Cpf_cnpj = dr[3].ToString();
                        ListaCliente.Add(c);
                    }
                    return ListaCliente;
                }
            }
            finally { cmd.Dispose(); }
       
        }
        public IEnumerable<Cliente> Get(string pesquisa)
        {
            

            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Select * from Cliente where nomeCliente like '{pesquisa}%'";

                    SqlDataReader dr = cmd.ExecuteReader();
                    List<Cliente> ListaCliente = new List<Cliente>();

                    while (dr.Read())
                    {
                        Cliente c = new Cliente();
                        c.CodCliente = int.Parse(dr[0].ToString());
                        c.NomeCliente = dr[1].ToString();
                        c.Descricao = dr[2].ToString();
                        c.Cpf_cnpj = dr[3].ToString();
                        ListaCliente.Add(c);
                    }
                    return ListaCliente;
                }
            }
            finally { cmd.Dispose(); }                    
        }
        public Cliente GetCliente(int id)
        {         
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Select * from Cliente where codCliente = {id}";
                    SqlDataReader dr = cmd.ExecuteReader();
                    Cliente c = new Cliente();
                    if (dr.Read())
                    {
                        c.CodCliente = int.Parse(dr[0].ToString());
                        c.NomeCliente = dr[1].ToString();
                        c.Descricao = dr[2].ToString();
                        c.Cpf_cnpj = dr[3].ToString();
                    }
                    return c;
                }
            }
            finally { cmd.Dispose(); }          
        }
        public void altera(Cliente visual)
        {           
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Update Cliente set nomeCliente, descricaoc, cpf/cnpj = '{visual.NomeCliente}','{visual.Descricao}','{visual.Cpf_cnpj}'where codCliente = {visual.CodCliente}";
                    cmd.ExecuteNonQuery();
                    //cn.Close();se der erro 
                }
            }
            finally { cmd.Dispose(); }     
        }
        public void exclui(Cliente visual)
        {          
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"Delete Cliente where codCliente = {visual.CodCliente}";
                    cmd.ExecuteNonQuery();
                }
            }
            finally { cmd.Dispose(); }         
        }
        public void adiciona(Cliente visual)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"insert into Cliente (nomeCliente, descricaoc, cpfCnpj) values ('{visual.NomeCliente}','{visual.Descricao}','{visual.Cpf_cnpj}')" +
                        $"set @idCliente = SCOPE_IDENTITY()";
                    cmd.Parameters.AddWithValue("@idCliente", 0).Direction = System.Data.ParameterDirection.Output;
                    cmd.ExecuteNonQuery();
                    visual.CodCliente = Convert.ToInt32(cmd.Parameters["@idCliente"].Value);
                }
            }
            finally { cmd.Dispose(); }
        }
        public int adicionaa(Cliente visual)
        {
            SqlCommand cmd = new SqlCommand();
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"insert into Cliente (nomeCliente, descricaoc, cpfCnpj) values ('{visual.NomeCliente}','{visual.Descricao}','{visual.Cpf_cnpj}')";
                    cmd.ExecuteNonQuery();
                    //cn.Close();
                }
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();
                    cmd.Connection = cn;
                    cmd.CommandText = $"select * from  Cliente where cpfCnpj = {visual.Cpf_cnpj}";
                    SqlDataReader dr = cmd.ExecuteReader();
                    Cliente c = new Cliente();
                    if (dr.Read())
                    {
                        c.CodCliente = int.Parse(dr[0].ToString());
                    }
                    return c.CodCliente;
                }
            }
            finally { cmd.Dispose(); }
        }
    }
}
