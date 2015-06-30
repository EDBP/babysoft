using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Boutique
{
    public partial class frmLogin : DevExpress.XtraEditors.XtraForm
    {
        public static int idUsuario;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                errorProvider1.SetError(txtUsuario, "Debe ingresar un nombre de usuario");
                txtUsuario.Focus();
                return;
            }
            if (txtContraseña.Text == "")
            {
                errorProvider1.SetError(txtContraseña, "Debe ingresar una contraseña");
                txtContraseña.Focus();
                return;
            }
            DataTable datos = conexion.fnEjecutarConsulta("SELECT id_usuario, password FROM usuario WHERE usuario= '" + txtUsuario.Text + "'");
            if (datos.Rows.Count > 0)
            {
                if (datos.Rows[0][1].ToString().Equals(txtContraseña.Text))
                {
                    idUsuario = int.Parse(datos.Rows[0][0].ToString());
                    frmPrincipal principal = new frmPrincipal(this);
                    
                    principal.Show();
                    this.Hide(); //Por el momento solamente se esconderá ésta ventana.
                }
                else
                {
                    MessageBox.Show("Contraseña incorrecta");
                    txtUsuario.Focus();
                }
            }
            else
            {
                MessageBox.Show("Usuario no existe");
                txtUsuario.Focus();
            }
        }
    }
}