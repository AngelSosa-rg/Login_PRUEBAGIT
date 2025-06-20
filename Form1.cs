using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Vistas;

namespace Login
{
    public partial class Form1 : Form
    {
        Controllers.AuthController _authController = new Controllers.AuthController();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            var usuario = new Models.LoginModel
            {
                NombreUsuario = txtUsuario.Text.Trim(),
                Contrasenia = txtContrasenia.Text.Trim()
            };

            var res = _authController.login(usuario);
            if (res == "ok")
            {
                MessageBox.Show("Bienvenido al Sistema");
                var frmMenuPrincipal = new FRM_MenuPrincipal();

                this.Hide();
                frmMenuPrincipal.Show();


                //enviar a abrir al formulario de dashboard
                /* var autores = new Vistas.Autores();
                this.Hide();
                autores.Show();*/
            }
            else
            {
                MessageBox.Show(res);
                lblMensaje.Text = res;
                lblMensaje.Visible = true;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
            txtContrasenia.Text = "";
            txtUsuario.Text = "";
        }
    }
}
