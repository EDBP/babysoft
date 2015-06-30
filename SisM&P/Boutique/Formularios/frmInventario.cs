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
    public partial class frmInventario : DevExpress.XtraEditors.XtraForm
    {        
        int idUsuario;
        //El ID del usuario debe venir desde la pantalla de LOGIN!
        private static frmInventario m_FormDefInstance;

        public frmInventario()
        {
            InitializeComponent();
            this.idUsuario = frmLogin.idUsuario;
        }
        
        public static frmInventario DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmInventario();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
        
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void agregarReg(string codigo)
        {
            DataTable tInventario = conexion.fnEjecutarConsulta("SELECT descripcion, "
                        + "cantidad, precio FROM producto where codigo_interno = '" + codigo +"'");
            
            
            dataGridView1.Rows.Add(codigo, tInventario.DefaultView[0].Row[0],
                        tInventario.DefaultView[0].Row[1], 0, tInventario.DefaultView[0].Row[2]);
        }
                
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 116)
            {
                frmIngresoBusqueda busqueda = new frmIngresoBusqueda(1);
                busqueda.ShowDialog();
            }            
        }

        private void btnGuardar_Click_1(object sender, EventArgs e)
        {
            int idIngreso = 0;
            int cantTotal = 0;
            string fecha = DateTime.Now.Date.ToShortDateString();
            string fecha2 = fecha.Substring(6, 4) + "/" + fecha.Substring(3, 2) + "/" + fecha.Substring(0, 2);
            try
            {
                conexion.fnEjecutarComando("INSERT INTO ingreso (fecha, id_usuario) "
                                + "VALUES ('" + fecha2 + "'," + idUsuario + ")");
                idIngreso = int.Parse(conexion.fnEjecutarEscalar("SELECT max(id_ingreso) FROM ingreso").ToString());
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    cantTotal = int.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString())
                                + int.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    conexion.fnEjecutarComando("INSERT INTO detalle_ingreso (id_ingreso, producto_codigo, cantidad) "
                    + "VALUES (" + idIngreso + ",'" + dataGridView1.Rows[i].Cells[0].Value + "',"
                    + dataGridView1.Rows[i].Cells[3].Value + ")");
                    conexion.fnEjecutarComando("UPDATE producto SET precio = " + dataGridView1.Rows[i].Cells[4].Value
                        + ", cantidad = " + cantTotal + " WHERE codigo_interno ='"
                        + dataGridView1.Rows[i].Cells[0].Value + "'");
                }
            }
            catch (Exception ex)
            {   //MessageBox.Show("Error al modificar los productos " + ex.Message);  
            }
            MessageBox.Show("Se ha(n) cargado correctamente el(los) producto(s)");
            dataGridView1.Enabled = false;
            dataGridView1.Rows.Clear();
        }

        private void btnNuevoIngreso_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            dataGridView1.Enabled = true;
        }

        private void btnNuevoProducto_Click(object sender, EventArgs e)
        {
            frmProducto datos = new frmProducto();
            //frmInventarioMantenimiento datos = new frmInventarioMantenimiento();
            datos.Text = "Nuevo Producto";
            datos.ShowDialog();
        }
        
        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentCellAddress.X == 0)
            {
                string codinterno = dataGridView1.CurrentCell.Value.ToString();
                DataTable resu =
                    conexion.fnEjecutarConsulta("SELECT * FROM producto WHERE codigo_barras = '" + codinterno +"'");
                dataGridView1.CurrentRow.Cells[0].Value = resu.Rows[0][0].ToString();
                dataGridView1.CurrentRow.Cells[1].Value = resu.Rows[0][2].ToString();
                dataGridView1.CurrentRow.Cells[2].Value = resu.Rows[0][7].ToString();
                dataGridView1.CurrentRow.Cells[3].Value = "0";
                dataGridView1.CurrentRow.Cells[4].Value = resu.Rows[0][4].ToString();
            }            
        }  
    }
}