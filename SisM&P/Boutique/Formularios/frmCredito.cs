using MySql.Data.MySqlClient;
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
    public partial class frmCredito : Form
    {
      
        public frmCredito()
        {
            InitializeComponent();
            
        }

        bool bandera = false;
        string usuario;
        public void mensaje(string id_cliente, string id_usuario, string total_venta)
        {
            textBox1.Text = id_cliente;
            usuario = id_usuario;
            textBox3.Text = "0.00";
            textBox1.Enabled = false;
            textBox3.Enabled = false;
            bandera = false;
        }

        public void extenderCredito(string id_cliente, string id_usuario, string total_venta)
        {
            DataTable creditoClietne = new DataTable();
            creditoClietne = conexion.fnEjecutarConsulta("select * from credito where codigo_cliente = "+id_cliente);

            textBox1.Text = creditoClietne.Rows[0][1].ToString();
            textBox2.Text = creditoClietne.Rows[0][2].ToString();
            textBox3.Text = creditoClietne.Rows[0][5].ToString();
            dateTimePicker1.Text = creditoClietne.Rows[0][3].ToString();
            dateTimePicker2.Text = creditoClietne.Rows[0][4].ToString();

            textBox1.Enabled = false;
            textBox3.Enabled = false;
            bandera = true;
        }





        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //busqueda listado de clientes
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (bandera == false)
            {
                guardar_credito();
            }
            else
            {
                actualizar_credito();
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox2.Text == "")
            {
                errorProvider1.SetError(textBox2, "Debe ingresar una monto aceptable");
                textBox2.Focus();
                return;
            }
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                guardar_credito();
            }
            
            if (char.IsDigit(e.KeyChar) || char.IsPunctuation(e.KeyChar) || char.IsControl(e.KeyChar))
            {
                return;
            }
            e.KeyChar = ' ';
            e.Handled = true;
        }

    private void guardar_credito()
    {
        if (float.Parse(textBox2.Text) >= float.Parse(textBox3.Text))
        {
            MySqlParameter[] registro = new MySqlParameter[]{
                    new MySqlParameter("id_usuario",usuario.ToString()),
                    new MySqlParameter("codigo_cliente",textBox1.Text),
                    new MySqlParameter("saldo_limite",textBox2.Text),
                    new MySqlParameter("fecha_inicio",dateTimePicker1.Value),
                    new MySqlParameter("fecha_fin",dateTimePicker2.Value),
                    new MySqlParameter("saldo_pendiete",textBox3.Text)};

            conexion.fnobjEjecutarProcedimientoEscalar("crear_credito", registro);
            MessageBox.Show("Credito Otorgado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        else
        {
            MessageBox.Show("No se puede otorgar un limite menor al saldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox2.Text = "";
            textBox2.Focus();
        }
    }

    private void actualizar_credito()
    {
        if (float.Parse(textBox2.Text) >= float.Parse(textBox3.Text))
        {
            String f_inicio = "'"+dateTimePicker1.Value.Year + "/" + dateTimePicker1.Value.Month + "/" + dateTimePicker1.Value.Day+"'";
            String f_fin = "'"+dateTimePicker2.Value.Year + "/" + dateTimePicker2.Value.Month + "/" + dateTimePicker2.Value.Day+"'";

            conexion.fnEjecutarEscalar("UPDATE boutique.credito SET saldo_limite= " + textBox2.Text +
                                                                  ", fecha_inicio= " + f_inicio+
                                                                  ", fecha_fin= "+f_fin+" where codigo_cliente= " + textBox1.Text);
            
            MessageBox.Show("Credito Extendido", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
        else
        {
            MessageBox.Show("No se puede otorgar un limite menor al saldo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            textBox2.Text = "";
            textBox2.Focus();
        }
    }  
        
    }
}
