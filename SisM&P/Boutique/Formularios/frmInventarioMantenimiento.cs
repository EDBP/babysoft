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
    public partial class frmInventarioMantenimiento : DevExpress.XtraEditors.XtraForm
    {
        int idproducto;
        public int idusuario;
        public frmInventarioMantenimiento()
        {
            InitializeComponent();
            
        }
        public frmInventarioMantenimiento(DataRow datos_inventario)
        {
            InitializeComponent();
            textEdit1.Text = datos_inventario.ItemArray[0].ToString();
            textEdit2.Text = datos_inventario.ItemArray[1].ToString();
            textEdit3.Text = datos_inventario.ItemArray[2].ToString();
            textEdit4.Text = datos_inventario.ItemArray[3].ToString();            
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (simpleButton1.Text == "Guardar Cambios")
                guardarcambios();
            else
                guardarNuevo();
        }

        private void guardarcambios()
        {
            try
            {
                string guardar = "UPDATE producto SET codigo_interno= '" +textEdit1.Text + "',descripcion='" +textEdit2.Text + "',cantidad='" +textEdit3.Text + "',precio= '"+textEdit4.Text + "' WHERE codigo_interno= "+idproducto;
                conexion.fnEjecutarComando(guardar);
                MessageBox.Show("Producto Modificado Exitosamente!","Modificación",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }            
            Close();
        }

        private void guardarNuevo()
        {   
            string guardar = "INSERT INTO producto(codigo_interno,descripcion,cantidad,precio) " +
                "VALUES(" + textEdit1.Text +
                ",'" + textEdit2.Text +
                "','" + textEdit3.Text +
                "','" + textEdit4.Text  + "')";
            conexion.fnEjecutarComando(guardar);
            MessageBox.Show("Nuevo Producto Agregado", "-Agregar-", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            //frmInventario.DefInstance.actualizar();
            Close();
        }

        private void frmInventarioMantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
        }

        private void frmInventarioMantenimiento_Load(object sender, EventArgs e)
        {
            if (this.Text == "-'- Editar Producto -'-")
            {
                simpleButton1.Text = "Guardar Cambios";
                textEdit3.Enabled = true;
                idproducto = int.Parse(textEdit1.Text);
            }
            else
            {
                simpleButton1.Text = "Guardar Nuevo";
            }
        }
    }

}