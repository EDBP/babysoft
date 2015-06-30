namespace Boutique
{
    partial class frmPrincipal
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barBotonVenta = new DevExpress.XtraBars.BarButtonItem();
            this.barBotonInventario = new DevExpress.XtraBars.BarButtonItem();
            this.barBotonIngreso = new DevExpress.XtraBars.BarButtonItem();
            this.barBotonMerma = new DevExpress.XtraBars.BarButtonItem();
            this.barBotonClientes = new DevExpress.XtraBars.BarButtonItem();
            this.barBotonVerInventario = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.barBotonIngresos = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnMerma = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnVentas = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnCreditos = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnPagoCreditos = new DevExpress.XtraBars.BarButtonItem();
            this.barBtnRanking = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.rPVentas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rPGVentas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPInventario = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rPGInventario = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPClientes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rPGClientes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPReportes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rPGReportes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.rPMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.rPGMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.repositoryItemTimeEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.Appearance.Image = ((System.Drawing.Image)(resources.GetObject("xtraTabbedMdiManager1.Appearance.Image")));
            this.xtraTabbedMdiManager1.Appearance.Options.UseImage = true;
            this.xtraTabbedMdiManager1.MdiParent = this;
            this.xtraTabbedMdiManager1.PageImagePosition = DevExpress.XtraTab.TabPageImagePosition.Far;
            // 
            // ribbon
            // 
            this.ribbon.ApplicationIcon = ((System.Drawing.Bitmap)(resources.GetObject("ribbon.ApplicationIcon")));
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.ExpandCollapseItem.Name = "";
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barBotonVenta,
            this.barBotonInventario,
            this.barBotonIngreso,
            this.barBotonMerma,
            this.barBotonClientes,
            this.barBotonVerInventario,
            this.barButtonUsuarios,
            this.barBotonIngresos,
            this.barBtnMerma,
            this.barBtnVentas,
            this.barBtnCreditos,
            this.barBtnPagoCreditos,
            this.barBtnRanking,
            this.barButtonItem1});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 20;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.rPVentas,
            this.rPInventario,
            this.rPClientes,
            this.rPReportes,
            this.rPMantenimiento});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemTimeEdit1});
            this.ribbon.Size = new System.Drawing.Size(1282, 144);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // barBotonVenta
            // 
            this.barBotonVenta.Caption = "Venta";
            this.barBotonVenta.Id = 3;
            this.barBotonVenta.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBotonVenta.LargeGlyph")));
            this.barBotonVenta.LargeWidth = 80;
            this.barBotonVenta.Name = "barBotonVenta";
            this.barBotonVenta.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBotonVenta_ItemClick);
            // 
            // barBotonInventario
            // 
            this.barBotonInventario.Caption = "Ingreso";
            this.barBotonInventario.Id = 4;
            this.barBotonInventario.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBotonInventario.LargeGlyph")));
            this.barBotonInventario.LargeWidth = 80;
            this.barBotonInventario.Name = "barBotonInventario";
            this.barBotonInventario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBotonInventario_ItemClick);
            // 
            // barBotonIngreso
            // 
            this.barBotonIngreso.Caption = "Gestión de Productos";
            this.barBotonIngreso.Id = 5;
            this.barBotonIngreso.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBotonIngreso.LargeGlyph")));
            this.barBotonIngreso.LargeWidth = 80;
            this.barBotonIngreso.Name = "barBotonIngreso";
            this.barBotonIngreso.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBotonIngreso_ItemClick);
            // 
            // barBotonMerma
            // 
            this.barBotonMerma.Caption = "Descarga";
            this.barBotonMerma.Id = 6;
            this.barBotonMerma.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBotonMerma.LargeGlyph")));
            this.barBotonMerma.LargeWidth = 80;
            this.barBotonMerma.Name = "barBotonMerma";
            this.barBotonMerma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBotonMerma_ItemClick);
            // 
            // barBotonClientes
            // 
            this.barBotonClientes.Caption = "   Clientes     ";
            this.barBotonClientes.Id = 7;
            this.barBotonClientes.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBotonClientes.LargeGlyph")));
            this.barBotonClientes.LargeWidth = 80;
            this.barBotonClientes.Name = "barBotonClientes";
            this.barBotonClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBotonClientes_ItemClick);
            // 
            // barBotonVerInventario
            // 
            this.barBotonVerInventario.Caption = "Inventario";
            this.barBotonVerInventario.Id = 8;
            this.barBotonVerInventario.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBotonVerInventario.LargeGlyph")));
            this.barBotonVerInventario.LargeWidth = 80;
            this.barBotonVerInventario.Name = "barBotonVerInventario";
            this.barBotonVerInventario.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBotonVerInventario_ItemClick);
            // 
            // barButtonUsuarios
            // 
            this.barButtonUsuarios.Caption = "Gestion de Usuarios";
            this.barButtonUsuarios.Id = 9;
            this.barButtonUsuarios.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F);
            this.barButtonUsuarios.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonUsuarios.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barButtonUsuarios.LargeGlyph")));
            this.barButtonUsuarios.LargeWidth = 80;
            this.barButtonUsuarios.Name = "barButtonUsuarios";
            this.barButtonUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonUsuarios_ItemClick);
            // 
            // barBotonIngresos
            // 
            this.barBotonIngresos.Caption = "Ingresos por día";
            this.barBotonIngresos.Id = 11;
            this.barBotonIngresos.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBotonIngresos.LargeGlyph")));
            this.barBotonIngresos.LargeWidth = 80;
            this.barBotonIngresos.Name = "barBotonIngresos";
            this.barBotonIngresos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBotonIngresos_ItemClick);
            // 
            // barBtnMerma
            // 
            this.barBtnMerma.Caption = "Descargas al mes";
            this.barBtnMerma.Id = 14;
            this.barBtnMerma.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnMerma.LargeGlyph")));
            this.barBtnMerma.LargeWidth = 80;
            this.barBtnMerma.Name = "barBtnMerma";
            this.barBtnMerma.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnMerma_ItemClick);
            // 
            // barBtnVentas
            // 
            this.barBtnVentas.Caption = "Ventas del día";
            this.barBtnVentas.Id = 15;
            this.barBtnVentas.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnVentas.LargeGlyph")));
            this.barBtnVentas.LargeWidth = 80;
            this.barBtnVentas.Name = "barBtnVentas";
            this.barBtnVentas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnVentas_ItemClick);
            // 
            // barBtnCreditos
            // 
            this.barBtnCreditos.Caption = "Creditos Clientes ";
            this.barBtnCreditos.Id = 16;
            this.barBtnCreditos.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnCreditos.LargeGlyph")));
            this.barBtnCreditos.Name = "barBtnCreditos";
            this.barBtnCreditos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnCreditos_ItemClick);
            // 
            // barBtnPagoCreditos
            // 
            this.barBtnPagoCreditos.Caption = "Pago de Creditos";
            this.barBtnPagoCreditos.Id = 17;
            this.barBtnPagoCreditos.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnPagoCreditos.LargeGlyph")));
            this.barBtnPagoCreditos.Name = "barBtnPagoCreditos";
            this.barBtnPagoCreditos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnPagoCreditos_ItemClick);
            // 
            // barBtnRanking
            // 
            this.barBtnRanking.Caption = "Ranking de Productos";
            this.barBtnRanking.Id = 18;
            this.barBtnRanking.LargeGlyph = ((System.Drawing.Image)(resources.GetObject("barBtnRanking.LargeGlyph")));
            this.barBtnRanking.Name = "barBtnRanking";
            this.barBtnRanking.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barBtnRanking_ItemClick);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Re-Impresión Comprobante";
            this.barButtonItem1.Id = 19;
            this.barButtonItem1.LargeGlyph = global::Boutique.Properties.Resources.save;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // rPVentas
            // 
            this.rPVentas.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rPGVentas});
            this.rPVentas.Name = "rPVentas";
            this.rPVentas.Text = "Ventas";
            // 
            // rPGVentas
            // 
            this.rPGVentas.ItemLinks.Add(this.barBotonVenta);
            this.rPGVentas.Name = "rPGVentas";
            this.rPGVentas.ShowCaptionButton = false;
            // 
            // rPInventario
            // 
            this.rPInventario.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rPGInventario});
            this.rPInventario.Name = "rPInventario";
            this.rPInventario.Text = "Inventario";
            // 
            // rPGInventario
            // 
            this.rPGInventario.ItemLinks.Add(this.barBotonIngreso);
            this.rPGInventario.ItemLinks.Add(this.barBotonInventario);
            this.rPGInventario.ItemLinks.Add(this.barBotonMerma);
            this.rPGInventario.Name = "rPGInventario";
            this.rPGInventario.ShowCaptionButton = false;
            // 
            // rPClientes
            // 
            this.rPClientes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rPGClientes});
            this.rPClientes.Name = "rPClientes";
            this.rPClientes.Text = "Clientes";
            // 
            // rPGClientes
            // 
            this.rPGClientes.ItemLinks.Add(this.barBotonClientes);
            this.rPGClientes.ItemLinks.Add(this.barBtnPagoCreditos);
            this.rPGClientes.Name = "rPGClientes";
            this.rPGClientes.ShowCaptionButton = false;
            // 
            // rPReportes
            // 
            this.rPReportes.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rPGReportes});
            this.rPReportes.Name = "rPReportes";
            this.rPReportes.Text = "Reportes";
            // 
            // rPGReportes
            // 
            this.rPGReportes.ItemLinks.Add(this.barBtnVentas);
            this.rPGReportes.ItemLinks.Add(this.barBotonVerInventario);
            this.rPGReportes.ItemLinks.Add(this.barBtnRanking);
            this.rPGReportes.ItemLinks.Add(this.barBotonIngresos);
            this.rPGReportes.ItemLinks.Add(this.barBtnMerma);
            this.rPGReportes.ItemLinks.Add(this.barBtnCreditos);
            this.rPGReportes.ItemLinks.Add(this.barButtonItem1);
            this.rPGReportes.Name = "rPGReportes";
            this.rPGReportes.ShowCaptionButton = false;
            // 
            // rPMantenimiento
            // 
            this.rPMantenimiento.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.rPGMantenimiento});
            this.rPMantenimiento.Name = "rPMantenimiento";
            this.rPMantenimiento.Text = "Mantenimiento";
            // 
            // rPGMantenimiento
            // 
            this.rPGMantenimiento.ItemLinks.Add(this.barButtonUsuarios);
            this.rPGMantenimiento.Name = "rPGMantenimiento";
            this.rPGMantenimiento.ShowCaptionButton = false;
            // 
            // repositoryItemTimeEdit1
            // 
            this.repositoryItemTimeEdit1.AutoHeight = false;
            this.repositoryItemTimeEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemTimeEdit1.Name = "repositoryItemTimeEdit1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 700);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1282, 31);
            this.ribbonStatusBar.Visible = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1282, 731);
            this.Controls.Add(this.ribbon);
            this.Controls.Add(this.ribbonStatusBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1250, 500);
            this.Name = "frmPrincipal";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "-\'- Boutique -\'-";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTimeEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.BarButtonItem barBotonVenta;
        private DevExpress.XtraBars.BarButtonItem barBotonInventario;
        private DevExpress.XtraBars.BarButtonItem barBotonIngreso;
        private DevExpress.XtraBars.BarButtonItem barBotonMerma;
        private DevExpress.XtraBars.BarButtonItem barBotonClientes;
        private DevExpress.XtraBars.BarButtonItem barBotonVerInventario;
        private DevExpress.XtraBars.BarButtonItem barButtonUsuarios;
        private DevExpress.XtraBars.BarButtonItem barBotonIngresos;
        private DevExpress.XtraBars.BarButtonItem barBtnMerma;
        private DevExpress.XtraBars.BarButtonItem barBtnVentas;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPVentas;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rPGVentas;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPInventario;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rPGInventario;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPClientes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rPGClientes;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPReportes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rPGReportes;
        private DevExpress.XtraBars.Ribbon.RibbonPage rPMantenimiento;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup rPGMantenimiento;
        private DevExpress.XtraEditors.Repository.RepositoryItemTimeEdit repositoryItemTimeEdit1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barBtnCreditos;
        private DevExpress.XtraBars.BarButtonItem barBtnPagoCreditos;
        private DevExpress.XtraBars.BarButtonItem barBtnRanking;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
    }
}