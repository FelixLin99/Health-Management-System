using System;
using System.Collections.Generic;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;

namespace Wpf
{
    public partial class DistriAccount : UserControl
    {
        ChartModel chartModel = new ChartModel();
        public DistriAccount()
        {
            InitializeComponent();
            //GetPieSeriesData();
            HighestCal = " KCal";
            DailyCal = "";
            AvgCal = "";
            this.DataContext = this;
        }

        public string HighestCal { get; set; }
        public string DailyCal { get; set; }
        public string AvgCal { get; set; }
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
            //List<string> titles = new List<string> { "低强度", "中强度", "高强度" };
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
