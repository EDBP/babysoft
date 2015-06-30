using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using MySql.Data.MySqlClient;
using System.IO;

namespace Boutique
{
    public partial class frmProducto : DevExpress.XtraEditors.XtraForm
    {
        bool bModf = false;
        DataTable dtbuscarproducto;        
        string rutaImg = "";
        string estado= "";
        string relativePath;

        private static frmProducto m_FormDefInstance;
        public static frmProducto DefInstance
        {
            get
            {
                if (m_FormDefInstance == null || m_FormDefInstance.IsDisposed)
                    m_FormDefInstance = new frmProducto();
                return m_FormDefInstance;
            }
            set
            {
                m_FormDefInstance = value;
            }
        }
               
        public frmProducto()
        {
            relativePath = Path.GetFullPath(Directory.GetCurrentDirectory());
            relativePath = relativePath.Substring(0, relativePath.Length - 9); 
            InitializeComponent();
        }

        public void buscarproducto()
        {
            dtbuscarproducto = conexion.fnEjecutarConsulta("SELECT * FROM producto Where codigo_interno= '" + txtCodInterno.Text + "'");
            if (dtbuscarproducto.Rows.Count != 0)
            {
                txtCodBarras.Text = dtbuscarproducto.Rows[0]["codigo_barras"].ToString();
                txtCodInterno.Text = dtbuscarproducto.Rows[0]["codigo_interno"].ToString();
                txtProd.Text = dtbuscarproducto.Rows[0]["descripcion"].ToString();
                txtMarca.Text = dtbuscarproducto.Rows[0]["marca"].ToString();
                txtCosto.Text = dtbuscarproducto.Rows[0]["costo"].ToString();
                txtPrecio.Text = dtbuscarproducto.Rows[0]["precio"].ToString();
                rutaImg = dtbuscarproducto.Rows[0]["ruta_imagen"].ToString();
                txtCodInterno.Focus();

                if (!rutaImg.Equals(""))
                {
                    if (File.Exists(rutaImg))
                    {
                        //picProducto.Image = Image.FromFile(rutaImg);
                        FileStream fs = new FileStream(rutaImg, FileMode.Open);
                        picProducto.Image = Image.FromStream(fs);
                        fs.Close();
                    }
                    else
                    {
                        FileStream fs = new FileStream(relativePath + @"\Productos\foto_no_disponible.jpg", FileMode.Open);
                        picProducto.Image = Image.FromStream(fs);
                        fs.Close();
                        //picProducto.Image = Image.FromFile(relativePath + @"\Productos\foto_no_disponible.jpg");
                    }
                }
                else
                {
                    FileStream fs = new FileStream(relativePath + @"\Productos\foto_no_disponible.jpg", FileMode.Open);
                    picProducto.Image = Image.FromStream(fs);
                    fs.Close();
                    //picProducto.Image = Image.FromFile(relativePath + @"\Productos\foto_no_disponible.jpg");
                }
                txtCodInterno.Focus();
            }
            else
            {
                DialogResult result = MessageBox.Show("Producto no encontrado, ¿Desea crear un nuevo Registro?", "Agregar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    //frmInventarioMantenimiento datos = new frmInventarioMantenimiento();

                    // datos.Text = "Nuevo Producto";
                    // datos.ShowDialog();
                }
                else if (result == DialogResult.No)
                    limpiar();
            }
        }
                
        private void limpiar()
        {
            txtCodBarras.Text = "";
            txtMarca.Text = "";
            txtCodInterno.Text = "";
            txtProd.Text = "";
            txtCodBarras.Focus();
            txtCosto.Text = "";
            txtPrecio.Text = "";

            txtCodBarras.Enabled = true;
            txtMarca.Enabled = true;
            txtCodInterno.Enabled = true;
            txtProd.Enabled = true;
            txtCosto.Enabled = true;
            txtPrecio.Enabled = true;

            //picProducto.Image = Image.FromFile(relativePath + @"\Productos\foto_no_disponible.jpg");
            FileStream fs = new FileStream(relativePath + @"\Productos\foto_no_disponible.jpg", FileMode.Open);
            picProducto.Image = Image.FromStream(fs);
            fs.Close();
            rutaImg = relativePath + @"Productos\foto_no_disponible.jpg";
        }
                        
        private void simpleButton2_Click(object sender, EventArgs e)
        {            
            if (estado.Equals("N"))
            {             
                btnModificar.Enabled = false;
                limpiar();
            }
            if (estado.Equals("M"))
            {
                btnModificar.Enabled = true;
            }

            txtCodBarras.Enabled = false;
            txtMarca.Enabled = false;
            txtCodInterno.Enabled = false;
            txtProd.Enabled = false;
            txtCosto.Enabled = false;
            txtPrecio.Enabled = false;

            btnNuevo.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = false;            
        }

