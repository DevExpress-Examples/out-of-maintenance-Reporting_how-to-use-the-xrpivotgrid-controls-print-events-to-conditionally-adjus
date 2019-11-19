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
			Me.components = New System.ComponentModel.Container()
			Dim crossTabColumnDefinition1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(81.25F)
			Dim crossTabColumnDefinition2 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(81.25F)
			Dim crossTabColumnDefinition3 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(81.25F)
			Dim crossTabColumnDefinition4 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(81.25F)
			Dim crossTabColumnDefinition5 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(81.25F)
			Dim crossTabColumnDefinition6 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(81.25F)
			Dim crossTabColumnDefinition7 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(81.25F)
			Dim crossTabColumnDefinition8 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition(81.25F)
			Dim crossTabColumnField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField()
			Dim crossTabColumnField2 As New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField()
			Dim crossTabDataField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
			Dim crossTabDataField2 As New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField()
			Dim crossTabRowField1 As New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
			Dim crossTabRowField2 As New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField()
			Dim selectQuery1 As New DevExpress.DataAccess.Sql.SelectQuery()
			Dim column1 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression1 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim table1 As New DevExpress.DataAccess.Sql.Table()
			Dim column2 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression2 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column3 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression3 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column4 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression4 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column5 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression5 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column6 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression6 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column7 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression7 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column8 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression8 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column9 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression9 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column10 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression10 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column11 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression11 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim column12 As New DevExpress.DataAccess.Sql.Column()
			Dim columnExpression12 As New DevExpress.DataAccess.Sql.ColumnExpression()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(XtraReport1))
			Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
			Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
			Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
			Me.xrCrossTab1 = New DevExpress.XtraReports.UI.XRCrossTab()
			Me.xrCrossTabCell1 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell2 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell3 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell4 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell5 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell6 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell7 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell8 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell9 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell10 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell11 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell12 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell13 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell14 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell15 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell16 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell17 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell18 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell19 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell20 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell21 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell22 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell23 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell24 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell25 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell26 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell27 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell28 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell29 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell30 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell31 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell32 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell33 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.xrCrossTabCell34 = New DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell()
			Me.sqlDataSource1 = New DevExpress.DataAccess.Sql.SqlDataSource(Me.components)
			CType(Me.xrCrossTab1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' Detail
			' 
			Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCrossTab1})
			Me.Detail.HeightF = 150F
			Me.Detail.Name = "Detail"
			Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' TopMargin
			' 
			Me.TopMargin.Name = "TopMargin"
			Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' BottomMargin
			' 
			Me.BottomMargin.Name = "BottomMargin"
			Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
			Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
			' 
			' xrCrossTab1
			' 
			Me.xrCrossTab1.Cells.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrCrossTabCell1, Me.xrCrossTabCell2, Me.xrCrossTabCell3, Me.xrCrossTabCell4, Me.xrCrossTabCell5, Me.xrCrossTabCell6, Me.xrCrossTabCell7, Me.xrCrossTabCell8, Me.xrCrossTabCell9, Me.xrCrossTabCell10, Me.xrCrossTabCell11, Me.xrCrossTabCell12, Me.xrCrossTabCell13, Me.xrCrossTabCell14, Me.xrCrossTabCell15, Me.xrCrossTabCell16, Me.xrCrossTabCell17, Me.xrCrossTabCell18, Me.xrCrossTabCell19, Me.xrCrossTabCell20, Me.xrCrossTabCell21, Me.xrCrossTabCell22, Me.xrCrossTabCell23, Me.xrCrossTabCell24, Me.xrCrossTabCell25, Me.xrCrossTabCell26, Me.xrCrossTabCell27, Me.xrCrossTabCell28, Me.xrCrossTabCell29, Me.xrCrossTabCell30, Me.xrCrossTabCell31, Me.xrCrossTabCell32, Me.xrCrossTabCell33, Me.xrCrossTabCell34})
			crossTabColumnDefinition1.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			crossTabColumnDefinition2.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			crossTabColumnDefinition3.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			crossTabColumnDefinition4.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			crossTabColumnDefinition5.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			crossTabColumnDefinition6.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			crossTabColumnDefinition7.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			crossTabColumnDefinition8.AutoWidthMode = DevExpress.XtraReports.UI.AutoSizeMode.ShrinkAndGrow
			Me.xrCrossTab1.ColumnDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnDefinition() { crossTabColumnDefinition1, crossTabColumnDefinition2, crossTabColumnDefinition3, crossTabColumnDefinition4, crossTabColumnDefinition5, crossTabColumnDefinition6, crossTabColumnDefinition7, crossTabColumnDefinition8})
			crossTabColumnField1.FieldName = "Country"
			crossTabColumnField2.FieldName = "Sales Person"
			Me.xrCrossTab1.ColumnFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabColumnField() { crossTabColumnField1, crossTabColumnField2})
			crossTabDataField1.FieldName = "Quantity"
			crossTabDataField2.FieldName = "Extended Price"
			Me.xrCrossTab1.DataFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabDataField() { crossTabDataField1, crossTabDataField2})
			Me.xrCrossTab1.DataMember = "SalesPerson"
			Me.xrCrossTab1.DataSource = Me.sqlDataSource1
			Me.xrCrossTab1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
			Me.xrCrossTab1.Name = "xrCrossTab1"
			Me.xrCrossTab1.OriginalPivotGridLayout = resources.GetString("xrCrossTab1.OriginalPivotGridLayout")
			Me.xrCrossTab1.PrintOptions.PrintTotalsForSingleValues = False
			Me.xrCrossTab1.RowDefinitions.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition() {
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F),
				New DevExpress.XtraReports.UI.CrossTab.CrossTabRowDefinition(25F)
			})
			crossTabRowField1.FieldName = "CategoryName"
			crossTabRowField2.FieldName = "ProductName"
			Me.xrCrossTab1.RowFields.AddRange(New DevExpress.XtraReports.UI.CrossTab.CrossTabRowField() { crossTabRowField1, crossTabRowField2})
			Me.xrCrossTab1.SizeF = New System.Drawing.SizeF(650F, 150F)
			' 
			' xrCrossTabCell1
			' 
			Me.xrCrossTabCell1.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell1.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell1.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell1.BorderWidth = 1F
			Me.xrCrossTabCell1.ColumnIndex = 0
			Me.xrCrossTabCell1.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell1.Name = "xrCrossTabCell1"
			Me.xrCrossTabCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell1.RowIndex = 0
			Me.xrCrossTabCell1.RowSpan = 3
			Me.xrCrossTabCell1.Text = "Category Name"
			Me.xrCrossTabCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell2
			' 
			Me.xrCrossTabCell2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell2.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell2.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell2.BorderWidth = 1F
			Me.xrCrossTabCell2.ColumnIndex = 2
			Me.xrCrossTabCell2.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "Iif([Quantity] > 50, 'LightGreen', ?)")})
			Me.xrCrossTabCell2.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell2.Name = "xrCrossTabCell2"
			Me.xrCrossTabCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell2.RowIndex = 3
			Me.xrCrossTabCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell3
			' 
			Me.xrCrossTabCell3.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell3.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell3.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell3.BorderWidth = 1F
			Me.xrCrossTabCell3.ColumnIndex = 2
			Me.xrCrossTabCell3.ColumnSpan = 2
			Me.xrCrossTabCell3.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell3.Name = "xrCrossTabCell3"
			Me.xrCrossTabCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell3.RowIndex = 0
			Me.xrCrossTabCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell4
			' 
			Me.xrCrossTabCell4.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell4.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell4.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell4.BorderWidth = 1F
			Me.xrCrossTabCell4.ColumnIndex = 6
			Me.xrCrossTabCell4.ColumnSpan = 2
			Me.xrCrossTabCell4.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell4.Name = "xrCrossTabCell4"
			Me.xrCrossTabCell4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell4.RowIndex = 0
			Me.xrCrossTabCell4.RowSpan = 2
			Me.xrCrossTabCell4.Text = "Grand Total"
			Me.xrCrossTabCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell5
			' 
			Me.xrCrossTabCell5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell5.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell5.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell5.BorderWidth = 1F
			Me.xrCrossTabCell5.ColumnIndex = 6
			Me.xrCrossTabCell5.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell5.Name = "xrCrossTabCell5"
			Me.xrCrossTabCell5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell5.RowIndex = 3
			Me.xrCrossTabCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell6
			' 
			Me.xrCrossTabCell6.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell6.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell6.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell6.BorderWidth = 1F
			Me.xrCrossTabCell6.ColumnIndex = 0
			Me.xrCrossTabCell6.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() { New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "Iif([CategoryName]='Condiments', ?, 'Beige')")})
			Me.xrCrossTabCell6.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell6.Name = "xrCrossTabCell6"
			Me.xrCrossTabCell6.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell6.RowIndex = 3
			Me.xrCrossTabCell6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell7
			' 
			Me.xrCrossTabCell7.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell7.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell7.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell7.BorderWidth = 1F
			Me.xrCrossTabCell7.ColumnIndex = 0
			Me.xrCrossTabCell7.ColumnSpan = 2
			Me.xrCrossTabCell7.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell7.Name = "xrCrossTabCell7"
			Me.xrCrossTabCell7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell7.RowIndex = 5
			Me.xrCrossTabCell7.Text = "Grand Total"
			Me.xrCrossTabCell7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell8
			' 
			Me.xrCrossTabCell8.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell8.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell8.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell8.BorderWidth = 1F
			Me.xrCrossTabCell8.ColumnIndex = 2
			Me.xrCrossTabCell8.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell8.Name = "xrCrossTabCell8"
			Me.xrCrossTabCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell8.RowIndex = 5
			Me.xrCrossTabCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell9
			' 
			Me.xrCrossTabCell9.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell9.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell9.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell9.BorderWidth = 1F
			Me.xrCrossTabCell9.ColumnIndex = 6
			Me.xrCrossTabCell9.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell9.Name = "xrCrossTabCell9"
			Me.xrCrossTabCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell9.RowIndex = 5
			Me.xrCrossTabCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell10
			' 
			Me.xrCrossTabCell10.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell10.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell10.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell10.BorderWidth = 1F
			Me.xrCrossTabCell10.ColumnIndex = 1
			Me.xrCrossTabCell10.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell10.Name = "xrCrossTabCell10"
			Me.xrCrossTabCell10.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell10.RowIndex = 0
			Me.xrCrossTabCell10.RowSpan = 3
			Me.xrCrossTabCell10.Text = "Product Name"
			Me.xrCrossTabCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell11
			' 
			Me.xrCrossTabCell11.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell11.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell11.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell11.BorderWidth = 1F
			Me.xrCrossTabCell11.ColumnIndex = 1
			Me.xrCrossTabCell11.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell11.Name = "xrCrossTabCell11"
			Me.xrCrossTabCell11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell11.RowIndex = 3
			Me.xrCrossTabCell11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell12
			' 
			Me.xrCrossTabCell12.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell12.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell12.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell12.BorderWidth = 1F
			Me.xrCrossTabCell12.ColumnIndex = 0
			Me.xrCrossTabCell12.ColumnSpan = 2
			Me.xrCrossTabCell12.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell12.Name = "xrCrossTabCell12"
			Me.xrCrossTabCell12.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell12.RowIndex = 4
			Me.xrCrossTabCell12.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrCrossTabCell12.TextFormatString = "{0} Total"
			' 
			' xrCrossTabCell13
			' 
			Me.xrCrossTabCell13.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell13.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell13.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell13.BorderWidth = 1F
			Me.xrCrossTabCell13.ColumnIndex = 2
			Me.xrCrossTabCell13.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell13.Name = "xrCrossTabCell13"
			Me.xrCrossTabCell13.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell13.RowIndex = 4
			Me.xrCrossTabCell13.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell14
			' 
			Me.xrCrossTabCell14.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell14.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell14.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell14.BorderWidth = 1F
			Me.xrCrossTabCell14.ColumnIndex = 6
			Me.xrCrossTabCell14.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell14.Name = "xrCrossTabCell14"
			Me.xrCrossTabCell14.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell14.RowIndex = 4
			Me.xrCrossTabCell14.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell15
			' 
			Me.xrCrossTabCell15.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell15.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell15.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell15.BorderWidth = 1F
			Me.xrCrossTabCell15.ColumnIndex = 2
			Me.xrCrossTabCell15.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell15.Name = "xrCrossTabCell15"
			Me.xrCrossTabCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell15.RowIndex = 2
			Me.xrCrossTabCell15.Text = "Quantity"
			Me.xrCrossTabCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell16
			' 
			Me.xrCrossTabCell16.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell16.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell16.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell16.BorderWidth = 1F
			Me.xrCrossTabCell16.ColumnIndex = 3
			Me.xrCrossTabCell16.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell16.Name = "xrCrossTabCell16"
			Me.xrCrossTabCell16.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell16.RowIndex = 2
			Me.xrCrossTabCell16.Text = "Extended Price"
			Me.xrCrossTabCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrCrossTabCell16.TextFormatString = "{0:c}"
			' 
			' xrCrossTabCell17
			' 
			Me.xrCrossTabCell17.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell17.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell17.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell17.BorderWidth = 1F
			Me.xrCrossTabCell17.ColumnIndex = 6
			Me.xrCrossTabCell17.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell17.Name = "xrCrossTabCell17"
			Me.xrCrossTabCell17.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell17.RowIndex = 2
			Me.xrCrossTabCell17.Text = "Quantity"
			Me.xrCrossTabCell17.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell18
			' 
			Me.xrCrossTabCell18.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell18.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell18.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell18.BorderWidth = 1F
			Me.xrCrossTabCell18.ColumnIndex = 7
			Me.xrCrossTabCell18.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell18.Name = "xrCrossTabCell18"
			Me.xrCrossTabCell18.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell18.RowIndex = 2
			Me.xrCrossTabCell18.Text = "Extended Price"
			Me.xrCrossTabCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrCrossTabCell18.TextFormatString = "{0:c}"
			' 
			' xrCrossTabCell19
			' 
			Me.xrCrossTabCell19.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell19.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell19.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell19.BorderWidth = 1F
			Me.xrCrossTabCell19.ColumnIndex = 3
			Me.xrCrossTabCell19.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell19.Name = "xrCrossTabCell19"
			Me.xrCrossTabCell19.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell19.RowIndex = 3
			Me.xrCrossTabCell19.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrCrossTabCell19.TextFormatString = "{0:c}"
			' 
			' xrCrossTabCell20
			' 
			Me.xrCrossTabCell20.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell20.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell20.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell20.BorderWidth = 1F
			Me.xrCrossTabCell20.ColumnIndex = 7
			Me.xrCrossTabCell20.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell20.Name = "xrCrossTabCell20"
			Me.xrCrossTabCell20.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell20.RowIndex = 3
			Me.xrCrossTabCell20.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrCrossTabCell20.TextFormatString = "{0:c}"
			' 
			' xrCrossTabCell21
			' 
			Me.xrCrossTabCell21.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell21.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell21.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell21.BorderWidth = 1F
			Me.xrCrossTabCell21.ColumnIndex = 3
			Me.xrCrossTabCell21.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell21.Name = "xrCrossTabCell21"
			Me.xrCrossTabCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell21.RowIndex = 4
			Me.xrCrossTabCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrCrossTabCell21.TextFormatString = "{0:c}"
			' 
			' xrCrossTabCell22
			' 
			Me.xrCrossTabCell22.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell22.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell22.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell22.BorderWidth = 1F
			Me.xrCrossTabCell22.ColumnIndex = 3
			Me.xrCrossTabCell22.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell22.Name = "xrCrossTabCell22"
			Me.xrCrossTabCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell22.RowIndex = 5
			Me.xrCrossTabCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrCrossTabCell22.TextFormatString = "{0:c}"
			' 
			' xrCrossTabCell23
			' 
			Me.xrCrossTabCell23.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell23.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell23.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell23.BorderWidth = 1F
			Me.xrCrossTabCell23.ColumnIndex = 7
			Me.xrCrossTabCell23.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell23.Name = "xrCrossTabCell23"
			Me.xrCrossTabCell23.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell23.RowIndex = 4
			Me.xrCrossTabCell23.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrCrossTabCell23.TextFormatString = "{0:c}"
			' 
			' xrCrossTabCell24
			' 
			Me.xrCrossTabCell24.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell24.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell24.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell24.BorderWidth = 1F
			Me.xrCrossTabCell24.ColumnIndex = 7
			Me.xrCrossTabCell24.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell24.Name = "xrCrossTabCell24"
			Me.xrCrossTabCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell24.RowIndex = 5
			Me.xrCrossTabCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrCrossTabCell24.TextFormatString = "{0:c}"
			' 
			' xrCrossTabCell25
			' 
			Me.xrCrossTabCell25.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell25.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell25.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell25.BorderWidth = 1F
			Me.xrCrossTabCell25.ColumnIndex = 4
			Me.xrCrossTabCell25.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell25.Name = "xrCrossTabCell25"
			Me.xrCrossTabCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell25.RowIndex = 2
			Me.xrCrossTabCell25.Text = "Quantity"
			Me.xrCrossTabCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell26
			' 
			Me.xrCrossTabCell26.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell26.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell26.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell26.BorderWidth = 1F
			Me.xrCrossTabCell26.ColumnIndex = 5
			Me.xrCrossTabCell26.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell26.Name = "xrCrossTabCell26"
			Me.xrCrossTabCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell26.RowIndex = 2
			Me.xrCrossTabCell26.Text = "Extended Price"
			Me.xrCrossTabCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrCrossTabCell26.TextFormatString = "{0:c}"
			' 
			' xrCrossTabCell27
			' 
			Me.xrCrossTabCell27.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell27.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell27.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell27.BorderWidth = 1F
			Me.xrCrossTabCell27.ColumnIndex = 2
			Me.xrCrossTabCell27.ColumnSpan = 2
			Me.xrCrossTabCell27.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell27.Name = "xrCrossTabCell27"
			Me.xrCrossTabCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell27.RowIndex = 1
			Me.xrCrossTabCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			' 
			' xrCrossTabCell28
			' 
			Me.xrCrossTabCell28.BackColor = System.Drawing.SystemColors.Control
			Me.xrCrossTabCell28.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell28.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell28.BorderWidth = 1F
			Me.xrCrossTabCell28.ColumnIndex = 4
			Me.xrCrossTabCell28.ColumnSpan = 2
			Me.xrCrossTabCell28.ForeColor = System.Drawing.SystemColors.ControlText
			Me.xrCrossTabCell28.Name = "xrCrossTabCell28"
			Me.xrCrossTabCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell28.RowIndex = 0
			Me.xrCrossTabCell28.RowSpan = 2
			Me.xrCrossTabCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
			Me.xrCrossTabCell28.TextFormatString = "{0} Total"
			' 
			' xrCrossTabCell29
			' 
			Me.xrCrossTabCell29.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell29.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell29.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell29.BorderWidth = 1F
			Me.xrCrossTabCell29.ColumnIndex = 4
			Me.xrCrossTabCell29.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell29.Name = "xrCrossTabCell29"
			Me.xrCrossTabCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell29.RowIndex = 3
			Me.xrCrossTabCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell30
			' 
			Me.xrCrossTabCell30.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell30.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell30.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell30.BorderWidth = 1F
			Me.xrCrossTabCell30.ColumnIndex = 5
			Me.xrCrossTabCell30.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell30.Name = "xrCrossTabCell30"
			Me.xrCrossTabCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell30.RowIndex = 3
			Me.xrCrossTabCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrCrossTabCell30.TextFormatString = "{0:c}"
			' 
			' xrCrossTabCell31
			' 
			Me.xrCrossTabCell31.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell31.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell31.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell31.BorderWidth = 1F
			Me.xrCrossTabCell31.ColumnIndex = 4
			Me.xrCrossTabCell31.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell31.Name = "xrCrossTabCell31"
			Me.xrCrossTabCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell31.RowIndex = 4
			Me.xrCrossTabCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell32
			' 
			Me.xrCrossTabCell32.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell32.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell32.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell32.BorderWidth = 1F
			Me.xrCrossTabCell32.ColumnIndex = 5
			Me.xrCrossTabCell32.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell32.Name = "xrCrossTabCell32"
			Me.xrCrossTabCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell32.RowIndex = 4
			Me.xrCrossTabCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrCrossTabCell32.TextFormatString = "{0:c}"
			' 
			' xrCrossTabCell33
			' 
			Me.xrCrossTabCell33.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell33.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell33.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell33.BorderWidth = 1F
			Me.xrCrossTabCell33.ColumnIndex = 4
			Me.xrCrossTabCell33.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell33.Name = "xrCrossTabCell33"
			Me.xrCrossTabCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell33.RowIndex = 5
			Me.xrCrossTabCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			' 
			' xrCrossTabCell34
			' 
			Me.xrCrossTabCell34.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(255)))), (CInt((CByte(255)))))
			Me.xrCrossTabCell34.BorderColor = System.Drawing.SystemColors.ControlDark
			Me.xrCrossTabCell34.Borders = (CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
			Me.xrCrossTabCell34.BorderWidth = 1F
			Me.xrCrossTabCell34.ColumnIndex = 5
			Me.xrCrossTabCell34.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(0)))), (CInt((CByte(0)))))
			Me.xrCrossTabCell34.Name = "xrCrossTabCell34"
			Me.xrCrossTabCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F)
			Me.xrCrossTabCell34.RowIndex = 5
			Me.xrCrossTabCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
			Me.xrCrossTabCell34.TextFormatString = "{0:c}"
			' 
			' sqlDataSource1
			' 
			Me.sqlDataSource1.ConnectionName = "XRPivotGridEvents.Properties.Settings.nwindConnectionString"
			Me.sqlDataSource1.Name = "sqlDataSource1"
			columnExpression1.ColumnName = "OrderID"
			table1.Name = "SalesPerson"
			columnExpression1.Table = table1
			column1.Expression = columnExpression1
			columnExpression2.ColumnName = "Country"
			columnExpression2.Table = table1
			column2.Expression = columnExpression2
			columnExpression3.ColumnName = "FirstName"
			columnExpression3.Table = table1
			column3.Expression = columnExpression3
			columnExpression4.ColumnName = "LastName"
			columnExpression4.Table = table1
			column4.Expression = columnExpression4
			columnExpression5.ColumnName = "ProductName"
			columnExpression5.Table = table1
			column5.Expression = columnExpression5
			columnExpression6.ColumnName = "CategoryName"
			columnExpression6.Table = table1
			column6.Expression = columnExpression6
			columnExpression7.ColumnName = "OrderDate"
			columnExpression7.Table = table1
			column7.Expression = columnExpression7
			columnExpression8.ColumnName = "UnitPrice"
			columnExpression8.Table = table1
			column8.Expression = columnExpression8
			columnExpression9.ColumnName = "Quantity"
			columnExpression9.Table = table1
			column9.Expression = columnExpression9
			columnExpression10.ColumnName = "Discount"
			columnExpression10.Table = table1
			column10.Expression = columnExpression10
			columnExpression11.ColumnName = "Extended Price"
			columnExpression11.Table = table1
			column11.Expression = columnExpression11
			columnExpression12.ColumnName = "Sales Person"
			columnExpression12.Table = table1
			column12.Expression = columnExpression12
			selectQuery1.Columns.Add(column1)
			selectQuery1.Columns.Add(column2)
			selectQuery1.Columns.Add(column3)
			selectQuery1.Columns.Add(column4)
			selectQuery1.Columns.Add(column5)
			selectQuery1.Columns.Add(column6)
			selectQuery1.Columns.Add(column7)
			selectQuery1.Columns.Add(column8)
			selectQuery1.Columns.Add(column9)
			selectQuery1.Columns.Add(column10)
			selectQuery1.Columns.Add(column11)
			selectQuery1.Columns.Add(column12)
			selectQuery1.Name = "SalesPerson"
			selectQuery1.Tables.Add(table1)
			Me.sqlDataSource1.Queries.AddRange(New DevExpress.DataAccess.Sql.SqlQuery() { selectQuery1})
			Me.sqlDataSource1.ResultSchemaSerializable = resources.GetString("sqlDataSource1.ResultSchemaSerializable")
			' 
			' XtraReport1
			' 
			Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin})
			Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() { Me.sqlDataSource1})
			Me.HorizontalContentSplitting = DevExpress.XtraPrinting.HorizontalContentSplitting.Smart
			Me.Landscape = True
			Me.PageHeight = 850
			Me.PageWidth = 1100
			Me.Version = "19.2"
			Me.VerticalContentSplitting = DevExpress.XtraPrinting.VerticalContentSplitting.Smart
			CType(Me.xrCrossTab1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub


		#End Region

		Private Detail As DevExpress.XtraReports.UI.DetailBand
		Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
		Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
		Private xrCrossTab1 As DevExpress.XtraReports.UI.XRCrossTab
		Private xrCrossTabCell1 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell2 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell3 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell4 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell5 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell6 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell7 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell8 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell9 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell10 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell11 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell12 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell13 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell14 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell15 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell16 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell17 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell18 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell19 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell20 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell21 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell22 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell23 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell24 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell25 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell26 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell27 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell28 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell29 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell30 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell31 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell32 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell33 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private xrCrossTabCell34 As DevExpress.XtraReports.UI.CrossTab.XRCrossTabCell
		Private sqlDataSource1 As DevExpress.DataAccess.Sql.SqlDataSource
	End Class
End Namespace
