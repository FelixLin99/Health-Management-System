using System.Windows;
using System.Windows.Controls;
using LiveCharts;

namespace Wpf.CartesianChart.SolidColorChart
{
    /// <summary>
    /// Interaction logic for SolidColorExample.xaml
    /// </summary>
    public partial class SolidColorExample : UserControl
    {
        public SolidColorExample()
        {
            InitializeComponent();

            Values = new ISeriesView<double> {150, 375, 420, 500, 160, 140};

            DataContext = this;
        }

        public ISeriesView<double> Values { get; set; }

        private void UpdateOnclick(object sender, RoutedEventArgs e)
        {
            Chart.Update(true);
        }
    }
}
