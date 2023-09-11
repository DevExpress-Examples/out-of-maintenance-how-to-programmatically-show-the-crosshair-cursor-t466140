Imports System.Windows.Forms
Imports DevExpress.XtraCharts

Namespace ShowCrosshair
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub
        #Region "#ShowCrosshair"
        Private Sub OnChartMouseUp(ByVal sender As Object, ByVal e As MouseEventArgs) Handles chartControl.MouseUp
            Dim xyDiagram As XYDiagram = TryCast(chartControl.Diagram, XYDiagram)
            If xyDiagram Is Nothing Then
                Return
            End If
            xyDiagram.ShowCrosshair(e.Location)
        End Sub
        #End Region ' #ShowCrosshair
    End Class
End Namespace
