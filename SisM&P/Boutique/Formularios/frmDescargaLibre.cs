using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;

namespace Boutique
{
    public partial class frmDescargaLibre : DevExpress.XtraEditors.XtraForm
    {
        int idUsuario;
        //El ID del usuario debe venir desde la pantalla de LOGIN!
        
        private static frmDescargaLibre m_FormDefInstance;
        public static frmDescargaLibre DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmDescargaLibre();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        public frmDescargaLibre()
        {
            InitializeComponent();
            this.idUsuario = frmLogin.idUsuario;
        }

        private void btnNuevaDescarga_Click(object sender, EventArgs e)
        {
            dtDescargas.Rows.Clear();
            dtDescargas.Enabled = true;  
        }

        public static void agregarReg(string codigo)
        {
            DataTable tInventario = conexion.fnEjecutarConsulta("SELECT descripcion, "
                        + "cantidad FROM producto where codigo_interno = '" + codigo+"'");
            dtDescargas.Rows.Add(codigo, tInventario.DefaultView[0].Row[0],
                        tInventario.DefaultView[0].Row[1], 0, "");
        }

        private void dtDescargas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                frmIngresoBusqueda busqueda = new frmIngresoBusqueda(2);
                busqueda.ShowDialog();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int cantTotal = 0;
            string fecha = DateTime.Now.Date.ToShortDateString();
            string fecha2 = fecha.Substring(6, 4) + "/" + fecha.Substring(3, 2) + "/" + fecha.Substring(0, 2);
            try
            {
                for (int i = 0; i < dtDescargas.Rows.Count; i++)
                {
                    cantTotal = int.Parse(dtDescargas.Rows[i].Cells[2].Value.ToString())
                                - int.Parse(dtDescargas.Rows[i].Cells[3].Value.ToString());
                    conexion.fnEjecutarComando("INSERT INTO descargalibre (producto_codigo, id_usuario, cantidad, fecha, motivo) "
                    + "VALUES ('" + dtDescargas.Rows[i].Cells[0].Value + "'," + idUsuario + "," + dtDescargas.Rows[i].Cells[3].Value
                    + ",'" + fecha2 + "','" + dtDescargas.Rows[i].Cells[4].Value + "')");
                    conexion.fnEjecutarComando("UPDATE producto SET cantidad = " + cantTotal
                        + " WHERE codigo_interno = '" + dtDescargas.Rows[i].Cells[0].Value + "'");
                }
            }
            catch (Exception ex)
            {   //MessageBox.Show("Error al modificar los productos " + ex.Message);  
            }
            MessageBox.Show("Se ha(n) descargado correctamente el(los) producto(s)");
            dtDescargas.Enabled = false;
        }

    }
}