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
    public partial class frmRptFecha : DevExpress.XtraEditors.XtraForm
    {
        public frmRptFecha()
        {
            InitializeComponent();
        }
        int tipo_reporte = 1;
        public void mensaje(int tipo)
        {
            tipo_reporte = tipo;
        }

        
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string fecha0 = dateTimePicker1.Value.ToShortDateString();
            string fecha1 = fecha0.Substring(6, 4) + "/" + fecha0.Substring(3, 2) + "/" + fecha0.Substring(0, 2);
            string fecha2 = dateTimePicker2.Value.ToShortDateString();
            string fecha3 = fecha2.Substring(6, 4) + "/" + fecha2.Substring(3, 2) + "/" + fecha2.Substring(0, 2);

            switch (tipo_reporte)
            {
                case 1:
                    Reportes.rptRankinProductos report = new Reportes.rptRankinProductos();
                    report.llenarreporte(fecha1, fecha3);
                    report.f_inicio.Text = fecha0;
                    report.f_fin.Text = fecha2;

                    report.ShowPreview();
                    break;
                case 2:
                    Reportes.rptIngresos reportIng = new Reportes.rptIngresos();
                    reportIng.llenarreporte(fecha1, fecha3);
                    reportIng.ShowPreview();
                    break;
                case 3:
                    Reportes.rptVentasDia ventas = new Reportes.rptVentasDia();
                    ventas.llenarreporte(fecha1, fecha3);
                    ventas.ShowPreview();
                    this.Dispose();
                    break;
                default:
                    Reportes.rptDescargas reportDesc = new Reportes.rptDescargas();
                    reportDesc.llenarreporte(fecha1, fecha3);
                    reportDesc.ShowPreview();
                    break;
            }
        }
    }
}