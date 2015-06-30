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
    public partial class frmPago : Form
    {
      
        public frmPago()
        {
            InitializeComponent();
            
        }
                        
        private void EnviarTab(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) SendKeys.Send("{TAB}");
        }

        string cliente;
        string usuario;
        string monto;
        string no_venta;
        public void mensaje(int id_cliente,int id_usuario,string total_venta, string id_venta)
        {
            cliente = id_cliente.ToString();
            usuario = id_usuario.ToString();
            monto = total_venta.ToString();
            no_venta = id_venta;
        }
        
        private void simpleButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void simpleButton1_Click(object sender, EventArgs e)
        {
            opcion_pago();
            frmConsultaComprobante imprimir_recibo = new frmConsultaComprobante();
            imprimir_recibo.mostrarRecibo(conexion.fnEjecutarEscalar("select MAX(id_venta) from venta").ToString());
        }


        private void procesar_pago(string no_documento, string titular, string tipo_pago)
        {
            frmVenta.DefInstance.guardar_venta();
            MySqlParameter[] registro = new MySqlParameter[]{
                            new MySqlParameter("id_venta", conexion.fnEjecutarEscalar("select MAX(id_venta) from venta").ToString()), 
                            new MySqlParameter("no_documento",no_documento),
                            new MySqlParameter("monto",monto),
                            new MySqlParameter("titular",titular),
                            new MySqlParameter("tipo_pago",tipo_pago)};

            conexion.fnobjEjecutarProcedimientoEscalar("guardar_pago", registro);
            MessageBox.Show("Pago guardado", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void opcion_pago()
        {
            DialogResult result;
            switch (comboBoxEdit1.SelectedIndex)
            {
                case 0:
                    result = MessageBox.Show("¿Desea procesar el pago con Tarjeta de Credito?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {

                            procesar_pago(textBox2.Text,textBox3.Text,"0");
                            frmVenta.DefInstance.nueva_venta();
                            this.Close();

                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("Seleccione otra forma de pago", "Informació", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    break;
                case 1:
                    result = MessageBox.Show("¿Desea procesar el pago con Tarjeta de débito?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            procesar_pago(textBox2.Text, textBox3.Text, "1");
                            frmVenta.DefInstance.nueva_venta();
                            this.Close();
                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("Seleccione otra forma de pago", "Informació", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    break;
                case 2:
                        result = MessageBox.Show("¿Desea procesar el pago con Cheque?", "Aviso", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            procesar_pago(textBox2.Text, "N/A", "2");
                            frmVenta.DefInstance.nueva_venta();
                            this.Close();
                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("Seleccione otra forma de pago", "Informació", MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                    
                    break;
                default:
                    int disponible = int.Parse(conexion.fnEjecutarEscalar("select count(codigo_cliente) as cantidad from boutique.credito where codigo_cliente= "+cliente).ToString());
                    if (disponible == 0)
                    {
                        result = MessageBox.Show("¿Desea otorgar un credito al cliente?", "Aviso", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                        if (result == DialogResult.Yes)
                        {
                            frmCredito Creditos = new frmCredito();
                            Creditos.mensaje(cliente, usuario, monto);
                            Creditos.ShowDialog();
                        }
                        else if (result == DialogResult.No)
                        {
                            MessageBox.Show("Seleccione otra forma de pago", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        float saldo = float.Parse(conexion.fnEjecutarEscalar("select saldo_pendiente from boutique.credito where codigo_cliente= "+cliente).ToString());
                        float limite = float.Parse(conexion.fnEjecutarEscalar("select saldo_limite from boutique.credito where codigo_cliente= " + cliente).ToString());

                        if ((saldo + float.Parse(monto)) > limite)
                        {
                            
                            result = MessageBox.Show("El limite del credito del cleinte no cubre la venta" + "\r"+
                                       "\r" + "\n" + "          ¿Deseea extender el credito?", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {

                                frmCredito Creditos = new frmCredito();
                                Creditos.extenderCredito(cliente, usuario, monto);
                                Creditos.ShowDialog();
                                
                            }
                            else if (result == DialogResult.No)
                            {
                                MessageBox.Show("Seleccione otra forma de pago", "Informació", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            
                        }
                        else
                        {
                            procesar_pago("N/A", "N/A", "3");
                            conexion.fnEjecutarEscalar("UPDATE boutique.credito SET saldo_pendiente= "+ (saldo+float.Parse(monto)) +" where codigo_cliente= " + cliente);
                            frmVenta.DefInstance.nueva_venta();
                            this.Close();
                        }
                       
                    }
                    break;
            }
        }

        private void frmPago_Load(object sender, EventArgs e)
        {
            textBox2.Enabled = false;
            textBox3.Enabled = false;
        }

        private void comboBoxEdit1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBoxEdit1.SelectedIndex)
            {
                case 2:
                    textBox2.Enabled = true;
                    textBox3.Enabled = false;
                    break;
                case 3:
                    textBox2.Enabled = false;
                    textBox3.Enabled = false;
                    break;
                default:
                    textBox2.Enabled = true;
                    textBox3.Enabled = true;
                    break;
            }
        }
    }
}
