using System;
using MySql.Data.MySqlClient;

using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DATOS
{
    public class ClassConexion
    {

        static String host = "127.0.0.1";
        static String username = "root";
        static String password = "Root1";
        static String database = "sistema_ra_vehiculos";

        static string connection = "datasource=" + host + ";username=" + username + ";password=" +
            password + ";database=" + database;

        public MySqlConnection conexion = new MySqlConnection(connection);

    }
}
