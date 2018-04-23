namespace XRPivotGridEvents {
    partial class XtraReport1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPivotGrid1 = new DevExpress.XtraReports.UI.XRPivotGrid();
            this.salesPersonTableAdapter = new XRPivotGridEvents.nwindDataSetTableAdapters.SalesPersonTableAdapter();
            this.nwindDataSet1 = new XRPivotGridEvents.nwindDataSet();
            this.fieldOrderID = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCountry = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldFirstName = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldLastName = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldProductName = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldCategoryName = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldOrderDate = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldUnitPrice = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldQuantity = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldDiscount = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldExtendedPrice = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.fieldSalesPerson = new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPivotGrid1});
            this.Detail.HeightF = 74F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrPivotGrid1
            // 
            this.xrPivotGrid1.DataAdapter = this.salesPersonTableAdapter;
            this.xrPivotGrid1.DataMember = "SalesPerson";
            this.xrPivotGrid1.DataSource = this.nwindDataSet1;

            this.xrPivotGrid1.Fields.AddRange(new DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField[] {
            this.fieldOrderID,
            this.fieldCountry,
            this.fieldFirstName,
            this.fieldLastName,
            this.fieldProductName,
            this.fieldCategoryName,
            this.fieldOrderDate,
            this.fieldUnitPrice,
            this.fieldQuantity,
            this.fieldDiscount,
            this.fieldExtendedPrice,
            this.fieldSalesPerson});
            
            this.xrPivotGrid1.LocationFloat = new DevExpress.Utils.PointFloat(10.00001F, 10.00001F);
            this.xrPivotGrid1.Name = "xrPivotGrid1";
            this.xrPivotGrid1.SizeF = new System.Drawing.SizeF(215F, 50F);
            
            this.xrPivotGrid1.PrintHeader += new System.EventHandler<DevExpress.XtraReports.UI.PivotGrid.CustomExportHeaderEventArgs>(this.xrPivotGrid1_PrintHeader);
            this.xrPivotGrid1.PrintFieldValue += new System.EventHandler<DevExpress.XtraReports.UI.PivotGrid.CustomExportFieldValueEventArgs>(this.xrPivotGrid1_PrintFieldValue);
            this.xrPivotGrid1.PrintCell += new System.EventHandler<DevExpress.XtraReports.UI.PivotGrid.CustomExportCellEventArgs>(this.xrPivotGrid1_PrintCell);


            // 
            // salesPersonTableAdapter
            // 
            this.salesPersonTableAdapter.ClearBeforeFill = true;
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fieldOrderID
            // 
            this.fieldOrderID.AreaIndex = 0;
            this.fieldOrderID.Caption = "Order ID";
            this.fieldOrderID.FieldName = "OrderID";
            this.fieldOrderID.Name = "fieldOrderID";
            // 
            // fieldCountry
            // 
            this.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldCountry.AreaIndex = 0;
            this.fieldCountry.Caption = "Country";
            this.fieldCountry.FieldName = "Country";
            this.fieldCountry.Name = "fieldCountry";
            // 
            // fieldFirstName
            // 
            this.fieldFirstName.AreaIndex = 1;
            this.fieldFirstName.Caption = "First Name";
            this.fieldFirstName.FieldName = "FirstName";
            this.fieldFirstName.Name = "fieldFirstName";
            // 
            // fieldLastName
            // 
            this.fieldLastName.AreaIndex = 2;
            this.fieldLastName.Caption = "Last Name";
            this.fieldLastName.FieldName = "LastName";
            this.fieldLastName.Name = "fieldLastName";
            // 
            // fieldProductName
            // 
            this.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldProductName.AreaIndex = 1;
            this.fieldProductName.Caption = "Product Name";
            this.fieldProductName.FieldName = "ProductName";
            this.fieldProductName.Name = "fieldProductName";
            // 
            // fieldCategoryName
            // 
            this.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea;
            this.fieldCategoryName.AreaIndex = 0;
            this.fieldCategoryName.Caption = "Category Name";
            this.fieldCategoryName.FieldName = "CategoryName";
            this.fieldCategoryName.Name = "fieldCategoryName";
            // 
            // fieldOrderDate
            // 
            this.fieldOrderDate.AreaIndex = 3;
            this.fieldOrderDate.Caption = "Order Date";
            this.fieldOrderDate.FieldName = "OrderDate";
            this.fieldOrderDate.Name = "fieldOrderDate";
            // 
            // fieldUnitPrice
            // 
            this.fieldUnitPrice.AreaIndex = 4;
            this.fieldUnitPrice.Caption = "Unit Price";
            this.fieldUnitPrice.FieldName = "UnitPrice";
            this.fieldUnitPrice.Name = "fieldUnitPrice";
            // 
            // fieldQuantity
            // 
            this.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldQuantity.AreaIndex = 0;
            this.fieldQuantity.Caption = "Quantity";
            this.fieldQuantity.FieldName = "Quantity";
            this.fieldQuantity.Name = "fieldQuantity";
            // 
            // fieldDiscount
            // 
            this.fieldDiscount.AreaIndex = 5;
            this.fieldDiscount.Caption = "Discount";
            this.fieldDiscount.FieldName = "Discount";
            this.fieldDiscount.Name = "fieldDiscount";
            // 
            // fieldExtendedPrice
            // 
            this.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea;
            this.fieldExtendedPrice.AreaIndex = 1;
            this.fieldExtendedPrice.Caption = "Extended Price";
            this.fieldExtendedPrice.FieldName = "Extended Price";
            this.fieldExtendedPrice.Name = "fieldExtendedPrice";
            // 
            // fieldSalesPerson
            // 
            this.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea;
            this.fieldSalesPerson.AreaIndex = 1;
            this.fieldSalesPerson.Caption = "Sales Person";
            this.fieldSalesPerson.FieldName = "Sales Person";
            this.fieldSalesPerson.Name = "fieldSalesPerson";
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // XtraReport1
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Version = "9.3";
            this.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart;
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }


        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPivotGrid xrPivotGrid1;
        private XRPivotGridEvents.nwindDataSetTableAdapters.SalesPersonTableAdapter salesPersonTableAdapter;
        private nwindDataSet nwindDataSet1;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldOrderID;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCountry;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldFirstName;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldLastName;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldProductName;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldCategoryName;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldOrderDate;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldUnitPrice;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldQuantity;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldDiscount;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldExtendedPrice;
        private DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField fieldSalesPerson;
    }
}
