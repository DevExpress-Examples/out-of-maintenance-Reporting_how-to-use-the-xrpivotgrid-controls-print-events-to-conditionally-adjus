Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraPivotGrid
Imports DevExpress.XtraReports.UI
' ...

Namespace XRPivotGridEvents
	Partial Public Class XtraReport1
		Inherits DevExpress.XtraReports.UI.XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrPivotGrid1_PrintCell(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PivotGrid.CustomExportCellEventArgs) Handles xrPivotGrid1.PrintCell
			If e.ColumnIndex = 1 AndAlso Convert.ToDouble(e.Value) > 50 Then
				e.Brick.BackColor = Color.AliceBlue
			End If
		End Sub

		Private Sub xrPivotGrid1_PrintFieldValue(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PivotGrid.CustomExportFieldValueEventArgs) Handles xrPivotGrid1.PrintFieldValue
			If e.Text <> "Condiments" Then
				e.Brick.BackColor = Color.Beige
			End If
		End Sub

		Private Sub xrPivotGrid1_PrintHeader(ByVal sender As Object, ByVal e As DevExpress.XtraReports.UI.PivotGrid.CustomExportHeaderEventArgs) Handles xrPivotGrid1.PrintHeader
			If e.Caption = "Quantity" Then
				e.Brick.BackColor = Color.AliceBlue
			End If
		End Sub

	End Class
End Namespace
