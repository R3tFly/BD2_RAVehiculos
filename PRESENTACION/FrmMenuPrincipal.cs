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
    public partial class FrmMenuPrincipal : Form
    {
        FrmVehiculo vehiculos = new FrmVehiculo();
        FrmReserva reserva = new FrmReserva();
        FrmAlquiler alquiler = new FrmAlquiler();
        FrmHistorial historial = new FrmHistorial();
        FrmConfiguraciones configuracion = new FrmConfiguraciones();
        public FrmMenuPrincipal()
        {
            InitializeComponent();
            vehiculos.TopLevel = false;
            PanelMostrar.Controls.Add(vehiculos);
            vehiculos.Show();
        }
       
        private void BtnVehiculo_Click(object sender, EventArgs e)
        {
            PanelMostrar.Controls.Clear();

            BtnVehiculo.BackColor = Color.FromArgb(75, 158, 250);
            PbVehiculo.BackColor = Color.FromArgb(75, 158, 250);

            BtnReserva.BackColor = Color.FromArgb(32, 43, 76);
            PbReserva.BackColor = Color.FromArgb(32, 43, 76);
            BtnAlquiler.BackColor = Color.FromArgb(32, 43, 76);
            PbAlquiler.BackColor = Color.FromArgb(32, 43, 76);
            BtnHistorial.BackColor = Color.FromArgb(32, 43, 76);
            PbHistorial.BackColor = Color.FromArgb(32, 43, 76);
            BtnConfiguracion.BackColor = Color.FromArgb(32, 43, 76);
            PbConfiguracion.BackColor = Color.FromArgb(32, 43, 76);

            vehiculos.TopLevel = false;
            PanelMostrar.Controls.Add(vehiculos);
            vehiculos.Show();
        }


        private void BtnReserva_Click(object sender, EventArgs e)
        {
            PanelMostrar.Controls.Clear();

            BtnReserva.BackColor = Color.FromArgb(75, 158, 250);
            PbReserva.BackColor = Color.FromArgb(75, 158, 250);

            BtnVehiculo.BackColor = Color.FromArgb(32, 43, 76);
            PbVehiculo.BackColor = Color.FromArgb(32, 43, 76);           
            BtnAlquiler.BackColor = Color.FromArgb(32, 43, 76);
            PbAlquiler.BackColor = Color.FromArgb(32, 43, 76);
            BtnHistorial.BackColor = Color.FromArgb(32, 43, 76);
            PbHistorial.BackColor = Color.FromArgb(32, 43, 76);
            BtnConfiguracion.BackColor = Color.FromArgb(32, 43, 76);
            PbConfiguracion.BackColor = Color.FromArgb(32, 43, 76);

            reserva.TopLevel = false;
            PanelMostrar.Controls.Add(reserva);
            reserva.Show();
        }

        private void BtnAlquiler_Click(object sender, EventArgs e)
        {
            PanelMostrar.Controls.Clear();

            BtnAlquiler.BackColor = Color.FromArgb(75, 158, 250);
            PbAlquiler.BackColor = Color.FromArgb(75, 158, 250);

            BtnReserva.BackColor = Color.FromArgb(32, 43, 76);
            PbReserva.BackColor = Color.FromArgb(32, 43, 76);
            BtnVehiculo.BackColor = Color.FromArgb(32, 43, 76);
            PbVehiculo.BackColor = Color.FromArgb(32, 43, 76);
            BtnHistorial.BackColor = Color.FromArgb(32, 43, 76);
            PbHistorial.BackColor = Color.FromArgb(32, 43, 76);
            BtnConfiguracion.BackColor = Color.FromArgb(32, 43, 76);
            PbConfiguracion.BackColor = Color.FromArgb(32, 43, 76);

            alquiler.TopLevel = false;
            PanelMostrar.Controls.Add(alquiler);
            alquiler.Show();
        }

        private void BtnHistorial_Click(object sender, EventArgs e)
        {
            PanelMostrar.Controls.Clear();

            BtnHistorial.BackColor = Color.FromArgb(75, 158, 250);
            PbHistorial.BackColor = Color.FromArgb(75, 158, 250);

            BtnReserva.BackColor = Color.FromArgb(32, 43, 76);
            PbReserva.BackColor = Color.FromArgb(32, 43, 76);
            BtnAlquiler.BackColor = Color.FromArgb(32, 43, 76);
            PbAlquiler.BackColor = Color.FromArgb(32, 43, 76);
            BtnVehiculo.BackColor = Color.FromArgb(32, 43, 76);
            PbVehiculo.BackColor = Color.FromArgb(32, 43, 76);
            BtnConfiguracion.BackColor = Color.FromArgb(32, 43, 76);
            PbConfiguracion.BackColor = Color.FromArgb(32, 43, 76);

            historial.TopLevel = false;
            PanelMostrar.Controls.Add(historial);
            historial.Show();
        }

        private void BtnConfiguracion_Click(object sender, EventArgs e)
        {
            PanelMostrar.Controls.Clear();

            BtnConfiguracion.BackColor = Color.FromArgb(75, 158, 250);
            PbConfiguracion.BackColor = Color.FromArgb(75, 158, 250);

            BtnReserva.BackColor = Color.FromArgb(32, 43, 76);
            PbReserva.BackColor = Color.FromArgb(32, 43, 76);
            BtnAlquiler.BackColor = Color.FromArgb(32, 43, 76);
            PbAlquiler.BackColor = Color.FromArgb(32, 43, 76);
            BtnHistorial.BackColor = Color.FromArgb(32, 43, 76);
            PbHistorial.BackColor = Color.FromArgb(32, 43, 76);
            BtnVehiculo.BackColor = Color.FromArgb(32, 43, 76);
            PbVehiculo.BackColor = Color.FromArgb(32, 43, 76);

            configuracion.TopLevel = false;
            PanelMostrar.Controls.Add(configuracion);
            configuracion.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            BtnSalir.BackColor = Color.FromArgb(75, 158, 250);
            PbSalir.BackColor = Color.FromArgb(75, 158, 250);

            this.Close();
        }
    }
}
