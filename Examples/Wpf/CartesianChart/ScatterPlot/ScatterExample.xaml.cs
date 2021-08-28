using System;
using System.Windows;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Defaults;

namespace Wpf.CartesianChart.ScatterPlot
{
    /// <summary>
    /// Interaction logic for ScatterExample.xaml
    /// </summary>
    public partial class ScatterExample : UserControl
    {
        public ScatterExample()
        {
            InitializeComponent();

            var r = new Random();
            ValuesA = new ISeriesView<ObservablePoint>();
            ValuesB = new ISeriesView<ObservablePoint>();
            ValuesC = new ISeriesView<ObservablePoint>();

            for (var i = 0; i < 20; i++)
            {
                ValuesA.Add(new ObservablePoint(r.NextDouble()*10, r.NextDouble()*10));
                ValuesB.Add(new ObservablePoint(r.NextDouble()*10, r.NextDouble()*10));
                ValuesC.Add(new ObservablePoint(r.NextDouble()*10, r.NextDouble()*10));
            }

            DataContext = this;
        }

        public ISeriesView<ObservablePoint> ValuesA { get; set; }
        public ISeriesView<ObservablePoint> ValuesB { get; set; }
        public ISeriesView<ObservablePoint> ValuesC { get; set; }

        private void RandomizeOnClick(object sender, RoutedEventArgs e)
        {
            var r = new Random();
            for (var i = 0; i < 20; i++)
            {
                ValuesA[i].X = r.NextDouble()*10;
                ValuesA[i].Y = r.NextDouble()*10;
                ValuesB[i].X = r.NextDouble()*10;
                ValuesB[i].Y = r.NextDouble()*10;
                ValuesC[i].X = r.NextDouble()*10;
                ValuesC[i].Y = r.NextDouble()*10;
            }
        }
    }
}
