using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Boutique.Reportes
{
    public partial class rptDescargas : DevExpress.XtraReports.UI.XtraReport
    {
        public rptDescargas()
        {
            InitializeComponent();
        }

            

        public void llenarreporte(string f_inicio, string f_fin)
        {
            DataSource = conexion.fnEjecutarConsulta("SELECT DATE_FORMAT(dl.fecha,'%d- %b- %Y') as fecha,dl.cantidad, p.descripcion, dl.motivo, u.usuario FROM descargalibre dl, usuario u, producto p where dl.id_usuario=u.id_usuario and dl.producto_codigo=p.codigo_interno and dl.fecha BETWEEN '" + f_inicio + "' AND '" + f_fin + "'");

            fecha.DataBindings.Add("Text", DataSource, "fecha");
            cantidad.DataBindings.Add("Text", DataSource, "cantidad");
            descripcion.DataBindings.Add("Text", DataSource, "descripcion");
            motivo.DataBindings.Add("Text",DataSource,"motivo");
            usuario.DataBindings.Add("Text", DataSource, "usuario");
        }

    }
}
