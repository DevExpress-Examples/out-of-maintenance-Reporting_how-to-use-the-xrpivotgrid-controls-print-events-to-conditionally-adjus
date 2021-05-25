Imports Microsoft.VisualBasic
Imports System
Namespace XRPivotGridEvents
	Partial Public Class XtraReport1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary> 
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.xrPivotGrid1 = New DevExpress.XtraReports.UI.XRPivotGrid()
			Me.salesPersonTableAdapter = New nwindDataSetTableAdapters.SalesPersonTableAdapter()
			Me.nwindDataSet1 = New nwindDataSet()
			Me.fieldOrderID = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldCountry = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldFirstName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldLastName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldProductName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldCategoryName = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldOrderDate = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldUnitPrice = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldQuantity = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldDiscount = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldExtendedPrice = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.fieldSalesPerson = New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrPivotGrid1})
			Me.Detail.HeightF = 74F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrPivotGrid1
			' 
			Me.xrPivotGrid1.DataAdapter = Me.salesPersonTableAdapter
			Me.xrPivotGrid1.DataMember = "SalesPerson"
			Me.xrPivotGrid1.DataSource = Me.nwindDataSet1

			Me.xrPivotGrid1.Fields.AddRange(New DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField() { Me.fieldOrderID, Me.fieldCountry, Me.fieldFirstName, Me.fieldLastName, Me.fieldProductName, Me.fieldCategoryName, Me.fieldOrderDate, Me.fieldUnitPrice, Me.fieldQuantity, Me.fieldDiscount, Me.fieldExtendedPrice, Me.fieldSalesPerson})

			Me.xrPivotGrid1.LocationFloat = New DevExpress.Utils.PointFloat(10.00001F, 10.00001F)
			Me.xrPivotGrid1.Name = "xrPivotGrid1"
			Me.xrPivotGrid1.SizeF = New System.Drawing.SizeF(215F, 50F)

'			Me.xrPivotGrid1.PrintHeader += New System.EventHandler(Of DevExpress.XtraReports.UI.PivotGrid.CustomExportHeaderEventArgs)(Me.xrPivotGrid1_PrintHeader);
'			Me.xrPivotGrid1.PrintFieldValue += New System.EventHandler(Of DevExpress.XtraReports.UI.PivotGrid.CustomExportFieldValueEventArgs)(Me.xrPivotGrid1_PrintFieldValue);
'			Me.xrPivotGrid1.PrintCell += New System.EventHandler(Of DevExpress.XtraReports.UI.PivotGrid.CustomExportCellEventArgs)(Me.xrPivotGrid1_PrintCell);


			' 
			' salesPersonTableAdapter
			' 
			Me.salesPersonTableAdapter.ClearBeforeFill = True
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' fieldOrderID
			' 
			Me.fieldOrderID.AreaIndex = 0
			Me.fieldOrderID.Caption = "Order ID"
			Me.fieldOrderID.FieldName = "OrderID"
			Me.fieldOrderID.Name = "fieldOrderID"
			' 
			' fieldCountry
			' 
			Me.fieldCountry.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldCountry.AreaIndex = 0
			Me.fieldCountry.Caption = "Country"
			Me.fieldCountry.FieldName = "Country"
			Me.fieldCountry.Name = "fieldCountry"
			' 
			' fieldFirstName
			' 
			Me.fieldFirstName.AreaIndex = 1
			Me.fieldFirstName.Caption = "First Name"
			Me.fieldFirstName.FieldName = "FirstName"
			Me.fieldFirstName.Name = "fieldFirstName"
			' 
			' fieldLastName
			' 
			Me.fieldLastName.AreaIndex = 2
			Me.fieldLastName.Caption = "Last Name"
			Me.fieldLastName.FieldName = "LastName"
			Me.fieldLastName.Name = "fieldLastName"
			' 
			' fieldProductName
			' 
			Me.fieldProductName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldProductName.AreaIndex = 1
			Me.fieldProductName.Caption = "Product Name"
			Me.fieldProductName.FieldName = "ProductName"
			Me.fieldProductName.Name = "fieldProductName"
			' 
			' fieldCategoryName
			' 
			Me.fieldCategoryName.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
			Me.fieldCategoryName.AreaIndex = 0
			Me.fieldCategoryName.Caption = "Category Name"
			Me.fieldCategoryName.FieldName = "CategoryName"
			Me.fieldCategoryName.Name = "fieldCategoryName"
			' 
			' fieldOrderDate
			' 
			Me.fieldOrderDate.AreaIndex = 3
			Me.fieldOrderDate.Caption = "Order Date"
			Me.fieldOrderDate.FieldName = "OrderDate"
			Me.fieldOrderDate.Name = "fieldOrderDate"
			' 
			' fieldUnitPrice
			' 
			Me.fieldUnitPrice.AreaIndex = 4
			Me.fieldUnitPrice.Caption = "Unit Price"
			Me.fieldUnitPrice.FieldName = "UnitPrice"
			Me.fieldUnitPrice.Name = "fieldUnitPrice"
			' 
			' fieldQuantity
			' 
			Me.fieldQuantity.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldQuantity.AreaIndex = 0
			Me.fieldQuantity.Caption = "Quantity"
			Me.fieldQuantity.FieldName = "Quantity"
			Me.fieldQuantity.Name = "fieldQuantity"
			' 
			' fieldDiscount
			' 
			Me.fieldDiscount.AreaIndex = 5
			Me.fieldDiscount.Caption = "Discount"
			Me.fieldDiscount.FieldName = "Discount"
			Me.fieldDiscount.Name = "fieldDiscount"
			' 
			' fieldExtendedPrice
			' 
			Me.fieldExtendedPrice.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
			Me.fieldExtendedPrice.AreaIndex = 1
			Me.fieldExtendedPrice.Caption = "Extended Price"
			Me.fieldExtendedPrice.FieldName = "Extended Price"
			Me.fieldExtendedPrice.Name = "fieldExtendedPrice"
			' 
			' fieldSalesPerson
			' 
			Me.fieldSalesPerson.Area = DevExpress.XtraPivotGrid.PivotArea.ColumnArea
			Me.fieldSalesPerson.AreaIndex = 1
			Me.fieldSalesPerson.Caption = "Sales Person"
			Me.fieldSalesPerson.FieldName = "Sales Person"
			Me.fieldSalesPerson.Name = "fieldSalesPerson"
			' 
			' TopMargin
			' 
			Me.TopMargin.HeightF = 100F
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.HeightF = 100F
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
			Me.Version = "9.3"
			Me.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
			CType(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub


		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private WithEvents xrPivotGrid1 As DevExpress.XtraReports.UI.XRPivotGrid
		Private salesPersonTableAdapter As nwindDataSetTableAdapters.SalesPersonTableAdapter
		Private nwindDataSet1 As nwindDataSet
		Private fieldOrderID As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldCountry As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldFirstName As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldLastName As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldProductName As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldCategoryName As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldOrderDate As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldUnitPrice As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldQuantity As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldDiscount As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldExtendedPrice As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
		Private fieldSalesPerson As DevExpress.XtraReports.UI.PivotGrid.XRPivotGridField
	End Class
End Namespace
