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
    public partial class frmVentaCobrar : DevExpress.XtraEditors.XtraForm
    {
        public frmVentaCobrar()
        {
            InitializeComponent();
        }

        public void recibirtotal(string cantidad)
        {
            textEdit1.Text = cantidad;
            //descuento = descu;
        }

        string id_venta;
        public void recibiventa(string numeroventa)
        {
            id_venta = numeroventa;
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            frmVenta.ventaCancel = false;
            this.Close();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            frmVenta.imprimir = true;
            this.Close();
        }

        private void frmVentaCobrar_Load(object sender, EventArgs e)
        {
            textEdit2.Focus();
            simpleButton1.Enabled = false;
            simpleButton2.Enabled = false;
        }

        private void textEdit2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (double.Parse(textEdit1.Text) <= double.Parse(textEdit2.Text))
                {
                    textEdit3.Text = string.Format("{0:f}", (double.Parse(textEdit2.Text) - double.Parse(textEdit1.Text))).ToString();
                    simpleButton1.Enabled = true;
                    simpleButton2.Enabled = true;
                    SendKeys.Send("{tab}");
                }
                else
                {
                    MessageBox.Show("EL PAGO ES MENOR A LA CANITDAD CONSUMIDA", "Alerta");
                    textEdit3.Text = "";
                    textEdit2.Text = "";
                    textEdit3.Focus();
                }
            }
        }

        private void frmVentaCobrar_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmVenta.ventaCancel = true;
            this.Close();
        }
    }
}