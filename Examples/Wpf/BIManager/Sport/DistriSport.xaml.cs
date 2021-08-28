using System;
using System.Collections.Generic;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Wpf;

namespace Wpf
{
    public partial class DistriSport : UserControl
    {
        ChartModel chartModel = new ChartModel();
        public DistriSport()
        {
            InitializeComponent();
            //GetPieSeriesData(null, null);
            FavoriteSport = "";
            Time = "";
            Cal = "";
            this.DataContext = this;
        }


        public string FavoriteSport { get; set; }
        public string Time { get; set; }
        public string Cal { get; set; }
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
            //List<string> titles = new List<string> { "跑步", "游泳", "骑行" };
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
