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
    public partial class frmAbonoCredito : DevExpress.XtraEditors.XtraForm
    {
        public frmAbonoCredito()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "") && (textBox2.Text == ""))
            {
                MessageBox.Show("Llene alguno de los campos de búsqueda");
            }
            if ((textBox1.Text != "") && (textBox2.Text == ""))
            {
                buscarcliente1(textBox1.Text);
            }
            if ((textBox1.Text == "") && (textBox2.Text != ""))
            {
                buscarcliente2(textBox2.Text);
            }
            if ((textBox1.Text != "") && (textBox2.Text != ""))
            {
                buscarcliente1(textBox1.Text);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox3.Text != "")
            {

                float nuevoSaldo;
                nuevoSaldo = float.Parse(textBox3.Text) - float.Parse(textBox4.Text);
                conexion.fnEjecutarConsulta("UPDATE boutique.credito SET saldo_pendiente= " + nuevoSaldo + " WHERE codigo_cliente = " + int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[3].Value.ToString()));                
                MessageBox.Show("Abono a credito realizado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Ningun cliente seleccionado para operación", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        DataTable dtBuscarCredito;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString() + " " + dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            dtBuscarCredito = conexion.fnEjecutarConsulta("SELECT saldo_pendiente FROM boutique.credito where codigo_cliente= '" + dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString() + "'");
            textBox3.Text = dtBuscarCredito.Rows[0][0].ToString();
        }

        DataTable dtBusquedaCliente;
        public void buscarcliente1(string parametro)
        {
            dtBusquedaCliente = conexion.fnEjecutarConsulta("SELECT c.nit, c.nombres, c.apellidos, c.codigo_cliente FROM cliente c, credito cr WHERE nombres like '%" + parametro + "%' and c.codigo_cliente=cr.codigo_cliente");
            if (dtBusquedaCliente.Rows.Count > 0)
            {
                dataGridView1.DataSource = dtBusquedaCliente;
                dataGridView1.Columns[0].HeaderText = "Nit";
                dataGridView1.Columns[1].HeaderText = "Nombres";
                dataGridView1.Columns[2].HeaderText = "Apellidos";
                dataGridView1.Columns[3].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = "";
                MessageBox.Show("No se encontró ninguna coincidencia");
            }
        }
        public void buscarcliente2(string parametro)
        {
            dtBusquedaCliente = conexion.fnEjecutarConsulta("SELECT c.nit, c.nombres, c.apellidos, c.codigo_cliente FROM cliente c, credito cr WHERE apellidos like '%" + parametro + "%' and c.codigo_cliente=cr.codigo_cliente");
            if (dtBusquedaCliente.Rows.Count > 0)
            {
                dataGridView1.DataSource = dtBusquedaCliente;
                dataGridView1.Columns[0].HeaderText = "Nit";
                dataGridView1.Columns[1].HeaderText = "Nombres";
                dataGridView1.Columns[2].HeaderText = "Apellidos";
                dataGridView1.Columns[3].Visible = false;
            }
            else
            {
                dataGridView1.DataSource = "";
                MessageBox.Show("No se encontró ninguna coincidencia");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}