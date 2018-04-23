Imports System
Imports System.Windows.Forms
Imports DevExpress.XtraCharts
' ...

Namespace _DStackedSplineAreaChart
    Partial Public Class Form1
        Inherits Form
        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) _
        Handles MyBase.Load
            ' Create an empty chart.
            Dim stackedSplineArea3DChart As New ChartControl()

            ' Create two series of the StackedSplineArea3D view type.
            Dim series1 As New Series("Series 1", ViewType.StackedSplineArea3D)
            Dim series2 As New Series("Series 2", ViewType.StackedSplineArea3D)

            ' Populate both series with points.
            series1.Points.Add(New SeriesPoint("A", 80))
            series1.Points.Add(New SeriesPoint("B", 20))
            series1.Points.Add(New SeriesPoint("C", 50))
            series1.Points.Add(New SeriesPoint("D", 30))
            series2.Points.Add(New SeriesPoint("A", 40))
            series2.Points.Add(New SeriesPoint("B", 60))
            series2.Points.Add(New SeriesPoint("C", 20))
            series2.Points.Add(New SeriesPoint("D", 80))

            ' Add the series to the chart.
            stackedSplineArea3DChart.Series.AddRange(New Series() {series1, series2})

            ' Adjust the view-type-specific options of the series.
            CType(series1.View, StackedSplineArea3DSeriesView).LineTensionPercent = 10
            CType(series2.View, StackedSplineArea3DSeriesView).LineTensionPercent = 90

            ' Access the diagram's options.
            CType(stackedSplineArea3DChart.Diagram, XYDiagram3D).ZoomPercent = 110

            ' Add a title to the chart and hide the legend.
            Dim chartTitle1 As New ChartTitle()
            chartTitle1.Text = "3D Stacked Spline Area Chart"
            stackedSplineArea3DChart.Titles.Add(chartTitle1)
            stackedSplineArea3DChart.Legend.Visible = False

            ' Add the chart to the form.
            stackedSplineArea3DChart.Dock = DockStyle.Fill
            Me.Controls.Add(stackedSplineArea3DChart)
        End Sub
    End Class
End Namespace

