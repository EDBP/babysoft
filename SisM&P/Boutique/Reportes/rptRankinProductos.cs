using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Boutique.Reportes
{
    public partial class rptRankinProductos : DevExpress.XtraReports.UI.XtraReport
    {
        public rptRankinProductos()
        {
            InitializeComponent();
        }
        public void llenarreporte(string f_inicio, string f_fin)
        {
            DataSource = conexion.fnEjecutarConsulta(" " +
                                                     " SELECT sum(dv.cantidad) as cant, p.descripcion, p.marca" +
                                                     " FROM venta v, detalle_venta dv, producto p " +
                                                     " WHERE v.id_venta=dv.id_venta and dv.producto_codigo=p.codigo_interno and v.fecha BETWEEN '" + f_inicio + "' AND '" + f_fin + "'" +
                                                     " group by p.descripcion " +
                                                     " order by cant desc ");

            cant.DataBindings.Add("Text", DataSource, "cant");
            descripcion.DataBindings.Add("Text", DataSource, "descripcion");
            marca.DataBindings.Add("Text", DataSource, "marca");

        }
    }
}
