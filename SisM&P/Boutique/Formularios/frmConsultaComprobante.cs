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
    public partial class frmConsultaComprobante : DevExpress.XtraEditors.XtraForm
    {
        public frmConsultaComprobante()
        {
            InitializeComponent();
        }

        private static frmConsultaComprobante m_FormDefInstance;
        public static frmConsultaComprobante DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmConsultaComprobante();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }

        private void dateEdit1_DateTimeChanged(object sender, EventArgs e)
        {

            String fecha = dateEdit1.DateTime.Date.Year + "-" + dateEdit1.DateTime.Date.Month + "-" +
                                dateEdit1.DateTime.Date.Day;
            DataTable dtFacturas = new DataTable();
            dtFacturas = conexion.fnEjecutarConsulta("SELECT id_venta as Venta, cliente as Cliente, direccion as Direccion " +
                                                      "FROM boutique.venta " +
                                                      "Where fecha = '" + fecha + "'");
            dataGridView1.DataSource = dtFacturas;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            mostrarRecibo(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
        }


        public void mostrarRecibo(string id_venta)
        {
            DialogResult result = MessageBox.Show("Imprimir Comprobante?", "-AVISO-", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (result == DialogResult.Yes)
            {
                Reportes.rptComprobante factura = new Reportes.rptComprobante();
                factura.DataSource = conexion.fnEjecutarConsulta("SELECT v.fecha, v.cliente as nombres, v.direccion,c.nit ,p.codigo_interno, p.descripcion, dv.precio_venta " +
                                                                 "From boutique.detalle_venta dv, boutique.venta v, boutique.producto p,  boutique.cliente c " +
                                                                 "Where dv.id_venta=v.id_venta and dv.producto_codigo=p.codigo_interno and c.codigo_cliente=v.codigo_cliente and v.id_venta= '" + id_venta + "'");

                factura.xrPageInfo1.DataBindings.Add("Text", factura.DataSource, "fecha");
                factura.nombre.DataBindings.Add("Text", factura.DataSource, "nombres");
                factura.direccion.DataBindings.Add("Text", factura.DataSource, "direccion");
                factura.nit.DataBindings.Add("Text", factura.DataSource, "nit");

                factura.codigo.DataBindings.Add("Text", factura.DataSource, "codigo_interno");
                factura.descripcion.DataBindings.Add("Text", factura.DataSource, "descripcion");
                factura.valor.DataBindings.Add("Text", factura.DataSource, "precio_venta");

                float total_venta = float.Parse(conexion.fnEjecutarEscalar("SELECT sum(dv.precio_venta)as total_v FROM detalle_venta dv, venta v where dv.id_venta=v.id_venta and v.id_venta= " + id_venta).ToString());

                factura.total.Text = string.Format("{0:0,0.00}", total_venta).ToString();
                
                factura.ShowPreview();
            }
            else
            {
                this.Close();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrarRecibo(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
        }
    }
}