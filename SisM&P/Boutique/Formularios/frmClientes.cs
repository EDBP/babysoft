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
    public partial class frmClientes : Form
    {
        DataTable dtusuarios;
        private static frmClientes m_FormDefInstance;
        public static frmClientes DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmClientes();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }       
 
        public frmClientes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            actualizar(); 
        }

        public void actualizar()
        {
            dtusuarios = conexion.fnEjecutarConsulta("select * from cliente");
            dataGridView1.DataSource = dtusuarios;
            
            dataGridView1.Columns[0].HeaderText = "Codigo";
            dataGridView1.Columns[0].Width = 100;
            
            dataGridView1.Columns[1].HeaderText = "Nit";
            dataGridView1.Columns[1].Width = 150;
            
            dataGridView1.Columns[2].HeaderText = "Nombre";
            dataGridView1.Columns[2].Width = 250;
            
            
            dataGridView1.Columns[3].HeaderText = "Apellido";
            dataGridView1.Columns[3].Width = 250;
            
            
            dataGridView1.Columns[4].HeaderText = "Dirección";
            dataGridView1.Columns[4].Width = 350;
            
            
            dataGridView1.Columns[5].HeaderText = "Telefono";
            dataGridView1.Columns[5].Width = 130;
            
            dataGridView1.Columns[6].Visible=false;
            for (int i = 0; i <= 5; i++)
            {
                dataGridView1.Columns[i].DefaultCellStyle.Font = new System.Drawing.Font("Verdana", 11F, FontStyle.Regular);
                dataGridView1.Columns[i].ReadOnly = true;
                dataGridView1.Columns[i].Resizable = DataGridViewTriState.False;
            }
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            if (dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString() == "")
            {
                DialogResult result = MessageBox.Show("No encontrado, ¿Desea crear un nuevo cliente?", "Aviso", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    nuevocliente();
                }
                else if (result == DialogResult.No)
                {
                }

            }
            else
            {
                frmClientesMantenimiento datoscliente = new frmClientesMantenimiento(dtusuarios.Rows[dataGridView1.CurrentRow.Index]);
                
                datoscliente.Text = "Editar Cliente";

                datoscliente.ShowDialog();
            }

        }
        public void nuevocliente()
        {
            frmClientesMantenimiento datos = new frmClientesMantenimiento();
            
            datos.Text = "Nuevo Cliente";
            datos.ShowDialog();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            nuevocliente();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
