using System;
using System.Collections.Generic;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Wpf
{
    public partial class DistriFood : UserControl
    {
        public DistriFood()
        {
            InitializeComponent();
            FavoriteFood = "";
            Amount = "";
            Cal = "";

            SeriesCollection = new SeriesCollection
            {
                //new PieSeries
                //{
                //    Title = "",
                //    Values = new ISeriesView<ObservableValue> { new ObservableValue(0) },
                //    DataLabels = true
                //}
            };

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public string FavoriteFood { get; set; }
        public string Amount { get; set; }
        public string Cal { get; set; }
    }
}
