using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using System.Windows.Forms;
using System.Data;

namespace Boutique.Reportes
{
    public partial class rptInventario : DevExpress.XtraReports.UI.XtraReport
    {
        public rptInventario()
        {
            InitializeComponent();
        }

        public void llenarreporte()
        {
            //DataSource = conexion.fnEjecutarConsulta("SELECT codigo_interno, codigo_barras, descripcion, precio, marca, cantidad, ruta_imagen FROM boutique.producto ORDER BY codigo_interno ASC");

            //cbarras.DataBindings.Add("Text", DataSource, "codigo_barras");
            //codigo_interno.DataBindings.Add("Text", DataSource, "codigo_interno");
            //descripcion.DataBindings.Add("Text", DataSource, "descripcion");
            //precio.DataBindings.Add("Text", DataSource, "precio");
            //marca.DataBindings.Add("Text", DataSource, "marca");
            //cantidad.DataBindings.Add("Text", DataSource, "cantidad");
            //imagen.DataBindings.Add("ImageUrl", DataSource, "ruta_imagen");
        }

        private void rptInventario_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            DataTable datos = conexion.fnEjecutarConsulta("SELECT codigo_interno, codigo_barras, descripcion, precio, marca, cantidad, ruta_imagen FROM boutique.producto ORDER BY codigo_interno ASC");
            
            DataSource = conexion.fnEjecutarConsulta("SELECT codigo_interno, codigo_barras, descripcion, precio, marca, cantidad, ruta_imagen FROM boutique.producto ORDER BY codigo_interno ASC");            
            cbarras.DataBindings.Add("Text", DataSource, "codigo_barras");
            codigo_interno.DataBindings.Add("Text", DataSource, "codigo_interno");
            descripcion.DataBindings.Add("Text", DataSource, "descripcion");
            precio.DataBindings.Add("Text", DataSource, "precio");
            marca.DataBindings.Add("Text", DataSource, "marca");
            cantidad.DataBindings.Add("Text", DataSource, "cantidad");            
            imagen.DataBindings.Add("ImageUrl", DataSource, "ruta_imagen");
        }
    }
}
