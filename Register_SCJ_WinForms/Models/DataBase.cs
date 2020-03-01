using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Register_SCJ_WinForms.Models
{
    public class DataBase
    {
        protected SqlConnection Conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["default"].ConnectionString);
        //Cadena_Conexion = string.Format(@"Server = tcp:ARTHUR\VNAJ_DB01,49156; DataBase = dbControlNotas; User Id = u_dbControlNotas; Password = 123456");
    }
}
