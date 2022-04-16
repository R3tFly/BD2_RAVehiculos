using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PRESENTACION
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void BtnIniciar_Click(object sender, EventArgs e)
        {
            if(BtnIniciar.Text == "Iniciar Sesion")
            {
                LblTitulo.Text = "Iniciar Sesion";
                PanelInicio.Visible = true;
                PanelRegistro.Visible = false;
                BtnIniciar.Text = "Registrarse";
                LblText1.Text = "¿Crear una cuenta?";
                LblTexto2.Text = "Has click en el boton de abajo para crear una cuenta nueva";
            }
            else if(BtnIniciar.Text == "Registrarse")
            {
                LblTitulo.Text = "Registrar Usuario";
                PanelRegistro.Visible = true;
                PanelInicio.Visible = false;
                BtnIniciar.Text = "Iniciar Sesion";
                LblText1.Text = "¿Ya tienes una cuenta?";
                LblTexto2.Text = "Has click en el boton de abajo para iniciar sesion";
            }
            
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            
        }

        private void BtnIniciar_MouseEnter(object sender, EventArgs e)
        {
            BtnIniciar.ForeColor = System.Drawing.Color.Black;
            BtnIniciar.BackColor = Color.White;
        }

        private void BtnIniciar_MouseLeave(object sender, EventArgs e)
        {
            BtnIniciar.ForeColor = System.Drawing.Color.White;
            BtnIniciar.BackColor = Color.FromArgb(32, 43, 76);
        }

        private void BtnAcceder_MouseEnter(object sender, EventArgs e)
        {
            BtnAcceder.ForeColor = System.Drawing.Color.Black;
            BtnAcceder.BackColor = Color.White;
        }

        private void BtnAcceder_MouseLeave(object sender, EventArgs e)
        {
            BtnAcceder.ForeColor = System.Drawing.Color.White;
            BtnAcceder.BackColor = Color.FromArgb(49, 65, 84);
        }

        private void BtnRegistrar_MouseEnter_1(object sender, EventArgs e)
        {
            BtnRegistrar.ForeColor = System.Drawing.Color.Black;
            BtnRegistrar.BackColor = Color.White;
        }

        private void BtnRegistrar_MouseLeave_1(object sender, EventArgs e)
        {
            BtnRegistrar.ForeColor = System.Drawing.Color.White;
            BtnRegistrar.BackColor = Color.FromArgb(40, 40, 40);
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void FrmLogin_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TxtNuevoUsuario_MouseEnter(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
            if (TxtNuevoUsuario.Text == "USERNAME")
            {
                TxtNuevoUsuario.Text = "";
                TxtNuevoUsuario.ForeColor = System.Drawing.Color.Gray;
            }
            
        }

        private void TxtNuevoUsuario_MouseLeave(object sender, EventArgs e)
        {
            if (TxtNuevoUsuario.Text == "")
            {
                TxtNuevoUsuario.Text = "USERNAME";
                TxtNuevoUsuario.ForeColor = System.Drawing.Color.DimGray;
                BtnRegistrar.Focus();
            }
            
        }

        private void Txtname_MouseEnter(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
            if (Txtname.Text == "NAME")
            {
                Txtname.Text = "";
                Txtname.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void Txtname_MouseLeave(object sender, EventArgs e)
        {
            if (Txtname.Text == "")
            {
                Txtname.Text = "NAME";
                Txtname.ForeColor = System.Drawing.Color.DimGray;
                BtnRegistrar.Focus();
            }
        }

        private void TxtLastname_MouseEnter(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
            if (TxtLastname.Text == "LASTNAME")
            {
                TxtLastname.Text = "";
                TxtLastname.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtLastname_MouseLeave(object sender, EventArgs e)
        {
            if (TxtLastname.Text == "")
            {
                TxtLastname.Text = "LASTNAME";
                TxtLastname.ForeColor = System.Drawing.Color.DimGray;
                BtnRegistrar.Focus();
            }
        }

        private void TxtPassword_MouseEnter(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
            if (TxtPassword.Text == "PASSWORD")
            {
                TxtPassword.Text = "";
                TxtPassword.PasswordChar = '*';
                TxtPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtPassword_MouseLeave(object sender, EventArgs e)
        {
            if (TxtPassword.Text == "")
            {
                
                TxtPassword.Text = "PASSWORD";
                TxtPassword.PasswordChar = '\0';
                TxtPassword.ForeColor = System.Drawing.Color.DimGray;
                BtnRegistrar.Focus();
            }
        }

        private void TxtConfirmarPassword_MouseEnter(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
            if (TxtConfirmarPassword.Text == "CONFIRM PASSWORD")
            {
                TxtConfirmarPassword.Text = "";
                TxtConfirmarPassword.PasswordChar = '*';
                TxtConfirmarPassword.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtConfirmarPassword_MouseLeave(object sender, EventArgs e)
        {
            if (TxtConfirmarPassword.Text == "")
            {

                TxtConfirmarPassword.Text = "CONFIRM PASSWORD";
                TxtConfirmarPassword.PasswordChar = '\0';
                TxtConfirmarPassword.ForeColor = System.Drawing.Color.DimGray;
                BtnRegistrar.Focus();
            }
        }

        private void TxtEdad_MouseEnter(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
            if (TxtEdad.Text == "AGE")
            {
                TxtEdad.Text = "";
                TxtEdad.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtEdad_MouseLeave(object sender, EventArgs e)
        {
            if (TxtEdad.Text == "")
            {

                TxtEdad.Text = "AGE";
                TxtEdad.ForeColor = System.Drawing.Color.DimGray;
                BtnRegistrar.Focus();
            }
        }

        private void TxtUsuario_MouseEnter(object sender, EventArgs e)
        {
            LblMensaje2.Text = "";
            if (TxtUsuario.Text == "USERNAME")
            {
                TxtUsuario.Text = "";
                TxtUsuario.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtUsuario_MouseLeave(object sender, EventArgs e)
        {
            if (TxtUsuario.Text == "")
            {

                TxtUsuario.Text = "USERNAME";
                TxtUsuario.ForeColor = System.Drawing.Color.DimGray;
                BtnAcceder.Focus();
            }
        }

        private void TxtContraseña_MouseEnter(object sender, EventArgs e)
        {
            LblMensaje2.Text = "";
            if (TxtContraseña.Text == "PASSWORD")
            {
                TxtContraseña.Text = "";
                TxtContraseña.PasswordChar = '*';
                TxtContraseña.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtContraseña_MouseLeave(object sender, EventArgs e)
        {
            if (TxtContraseña.Text == "")
            {

                TxtContraseña.Text = "PASSWORD";
                TxtContraseña.PasswordChar = '\0';
                TxtContraseña.ForeColor = System.Drawing.Color.DimGray;
                BtnAcceder.Focus();
            }
        }

        private void TxtNumero_MouseEnter(object sender, EventArgs e)
        {
            LblMensaje.Text = "";
            if (TxtNumero.Text == "NUMBER")
            {
                TxtNumero.Text = "";
                TxtNumero.ForeColor = System.Drawing.Color.Gray;
            }
        }

        private void TxtNumero_MouseLeave(object sender, EventArgs e)
        {
            if (TxtNumero.Text == "")
            {

                TxtNumero.Text = "NUMBER";
                TxtNumero.ForeColor = System.Drawing.Color.DimGray;
                BtnRegistrar.Focus();
            }
        }

        LOGICA.ClassLogicaUsuario logica = new LOGICA.ClassLogicaUsuario();

        private void BtnRegistrar_Click_1(object sender, EventArgs e)
        {
            if ((TxtNuevoUsuario.Text == "" || TxtNuevoUsuario.Text == "USERNAME") || (Txtname.Text == "" || Txtname.Text == "NAME") || (TxtLastname.Text == "" || TxtLastname.Text == "LASTNAME") || (TxtPassword.Text == "" || TxtPassword.Text == "PASSWORD") || (TxtConfirmarPassword.Text == "" || TxtConfirmarPassword.Text == "CONFIRM PASSWORD") || (TxtEdad.Text == "" || TxtEdad.Text == "AGE") || (TxtNumero.Text == "" || TxtNumero.Text == "NUMBER"))
            {
                LblMensaje.Text = "*Por Favor llenar todos campos*";
            }
            else
            {
                if (TxtPassword.Text.Equals(TxtConfirmarPassword.Text))
                {
                    string usuario = TxtNuevoUsuario.Text;
                    string nombre = Txtname.Text;
                    string apellido = TxtLastname.Text;
                    string contraseña = TxtPassword.Text;
                    string edad = TxtEdad.Text;
                    string numero = TxtNumero.Text;

                    string mensaje = logica.LogicaAgregarUsuario(usuario,nombre,apellido,contraseña,edad,numero);

                    LblMensaje.Text = mensaje;

                    if(mensaje == "Registro compleado exitosamente")
                    {
                        TxtNuevoUsuario.Text = "USERNAME";
                        Txtname.Text = "NAME";
                        TxtLastname.Text = "LASTNAME";
                        TxtPassword.Text = "PASSWORD";
                        TxtPassword.PasswordChar = '\0';
                        TxtConfirmarPassword.Text = "CONFIRM PASSWORD";
                        TxtConfirmarPassword.PasswordChar = '\0';
                        TxtEdad.Text = "AGE";
                        TxtNumero.Text = "NUMBER";
                        BtnRegistrar.Focus();
                    }
                    else
                    {
                        TxtNuevoUsuario.Text = "";
                        TxtNuevoUsuario.Focus();
                    }

                }
                else
                {
                    LblMensaje.Text = "Las contraseñas no coiciden";
                }
            }    
        }

        private void BtnAcceder_Click(object sender, EventArgs e)
        {
            if ((TxtUsuario.Text == "" || TxtUsuario.Text == "USERNAME") || (TxtContraseña.Text == "" || TxtContraseña.Text == "PASSWORD"))
            {
                LblMensaje2.Text = "*Por Favor llenar todos campos*";
            }
            else
            {
                string usuario = TxtUsuario.Text;
                string contraseña = TxtContraseña.Text;

                string mensaje = logica.LogicaBuscarUsuario(usuario,contraseña);

                LblMensaje2.Text = mensaje;

                if (mensaje == "Valido")
                {
                    TxtUsuario.Text = "USERNAME";
                    TxtContraseña.Text = "PASSWORD";
                    TxtContraseña.PasswordChar = '\0';
                    LblMensaje2.Text = "";

                    FrmMenuPrincipal menu = new FrmMenuPrincipal();
                    this.Hide();
                    menu.ShowDialog();
                    this.Show();

                }
            }
        }

        private void TxtContraseña_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if ((TxtUsuario.Text == "" || TxtUsuario.Text == "USERNAME") || (TxtContraseña.Text == "" || TxtContraseña.Text == "PASSWORD"))
                {
                    LblMensaje2.Text = "*Por Favor llenar todos campos*";
                }
                else
                {
                    string usuario = TxtUsuario.Text;
                    string contraseña = TxtContraseña.Text;

                    string mensaje = logica.LogicaBuscarUsuario(usuario, contraseña);

                    LblMensaje2.Text = mensaje;

                    if (mensaje == "Valido")
                    {
                        TxtUsuario.Text = "USERNAME";
                        TxtContraseña.Text = "PASSWORD";
                        TxtContraseña.PasswordChar = '\0';
                        LblMensaje2.Text = "";

                        FrmMenuPrincipal menu = new FrmMenuPrincipal();
                        this.Hide();
                        menu.ShowDialog();
                        this.Show();

                    }
                }
            }

            
        }
    }
}
