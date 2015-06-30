using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System.Globalization;

namespace Boutique
{
    public partial class frmVenta : DevExpress.XtraEditors.XtraForm
    {
        DataTable dtbuscarproducto;
        private bool bEditandoCelda = false;
        public static bool ventaCancel = false;
        public static bool imprimir = false;
        double precio;
        int cantidad, numFila;

        public frmVenta()
        {
            InitializeComponent();
        }

        private static frmVenta m_FormDefInstance;
        public static frmVenta DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmVenta();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }


        public bool buscarproducto(string codigo)
        {
            dtbuscarproducto = conexion.fnEjecutarConsulta("SELECT * FROM producto Where codigo_barras='" + codigo + "'");
            if (dtbuscarproducto.Rows.Count != 0)
            {
                dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["Cod"].Value = dtbuscarproducto.Rows[0]["codigo_barras"].ToString();
                dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["Desc"].Value = dtbuscarproducto.Rows[0]["descripcion"].ToString();
                dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["Prec"].Value = dtbuscarproducto.Rows[0]["precio"].ToString();
                return true;
            }
            else
            {
                MessageBox.Show("Producto no encontrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           
        }


        int id_cliente;
        public void buscarcliente()
        {
            dtbuscarproducto = conexion.fnEjecutarConsulta("SELECT * FROM cliente Where nit='" + textEdit6.Text + "'");
            if (dtbuscarproducto.Rows.Count != 0)
            {
                id_cliente = int.Parse(dtbuscarproducto.Rows[0]["codigo_cliente"].ToString());
                textEdit7.Text = dtbuscarproducto.Rows[0]["nombres"].ToString() + " " + dtbuscarproducto.Rows[0]["apellidos"].ToString();
                textEdit9.Text = dtbuscarproducto.Rows[0]["direccion"].ToString();                
            }
            else
            {
                DialogResult result = MessageBox.Show("No encontrado, ¿Desea crear un nuevo cliente?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    frmClientesMantenimiento datos = new frmClientesMantenimiento();
                    datos.Text = "Nuevo Cliente";
                    datos.textBox1.Text = conexion.fnEjecutarEscalar("SELECT max(codigo_cliente)+1 FROM cliente").ToString();
                    datos.textBox1.Enabled = false;
                    datos.textBox2.Text = textEdit6.Text;
                    datos.textBox2.Enabled = false;
                    datos.ShowDialog();
                }
                else if (result == DialogResult.No)
                {
                    nueva_venta();
                }
            }
        }

        private void textEdit6_KeyPress(object sender, KeyPressEventArgs e)
        {
            string primera_cadena = "";
            string segunda_cadena = "";
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                primera_cadena = textEdit6.Text.Substring(0, (textEdit6.Text.Length - 1));
                segunda_cadena = textEdit6.Text.Substring(textEdit6.Text.Length - 1, 1);
                textEdit6.Text = primera_cadena + "-" + segunda_cadena;
                buscarcliente();
                SendKeys.Send("{TAB}");
            }
        }

        int usuario = 1;
        public void mensaje(int id_usuario)
        {
            usuario = id_usuario;
        }

        public void nueva_venta()
        {
            dataGridView2.Rows.Clear();            
            textEdit10.Text = "0.00";
            textEdit9.Text = "";
            textEdit7.Text = "";
            textEdit6.Text = "C/F";
            checkBox1.Checked = true;
            textEdit6.Focus();
            ventaCancel = false;
            imprimir = false;
            id_cliente = 1;
        }

        bool tipo_pago = false;
        object id_venta = -1;
        private void simpleButton1_Click_1(object sender, EventArgs e)
        {
             if (checkBox1.Checked)
            {
                tipo_pago = true;                
                frmVentaCobrar cobro = new frmVentaCobrar();
                cobro.recibirtotal(textEdit10.Text);
                cobro.recibiventa(id_venta.ToString());
                cobro.ShowDialog();

                if (!ventaCancel)
                    guardar_venta();
                if (imprimir)
                {
                  
                    Reportes.rptComprobante factura = new Reportes.rptComprobante();
                    factura.DataSource = conexion.fnEjecutarConsulta("SELECT producto_codigo, descripcion, precio_venta from "
                                         +"detalle_venta, producto where id_venta = " +id_venta+" and codigo_interno = producto_codigo");
                    factura.nombre.Text = textEdit7.Text;
                    factura.direccion.Text = textEdit9.Text;
                    factura.nit.Text = textEdit6.Text;                    
                    factura.codigo.DataBindings.Add("Text", factura.DataSource, "producto_codigo");
                    factura.descripcion.DataBindings.Add("Text", factura.DataSource, "descripcion");
                    factura.valor.DataBindings.Add("Text", factura.DataSource, "precio_venta");
                    factura.total.Text = string.Format("{0:0,0.00}", textEdit10.Text).ToString();
                    
                    factura.PrintDialog();
                }
                nueva_venta();
            }
            else
            {
                tipo_pago = false;
                frmPago pago = new frmPago();
                pago.mensaje(id_cliente, usuario, textEdit10.Text, id_venta.ToString());
                pago.ShowDialog();
            }
        }

        public void guardar_venta()
        {
            MySqlParameter[] registro = new MySqlParameter[]{
                new MySqlParameter("codigo_cliente",id_cliente.ToString()),
                new MySqlParameter("id_usuario",usuario.ToString()),
                new MySqlParameter("fecha",dateTimePicker1.Value),
                //new MySqlParameter("descuento",descuento),
                new MySqlParameter("tipo_pago",tipo_pago),
                new MySqlParameter("cliente",textEdit7.Text),
                new MySqlParameter("direccion",textEdit9.Text)
            };
            
            id_venta = conexion.fnobjEjecutarProcedimientoEscalar("encabezado_venta", registro);

            registro = new MySqlParameter[]{
                            new MySqlParameter("id_venta", conexion.fnEjecutarEscalar("select MAX(id_venta) from venta").ToString()), 
                            new MySqlParameter("no_documento","N/A"),
                            new MySqlParameter("monto",textEdit10.Text),
                            new MySqlParameter("titular","N/A"),
                            new MySqlParameter("tipo_pago","4")};

            conexion.fnobjEjecutarProcedimientoEscalar("guardar_pago", registro);



            if (int.Parse(id_venta.ToString()) != -1)
            {
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value != null)
                    {
                        string codigo = (conexion.fnEjecutarEscalar("SELECT codigo_interno FROM producto WHERE codigo_barras= " + row.Cells[0].Value.ToString()).ToString());
                        string guardar = "INSERT INTO detalle_venta(id_venta,producto_codigo,cantidad,precio_venta) " +
                        "VALUES('" + id_venta.ToString() +
                        "','" + codigo + "'," + row.Cells[1].Value.ToString() + "," + row.Cells[5].Value.ToString() + ")";
                        conexion.fnEjecutarComando(guardar);

                        int disponible = int.Parse(conexion.fnEjecutarEscalar("SELECT cantidad FROM producto WHERE codigo_barras= " + row.Cells[0].Value.ToString()).ToString()) - int.Parse(row.Cells[1].Value.ToString());

                        string descargadeinventario = "UPDATE producto SET cantidad= " +
                               disponible + " WHERE codigo_barras= '" + row.Cells[0].Value.ToString() +"'";

                        conexion.fnEjecutarComando(descargadeinventario);
                    }
                }                
            }
        }
    
        public void total()
        {
            float total = 0;
            foreach (DataGridViewRow row in dataGridView2.Rows)
            {
                if (row.Cells[0].Value != null)
                {
                    total+=float.Parse(row.Cells[5].Value.ToString());
                }
            }
            textEdit10.Text = string.Format("{0:f}", total).ToString();
        }
               
        public void mensaje(string valor)
        {
            SendKeys.Send("{tab}");
            SendKeys.Send("{enter}");
        }

        private void pictureEdit1_MouseClick(object sender, MouseEventArgs e)
        {
            frmIngresoBusqueda busqueda = new frmIngresoBusqueda();
            busqueda.identificar("venta");
            busqueda.ShowDialog();
        }

        
        private void dataGridView2_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "Cod" || this.dataGridView2.Columns[e.ColumnIndex].Name == "Cant"
                || this.dataGridView2.Columns[e.ColumnIndex].Name == "aplica_descuento" )
            {
                bEditandoCelda = true;
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            numFila = dataGridView2.CurrentCell.RowIndex;
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "Cod")
            {
                bEditandoCelda = false;
                if (dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["Cod"].Value != null)
                {
                    if (buscarproducto(dataGridView2.Rows[numFila].Cells["Cod"].Value.ToString()))
                    {
                        
                        SendKeys.Send("{UP}");
                        dataGridView2.CurrentCell = dataGridView2.Rows[numFila].Cells["Cant"];
                    }
                    else
                    {
                        dataGridView2.Rows.Remove(dataGridView2.Rows[numFila]);
                        SendKeys.Send("{DOWN}");
                    }
                }
                
            }
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "Cant")
            {
                bEditandoCelda = false;
                if (dataGridView2.Rows[numFila].Cells["Cant"].Value == null)
                    MessageBox.Show("Debe ingresar una cantidad correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                else
                {
                    dataGridView2.Rows[numFila].Cells["aplica_descuento"].Value = 0;
                    precio = double.Parse(dataGridView2.Rows[numFila].Cells["Prec"].Value.ToString());
                    cantidad = int.Parse(dataGridView2.Rows[numFila].Cells["Cant"].Value.ToString());
                    dataGridView2.Rows[numFila].Cells[5].Value = string.Format("{0:f}", (cantidad * precio)).ToString();
                    total();
                    SendKeys.Send("{UP}");
                    dataGridView2.CurrentCell = dataGridView2.Rows[numFila].Cells["aplica_descuento"];
                }
            }
            if (this.dataGridView2.Columns[e.ColumnIndex].Name == "aplica_descuento")
            {
                bEditandoCelda = false;
                if (dataGridView2.Rows[numFila].Cells["Prec"].Value != null)
                {
                    double descuento = double.Parse(dataGridView2.Rows[numFila].Cells["aplica_descuento"].Value.ToString());
                    if (descuento >= 0)
                    {
                        double precio = double.Parse(conexion.fnEjecutarEscalar("SELECT precio FROM producto WHERE codigo_barras= " + dataGridView2.Rows[numFila].Cells["Cod"].Value.ToString()).ToString());
                        precio = precio * ((100 - descuento) / 100);
                        dataGridView2.Rows[numFila].Cells[5].Value = string.Format("{0:f}", (cantidad * precio)).ToString();
                        SendKeys.Send("{LEFT}");
                        SendKeys.Send("{LEFT}");
                        SendKeys.Send("{LEFT}");
                        SendKeys.Send("{LEFT}");
                        //dataGridView2.CurrentCell = dataGridView2.Rows[numFila].Cells["Cod"];
                    }
                    total();
                    
                }
                
                //dataGridView2.CurrentCell = dataGridView2.Rows[numFila].Cells["Cod"];
            }
        }

        private void frmVenta_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void frmVenta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (bEditandoCelda)
            {
                if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsControl(e.KeyChar))
                {
                    return;
                }
                e.KeyChar=' ';
                e.Handled=true;
            }
            
        }
        
        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if ((dataGridView2.Rows.Count > 1) && (dataGridView2.CurrentCell.ColumnIndex == 0))
            {
                dataGridView2.Rows.Remove(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex]);
                total();
            }
        }

        private void dataGridView2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled=true;
                SendKeys.Send("{TAB}");
            }
            if ((e.KeyCode == Keys.Enter) && (dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex].Cells["Cant"].Value == null))
            {
                MessageBox.Show("Debe ingresar una cantidad correcta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if ((e.KeyCode == Keys.Delete) )
            {
                if ((dataGridView2.Rows.Count > 1) )
                {
                    dataGridView2.Rows.Remove(dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex]);
                }
                total();
                
            }
        }

        private void EnviarTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        }

        
    }
}