using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Boutique.Reportes
{
    public partial class rptIngresos : DevExpress.XtraReports.UI.XtraReport
    {
        public rptIngresos()
        {
            InitializeComponent();
        }
        public void llenarreporte(string f_inicio, string f_fin)
        {
            DataSource = conexion.fnEjecutarConsulta("SELECT DATE_FORMAT(i.fecha,'%d- %b- %Y') as fecha,di.cantidad, p.descripcion, u.usuario FROM ingreso i, detalle_ingreso di, usuario u, producto p where i.id_ingreso=di.id_ingreso and i.id_usuario=u.id_usuario and di.producto_codigo=p.codigo_interno and i.fecha BETWEEN '" + f_inicio + "' AND '" + f_fin + "'");

            fecha.DataBindings.Add("Text", DataSource, "fecha");
            cantidad.DataBindings.Add("Text", DataSource, "cantidad");
            descripcion.DataBindings.Add("Text", DataSource, "descripcion");
            usuario.DataBindings.Add("Text", DataSource, "usuario");
            
        }
    }
}
