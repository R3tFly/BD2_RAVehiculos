using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace LOGICA
{
    public class ClassLogicaUsuario
    {

        DATOS.ClassDatosUsuario datosUsuario = new DATOS.ClassDatosUsuario();

        public string LogicaAgregarUsuario(string P_usuario, string P_nombre, string P_apellido, string P_contraseña, string P_edad, string P_numero)
        {
            return datosUsuario.AgregarUsuario(P_usuario, P_nombre, P_apellido, P_contraseña, P_edad, P_numero);
        }

        public string LogicaBuscarUsuario(string P_usuario, string P_contraseña)
        {
            return datosUsuario.BuscarUsuario(P_usuario, P_contraseña);
        }

        public DataSet LogicaCargarVehiculos(string query)
        {
            return datosUsuario.CargarVehiculos(query);
        }
    }
}