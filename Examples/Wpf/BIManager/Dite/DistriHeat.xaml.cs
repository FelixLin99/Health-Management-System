using System;
using System.Collections.Generic;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Wpf
{
    public partial class DistriHeat : UserControl
    {
        public DistriHeat()
        {
            InitializeComponent();
            HeatLevel = "高热量";
            DailyHeat = "3000";
            AvgHeat = "100";

            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "高热量",
                    Values = new ISeriesView<ObservableValue> { new ObservableValue(8) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "中热量",
                    Values = new ISeriesView<ObservableValue> { new ObservableValue(6) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "低热量",
                    Values = new ISeriesView<ObservableValue> { new ObservableValue(6) },
                    DataLabels = true
                },
            };

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string HeatLevel { get; set; }
        public string DailyHeat { get; set; }
        public string AvgHeat { get; set; }
    }
}
