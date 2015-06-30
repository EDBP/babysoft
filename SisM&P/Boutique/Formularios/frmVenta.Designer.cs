namespace Boutique
{
    partial class frmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVenta));
            this.textEdit10 = new DevExpress.XtraEditors.TextEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Cod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prec = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aplica_descuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textEdit7 = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.textEdit9 = new DevExpress.XtraEditors.TextEdit();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.textEdit6 = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEdit10
            // 
            this.textEdit10.EditValue = "0.00";
            this.textEdit10.Location = new System.Drawing.Point(75, 73);
            this.textEdit10.Name = "textEdit10";
            this.textEdit10.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 30F);
            this.textEdit10.Properties.Appearance.Options.UseFont = true;
            this.textEdit10.Size = new System.Drawing.Size(219, 54);
            this.textEdit10.TabIndex = 18;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 20F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(19, 21);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(231, 33);
            this.label11.TabIndex = 26;
            this.label11.Text = "TOTAL A PAGAR";
            // 
            // panelControl3
            // 
            this.panelControl3.ContentImage = global::Boutique.Properties.Resources.corazonespastel;
            this.panelControl3.Controls.Add(this.pictureEdit1);
            this.panelControl3.Controls.Add(this.checkBox1);
            this.panelControl3.Controls.Add(this.label11);
            this.panelControl3.Controls.Add(this.textEdit10);
            this.panelControl3.Controls.Add(this.simpleButton1);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControl3.Location = new System.Drawing.Point(934, 0);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(334, 467);
            this.panelControl3.TabIndex = 30;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(142, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(107, 17);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Pago en efectivo";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // panelControl2
            // 
            this.panelControl2.ContentImage = global::Boutique.Properties.Resources.corazonespastel;
            this.panelControl2.Controls.Add(this.dataGridView2);
            this.panelControl2.Controls.Add(this.textEdit7);
            this.panelControl2.Controls.Add(this.label7);
            this.panelControl2.Controls.Add(this.textEdit9);
            this.panelControl2.Controls.Add(this.dateTimePicker1);
            this.panelControl2.Controls.Add(this.label9);
            this.panelControl2.Controls.Add(this.textEdit6);
            this.panelControl2.Controls.Add(this.label8);
            this.panelControl2.Controls.Add(this.label6);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(934, 467);
            this.panelControl2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Cod,
            this.Cant,
            this.Desc,
            this.Prec,
            this.aplica_descuento,
            this.SubTot});
            this.dataGridView2.Location = new System.Drawing.Point(53, 182);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(848, 262);
            this.dataGridView2.TabIndex = 4;
            this.dataGridView2.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.dataGridView2_CellBeginEdit);
            this.dataGridView2.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellDoubleClick);
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView2_KeyDown);
            // 
            // Cod
            // 
            this.Cod.HeaderText = "Codigo";
            this.Cod.Name = "Cod";
            this.Cod.Width = 150;
            // 
            // Cant
            // 
            this.Cant.HeaderText = "Cantidad";
            this.Cant.Name = "Cant";
            this.Cant.Width = 75;
            // 
            // Desc
            // 
            this.Desc.HeaderText = "Descripcion";
            this.Desc.Name = "Desc";
            this.Desc.Width = 300;
            // 
            // Prec
            // 
            this.Prec.HeaderText = "Precio";
            this.Prec.Name = "Prec";
            this.Prec.Width = 75;
            // 
            // aplica_descuento
            // 
            this.aplica_descuento.HeaderText = "Descuento";
            this.aplica_descuento.Name = "aplica_descuento";
            // 
            // SubTot
            // 
            this.SubTot.HeaderText = "Sub-Total";
            this.SubTot.Name = "SubTot";
            // 
            // textEdit7
            // 
            this.textEdit7.Location = new System.Drawing.Point(228, 72);
            this.textEdit7.Name = "textEdit7";
            this.textEdit7.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textEdit7.Properties.Appearance.Options.UseFont = true;
            this.textEdit7.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textEdit7.Size = new System.Drawing.Size(491, 32);
            this.textEdit7.TabIndex = 2;
            this.textEdit7.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnviarTab);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label7.Location = new System.Drawing.Point(123, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 23);
            this.label7.TabIndex = 19;
            this.label7.Text = "Quetzaltenango,";
            // 
            // textEdit9
            // 
            this.textEdit9.Location = new System.Drawing.Point(228, 110);
            this.textEdit9.Name = "textEdit9";
            this.textEdit9.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textEdit9.Properties.Appearance.Options.UseFont = true;
            this.textEdit9.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textEdit9.Size = new System.Drawing.Size(491, 32);
            this.textEdit9.TabIndex = 3;
            this.textEdit9.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnviarTab);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 14F, System.Drawing.FontStyle.Bold);
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(279, 35);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(160, 30);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.EnviarTab);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label9.Location = new System.Drawing.Point(123, 114);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "Dirección:";
            // 
            // textEdit6
            // 
            this.textEdit6.EditValue = "C/F";
            this.textEdit6.Location = new System.Drawing.Point(601, 34);
            this.textEdit6.Name = "textEdit6";
            this.textEdit6.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 14F);
            this.textEdit6.Properties.Appearance.Options.UseFont = true;
            this.textEdit6.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.textEdit6.Size = new System.Drawing.Size(118, 32);
            this.textEdit6.TabIndex = 1;
            this.textEdit6.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textEdit6_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label8.Location = new System.Drawing.Point(123, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 23);
            this.label8.TabIndex = 20;
            this.label8.Text = "Nombre:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 14F);
            this.label6.Location = new System.Drawing.Point(547, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 23);
            this.label6.TabIndex = 17;
            this.label6.Text = "NIT:";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(119, 262);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.pictureEdit1.Size = new System.Drawing.Size(151, 37);
            this.pictureEdit1.TabIndex = 5;
            this.pictureEdit1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureEdit1_MouseClick);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(119, 199);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(151, 43);
            this.simpleButton1.TabIndex = 8;
            this.simpleButton1.Text = "COBRAR";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // frmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1268, 467);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.panelControl3);
            this.Name = "frmVenta";
            this.Text = "-..-   Venta   -..-";
            this.Load += new System.EventHandler(this.frmVenta_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmVenta_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.textEdit10.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.panelControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.panelControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit7.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit9.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEdit6.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit textEdit6;
        private DevExpress.XtraEditors.TextEdit textEdit7;
        private DevExpress.XtraEditors.TextEdit textEdit9;
        private DevExpress.XtraEditors.TextEdit textEdit10;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cod;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cant;
        private System.Windows.Forms.DataGridViewTextBoxColumn Desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prec;
        private System.Windows.Forms.DataGridViewTextBoxColumn aplica_descuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTot;
    }
}