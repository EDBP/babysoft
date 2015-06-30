using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Boutique.Reportes
{
    public partial class rptVentasDia : DevExpress.XtraReports.UI.XtraReport
    {
        public rptVentasDia()
        {
            InitializeComponent();
        }
        
        public void llenarreporte(string fecha1, string fecha2)
        {
            DataSource = conexion.fnEjecutarConsulta("SELECT dv.producto_codigo, dv.cantidad, prod.descripcion, prod.marca, dv.precio_venta, " +
"case p.tipo_pago WHEN 0 THEN 'Tarjeta de Crédito' WHEN 1 THEN 'Tarjeta de Débito' WHEN 2 THEN 'Cheque' WHEN 3 THEN 'Crédito' WHEN 4 THEN 'Efectivo' end as tipo_pago " +
"FROM boutique.venta v, boutique.detalle_venta dv, boutique.pago p, boutique.producto prod " +
"where v.id_venta=dv.id_venta and v.id_venta=p.id_venta and prod.codigo_interno=dv.producto_codigo and v.fecha between '" + fecha1 + "' and '" + fecha2 + "' order by p.tipo_pago");
                        
            GroupHeaderBand agrupamiento = new GroupHeaderBand();
            Bands.Add(agrupamiento);
            GroupField columna = new GroupField("tipo_pago");
            agrupamiento.GroupFields.Add(columna);
            labelGroup.DataBindings.Add("Text", DataSource, "tipo_pago");


            DevExpress.XtraReports.UI.XRSummary sub_totales = new DevExpress.XtraReports.UI.XRSummary();
            DevExpress.XtraReports.UI.XRSummary total = new DevExpress.XtraReports.UI.XRSummary();

            XrLabel77.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "precio_venta") });
            xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] { new DevExpress.XtraReports.UI.XRBinding("Text", DataSource, "precio_venta") });
            XrLabel77.Name = "XrLabel77";
            sub_totales.FormatString = "Sub-total: Q {0:0,0.00}";
            sub_totales.Func = DevExpress.XtraReports.UI.SummaryFunc.Sum;
            sub_totales.Running = DevExpress.XtraReports.UI.SummaryRunning.Group;
            total.FormatString = "{0:0,0.00}";
            total.Running = DevExpress.XtraReports.UI.SummaryRunning.Report;
            XrLabel77.Summary = sub_totales;
            xrLabel3.Summary = total;
            
            labelCodigo.DataBindings.Add("Text", DataSource, "producto_codigo");
            labelCantidad.DataBindings.Add("Text", DataSource, "cantidad");
            labelDescripcion.DataBindings.Add("Text", DataSource, "descripcion");
            labelMarca.DataBindings.Add("Text", DataSource, "producto_codigo");
            labelTotal.DataBindings.Add("Text", DataSource, "precio_venta");

            
        }
    }
}
