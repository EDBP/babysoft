namespace Boutique
{
    partial class frmDescargaLibre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDescargaLibre));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            dtDescargas = new System.Windows.Forms.DataGridView();
            this.codigo_interno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Egreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Motivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.btnNuevaDescarga = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dtDescargas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(dtDescargas);
            this.panelControl1.Controls.Add(this.panelControl3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(1116, 451);
            this.panelControl1.TabIndex = 9;
            // 
            // dtDescargas
            // 
            dtDescargas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtDescargas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_interno,
            this.descripcion,
            this.cantidad,
            this.Egreso,
            this.Motivo});
            dtDescargas.Dock = System.Windows.Forms.DockStyle.Fill;
            dtDescargas.Location = new System.Drawing.Point(2, 85);
            dtDescargas.Name = "dtDescargas";
            dtDescargas.Size = new System.Drawing.Size(1112, 364);
            dtDescargas.TabIndex = 8;
            dtDescargas.KeyDown += new System.Windows.Forms.KeyEventHandler(dtDescargas_KeyDown);
            // 
            // codigo_interno
            // 
            this.codigo_interno.HeaderText = "Código Interno";
            this.codigo_interno.Name = "codigo_interno";
            this.codigo_interno.Width = 143;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.Width = 400;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Existencia";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 115;
            // 
            // Egreso
            // 
            this.Egreso.HeaderText = "Egreso";
            this.Egreso.Name = "Egreso";
            // 
            // Motivo
            // 
            this.Motivo.HeaderText = "Motivo";
            this.Motivo.Name = "Motivo";
            this.Motivo.Width = 300;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.btnNuevaDescarga);
            this.panelControl3.Controls.Add(this.btnGuardar);
            this.panelControl3.Controls.Add(this.btnSalir);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(1112, 83);
            this.panelControl3.TabIndex = 1;
            // 
            // btnNuevaDescarga
            // 
            this.btnNuevaDescarga.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevaDescarga.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevaDescarga.Image")));
            this.btnNuevaDescarga.Location = new System.Drawing.Point(714, 2);
            this.btnNuevaDescarga.Name = "btnNuevaDescarga";
            this.btnNuevaDescarga.Size = new System.Drawing.Size(128, 79);
            this.btnNuevaDescarga.TabIndex = 6;
            this.btnNuevaDescarga.Text = "Nueva descarga";
            this.btnNuevaDescarga.Click += new System.EventHandler(this.btnNuevaDescarga_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(842, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(128, 79);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.Location = new System.Drawing.Point(970, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(140, 79);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmDescargaLibre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 451);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmDescargaLibre";
            this.Text = "-.-   Gestión de Descargas  -.-";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dtDescargas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        protected static internal System.Windows.Forms.DataGridView dtDescargas;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_interno;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Egreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn Motivo;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.SimpleButton btnNuevaDescarga;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;

    }
}