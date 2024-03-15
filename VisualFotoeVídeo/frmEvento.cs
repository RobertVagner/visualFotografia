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
using VisualFotoeVídeo.Repositório;
using VisualFotoeVídeo.Model;
using System.Linq.Expressions;

namespace VisualFotoeVídeo
{
    public partial class frmEvento : MetroFramework.Forms.MetroForm
    {
        public frmEvento()
        {
            InitializeComponent();
        }
        private void frmEvento_Load(object sender, EventArgs e)
        {         
            SqlCommand cmd = new SqlCommand();
            using (SqlConnection cn = new SqlConnection(Conn.StrCon))
            {
                cn.Open();
                var sqlQuery = "Select * from dbo.tabEvento_Mostra where Status != 'Finalizada' order by Data ASC";
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
    }
}
