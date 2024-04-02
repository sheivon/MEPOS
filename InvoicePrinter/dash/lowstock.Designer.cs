namespace InvoicePrinter.dash
{
    partial class lowstock
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
            this.components = new System.ComponentModel.Container();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
            this.VerticalDetail = new DevExpress.XtraReports.UI.VerticalDetailBand();
            this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.GroupData1 = new DevExpress.XtraReports.UI.XRControlStyle();
            this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1VerticalFirstRow = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1VerticalLastRow = new DevExpress.XtraReports.UI.XRControlStyle();
            this.DetailData1VerticalRow_Even = new DevExpress.XtraReports.UI.XRControlStyle();
            this.HeaderData1VerticalFirstRow = new DevExpress.XtraReports.UI.XRControlStyle();
            this.HeaderData1VerticalLastRow = new DevExpress.XtraReports.UI.XRControlStyle();
            this.HeaderData1VerticalRow_Even = new DevExpress.XtraReports.UI.XRControlStyle();
            this.objectDataSource1 = new DevExpress.DataAccess.ObjectBinding.ObjectDataSource(this.components);
            this.xrPictureBox1 = new DevExpress.XtraReports.UI.XRPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // TopMargin
            // 
            this.TopMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPictureBox1});
            this.TopMargin.Name = "TopMargin";
            // 
            // BottomMargin
            // 
            this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
            this.BottomMargin.Name = "BottomMargin";
            // 
            // pageInfo1
            // 
            this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
            this.pageInfo1.Name = "pageInfo1";
            this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
            this.pageInfo1.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.pageInfo1.StyleName = "PageInfo";
            // 
            // pageInfo2
            // 
            this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(325F, 0F);
            this.pageInfo2.Name = "pageInfo2";
            this.pageInfo2.SizeF = new System.Drawing.SizeF(325F, 23F);
            this.pageInfo2.StyleName = "PageInfo";
            this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
            this.pageInfo2.TextFormatString = "Page {0} of {1}";
            // 
            // VerticalDetail
            // 
            this.VerticalDetail.HeightF = 84F;
            this.VerticalDetail.KeepTogether = true;
            this.VerticalDetail.Name = "VerticalDetail";
            this.VerticalDetail.WidthF = 46.57285F;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.BorderColor = System.Drawing.Color.Black;
            this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
            this.Title.BorderWidth = 1F;
            this.Title.Font = new DevExpress.Drawing.DXFont("Arial", 14.25F);
            this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.Title.Name = "Title";
            this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // GroupCaption1
            // 
            this.GroupCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.GroupCaption1.BorderColor = System.Drawing.Color.White;
            this.GroupCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupCaption1.BorderWidth = 2F;
            this.GroupCaption1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupCaption1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(228)))), ((int)(((byte)(228)))));
            this.GroupCaption1.Name = "GroupCaption1";
            this.GroupCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // GroupData1
            // 
            this.GroupData1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(51)))), ((int)(((byte)(91)))));
            this.GroupData1.BorderColor = System.Drawing.Color.White;
            this.GroupData1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom;
            this.GroupData1.BorderWidth = 2F;
            this.GroupData1.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.GroupData1.ForeColor = System.Drawing.Color.White;
            this.GroupData1.Name = "GroupData1";
            this.GroupData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 2, 0, 0, 100F);
            this.GroupData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // PageInfo
            // 
            this.PageInfo.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
            this.PageInfo.Name = "PageInfo";
            this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            // 
            // DetailData1VerticalFirstRow
            // 
            this.DetailData1VerticalFirstRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.DetailData1VerticalFirstRow.BorderColor = System.Drawing.Color.White;
            this.DetailData1VerticalFirstRow.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.DetailData1VerticalFirstRow.BorderWidth = 2F;
            this.DetailData1VerticalFirstRow.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData1VerticalFirstRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DetailData1VerticalFirstRow.Name = "DetailData1VerticalFirstRow";
            this.DetailData1VerticalFirstRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1VerticalFirstRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1VerticalLastRow
            // 
            this.DetailData1VerticalLastRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
            this.DetailData1VerticalLastRow.BorderColor = System.Drawing.Color.White;
            this.DetailData1VerticalLastRow.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.DetailData1VerticalLastRow.BorderWidth = 2F;
            this.DetailData1VerticalLastRow.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData1VerticalLastRow.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DetailData1VerticalLastRow.Name = "DetailData1VerticalLastRow";
            this.DetailData1VerticalLastRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1VerticalLastRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // DetailData1VerticalRow_Even
            // 
            this.DetailData1VerticalRow_Even.BackColor = System.Drawing.Color.Transparent;
            this.DetailData1VerticalRow_Even.BorderColor = System.Drawing.Color.White;
            this.DetailData1VerticalRow_Even.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.DetailData1VerticalRow_Even.BorderWidth = 2F;
            this.DetailData1VerticalRow_Even.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F);
            this.DetailData1VerticalRow_Even.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.DetailData1VerticalRow_Even.Name = "DetailData1VerticalRow_Even";
            this.DetailData1VerticalRow_Even.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.DetailData1VerticalRow_Even.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // HeaderData1VerticalFirstRow
            // 
            this.HeaderData1VerticalFirstRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(73)))), ((int)(((byte)(114)))));
            this.HeaderData1VerticalFirstRow.BorderColor = System.Drawing.Color.White;
            this.HeaderData1VerticalFirstRow.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Top | DevExpress.XtraPrinting.BorderSide.Right)));
            this.HeaderData1VerticalFirstRow.BorderWidth = 2F;
            this.HeaderData1VerticalFirstRow.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.HeaderData1VerticalFirstRow.ForeColor = System.Drawing.Color.White;
            this.HeaderData1VerticalFirstRow.Name = "HeaderData1VerticalFirstRow";
            this.HeaderData1VerticalFirstRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.HeaderData1VerticalFirstRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // HeaderData1VerticalLastRow
            // 
            this.HeaderData1VerticalLastRow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(73)))), ((int)(((byte)(114)))));
            this.HeaderData1VerticalLastRow.BorderColor = System.Drawing.Color.White;
            this.HeaderData1VerticalLastRow.Borders = ((DevExpress.XtraPrinting.BorderSide)((DevExpress.XtraPrinting.BorderSide.Right | DevExpress.XtraPrinting.BorderSide.Bottom)));
            this.HeaderData1VerticalLastRow.BorderWidth = 2F;
            this.HeaderData1VerticalLastRow.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.HeaderData1VerticalLastRow.ForeColor = System.Drawing.Color.White;
            this.HeaderData1VerticalLastRow.Name = "HeaderData1VerticalLastRow";
            this.HeaderData1VerticalLastRow.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.HeaderData1VerticalLastRow.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // HeaderData1VerticalRow_Even
            // 
            this.HeaderData1VerticalRow_Even.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(105)))), ((int)(((byte)(141)))));
            this.HeaderData1VerticalRow_Even.BorderColor = System.Drawing.Color.White;
            this.HeaderData1VerticalRow_Even.Borders = DevExpress.XtraPrinting.BorderSide.Right;
            this.HeaderData1VerticalRow_Even.BorderWidth = 2F;
            this.HeaderData1VerticalRow_Even.Font = new DevExpress.Drawing.DXFont("Arial", 8.25F, DevExpress.Drawing.DXFontStyle.Bold);
            this.HeaderData1VerticalRow_Even.ForeColor = System.Drawing.Color.White;
            this.HeaderData1VerticalRow_Even.Name = "HeaderData1VerticalRow_Even";
            this.HeaderData1VerticalRow_Even.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
            this.HeaderData1VerticalRow_Even.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
            // 
            // objectDataSource1
            // 
            this.objectDataSource1.DataMember = "GetProductsLow";
            this.objectDataSource1.DataSource = typeof(DataBase.DataModule);
            this.objectDataSource1.Name = "objectDataSource1";
            // 
            // xrPictureBox1
            // 
            this.xrPictureBox1.ImageSource = new DevExpress.XtraPrinting.Drawing.ImageSource(global::InvoicePrinter.Properties.Resources.Marshell1, true);
            this.xrPictureBox1.LocationFloat = new DevExpress.Utils.PointFloat(20.83333F, 0F);
            this.xrPictureBox1.Name = "xrPictureBox1";
            this.xrPictureBox1.SizeF = new System.Drawing.SizeF(100F, 100F);
            this.xrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.ZoomImage;
            // 
            // lowstock
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.VerticalDetail});
            this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.objectDataSource1});
            this.DataSource = this.objectDataSource1;
            this.Font = new DevExpress.Drawing.DXFont("Arial", 9.75F);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.GroupCaption1,
            this.GroupData1,
            this.PageInfo,
            this.DetailData1VerticalFirstRow,
            this.DetailData1VerticalLastRow,
            this.DetailData1VerticalRow_Even,
            this.HeaderData1VerticalFirstRow,
            this.HeaderData1VerticalLastRow,
            this.HeaderData1VerticalRow_Even});
            this.Version = "22.2";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this.objectDataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
        private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
        private DevExpress.XtraReports.UI.VerticalDetailBand VerticalDetail;
        private DevExpress.DataAccess.ObjectBinding.ObjectDataSource objectDataSource1;
        private DevExpress.XtraReports.UI.XRControlStyle Title;
        private DevExpress.XtraReports.UI.XRControlStyle GroupCaption1;
        private DevExpress.XtraReports.UI.XRControlStyle GroupData1;
        private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1VerticalFirstRow;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1VerticalLastRow;
        private DevExpress.XtraReports.UI.XRControlStyle DetailData1VerticalRow_Even;
        private DevExpress.XtraReports.UI.XRControlStyle HeaderData1VerticalFirstRow;
        private DevExpress.XtraReports.UI.XRControlStyle HeaderData1VerticalLastRow;
        private DevExpress.XtraReports.UI.XRControlStyle HeaderData1VerticalRow_Even;
        private DevExpress.XtraReports.UI.XRPictureBox xrPictureBox1;
    }
}
