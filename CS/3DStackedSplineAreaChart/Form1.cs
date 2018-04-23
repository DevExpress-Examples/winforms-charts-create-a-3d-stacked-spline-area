using System;
using System.Windows.Forms;
using DevExpress.XtraCharts;
// ...

namespace _DStackedSplineAreaChart {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create an empty chart.
            ChartControl stackedSplineArea3DChart = new ChartControl();

            // Create two series of the StackedSplineArea3D view type.
            Series series1 = new Series("Series 1", ViewType.StackedSplineArea3D);
            Series series2 = new Series("Series 2", ViewType.StackedSplineArea3D);

            // Populate both series with points.
            series1.Points.Add(new SeriesPoint("A", 80));
            series1.Points.Add(new SeriesPoint("B", 20));
            series1.Points.Add(new SeriesPoint("C", 50));
            series1.Points.Add(new SeriesPoint("D", 30));
            series2.Points.Add(new SeriesPoint("A", 40));
            series2.Points.Add(new SeriesPoint("B", 60));
            series2.Points.Add(new SeriesPoint("C", 20));
            series2.Points.Add(new SeriesPoint("D", 80));

            // Add the series to the chart.
            stackedSplineArea3DChart.Series.AddRange(new Series[] {
                series1,
                series2});

            // Adjust the series options.
            series1.Label.Visible = false;
            series2.Label.Visible = false;

            // Adjust the view-type-specific options of the series.
            ((StackedSplineArea3DSeriesView)series1.View).LineTensionPercent = 10;
            ((StackedSplineArea3DSeriesView)series2.View).LineTensionPercent = 90;

            // Access the diagram's options.
            ((XYDiagram3D)stackedSplineArea3DChart.Diagram).ZoomPercent = 110;

            // Add a title to the chart and hide the legend.
            ChartTitle chartTitle1 = new ChartTitle();
            chartTitle1.Text = "3D Stacked Spline Area Chart";
            stackedSplineArea3DChart.Titles.Add(chartTitle1);
            stackedSplineArea3DChart.Legend.Visible = false;

            // Add the chart to the form.
            stackedSplineArea3DChart.Dock = DockStyle.Fill;
            this.Controls.Add(stackedSplineArea3DChart);
        }
    }
}

