using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PRESENTACION
{
    public partial class FrmVehiculo : Form
    {
        LOGICA.ClassLogicaUsuario logicaUsuario = new LOGICA.ClassLogicaUsuario();

        DataSet dato = new DataSet();

        public FrmVehiculo()
        {
            InitializeComponent();

            //this.DgUsuarios.DataSource = "";

            //string query = "select * from tbl_usuario where usuario like '%'"+ TxtBuscar + '%';

            string query = "SELECT id_vehiculo AS Vehiculo,nombre_modelo AS Modelo,nombre_marca AS Marca,nombre_color AS Color "
                           +"FROM vehiculo, modelo, marca, color "
                           +"WHERE vehiculo.id_modelo = modelo.id_modelo "
                           +"and vehiculo.id_marca = marca.id_marca "
                           +"and vehiculo.id_color = color.id_color ";
            dato = logicaUsuario.LogicaCargarVehiculos(query);
            this.DgVehiculo.DataSource = dato.Tables[0];
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (RbtnModelo.Checked == true)
            {
                string query = "SELECT id_vehiculo AS Vehiculo,nombre_modelo AS Modelo,nombre_marca AS Marca,nombre_color AS Color "
                           + "FROM vehiculo, modelo, marca, color "
                           + "WHERE vehiculo.id_modelo = modelo.id_modelo "
                           + "and vehiculo.id_marca = marca.id_marca "
                           + "and vehiculo.id_color = color.id_color "
                           + "and nombre_modelo LIKE '%" + TxtBuscar.Text + "%'";
                dato = logicaUsuario.LogicaCargarVehiculos(query);
            }else if (RbtnMarca.Checked == true)
            {
                string query = "SELECT id_vehiculo AS Vehiculo,nombre_modelo AS Modelo,nombre_marca AS Marca,nombre_color AS Color "
                           + "FROM vehiculo, modelo, marca, color "
                           + "WHERE vehiculo.id_modelo = modelo.id_modelo "
                           + "and vehiculo.id_marca = marca.id_marca "
                           + "and vehiculo.id_color = color.id_color "
                           + "and nombre_marca LIKE '%" + TxtBuscar.Text + "%'";
                dato = logicaUsuario.LogicaCargarVehiculos(query);
            }
            else if (RbtnColor.Checked == true)
            {
                string query = "SELECT id_vehiculo AS Vehiculo,nombre_modelo AS Modelo,nombre_marca AS Marca,nombre_color AS Color "
                           + "FROM vehiculo, modelo, marca, color "
                           + "WHERE vehiculo.id_modelo = modelo.id_modelo "
                           + "and vehiculo.id_marca = marca.id_marca "
                           + "and vehiculo.id_color = color.id_color "
                           + "and nombre_color LIKE '%"+TxtBuscar.Text+"%'";
                dato = logicaUsuario.LogicaCargarVehiculos(query);
            }

            this.DgVehiculo.DataSource = dato.Tables[0];
        }
    }
}
