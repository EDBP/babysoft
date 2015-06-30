namespace Boutique
{
    partial class frmProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProducto));
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpload = new DevExpress.XtraEditors.SimpleButton();
            this.picProducto = new DevExpress.XtraEditors.PictureEdit();
            this.txtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCosto = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.btnBuscar = new DevExpress.XtraEditors.SimpleButton();
            this.btnImprimirIngresos = new DevExpress.XtraEditors.SimpleButton();
            this.btnRptIngresos = new DevExpress.XtraEditors.SimpleButton();
            this.btnListarProds = new DevExpress.XtraEditors.SimpleButton();
            this.txtProd = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.txtCodInterno = new DevExpress.XtraEditors.TextEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtMarca = new DevExpress.XtraEditors.TextEdit();
            this.txtCodBarras = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.picProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtProd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodInterno.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodBarras.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(178, 442);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(114, 51);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Enabled = false;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(421, 442);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(114, 51);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.Location = new System.Drawing.Point(355, 263);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(280, 31);
            this.btnUpload.TabIndex = 7;
            this.btnUpload.Text = "Subir foto";
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click_1);
            // 
            // picProducto
            // 
            this.picProducto.Location = new System.Drawing.Point(355, 63);
            this.picProducto.Name = "picProducto";
            this.picProducto.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picProducto.Size = new System.Drawing.Size(280, 194);
            this.picProducto.TabIndex = 18;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(187, 372);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtPrecio.Properties.Appearance.Options.UseFont = true;
            this.txtPrecio.Size = new System.Drawing.Size(113, 30);
            this.txtPrecio.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(183, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio Q:";
            // 
            // txtCosto
            // 
            this.txtCosto.Enabled = false;
            this.txtCosto.Location = new System.Drawing.Point(27, 372);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCosto.Properties.Appearance.Options.UseFont = true;
            this.txtCosto.Size = new System.Drawing.Size(113, 30);
            this.txtCosto.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(23, 346);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(93, 23);
            this.label8.TabIndex = 15;
            this.label8.Text = "Costo Q:";
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Controls.Add(this.btnBuscar);
            this.panelControl2.Controls.Add(this.btnImprimirIngresos);
            this.panelControl2.Controls.Add(this.btnRptIngresos);
            this.panelControl2.Controls.Add(this.btnListarProds);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl2.Location = new System.Drawing.Point(690, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(200, 517);
            this.panelControl2.TabIndex = 7;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.Location = new System.Drawing.Point(30, 271);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(144, 51);
            this.btnBuscar.TabIndex = 9;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnImprimirIngresos
            // 
            this.btnImprimirIngresos.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimirIngresos.Image")));
            this.btnImprimirIngresos.Location = new System.Drawing.Point(30, 194);
            this.btnImprimirIngresos.Name = "btnImprimirIngresos";
            this.btnImprimirIngresos.Size = new System.Drawing.Size(144, 48);
            this.btnImprimirIngresos.TabIndex = 2;
            this.btnImprimirIngresos.Text = "Imprimir Ingresos";
            this.btnImprimirIngresos.Click += new System.EventHandler(this.btnImprimirIngresos_Click);
            // 
            // btnRptIngresos
            // 
            this.btnRptIngresos.Image = ((System.Drawing.Image)(resources.GetObject("btnRptIngresos.Image")));
            this.btnRptIngresos.Location = new System.Drawing.Point(30, 114);
            this.btnRptIngresos.Name = "btnRptIngresos";
            this.btnRptIngresos.Size = new System.Drawing.Size(144, 53);
            this.btnRptIngresos.TabIndex = 1;
            this.btnRptIngresos.Text = "Ingresos del día";
            this.btnRptIngresos.Click += new System.EventHandler(this.btnRptIngresos_Click);
            // 
            // btnListarProds
            // 
            this.btnListarProds.Image = ((System.Drawing.Image)(resources.GetObject("btnListarProds.Image")));
            this.btnListarProds.Location = new System.Drawing.Point(30, 33);
            this.btnListarProds.Name = "btnListarProds";
            this.btnListarProds.Size = new System.Drawing.Size(144, 52);
            this.btnListarProds.TabIndex = 0;
            this.btnListarProds.Text = "Listar Productos";
            this.btnListarProds.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // txtProd
            // 
            this.txtProd.Enabled = false;
            this.txtProd.Location = new System.Drawing.Point(27, 208);
            this.txtProd.Name = "txtProd";
            this.txtProd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtProd.Properties.Appearance.Options.UseFont = true;
            this.txtProd.Size = new System.Drawing.Size(273, 30);
            this.txtProd.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(23, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 23);
            this.label5.TabIndex = 11;
            this.label5.Text = "Producto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(23, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Código interno:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(549, 442);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(114, 51);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtCodInterno
            // 
            this.txtCodInterno.Enabled = false;
            this.txtCodInterno.Location = new System.Drawing.Point(27, 138);
            this.txtCodInterno.Name = "txtCodInterno";
            this.txtCodInterno.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCodInterno.Properties.Appearance.Options.UseFont = true;
            this.txtCodInterno.Size = new System.Drawing.Size(273, 30);
            this.txtCodInterno.TabIndex = 1;
            this.txtCodInterno.Leave += new System.EventHandler(this.txtCodInterno_Leave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtMarca
            // 
            this.txtMarca.Enabled = false;
            this.txtMarca.Location = new System.Drawing.Point(27, 297);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtMarca.Properties.Appearance.Options.UseFont = true;
            this.txtMarca.Size = new System.Drawing.Size(273, 30);
            this.txtMarca.TabIndex = 3;
            // 
            // txtCodBarras
            // 
            this.txtCodBarras.Enabled = false;
            this.txtCodBarras.Location = new System.Drawing.Point(27, 60);
            this.txtCodBarras.Name = "txtCodBarras";
            this.txtCodBarras.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.txtCodBarras.Properties.Appearance.Options.UseFont = true;
            this.txtCodBarras.Size = new System.Drawing.Size(273, 30);
            this.txtCodBarras.TabIndex = 0;
            this.txtCodBarras.Validated += new System.EventHandler(this.txtCodBarras_Validated);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(351, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Imagen:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(23, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Marca:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(23, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código de barras:";
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.Image = ((System.Drawing.Image)(resources.GetObject("btnModificar.Image")));
            this.btnModificar.Location = new System.Drawing.Point(301, 442);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(114, 51);
            this.btnModificar.TabIndex = 9;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.picProducto);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtCosto);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtProd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtCodInterno);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMarca);
            this.groupBox1.Controls.Add(this.txtCodBarras);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(675, 424);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso del Producto";
            // 
            // panelControl1
            // 
            this.panelControl1.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.panelControl1.Appearance.Options.UseBackColor = true;
            this.panelControl1.Controls.Add(this.btnModificar);
            this.panelControl1.Controls.Add(this.btnNuevo);
            this.panelControl1.Controls.Add(this.btnCancelar);
            this.panelControl1.Controls.Add(this.btnGuardar);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(890, 517);
            this.panelControl1.TabIndex = 6;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayoutStore = System.Windows.Forms.ImageLayout.Stretch;
            this.BackgroundImageStore = global::Boutique.Properties.Resources.depositphotos_10466388_Seamless_baby_background_with_toys;
            this.ClientSize = new System.Drawing.Size(890, 517);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "-.-   Producto   -.-";
            ((System.ComponentModel.ISupportInitialize)(this.picProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCosto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtProd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodInterno.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtMarca.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCodBarras.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnUpload;
        private DevExpress.XtraEditors.PictureEdit picProducto;
        private DevExpress.XtraEditors.TextEdit txtPrecio;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit txtCosto;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton btnImprimirIngresos;
        private DevExpress.XtraEditors.SimpleButton btnRptIngresos;
        private DevExpress.XtraEditors.SimpleButton btnListarProds;
        private DevExpress.XtraEditors.TextEdit txtProd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        protected internal DevExpress.XtraEditors.TextEdit txtCodInterno;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.TextEdit txtMarca;
        private DevExpress.XtraEditors.TextEdit txtCodBarras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton btnModificar;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnBuscar;

    }
}