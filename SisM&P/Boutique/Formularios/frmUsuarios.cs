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
    public partial class frmUsuarios : DevExpress.XtraEditors.XtraForm
    {
        private DataTable dtUsuarios;
        private string usuario, nombre, contrasena;
        private int id = 1;
        private static frmUsuarios m_FormDefInstance;

        public frmUsuarios()
        {
            InitializeComponent();
            cargarUsuarios();
        }

        public static frmUsuarios DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmUsuarios();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
              
        private void cargarUsuarios()
        {
            dtUsuarios = conexion.fnEjecutarConsulta("SELECT * FROM usuario WHERE id_usuario = " + id);
            llenarPermisos();

            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;
            btnAtras.Enabled = true;
            btnSiguiente.Enabled = true;
            txtRepContraseña.Enabled = false;
            lblRepetirCont.Enabled = false;
        }

        private void llenarPermisos()
        {
            txtUsuario.Text = dtUsuarios.Rows[0][1].ToString();
            txtNombre.Text = dtUsuarios.Rows[0][2].ToString();
            txtContraseña.Text = dtUsuarios.Rows[0][3].ToString();

            if (int.Parse(dtUsuarios.Rows[0][4].ToString()) == 1)
                chkReportes.Checked = true;
            else
                chkReportes.Checked = false;

            txtUsuario.Enabled = false;
            txtNombre.Enabled = false;
            txtContraseña.Enabled = false;
            chkReportes.Enabled = false;
            chkInventario.Enabled = false;
            chkBusqueda.Enabled = false;
            chkMerma.Enabled = false;
            chkUsuarios.Enabled = false;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtNombre.Text = "";
            txtContraseña.Text = "";
            chkReportes.Checked = false;
            chkInventario.Checked = false;
            chkBusqueda.Checked = true;
            chkMerma.Checked = false;
            chkUsuarios.Checked = false;

            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAtras.Enabled = false;
            btnSiguiente.Enabled = false;

            txtUsuario.Enabled = true;
            txtNombre.Enabled = true;
            txtContraseña.Enabled = true;
            txtRepContraseña.Enabled = true;
            lblRepetirCont.Enabled = true;
            chkReportes.Enabled = true;
            chkInventario.Enabled = true;
            chkBusqueda.Enabled = true;
            chkMerma.Enabled = true;
            chkUsuarios.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
            btnAtras.Enabled = false;
            btnSiguiente.Enabled = false;

            txtUsuario.Enabled = true;
            txtNombre.Enabled = true;
            txtContraseña.Enabled = true;
            txtRepContraseña.Enabled = true;
            lblRepetirCont.Enabled = true;
            chkReportes.Enabled = true;
            chkInventario.Enabled = true;
            chkBusqueda.Enabled = true;
            chkMerma.Enabled = true;
            chkUsuarios.Enabled = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            nombre = txtNombre.Text;
            contrasena = txtContraseña.Text;
            if (!usuario.Equals("") && !nombre.Equals("") && !contrasena.Equals(""))
            {
                if (contrasena.Equals(txtRepContraseña.Text))
                {
                    if (btnModificar.Enabled == false)
                    {
                        conexion.fnEjecutarComando("INSERT INTO usuario(usuario, nombre_completo, password, acceso_reportes, acceso_ingreso_inv,"
                                    + " acceso_consulta_inv, acceso_merma, acceso_usuarios) "
                                    + "VALUES('" + usuario + "','" + nombre + "','" + contrasena + "'," + convertir(chkReportes.Checked) + ","
                                    + convertir(chkInventario.Checked) + "," + convertir(chkBusqueda.Checked) + "," + convertir(chkMerma.Checked) + "," + convertir(chkUsuarios.Checked) + ")");
                    }
                    else
                    {
                        conexion.fnEjecutarComando("UPDATE usuario SET usuario='" + usuario + "', nombre_completo='" + nombre + "',"
                            + " password='" + contrasena + "', acceso_reportes=" + convertir(chkReportes.Checked) + ", acceso_ingreso_inv="
                            + convertir(chkInventario.Checked) + ", acceso_consulta_inv=" + convertir(chkBusqueda.Checked) + ", acceso_merma="
                            + convertir(chkMerma.Checked) + ", acceso_usuarios=" + convertir(chkUsuarios.Checked) + " WHERE id_usuario =" + id);
                    }
                    id = 1;
                    cargarUsuarios();
                }
                else
                    MessageBox.Show("Las contraseñas no coinciden, favor de verificar");
            }
            else
            {
                MessageBox.Show("Debe llenar todos los campos");
                btnNuevo.Enabled = false;
                btnAtras.Enabled = false;
                btnSiguiente.Enabled = false;
                btnModificar.Enabled = false;
                btnCancelar.Enabled = true;
            }
        }

        private int convertir(bool dato)
        {
            if (dato)
                return 1;
            else
                return 0;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            id--;
            if (id >= 1)
            {
                dtUsuarios = conexion.fnEjecutarConsulta("SELECT * FROM usuario WHERE id_usuario = " + id);
                llenarPermisos();
            }
            else
                id++;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            id++;
            dtUsuarios = conexion.fnEjecutarConsulta("SELECT * FROM usuario WHERE id_usuario = " + id);
            if (dtUsuarios.Rows.Count > 0)
                llenarPermisos();
            else
                id--;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargarUsuarios();
        }
    }
}