using System.Windows;
using System.Windows.Controls;
using LiveCharts;

namespace Wpf
{
    /// <summary>
    /// Interaction logic for SolidColorExample.xaml
    /// </summary>
    public partial class PaiLineChart : UserControl
    {
        public PaiLineChart()
        {
            InitializeComponent();

            Values = new ISeriesView<double> {0, 0, 0, 0, 0, 0, 0};
            
            CurPai = "0";
            BestPai = "0";

            DataContext = this;
        }

        public ISeriesView<double> Values { get; set; }
        public string CurPai { get; set; }
        public string BestPai { get; set; }

        private void UpdateOnclick(object sender, RoutedEventArgs e)
        {
            Chart.Update(true);
        }
    }
}
