using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using VisualFotoeVídeo.Model;

namespace VisualFotoeVídeo
{
    internal static class Program
    {
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormEntrarCadastrar());
        }
        static public List<UsuarioSqlServer> listaUsuario = new List<UsuarioSqlServer>();
    }
}
