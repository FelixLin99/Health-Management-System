using System;
using System.Collections.Generic;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;

namespace Wpf
{
    public partial class DistriTime : UserControl
    {
        ChartModel chartModel = new ChartModel();
        public DistriTime()
        {
            InitializeComponent();
            //GetPieSeriesData();
            LongestTime = "";
            DailyTime = "";
            AvgTime = "";
            this.DataContext = this;
        }

        public string LongestTime { get; set; }
        public string DailyTime { get; set; }
        public string AvgTime { get; set; }
        private void Chart_OnDataClick(object sender, ChartPoint chartpoint)
        {
            var chart = (LiveCharts.Wpf.PieChart) chartpoint.ChartView;
            
            //clear selected slice.
            foreach (PieSeries series in chart.Series)
                series.PushOut = 0;

            var selectedSeries = (PieSeries) chartpoint.SeriesView;
            selectedSeries.PushOut = 8;
        }
        public SeriesCollection pieSeriesCollection = new SeriesCollection();

        public SeriesCollection PieSeriesCollection
        {
            get
            {
                return pieSeriesCollection;
            }

            set
            {
                pieSeriesCollection = value;
            }
        }


        public void GetPieSeriesData(List<string> titles, List<double> pieValues)
        {
            //List<string> titles = new List<string> { "0-30 min", "30-60 min", "60+ min" };
            //List<double> pieValues = new List<double> { 60, 30, 10 };
            ISeriesView<double> chartvalue = new ISeriesView<double>();
            for (int i = 0; i < titles.Count; i++)
            {
                chartvalue = new ISeriesView<double>();
                chartvalue.Add(pieValues[i]);
                PieSeries series = new PieSeries();
                series.DataLabels = true;
                series.Title = titles[i];
                series.Values = chartvalue;
                PieSeriesCollection.Add(series);
            }
        }
    }
}
