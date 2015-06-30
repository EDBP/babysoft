using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace Boutique
{
    public partial class frmPrincipal : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        Form padre;
        String tipo = "";
        public frmPrincipal(Form Padre)
        {
            this.padre = Padre;
            InitializeComponent();           
        }
        int usuario;
        public void mensaje (int id_usuario)
        {
            usuario = id_usuario;
        }

        private void barBotonClientes_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmClientes.DefInstance.MdiParent = this;
            frmClientes.DefInstance.Show();
            frmClientes.DefInstance.Activate();
            frmClientes.DefInstance.BringToFront();
        }

        private void barBotonInventario_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmInventario.DefInstance.MdiParent = this;
            frmInventario.DefInstance.Show();
            frmInventario.DefInstance.Activate();
            frmInventario.DefInstance.BringToFront();
        }

        private void barBotonVenta_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmVenta.DefInstance.MdiParent = this;
            frmVenta.DefInstance.Show();
            frmVenta.DefInstance.Activate();
            frmVenta.DefInstance.BringToFront();
        }

        private void barBotonIngreso_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmProducto.DefInstance.MdiParent = this;
            frmProducto.DefInstance.Show();
            frmProducto.DefInstance.Activate();
            frmProducto.DefInstance.BringToFront();
        }

        private void barBotonMerma_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmDescargaLibre.DefInstance.MdiParent = this;
            frmDescargaLibre.DefInstance.Show();
            frmDescargaLibre.DefInstance.Activate();
            frmDescargaLibre.DefInstance.BringToFront();
        }

        private void barButtonUsuarios_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmUsuarios.DefInstance.MdiParent = this;
            frmUsuarios.DefInstance.Show();
            frmUsuarios.DefInstance.Activate();
            frmUsuarios.DefInstance.BringToFront();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Dispose();
        }
        
        private void barBotonVerInventario_ItemClick(object sender, ItemClickEventArgs e)
        {
            Reportes.rptInventario report = new Reportes.rptInventario();
            report.llenarreporte();
            report.ShowPreview();
        }

        private void barBotonIngresos_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRptFecha fecha = new frmRptFecha();
            fecha.mensaje(2);
            fecha.ShowDialog();
        }
        
        private void btnBuscarRpt_Click(object sender, EventArgs e)
        {
            //if (tipo.Equals("ingresos"))
            //{
            //    Reportes.rptIngresos report = new Reportes.rptIngresos();
            //    report.dtAdapterIngreso.getIngresos(dateEdit1.DateTime.Date);
            //    report.lblFecha.Text = dateEdit1.DateTime.Date.ToShortDateString();
            //    report.ShowPreview();
            //}
            //if (tipo.Equals("merma"))
            //{
            //    Reportes.rptMermas report = new Reportes.rptMermas();
            //    report.dtAdapterMerma.getMermas(dateEdit1.DateTime.Date);
            //    report.lblFecha.Text = dateEdit1.DateTime.Date.ToShortDateString();
            //    report.ShowPreview();
            //}
            //if (tipo.Equals("ventas"))
            //{
            //    Reportes.rptVentas report = new Reportes.rptVentas();
            //    report.dtAdapterVenta.getVentas(dateEdit1.DateTime.Date);
            //    report.lblFecha.Text = dateEdit1.DateTime.Date.ToShortDateString();
            //    String fecha = dateEdit1.DateTime.Date.Year+"-"+dateEdit1.DateTime.Date.Month+"-"+
            //                    dateEdit1.DateTime.Date.Day;
            //    report.lblTotal.Text = conexion.fnEjecutarEscalar("select sum(dv.cantidad*dv.precio_venta) "
            //                           + "from detalle_venta dv, venta v "
            //                           + "where dv.id_venta = v.id_venta "
            //                           + "and v.fecha = '"+fecha+"'").ToString();
            //    report.ShowPreview();
            //}
            //panel1.Visible = false;
        }

        private void barBtnMerma_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRptFecha fecha = new frmRptFecha();
            fecha.mensaje(4);
            fecha.ShowDialog();
        }

        private void barBtnVentas_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRptFecha buscar = new frmRptFecha();
            buscar.mensaje(3);
            buscar.ShowDialog();
        }

        private void barBtnCreditos_ItemClick(object sender, ItemClickEventArgs e)
        {
            Reportes.rptCreditos report = new Reportes.rptCreditos();
            report.llenarreporte();
            report.ShowPreview();
        }

        private void barBtnPagoCreditos_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAbonoCredito abono = new frmAbonoCredito();
            abono.ShowDialog();
        }

        private void barBtnRanking_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmRptFecha fecha = new frmRptFecha();
            fecha.mensaje(1);
            fecha.ShowDialog();
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmConsultaComprobante.DefInstance.MdiParent = this;
            frmConsultaComprobante.DefInstance.Show();
            frmConsultaComprobante.DefInstance.Activate();
            frmConsultaComprobante.DefInstance.BringToFront();
        }

    }
}