using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Wpf.Annotations;

namespace Wpf
{
    /// <summary>
    /// 最近一周运动总时间和卡路里消耗
    /// </summary>
    public partial class ConsumeCards : UserControl
    {
        // 运动总时间
        public string TotalTime { get; set; }
        // 卡路里消耗
        public string TotalCal { get; set; }
        public ISeriesView<double> CalSeries { get; set; }
        public SeriesCollection TimeSeries { get; set; }
        public string Today { get; set; }
        public ConsumeCards()
        {
            InitializeComponent();
            TotalTime = "0";
            TotalCal = "0";
            CalSeries = new ISeriesView<double> { 0, 0, 0, 0, 0, 0, 0 };
            TimeSeries = new SeriesCollection
            {
                new LineSeries
                {
                    AreaLimit = -10,
                    Values = new ISeriesView<ObservableValue>
                    {
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0),
                        new ObservableValue(0)
                    }
                }
            };

            Today = DateTime.Now.AddDays(-6).Date.ToString("yyyy.MM.dd") + " - " + DateTime.Now.ToString("yyyy.MM.dd");
            //Today = DateTime.Now.ToLongDateString().ToString();
            DataContext = this;
        }

        private void UpdateOnclick(object sender, RoutedEventArgs e)
        {
            CalChart.Update(true);
            TimeChart.Update(true);
        }
    }
}
