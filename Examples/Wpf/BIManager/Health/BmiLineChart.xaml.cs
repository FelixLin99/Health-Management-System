using System.Windows;
using System.Windows.Controls;
using LiveCharts;

namespace Wpf
{
    /// <summary>
    /// Interaction logic for SolidColorExample.xaml
    /// </summary>
    public partial class BmiLineChart : UserControl
    {
        public BmiLineChart()
        {
            InitializeComponent();

            Values = new ISeriesView<double> {0, 0, 0, 0, 0, 0};
            CurBMI = "0";
            BestBMI = "0";
            DataContext = this;
        }

        public ISeriesView<double> Values { get; set; }
        public string CurBMI { get; set; }
        public string BestBMI { get; set; }
        private void UpdateOnclick(object sender, RoutedEventArgs e)
        {
            Chart.Update(true);
        }
    }
}