        private void mostrarform()
        {
            frmIngresoBusqueda busqueda = new frmIngresoBusqueda();
            busqueda.identificar("ingreso");
            busqueda.ShowDialog();
        }
        private void simpleButton3_Click(object sender, EventArgs e)
        {
            //mostrarform();   
            Reportes.rptInventario report = new Reportes.rptInventario();
            report.llenarreporte();
            report.ShowPreview();
        }

        public void mensaje(string valor)
        {
            txtCodBarras.Text = valor;
            SendKeys.Send("{tab}");
            SendKeys.Send("{tab}");
            SendKeys.Send("{tab}");
            SendKeys.Send("{enter}");
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {            
            btnModificar.Enabled = true;
            btnNuevo.Enabled = true;
            btnCancelar.Enabled = false;
            btnGuardar.Enabled = false;
            try
            {
                
                if (estado.Equals("N"))
                {
                    Image img = Image.FromFile(rutaImg);

                    Bitmap newImg = new Bitmap(img, 280, 194);
                    newImg.Save(relativePath + @"Productos\" + txtCodInterno.Text + ".png");
                    newImg.Dispose();

                    MySqlParameter[] registro = new MySqlParameter[]{
                    new MySqlParameter("cod_interno",txtCodInterno.Text.ToString()),
                    new MySqlParameter("cod_barras",txtCodBarras.Text.ToString()),
                    new MySqlParameter("descripcion",txtProd.Text.ToString()),
                    new MySqlParameter("costo",float.Parse(txtCosto.Text.ToString())),
                    new MySqlParameter("precio",float.Parse(txtPrecio.Text.ToString())),
                    new MySqlParameter("path_img", relativePath + @"Productos\" + txtCodInterno.Text + ".png"),
                    new MySqlParameter("marca",txtMarca.Text.ToString())
                    };
                    object ingreso = conexion.fnobjEjecutarProcedimientoEscalar("ingreso_producto", registro);
                    
                    //img.Save(relativePath + @"Productos\" + txtCodInterno.Text + ".png");
                    img.Dispose();
                    MessageBox.Show("Ingreso exitoso!", "- Ingreso Producto -", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (estado.Equals("M"))
                {
                    if ((File.Exists(relativePath + @"Productos\" + txtCodInterno.Text + ".png")) && (bModf==true) )
                    {
                        System.IO.File.Delete(relativePath + @"Productos\" + txtCodInterno.Text + ".png");
                        Image img = Image.FromFile(rutaImg);
                        img.Save(relativePath + @"Productos\" + txtCodInterno.Text + ".png");
                        img.Dispose();
                    }
                    if (!(File.Exists(relativePath + @"Productos\" + txtCodInterno.Text + ".png")) && (bModf == true))
                    {
                        Image img = Image.FromFile(rutaImg);
                        img.Save(relativePath + @"Productos\" + txtCodInterno.Text + ".png");
                        img.Dispose();
                    }
                    if (!(File.Exists(relativePath + @"Productos\" + txtCodInterno.Text + ".png")) && (bModf == false))
                    {
                        File.Move(relativePath + @"Productos\" + cod_anterior + ".png", relativePath + @"Productos\" + txtCodInterno.Text + ".png");
                        
                    }

                    MySqlParameter[] registro = new MySqlParameter[]{
                    new MySqlParameter("cod_interno",cod_anterior),
                    new MySqlParameter("Ncod_interno",txtCodInterno.Text.ToString()),
                    new MySqlParameter("cod_barras",txtCodBarras.Text.ToString()),
                    new MySqlParameter("nombre",txtProd.Text.ToString()),
                    new MySqlParameter("costop",float.Parse(txtCosto.Text.ToString())),
                    new MySqlParameter("preciop",float.Parse(txtPrecio.Text.ToString())),
                    new MySqlParameter("path_img", relativePath + @"Productos\" + txtCodInterno.Text + ".png"),
                    new MySqlParameter("marcap",txtMarca.Text.ToString())
                    };
                    object ingreso = conexion.fnobjEjecutarProcedimientoEscalar("modificar_producto", registro);

                    
                    
                    MessageBox.Show("Modificación exitosa!", "- Modificación Producto -", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo el siguiente error: " + ex);
            }
            estado = "G";
        }
        
        private void btNuevo_Click(object sender, EventArgs e)
        {
            estado = "N";
            btnNuevo.Enabled = false;
            btnModificar.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;

            limpiar();
        }
        string cod_anterior;
        public void modificar()
        {
            estado = "M";
            txtCodBarras.Enabled = false;
            txtCodInterno.Enabled = true;
            txtProd.Enabled = true;
            txtCosto.Enabled = true;
            txtPrecio.Enabled = true;
            txtMarca.Enabled = true;
            cod_anterior = txtCodInterno.Text;

            btnModificar.Enabled = false;
            btnNuevo.Enabled = false;
            btnGuardar.Enabled = true;
            btnCancelar.Enabled = true;
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnRptIngresos_Click(object sender, EventArgs e)
        {
            DateTime fechaHoy = DateTime.Now;
            string fecha = fechaHoy.ToString("d");
            string fecha1 = fecha.Substring(6, 4) + "/" + fecha.Substring(3, 2) + "/" + fecha.Substring(0, 2);
            Reportes.rptIngresos report = new Reportes.rptIngresos();
            report.llenarreporte(fecha1,fecha1);
            report.ShowPreview();
        }
        
        private void btnUpload_Click_1(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog1.FileName, FileMode.Open);                
                picProducto.Image = Image.FromStream(fs);    
                fs.Close();
                bModf = true;                
                rutaImg = openFileDialog1.FileName.ToString();
            }
        }

        public static void agregarReg(string codigo)
        {
            DataTable tInventario = conexion.fnEjecutarConsulta("SELECT codigo_barras, descripcion, "
                        + "marca, costo, precio, ruta_imagen FROM producto where codigo_interno = '" + codigo+"'");
            m_FormDefInstance.llenarCampos(codigo, tInventario);
        }

        public void llenarCampos(string codigo, DataTable tbInventario)
        {
            //limpiar();
            txtCodBarras.Text = "";
            txtMarca.Text = "";
            txtCodInterno.Text = "";
            txtProd.Text = "";
            txtCodBarras.Focus();
            txtCosto.Text = "";
            txtPrecio.Text = "";

            


            txtCodBarras.Text = tbInventario.DefaultView[0].Row[0].ToString();
            txtCodInterno.Text = codigo;
            txtProd.Text = tbInventario.DefaultView[0].Row[1].ToString();
            txtMarca.Text = tbInventario.DefaultView[0].Row[2].ToString();
            txtCosto.Text = tbInventario.DefaultView[0].Row[3].ToString();
            txtPrecio.Text = tbInventario.DefaultView[0].Row[4].ToString();
            rutaImg = tbInventario.DefaultView[0].Row[5].ToString();

            if (!rutaImg.Equals(""))
            {
                if (!(File.Exists(relativePath + @"Productos\" + txtCodInterno.Text + ".png")))
                {
                    FileStream fs = new FileStream(relativePath + @"\Productos\foto_no_disponible.jpg", FileMode.Open);
                    picProducto.Image = Image.FromStream(fs);
                    fs.Close();
                    rutaImg = relativePath + @"Productos\foto_no_disponible.jpg";
                }
                else
                {
                    FileStream fs = new FileStream(rutaImg, FileMode.Open);
                    picProducto.Image = Image.FromStream(fs);
                    fs.Close();
                }
            }
            //picProducto.Image = Image.FromFile(rutaImg);
            else
            {
                FileStream fs = new FileStream(relativePath + @"\Productos\foto_no_disponible.jpg", FileMode.Open);
                picProducto.Image = Image.FromStream(fs);
                fs.Close();
                rutaImg = relativePath + @"Productos\foto_no_disponible.jpg";
                //picProducto.Image = Image.FromFile(relativePath + @"\Productos\foto_no_disponible.jpg");
            }
            txtCodInterno.Focus();

            btnNuevo.Enabled = false;
            btnModificar.Enabled = true;
            btnGuardar.Enabled = false;
            btnCancelar.Enabled = true;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmIngresoBusqueda busqueda = new frmIngresoBusqueda(3);
            busqueda.label1.Text = "Búsqueda de Producto";
            busqueda.ShowDialog();
        }

        private void btnImprimirIngresos_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Desea imprimir el reporte?", "Impresion en Espera...", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                DateTime fechaHoy = DateTime.Now;
                string fecha = fechaHoy.ToString("d");
                Reportes.rptIngresos report = new Reportes.rptIngresos();
                report.llenarreporte(fecha, fecha);

                report.Print();
            }
            
        }

        private void txtCodInterno_Leave(object sender, EventArgs e)
        {
            int codigo_disponible = int.Parse(conexion.fnEjecutarEscalar("SELECT count(codigo_interno) FROM boutique.producto WHERE codigo_interno = '" + txtCodInterno.Text + "'").ToString());
            if (codigo_disponible != 0)
            {
                MessageBox.Show("EL CODIGO ASIGNADO YA EXISTE", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCodInterno.Text = "";
                txtCodInterno.Focus();
            }
        }


        private void txtCodBarras_Validated(object sender, EventArgs e)
        {
            int codigo_disponible = int.Parse(conexion.fnEjecutarEscalar("SELECT count(codigo_barras) FROM boutique.producto WHERE codigo_barras = '" + txtCodBarras.Text + "'").ToString());
            if ((codigo_disponible != 0) && (txtCodBarras.Text != ""))
            {
                MessageBox.Show("CODIGO DE BARRAS YA EXISTE", "ERROR...", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodBarras.Text = "";
                txtCodBarras.Focus();
            }
        }

        
        
    }
}