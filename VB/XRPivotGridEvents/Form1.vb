Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraReports.UI
' ...

Namespace XRPivotGridEvents
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Using report As XtraReport = New XtraReport1()
			Using printTool As New ReportPrintTool(report)
				printTool.ShowRibbonPreviewDialog()
			End Using
			End Using
		End Sub
	End Class
End Namespace