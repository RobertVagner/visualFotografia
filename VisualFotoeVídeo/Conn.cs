using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisualFotoeVídeo
{
    public class Conn
    {
        //private static string server = @"DESKTOP-B7MO8G6"; //Robert
        //private static string server = @"DESKTOP-O9R0LU7\SQLEXPRESS"; //Visual
        private static string server = @"DESKTOP-2BK76K8\SQLEXPRESS"; //Robert
        private static string dataBase = "Visual";
        private static string user = "sa";
        private static string password = "123456";

        public static string StrCon
        {
            get { return $"Data Source={server}; Integrated Security=false;Initial Catalog={dataBase}; User ID={user}; Password={password}"; }
        }
    }
}
