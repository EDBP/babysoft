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
    public partial class frmIngresoBusqueda : DevExpress.XtraEditors.XtraForm
    {
        int inventario = 0;
        public frmIngresoBusqueda()
        {
            InitializeComponent();
        }

        public frmIngresoBusqueda(int inventario)
        {
            InitializeComponent();
            this.inventario = inventario;
        }


        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void identificar(string texto)
        {
            label1.Text = texto;
        }


        private DataTable dt = new DataTable();
        private DataSet ds = new DataSet();
        private void frmIngresoBusqueda_Load(object sender, EventArgs e)
        {
            dt = conexion.fnEjecutarConsulta("select codigo_interno, descripcion, codigo_barras from producto");
            ds.Tables.Add(dt);
            dataGridView1.DataSource = dt;
           

            dataGridView1.Columns[0].HeaderText = "Codigo Producto";
            dataGridView1.Columns[0].Width = 100;

            dataGridView1.Columns[1].HeaderText = "Nombre Producto";
            dataGridView1.Columns[1].Width = 220;

            dataGridView1.Columns[2].HeaderText = "Codigo de Barras";
            dataGridView1.Columns[2].Visible = false;

            for (int i = 0; i <= 1; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 11F, FontStyle.Regular);
                dataGridView1.Columns[i].ReadOnly = true;
                dataGridView1.Columns[i].Resizable = DataGridViewTriState.False;
            }
        }


        private void enviar()
        {
            //if (label1.Text == "ingreso")
            if (inventario == 0)
            {
                frmProducto fProd = new frmProducto();
                fProd.txtCodInterno.Text = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                fProd.buscarproducto();
                fProd.modificar();
                fProd.ShowDialog();
            }
            if (inventario == 1)
                frmInventario.agregarReg(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            if (inventario == 2)
                frmDescargaLibre.agregarReg(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());                
            if (inventario == 3)
                frmProducto.agregarReg(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString());
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            enviar();            
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            enviar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string fieldName = string.Concat("[", dt.Columns[1].ColumnName, "]");
            dt.DefaultView.Sort = fieldName;
            DataView view = dt.DefaultView;
            view.RowFilter = string.Empty;
            if (textBox1.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + textBox1.Text + "%'";
            dataGridView1.DataSource = view;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string fieldName = string.Concat("[", dt.Columns[2].ColumnName, "]");
            dt.DefaultView.Sort = fieldName;
            DataView view = dt.DefaultView;
            view.RowFilter = string.Empty;
            if (textBox2.Text != string.Empty)
                view.RowFilter = fieldName + " LIKE '%" + textBox2.Text + "%'";
            dataGridView1.DataSource = view;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void dataGridView1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
            enviar();
            }
        }
    }
}