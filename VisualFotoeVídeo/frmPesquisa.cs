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

namespace VisualFotoeVídeo
{
    public partial class frmPesquisa : MetroFramework.Forms.MetroForm
    {
        public frmPesquisa()
        {
            InitializeComponent();
        }

        private void btnPesquisaNome_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sqlQuery = $"select * from dbo.tabEvento_Mostra where Cliente like'%{txtPesquisaNome.Text}%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar concetar\n\n" + ex.Message);
            }
        }

        private void btnPesquisaCpfCnpj_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sqlQuery = $"select * from dbo.tabEvento_Mostra where Cidade like'%{txtPequisaCpfCnpj.Text}%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar concetar\n\n" + ex.Message);
            }
        }

        private void btnPesquisaData_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(Conn.StrCon))
                {
                    cn.Open();

                    var sqlQuery = $"select * from dbo.tabEvento_Mostra where Data like'%{txtData.Text}%'";
                    using (SqlDataAdapter da = new SqlDataAdapter(sqlQuery, cn))
                    {
                        using (DataTable dt = new DataTable())
                        {
                            da.Fill(dt);
                            dataGridView1.DataSource = dt;
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar concetar\n\n" + ex.Message);
            }
        }
    }
}
