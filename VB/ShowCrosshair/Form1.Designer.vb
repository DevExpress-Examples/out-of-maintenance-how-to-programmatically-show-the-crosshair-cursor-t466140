Namespace ShowCrosshair
    Partial Public Class Form1
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

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xyDiagram1 As New DevExpress.XtraCharts.XYDiagram()
            Dim xyDiagramPane1 As New DevExpress.XtraCharts.XYDiagramPane()
            Dim xyDiagramPane2 As New DevExpress.XtraCharts.XYDiagramPane()
            Dim secondaryAxisY1 As New DevExpress.XtraCharts.SecondaryAxisY()
            Dim secondaryAxisY2 As New DevExpress.XtraCharts.SecondaryAxisY()
            Dim legend1 As New DevExpress.XtraCharts.Legend()
            Dim legend2 As New DevExpress.XtraCharts.Legend()
            Dim series1 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint1 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 11, 6, 0, 0, 0), New Object() { (DirectCast(56.48R, Object))})
            Dim seriesPoint2 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 11, 3, 0, 0, 0), New Object() { (DirectCast(53.78R, Object))})
            Dim seriesPoint3 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 11, 0, 0, 0, 0), New Object() { (DirectCast(57.74R, Object))})
            Dim seriesPoint4 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 21, 0, 0, 0), New Object() { (DirectCast(64.4R, Object))})
            Dim seriesPoint5 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 18, 0, 0, 0), New Object() { (DirectCast(72.5R, Object))})
            Dim seriesPoint6 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 15, 0, 0, 0), New Object() { (DirectCast(72.68R, Object))})
            Dim seriesPoint7 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 12, 0, 0, 0), New Object() { (DirectCast(69.62R, Object))})
            Dim seriesPoint8 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 9, 0, 0, 0), New Object() { (DirectCast(67.28R, Object))})
            Dim seriesPoint9 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 6, 0, 0, 0), New Object() { (DirectCast(62.42R, Object))})
            Dim seriesPoint10 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 3, 0, 0, 0), New Object() { (DirectCast(60.62R, Object))})
            Dim seriesPoint11 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 0, 0, 0, 0), New Object() { (DirectCast(62.6R, Object))})
            Dim seriesPoint12 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 21, 0, 0, 0), New Object() { (DirectCast(71.96R, Object))})
            Dim seriesPoint13 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 18, 0, 0, 0), New Object() { (DirectCast(77.9R, Object))})
            Dim seriesPoint14 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 15, 0, 0, 0), New Object() { (DirectCast(78.98R, Object))})
            Dim seriesPoint15 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 12, 0, 0, 0), New Object() { (DirectCast(76.28R, Object))})
            Dim seriesPoint16 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 9, 0, 0, 0), New Object() { (DirectCast(71.06R, Object))})
            Dim seriesPoint17 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 6, 0, 0, 0), New Object() { (DirectCast(60.8R, Object))})
            Dim seriesPoint18 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 3, 0, 0, 0), New Object() { (DirectCast(58.64R, Object))})
            Dim seriesPoint19 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 0, 0, 0, 0), New Object() { (DirectCast(63.14R, Object))})
            Dim seriesPoint20 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 21, 0, 0, 0), New Object() { (DirectCast(68.54R, Object))})
            Dim seriesPoint21 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 18, 0, 0, 0), New Object() { (DirectCast(75.2R, Object))})
            Dim seriesPoint22 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 15, 0, 0, 0), New Object() { (DirectCast(77.18R, Object))})
            Dim seriesPoint23 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 12, 0, 0, 0), New Object() { (DirectCast(74.48R, Object))})
            Dim seriesPoint24 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 9, 0, 0, 0), New Object() { (DirectCast(64.58R, Object))})
            Dim seriesPoint25 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 6, 0, 0, 0), New Object() { (DirectCast(59.36R, Object))})
            Dim seriesPoint26 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 3, 0, 0, 0), New Object() { (DirectCast(60.08R, Object))})
            Dim seriesPoint27 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 0, 0, 0, 0), New Object() { (DirectCast(61.16R, Object))})
            Dim seriesPoint28 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 21, 0, 0, 0), New Object() { (DirectCast(63.86R, Object))})
            Dim seriesPoint29 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 18, 0, 0, 0), New Object() { (DirectCast(65.66R, Object))})
            Dim seriesPoint30 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 15, 0, 0, 0), New Object() { (DirectCast(65.12R, Object))})
            Dim seriesPoint31 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 12, 0, 0, 0), New Object() { (DirectCast(63.86R, Object))})
            Dim seriesPoint32 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 9, 0, 0, 0), New Object() { (DirectCast(61.52R, Object))})
            Dim seriesPoint33 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 6, 0, 0, 0), New Object() { (DirectCast(51.8R, Object))})
            Dim seriesPoint34 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 3, 0, 0, 0), New Object() { (DirectCast(52.34R, Object))})
            Dim seriesPoint35 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 0, 0, 0, 0), New Object() { (DirectCast(57.2R, Object))})
            Dim seriesPoint36 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 21, 0, 0, 0), New Object() { (DirectCast(60.44R, Object))})
            Dim seriesPoint37 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 18, 0, 0, 0), New Object() { (DirectCast(65.48R, Object))})
            Dim seriesPoint38 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 15, 0, 0, 0), New Object() { (DirectCast(66.56R, Object))})
            Dim seriesPoint39 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 12, 0, 0, 0), New Object() { (DirectCast(64.04R, Object))})
            Dim seriesPoint40 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 9, 0, 0, 0), New Object() { (DirectCast(60.26R, Object))})
            Dim seriesPoint41 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 6, 0, 0, 0), New Object() { (DirectCast(51.44R, Object))})
            Dim seriesPoint42 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 3, 0, 0, 0), New Object() { (DirectCast(50.18R, Object))})
            Dim seriesPoint43 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 0, 0, 0, 0), New Object() { (DirectCast(56.12R, Object))})
            Dim lineSeriesView1 As New DevExpress.XtraCharts.LineSeriesView()
            Dim series2 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint44 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 11, 6, 0, 0, 0), New Object() { (DirectCast(1023R, Object))})
            Dim seriesPoint45 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 11, 3, 0, 0, 0), New Object() { (DirectCast(1021R, Object))})
            Dim seriesPoint46 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 11, 0, 0, 0, 0), New Object() { (DirectCast(1023R, Object))})
            Dim seriesPoint47 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 21, 0, 0, 0), New Object() { (DirectCast(1021R, Object))})
            Dim seriesPoint48 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 18, 0, 0, 0), New Object() { (DirectCast(1020R, Object))})
            Dim seriesPoint49 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 15, 0, 0, 0), New Object() { (DirectCast(1021R, Object))})
            Dim seriesPoint50 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 12, 0, 0, 0), New Object() { (DirectCast(1023R, Object))})
            Dim seriesPoint51 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 9, 0, 0, 0), New Object() { (DirectCast(1023R, Object))})
            Dim seriesPoint52 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 6, 0, 0, 0), New Object() { (DirectCast(1023R, Object))})
            Dim seriesPoint53 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 3, 0, 0, 0), New Object() { (DirectCast(1021R, Object))})
            Dim seriesPoint54 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 0, 0, 0, 0), New Object() { (DirectCast(1023R, Object))})
            Dim seriesPoint55 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 21, 0, 0, 0), New Object() { (DirectCast(1023R, Object))})
            Dim seriesPoint56 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 18, 0, 0, 0), New Object() { (DirectCast(1021R, Object))})
            Dim seriesPoint57 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 15, 0, 0, 0), New Object() { (DirectCast(1023R, Object))})
            Dim seriesPoint58 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 12, 0, 0, 0), New Object() { (DirectCast(1024R, Object))})
            Dim seriesPoint59 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 9, 0, 0, 0), New Object() { (DirectCast(1024R, Object))})
            Dim seriesPoint60 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 6, 0, 0, 0), New Object() { (DirectCast(1024R, Object))})
            Dim seriesPoint61 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 3, 0, 0, 0), New Object() { (DirectCast(1023R, Object))})
            Dim seriesPoint62 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 0, 0, 0, 0), New Object() { (DirectCast(1024R, Object))})
            Dim seriesPoint63 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 21, 0, 0, 0), New Object() { (DirectCast(1023R, Object))})
            Dim seriesPoint64 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 18, 0, 0, 0), New Object() { (DirectCast(1021R, Object))})
            Dim seriesPoint65 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 15, 0, 0, 0), New Object() { (DirectCast(1021R, Object))})
            Dim seriesPoint66 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 12, 0, 0, 0), New Object() { (DirectCast(1021R, Object))})
            Dim seriesPoint67 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 9, 0, 0, 0), New Object() { (DirectCast(1021R, Object))})
            Dim seriesPoint68 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 6, 0, 0, 0), New Object() { (DirectCast(1020R, Object))})
            Dim seriesPoint69 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 3, 0, 0, 0), New Object() { (DirectCast(1019R, Object))})
            Dim seriesPoint70 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 0, 0, 0, 0), New Object() { (DirectCast(1019R, Object))})
            Dim seriesPoint71 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 21, 0, 0, 0), New Object() { (DirectCast(1019R, Object))})
            Dim seriesPoint72 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 18, 0, 0, 0), New Object() { (DirectCast(1017R, Object))})
            Dim seriesPoint73 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 15, 0, 0, 0), New Object() { (DirectCast(1017R, Object))})
            Dim seriesPoint74 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 12, 0, 0, 0), New Object() { (DirectCast(1017R, Object))})
            Dim seriesPoint75 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 9, 0, 0, 0), New Object() { (DirectCast(1017R, Object))})
            Dim seriesPoint76 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 6, 0, 0, 0), New Object() { (DirectCast(1017R, Object))})
            Dim seriesPoint77 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 3, 0, 0, 0), New Object() { (DirectCast(1016R, Object))})
            Dim seriesPoint78 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 0, 0, 0, 0), New Object() { (DirectCast(1016R, Object))})
            Dim seriesPoint79 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 21, 0, 0, 0), New Object() { (DirectCast(1016R, Object))})
            Dim seriesPoint80 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 18, 0, 0, 0), New Object() { (DirectCast(1015R, Object))})
            Dim seriesPoint81 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 15, 0, 0, 0), New Object() { (DirectCast(1015R, Object))})
            Dim seriesPoint82 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 12, 0, 0, 0), New Object() { (DirectCast(1015R, Object))})
            Dim seriesPoint83 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 9, 0, 0, 0), New Object() { (DirectCast(1015R, Object))})
            Dim seriesPoint84 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 6, 0, 0, 0), New Object() { (DirectCast(1015R, Object))})
            Dim seriesPoint85 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 3, 0, 0, 0), New Object() { (DirectCast(1015R, Object))})
            Dim seriesPoint86 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 0, 0, 0, 0), New Object() { (DirectCast(1015R, Object))})
            Dim areaSeriesView1 As New DevExpress.XtraCharts.AreaSeriesView()
            Dim series3 As New DevExpress.XtraCharts.Series()
            Dim seriesPoint87 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 11, 6, 0, 0, 0), New Object() { (DirectCast(69R, Object))})
            Dim seriesPoint88 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 11, 3, 0, 0, 0), New Object() { (DirectCast(76R, Object))})
            Dim seriesPoint89 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 11, 0, 0, 0, 0), New Object() { (DirectCast(66R, Object))})
            Dim seriesPoint90 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 21, 0, 0, 0), New Object() { (DirectCast(49R, Object))})
            Dim seriesPoint91 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 18, 0, 0, 0), New Object() { (DirectCast(45R, Object))})
            Dim seriesPoint92 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 15, 0, 0, 0), New Object() { (DirectCast(48R, Object))})
            Dim seriesPoint93 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 12, 0, 0, 0), New Object() { (DirectCast(57R, Object))})
            Dim seriesPoint94 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 9, 0, 0, 0), New Object() { (DirectCast(66R, Object))})
            Dim seriesPoint95 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 6, 0, 0, 0), New Object() { (DirectCast(78R, Object))})
            Dim seriesPoint96 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 3, 0, 0, 0), New Object() { (DirectCast(83R, Object))})
            Dim seriesPoint97 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 10, 0, 0, 0, 0), New Object() { (DirectCast(72R, Object))})
            Dim seriesPoint98 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 21, 0, 0, 0), New Object() { (DirectCast(52R, Object))})
            Dim seriesPoint99 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 18, 0, 0, 0), New Object() { (DirectCast(40R, Object))})
            Dim seriesPoint100 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 15, 0, 0, 0), New Object() { (DirectCast(41R, Object))})
            Dim seriesPoint101 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 12, 0, 0, 0), New Object() { (DirectCast(37R, Object))})
            Dim seriesPoint102 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 9, 0, 0, 0), New Object() { (DirectCast(41R, Object))})
            Dim seriesPoint103 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 6, 0, 0, 0), New Object() { (DirectCast(68R, Object))})
            Dim seriesPoint104 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 3, 0, 0, 0), New Object() { (DirectCast(78R, Object))})
            Dim seriesPoint105 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 9, 0, 0, 0, 0), New Object() { (DirectCast(71R, Object))})
            Dim seriesPoint106 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 21, 0, 0, 0), New Object() { (DirectCast(63R, Object))})
            Dim seriesPoint107 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 18, 0, 0, 0), New Object() { (DirectCast(47R, Object))})
            Dim seriesPoint108 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 15, 0, 0, 0), New Object() { (DirectCast(44R, Object))})
            Dim seriesPoint109 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 12, 0, 0, 0), New Object() { (DirectCast(48R, Object))})
            Dim seriesPoint110 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 9, 0, 0, 0), New Object() { (DirectCast(68R, Object))})
            Dim seriesPoint111 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 6, 0, 0, 0), New Object() { (DirectCast(81R, Object))})
            Dim seriesPoint112 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 3, 0, 0, 0), New Object() { (DirectCast(85R, Object))})
            Dim seriesPoint113 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 8, 0, 0, 0, 0), New Object() { (DirectCast(76R, Object))})
            Dim seriesPoint114 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 21, 0, 0, 0), New Object() { (DirectCast(65R, Object))})
            Dim seriesPoint115 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 18, 0, 0, 0), New Object() { (DirectCast(57R, Object))})
            Dim seriesPoint116 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 15, 0, 0, 0), New Object() { (DirectCast(62R, Object))})
            Dim seriesPoint117 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 12, 0, 0, 0), New Object() { (DirectCast(53R, Object))})
            Dim seriesPoint118 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 9, 0, 0, 0), New Object() { (DirectCast(62R, Object))})
            Dim seriesPoint119 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 6, 0, 0, 0), New Object() { (DirectCast(76R, Object))})
            Dim seriesPoint120 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 3, 0, 0, 0), New Object() { (DirectCast(80R, Object))})
            Dim seriesPoint121 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 7, 0, 0, 0, 0), New Object() { (DirectCast(82R, Object))})
            Dim seriesPoint122 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 21, 0, 0, 0), New Object() { (DirectCast(73R, Object))})
            Dim seriesPoint123 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 18, 0, 0, 0), New Object() { (DirectCast(57R, Object))})
            Dim seriesPoint124 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 15, 0, 0, 0), New Object() { (DirectCast(55R, Object))})
            Dim seriesPoint125 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 12, 0, 0, 0), New Object() { (DirectCast(64R, Object))})
            Dim seriesPoint126 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 9, 0, 0, 0), New Object() { (DirectCast(74R, Object))})
            Dim seriesPoint127 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 6, 0, 0, 0), New Object() { (DirectCast(89R, Object))})
            Dim seriesPoint128 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 3, 0, 0, 0), New Object() { (DirectCast(87R, Object))})
            Dim seriesPoint129 As New DevExpress.XtraCharts.SeriesPoint(New Date(2008, 6, 6, 0, 0, 0, 0), New Object() { (DirectCast(80R, Object))})
            Dim sideBySideBarSeriesView1 As New DevExpress.XtraCharts.SideBySideBarSeriesView()
            Dim chartTitle1 As New DevExpress.XtraCharts.ChartTitle()
            Me.chartControl = New DevExpress.XtraCharts.ChartControl()
            DirectCast(Me.chartControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagramPane1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(xyDiagramPane2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(secondaryAxisY1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(secondaryAxisY2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(areaSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(series3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' chartControl
            ' 
            Me.chartControl.CrosshairEnabled = DevExpress.Utils.DefaultBoolean.False
            Me.chartControl.CrosshairOptions.ShowOnlyInFocusedPane = False
            Me.chartControl.DataBindings = Nothing
            xyDiagram1.AxisX.DateTimeScaleOptions.AggregateFunction = DevExpress.XtraCharts.AggregateFunction.None
            xyDiagram1.AxisX.DateTimeScaleOptions.AutoGrid = False
            xyDiagram1.AxisX.DateTimeScaleOptions.GridAlignment = DevExpress.XtraCharts.DateTimeGridAlignment.Hour
            xyDiagram1.AxisX.DateTimeScaleOptions.GridSpacing = 5R
            xyDiagram1.AxisX.DateTimeScaleOptions.MeasureUnit = DevExpress.XtraCharts.DateTimeMeasureUnit.Hour
            xyDiagram1.AxisX.Label.TextPattern = "{A:MMMM d, H:mm tt}"
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1;1;0"
            xyDiagram1.AxisX.VisualRange.Auto = False
            xyDiagram1.AxisX.VisualRange.MaxValueSerializable = "06/08/2008 06:00:00.000"
            xyDiagram1.AxisX.VisualRange.MinValueSerializable = "06/06/2008 00:00:00.000"
            xyDiagram1.AxisY.Title.Text = "Temperature, F"
            xyDiagram1.AxisY.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1"
            xyDiagram1.AxisY.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.EnableAxisXScrolling = True
            xyDiagramPane1.Name = "Pane 1"
            xyDiagramPane1.PaneID = 0
            xyDiagramPane2.Name = "Pane 2"
            xyDiagramPane2.PaneID = 1
            xyDiagram1.Panes.AddRange(New DevExpress.XtraCharts.XYDiagramPane() { xyDiagramPane1, xyDiagramPane2})
            secondaryAxisY1.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY1.AxisID = 0
            secondaryAxisY1.GridLines.Visible = True
            secondaryAxisY1.Name = "Secondary AxisY 1"
            secondaryAxisY1.Title.Text = "Pressure, mbar"
            secondaryAxisY1.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
            secondaryAxisY1.VisibleInPanesSerializable = "0"
            secondaryAxisY1.WholeRange.AlwaysShowZeroLevel = False
            secondaryAxisY2.Alignment = DevExpress.XtraCharts.AxisAlignment.Near
            secondaryAxisY2.AxisID = 1
            secondaryAxisY2.GridLines.Visible = True
            secondaryAxisY2.Name = "Secondary AxisY 2"
            secondaryAxisY2.Title.Text = "Humidity, %"
            secondaryAxisY2.Title.Visibility = DevExpress.Utils.DefaultBoolean.True
            secondaryAxisY2.VisibleInPanesSerializable = "1"
            secondaryAxisY2.WholeRange.AlwaysShowZeroLevel = False
            xyDiagram1.SecondaryAxesY.AddRange(New DevExpress.XtraCharts.SecondaryAxisY() { secondaryAxisY1, secondaryAxisY2})
            Me.chartControl.Diagram = xyDiagram1
            Me.chartControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.chartControl.Legend.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            Me.chartControl.Legend.Direction = DevExpress.XtraCharts.LegendDirection.LeftToRight
            Me.chartControl.Legend.DockTargetName = "Default Pane"
            Me.chartControl.Legend.Name = "Default Legend"
            legend1.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            legend1.DockTargetName = "Pane 1"
            legend1.Name = "Legend1"
            legend2.AlignmentHorizontal = DevExpress.XtraCharts.LegendAlignmentHorizontal.Right
            legend2.DockTargetName = "Pane 2"
            legend2.Name = "Legend2"
            Me.chartControl.Legends.AddRange(New DevExpress.XtraCharts.Legend() { legend1, legend2})
            Me.chartControl.Location = New System.Drawing.Point(0, 0)
            Me.chartControl.Name = "chartControl"
            series1.CrosshairLabelPattern = "{S} : {V}F"
            series1.LegendName = "Default Legend"
            series1.Name = "Temperature"
            series1.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint1, seriesPoint2, seriesPoint3, seriesPoint4, seriesPoint5, seriesPoint6, seriesPoint7, seriesPoint8, seriesPoint9, seriesPoint10, seriesPoint11, seriesPoint12, seriesPoint13, seriesPoint14, seriesPoint15, seriesPoint16, seriesPoint17, seriesPoint18, seriesPoint19, seriesPoint20, seriesPoint21, seriesPoint22, seriesPoint23, seriesPoint24, seriesPoint25, seriesPoint26, seriesPoint27, seriesPoint28, seriesPoint29, seriesPoint30, seriesPoint31, seriesPoint32, seriesPoint33, seriesPoint34, seriesPoint35, seriesPoint36, seriesPoint37, seriesPoint38, seriesPoint39, seriesPoint40, seriesPoint41, seriesPoint42, seriesPoint43})
            series1.View = lineSeriesView1
            series2.CrosshairLabelPattern = "{S} :  {V} mbars"
            series2.LegendName = "Legend1"
            series2.Name = "Pressure"
            series2.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint44, seriesPoint45, seriesPoint46, seriesPoint47, seriesPoint48, seriesPoint49, seriesPoint50, seriesPoint51, seriesPoint52, seriesPoint53, seriesPoint54, seriesPoint55, seriesPoint56, seriesPoint57, seriesPoint58, seriesPoint59, seriesPoint60, seriesPoint61, seriesPoint62, seriesPoint63, seriesPoint64, seriesPoint65, seriesPoint66, seriesPoint67, seriesPoint68, seriesPoint69, seriesPoint70, seriesPoint71, seriesPoint72, seriesPoint73, seriesPoint74, seriesPoint75, seriesPoint76, seriesPoint77, seriesPoint78, seriesPoint79, seriesPoint80, seriesPoint81, seriesPoint82, seriesPoint83, seriesPoint84, seriesPoint85, seriesPoint86})
            areaSeriesView1.AxisYName = "Secondary AxisY 1"
            areaSeriesView1.PaneName = "Pane 1"
            areaSeriesView1.Transparency = (CByte(0))
            series2.View = areaSeriesView1
            series3.CrosshairLabelPattern = "{S} : {V}%"
            series3.LegendName = "Legend2"
            series3.Name = "Humidity"
            series3.Points.AddRange(New DevExpress.XtraCharts.SeriesPoint() { seriesPoint87, seriesPoint88, seriesPoint89, seriesPoint90, seriesPoint91, seriesPoint92, seriesPoint93, seriesPoint94, seriesPoint95, seriesPoint96, seriesPoint97, seriesPoint98, seriesPoint99, seriesPoint100, seriesPoint101, seriesPoint102, seriesPoint103, seriesPoint104, seriesPoint105, seriesPoint106, seriesPoint107, seriesPoint108, seriesPoint109, seriesPoint110, seriesPoint111, seriesPoint112, seriesPoint113, seriesPoint114, seriesPoint115, seriesPoint116, seriesPoint117, seriesPoint118, seriesPoint119, seriesPoint120, seriesPoint121, seriesPoint122, seriesPoint123, seriesPoint124, seriesPoint125, seriesPoint126, seriesPoint127, seriesPoint128, seriesPoint129})
            sideBySideBarSeriesView1.AxisYName = "Secondary AxisY 2"
            sideBySideBarSeriesView1.PaneName = "Pane 2"
            series3.View = sideBySideBarSeriesView1
            Me.chartControl.SeriesSerializable = New DevExpress.XtraCharts.Series() { series1, series2, series3}
            Me.chartControl.Size = New System.Drawing.Size(1264, 681)
            Me.chartControl.TabIndex = 0
            chartTitle1.Text = "Weather in London"
            Me.chartControl.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() { chartTitle1})
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1264, 681)
            Me.Controls.Add(Me.chartControl)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(xyDiagramPane1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagramPane2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(secondaryAxisY1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(secondaryAxisY2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(xyDiagram1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(lineSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(areaSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(sideBySideBarSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(series3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.chartControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents chartControl As DevExpress.XtraCharts.ChartControl
    End Class
End Namespace

