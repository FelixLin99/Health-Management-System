using LiveCharts;
using System.Windows.Controls;

namespace Wpf
{
    /// <summary>
    /// Interaction logic for FunnelExample.xaml
    /// </summary>
    public partial class SportConsume : UserControl
    {
        public SportConsume()
        {
            InitializeComponent();
            Total = "0 KCal";
            Sugar = "0 KCal";
            Fat = "0 KCal";
            // 以下用于绘图
            DataSeries_up = new ISeriesView<double> {0, 0, 0, 0, 0, 0};
            DataSeries_down = new ISeriesView<double> { 0, 0, 0, 0, 0, 0 };
            Shadow_1_up = new ISeriesView<double> { 0, 0, 0, 0, 0, 0 };
            Shadow_1_down = new ISeriesView<double> { 0, 0, 0, 0, 0, 0 };
            Shadow_2_up = new ISeriesView<double> { 0, 0, 0, 0, 0, 0 };
            Shadow_2_down = new ISeriesView<double> { 0, 0, 0, 0, 0, 0 };

            DataContext = this;
        }

        public string Total { get; set; }
        public string Sugar { get; set; }
        public string Fat { get; set; }
        public ISeriesView<double> DataSeries_up { get; set; }
        public ISeriesView<double> DataSeries_down { get; set; }
        public ISeriesView<double> Shadow_1_up { get; set; }
        public ISeriesView<double> Shadow_1_down { get; set; }
        public ISeriesView<double> Shadow_2_up { get; set; }
        public ISeriesView<double> Shadow_2_down { get; set; }


    }
}
