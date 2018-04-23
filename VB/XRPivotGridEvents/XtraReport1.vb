Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UI.PivotGrid
' ...

Namespace XRPivotGridEvents
	Partial Public Class XtraReport1
		Inherits XtraReport
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub xrPivotGrid1_PrintCell(ByVal sender As Object, ByVal e As CustomExportCellEventArgs) Handles xrPivotGrid1.PrintCell
			If e.ColumnIndex = 1 AndAlso Convert.ToDouble(e.Value) > 50 Then
				e.Appearance.BackColor = Color.AliceBlue
			End If
		End Sub

		Private Sub xrPivotGrid1_PrintFieldValue(ByVal sender As Object, ByVal e As CustomExportFieldValueEventArgs) Handles xrPivotGrid1.PrintFieldValue
			If e.Text <> "Condiments" Then
				e.Appearance.BackColor = Color.Beige
			End If
		End Sub

		Private Sub xrPivotGrid1_PrintHeader(ByVal sender As Object, ByVal e As CustomExportHeaderEventArgs) Handles xrPivotGrid1.PrintHeader
			If e.Caption = "Quantity" Then
				e.Appearance.BackColor = Color.AliceBlue
			End If
		End Sub

	End Class
End Namespace
