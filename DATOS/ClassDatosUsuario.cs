using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace DATOS
{
    public class ClassDatosUsuario
    {

        ClassConexion conexion = new ClassConexion();

        public string AgregarUsuario(string P_usuario,string P_nombre, string P_apellido, string P_contraseña, string P_edad, string P_numero)
        {
            conexion.conexion.Open();

            MySqlCommand comando = new MySqlCommand("pa_agregarCliente", conexion.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@P_usuario", P_usuario);
            comando.Parameters.AddWithValue("@P_nombre", P_nombre);
            comando.Parameters.AddWithValue("@P_apellido", P_apellido);
            comando.Parameters.AddWithValue("@P_contrasenia", P_contraseña);
            comando.Parameters.AddWithValue("@P_edad", P_edad);
            comando.Parameters.AddWithValue("@P_numero", P_numero);

            comando.Parameters.Add("@msg", MySqlDbType.VarChar, 100);
            comando.Parameters["@msg"].Direction = System.Data.ParameterDirection.Output;

            try
            {
                comando.ExecuteNonQuery();

                String mensaje = Convert.ToString(comando.Parameters["@msg"].Value);

                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.ToString();

            }
            finally
            {
                conexion.conexion.Close();
            }

        }

        public string BuscarUsuario(string P_usuario, string P_contraseña)
        {
            conexion.conexion.Open();

            MySqlCommand comando = new MySqlCommand("pa_buscarUsuario", conexion.conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@P_usuario", P_usuario);
            comando.Parameters.AddWithValue("@P_contrasenia", P_contraseña);

            comando.Parameters.Add("@msg", MySqlDbType.VarChar, 100);
            comando.Parameters["@msg"].Direction = System.Data.ParameterDirection.Output;

            try
            {
                comando.ExecuteNonQuery();

                String mensaje = Convert.ToString(comando.Parameters["@msg"].Value);

                return mensaje;
            }
            catch (Exception ex)
            {
                return ex.ToString();

            }
            finally
            {
                conexion.conexion.Close();
            }
        }

        public DataSet CargarVehiculos(string query)
        {
            conexion.conexion.Open(); // SE ABRE LA CONEXION

            MySqlCommand comando = new MySqlCommand(query, conexion.conexion);
            comando.CommandType = CommandType.Text;

            MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);

            DataSet datos = new DataSet();
            adaptador.Fill(datos);

            conexion.conexion.Close();
            return datos;
        }

    }
}
