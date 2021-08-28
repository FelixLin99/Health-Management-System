using System;
using System.Collections.Generic;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Wpf
{
    public partial class DistriNutri : UserControl
    {
        public DistriNutri()
        {
            InitializeComponent();
            Proportion = "0:0:0";
            Reduce = "";
            Add = "";

            SeriesCollection = new SeriesCollection
            {
                new PieSeries
                {
                    Title = "蛋白质",
                    Values = new ISeriesView<ObservableValue> { new ObservableValue(0) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "脂肪",
                    Values = new ISeriesView<ObservableValue> { new ObservableValue(0) },
                    DataLabels = true
                },
                new PieSeries
                {
                    Title = "碳水",
                    Values = new ISeriesView<ObservableValue> { new ObservableValue(0) },
                    DataLabels = true
                }
            };

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string Proportion { get; set; }
        public string Reduce { get; set; }
        public string Add { get; set; }
    }
}
