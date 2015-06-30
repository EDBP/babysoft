using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Boutique
{
    public partial class frmClientesMantenimiento : Form
    {
      
        public frmClientesMantenimiento()
        {
            InitializeComponent();
            cargarCodigo();
        }

        private void cargarCodigo()
        {
            int disponible = int.Parse(conexion.fnEjecutarEscalar("SELECT max(codigo_cliente) FROM cliente").ToString()) + 1;
            textBox1.Text = disponible.ToString();
        }

        public frmClientesMantenimiento(DataRow datos_cliente)
        {
            InitializeComponent();
            textBox1.Text = datos_cliente.ItemArray[0].ToString();
            textBox2.Text = datos_cliente.ItemArray[1].ToString();
            textBox3.Text = datos_cliente.ItemArray[2].ToString();
            textBox4.Text = datos_cliente.ItemArray[3].ToString();
            textBox5.Text = datos_cliente.ItemArray[4].ToString();
            textBox6.Text = datos_cliente.ItemArray[5].ToString();    
        }

        private void guardarcambios()
        {
            try
            {
                string telefono = textBox6.Text;
                if (telefono == "")
                    telefono = "0";
                string guardar = "UPDATE cliente SET codigo_cliente='" +
                    textBox1.Text + "',nit='" +
                    textBox2.Text + "',nombres='" +
                    textBox3.Text + "',apellidos='" +
                    textBox4.Text + "',direccion='" +
                    textBox5.Text + "',telefono='" +
                    telefono + "' WHERE codigo_cliente= " + int.Parse(textBox1.Text);
                
                conexion.fnEjecutarComando(guardar);
                MessageBox.Show("Cliente modificado exitosamente!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }
            frmClientes.DefInstance.actualizar();
            Close();
        }
        private void guardarNuevo()
        {
            string telefono = textBox6.Text;
            if (telefono == "")
                telefono = "0";
            string guardar = "INSERT INTO cliente(codigo_cliente,nit,nombres,apellidos,direccion,telefono) " +
                "VALUES(" + textBox1.Text +
                ",'" + textBox2.Text +
                "','" + textBox3.Text +
                "','" + textBox4.Text +
                "','" + textBox5.Text +
                "','" + telefono + "')";
            conexion.fnEjecutarComando(guardar);
            frmClientes.DefInstance.actualizar();
            Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void frmClientesMantenimiento_Activated(object sender, EventArgs e)
        {
            if (this.Text == "Editar Cliente")
            {
                button1.Text = "Guardar Cambios";
            }
            else
            {
                button1.Text = "Guardar Nuevo";
            }
        }
        private void EnviarTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            string primera_cadena = "";
            string segunda_cadena = "";
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                primera_cadena = textBox2.Text.Substring(0, (textBox2.Text.Length-1));
                segunda_cadena = textBox2.Text.Substring(textBox2.Text.Length-1, 1);
                textBox2.Text=primera_cadena + "-" + segunda_cadena;
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "Guardar Cambios")
            {
                guardarcambios();
            }
            else
            {
                guardarNuevo();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       
        
    }
}
