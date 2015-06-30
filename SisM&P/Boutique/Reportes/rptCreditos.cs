using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace Boutique.Reportes
{
    public partial class rptCreditos : DevExpress.XtraReports.UI.XtraReport
    {
        public rptCreditos()
        {
            InitializeComponent();
        }

        public void llenarreporte()
        {
            DataSource = conexion.fnEjecutarConsulta("SELECT cl.nit, CONCAT(cl.nombres, ' ', cl.apellidos)as nombre_comp, cr.saldo_pendiente, cr.saldo_limite, IF((DAYOFYEAR(cr.fecha_fin)-DAYOFYEAR(CURDATE()))<0,'Moroso',(DAYOFYEAR(cr.fecha_fin)-DAYOFYEAR(CURDATE()))) as dias_restantes_pago "+
                                                     " FROM credito cr, cliente cl "+
                                                     " WHERE cr.codigo_cliente=cl.codigo_cliente;");


            nit.DataBindings.Add("Text", DataSource, "nit");
            nombre_comp.DataBindings.Add("Text", DataSource, "nombre_comp");
            saldo_pendiente.DataBindings.Add("Text", DataSource, "saldo_pendiente");
            saldo_limite.DataBindings.Add("Text", DataSource, "saldo_limite");
            dias_restantes_pago.DataBindings.Add("Text", DataSource, "dias_restantes_pago");
            
        }

    }
}
