Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace ShowCrosshair

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

#Region "#ShowCrosshair"
        Private Sub OnChartMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            Dim xyDiagram As XYDiagram = TryCast(chartControl.Diagram, XYDiagram)
            If xyDiagram Is Nothing Then Return
            xyDiagram.ShowCrosshair(e.Location)
        End Sub
#End Region  ' #ShowCrosshair
    End Class
End Namespace
