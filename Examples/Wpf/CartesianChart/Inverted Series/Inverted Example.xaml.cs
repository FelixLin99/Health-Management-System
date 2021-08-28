using System.Windows.Controls;
using LiveCharts;

namespace Wpf.CartesianChart.Inverted_Series
{
    public partial class InvertedExample : UserControl
    {
        public InvertedExample()
        {
            InitializeComponent();

            Values1 = new ISeriesView<double> {3, 5, 2, 6, 2, 7, 1};

            Values2 = new ISeriesView<double> {6, 2, 6, 3, 2, 7, 2};

            DataContext = this;
        }

        public ISeriesView<double> Values1 { get; set; }
        public ISeriesView<double> Values2 { get; set; }

    }
}
