namespace Boutique.Reportes
{
    partial class rptComprobante
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraReports.UI.XRSummary xrSummary1 = new DevExpress.XtraReports.UI.XRSummary();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrTable1 = new DevExpress.XtraReports.UI.XRTable();
            this.xrTableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
            this.codigo = new DevExpress.XtraReports.UI.XRTableCell();
            this.descripcion = new DevExpress.XtraReports.UI.XRTableCell();
            this.valor = new DevExpress.XtraReports.UI.XRTableCell();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.nit = new DevExpress.XtraReports.UI.XRLabel();
            this.direccion = new DevExpress.XtraReports.UI.XRLabel();
            this.nombre = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.PageFooter = new DevExpress.XtraReports.UI.PageFooterBand();
            this.total = new DevExpress.XtraReports.UI.XRLabel();
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrTable1});
            this.Detail.HeightF = 23.95833F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrTable1
            // 
            this.xrTable1.LocationFloat = new DevExpress.Utils.PointFloat(10.75001F, 0F);
            this.xrTable1.Name = "xrTable1";
            this.xrTable1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.xrTableRow1});
            this.xrTable1.SizeF = new System.Drawing.SizeF(456.25F, 19.16667F);
            // 
            // xrTableRow1
            // 
            this.xrTableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.codigo,
            this.descripcion,
            this.valor});
            this.xrTableRow1.Name = "xrTableRow1";
            this.xrTableRow1.Weight = 1D;
            // 
            // codigo
            // 
            this.codigo.Name = "codigo";
            this.codigo.StylePriority.UseTextAlignment = false;
            this.codigo.Text = "codigo";
            this.codigo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.codigo.Weight = 0.76458344138224088D;
            // 
            // descripcion
            // 
            this.descripcion.Name = "descripcion";
            this.descripcion.Text = "descripcion";
            this.descripcion.Weight = 2.2708323892004718D;
            // 
            // valor
            // 
            this.valor.Name = "valor";
            this.valor.StylePriority.UseTextAlignment = false;
            this.valor.Text = "valor";
            this.valor.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
            this.valor.Weight = 1.8083341939907842D;
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.nit,
            this.direccion,
            this.nombre,
            this.xrPageInfo1});
            this.TopMargin.HeightF = 314F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // nit
            // 
            this.nit.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.nit.LocationFloat = new DevExpress.Utils.PointFloat(357F, 237.6251F);
            this.nit.Name = "nit";
            this.nit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.nit.SizeF = new System.Drawing.SizeF(106.875F, 22.99997F);
            this.nit.StylePriority.UseFont = false;
            this.nit.Text = "nit";
            // 
            // direccion
            // 
            this.direccion.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.direccion.LocationFloat = new DevExpress.Utils.PointFloat(92.33344F, 242.625F);
            this.direccion.Name = "direccion";
            this.direccion.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.direccion.SizeF = new System.Drawing.SizeF(204.1666F, 23.00001F);
            this.direccion.StylePriority.UseFont = false;
            this.direccion.Text = "direccion";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.nombre.LocationFloat = new DevExpress.Utils.PointFloat(92.33344F, 207.125F);
            this.nombre.Name = "nombre";
            this.nombre.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.nombre.SizeF = new System.Drawing.SizeF(319.7916F, 23F);
            this.nombre.StylePriority.UseFont = false;
            this.nombre.Text = "nombre";
            // 
            // xrPageInfo1
            // 
            this.xrPageInfo1.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.xrPageInfo1.Format = "{0:d\' de \'MMMM\' de \'yyyy}";
            this.xrPageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(23.25F, 168.0417F);
            this.xrPageInfo1.Name = "xrPageInfo1";
            this.xrPageInfo1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrPageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.xrPageInfo1.SizeF = new System.Drawing.SizeF(130.8333F, 23F);
            this.xrPageInfo1.StylePriority.UseFont = false;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 12.20843F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // PageFooter
            // 
            this.PageFooter.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.total});
            this.PageFooter.HeightF = 110.1249F;
            this.PageFooter.Name = "PageFooter";
            // 
            // total
            // 
            this.total.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.LocationFloat = new DevExpress.Utils.PointFloat(391.0833F, 0F);
            this.total.Name = "total";
            this.total.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.total.SizeF = new System.Drawing.SizeF(82.91669F, 19.16656F);
            this.total.StylePriority.UseFont = false;
            this.total.StylePriority.UsePadding = false;
            this.total.StylePriority.UseTextAlignment = false;
            xrSummary1.FormatString = "{0:c}";
            this.total.Summary = xrSummary1;
            this.total.Text = "total";
            this.total.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            // 
            // rptComprobante
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.PageFooter});
            this.DisplayName = "Comprobante";
            this.Margins = new System.Drawing.Printing.Margins(26, 26, 314, 12);
            this.PageHeight = 910;
            this.PageWidth = 529;
            this.PaperKind = System.Drawing.Printing.PaperKind.Custom;
            this.ShowPreviewMarginLines = false;
            this.ShowPrintMarginsWarning = false;
            this.Version = "12.1";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this.xrTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRTable xrTable1;
        private DevExpress.XtraReports.UI.XRTableRow xrTableRow1;
        public DevExpress.XtraReports.UI.XRTableCell codigo;
        public DevExpress.XtraReports.UI.XRTableCell descripcion;
        public DevExpress.XtraReports.UI.XRTableCell valor;
        private DevExpress.XtraReports.UI.PageFooterBand PageFooter;
        public DevExpress.XtraReports.UI.XRLabel total;
        protected internal DevExpress.XtraReports.UI.XRLabel nit;
        protected internal DevExpress.XtraReports.UI.XRLabel direccion;
        protected internal DevExpress.XtraReports.UI.XRLabel nombre;
        public DevExpress.XtraReports.UI.XRPageInfo xrPageInfo1;
    }
}
