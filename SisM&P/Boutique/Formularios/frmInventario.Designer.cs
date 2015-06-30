namespace Boutique
{
    partial class frmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInventario));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnNuevoIngreso = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevoProducto = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigo_interno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ingreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnNuevoIngreso);
            this.panelControl1.Controls.Add(this.btnGuardar);
            this.panelControl1.Controls.Add(this.btnNuevoProducto);
            this.panelControl1.Controls.Add(this.simpleButton3);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(822, 83);
            this.panelControl1.TabIndex = 0;
            // 
            // btnNuevoIngreso
            // 
            this.btnNuevoIngreso.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevoIngreso.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoIngreso.Image")));
            this.btnNuevoIngreso.Location = new System.Drawing.Point(296, 2);
            this.btnNuevoIngreso.Name = "btnNuevoIngreso";
            this.btnNuevoIngreso.Size = new System.Drawing.Size(128, 79);
            this.btnNuevoIngreso.TabIndex = 9;
            this.btnNuevoIngreso.Text = "Nuevo ingreso";
            this.btnNuevoIngreso.Click += new System.EventHandler(this.btnNuevoIngreso_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(424, 2);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(128, 79);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar cambios";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click_1);
            // 
            // btnNuevoProducto
            // 
            this.btnNuevoProducto.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnNuevoProducto.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevoProducto.Image")));
            this.btnNuevoProducto.Location = new System.Drawing.Point(552, 2);
            this.btnNuevoProducto.Name = "btnNuevoProducto";
            this.btnNuevoProducto.Size = new System.Drawing.Size(128, 79);
            this.btnNuevoProducto.TabIndex = 7;
            this.btnNuevoProducto.Text = "Nuevo Producto";
            this.btnNuevoProducto.Click += new System.EventHandler(this.btnNuevoProducto_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton3.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(680, 2);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(140, 79);
            this.simpleButton3.TabIndex = 3;
            this.simpleButton3.Text = "Salir";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(dataGridView1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 83);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(822, 421);
            this.panelControl2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo_interno,
            this.descripcion,
            this.cantidad,
            this.Ingreso,
            this.precio});
            dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            dataGridView1.Location = new System.Drawing.Point(2, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new System.Drawing.Size(818, 417);
            dataGridView1.TabIndex = 8;
            dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(dataGridView1_CellEndEdit);
            dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(dataGridView1_KeyDown);
            // 
            // codigo_interno
            // 
            this.codigo_interno.HeaderText = "Código";
            this.codigo_interno.Name = "codigo_interno";
            this.codigo_interno.Width = 143;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Descripción";
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 400;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Existencia";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            this.cantidad.Width = 115;
            // 
            // Ingreso
            // 
            this.Ingreso.HeaderText = "Ingreso";
            this.Ingreso.Name = "Ingreso";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.Width = 115;
            // 
            // frmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 504);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl1);
            this.Name = "frmInventario";
            this.Text = ".\'. Gestión de Ingresos .\'.";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnNuevoIngreso;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevoProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo_interno;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ingreso;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        protected static internal System.Windows.Forms.DataGridView dataGridView1;
    }
}