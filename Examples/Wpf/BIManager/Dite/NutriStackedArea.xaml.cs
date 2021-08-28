using System;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Wpf.Annotations;

namespace Wpf
{
    /// <summary>
    /// 摄入与消耗
    /// </summary>
    public partial class NutriStackedArea : INotifyPropertyChanged
    {
        private Func<double, string> _yFormatter;

        public NutriStackedArea()
        {
            InitializeComponent();

            SeriesCollection = new SeriesCollection
            {
                ///<summary>
                /// FNutri.cs中重新初始化了参数，故以下的值不在前端展示
                /// </summary>
                new StackedAreaSeries
                {
                    Title = "运动消耗",
                    Values = new ISeriesView<DateTimePoint>
                    {
                        new DateTimePoint(new DateTime(2021, 6, 1), 300),
                        new DateTimePoint(new DateTime(2021, 6, 2), 600),
                        new DateTimePoint(new DateTime(2021, 6, 3), 700),
                        new DateTimePoint(new DateTime(2021, 6, 4), 900),
                        new DateTimePoint(new DateTime(2021, 6, 5), 320),
                        new DateTimePoint(new DateTime(2021, 6, 6), 620),
                        new DateTimePoint(new DateTime(2021, 6, 7), 200),
                        new DateTimePoint(new DateTime(2021, 6, 8), 500)
                    },
                    LineSmoothness = 0
                },
                new StackedAreaSeries
                {
                    Title = "基础代谢",
                    Values = new ISeriesView<DateTimePoint>
                    {
                        new DateTimePoint(new DateTime(2021, 6, 1), 1500),
                        new DateTimePoint(new DateTime(2021, 6, 2), 1500),
                        new DateTimePoint(new DateTime(2021, 6, 3), 1500),
                        new DateTimePoint(new DateTime(2021, 6, 4), 1500),
                        new DateTimePoint(new DateTime(2021, 6, 5), 1500),
                        new DateTimePoint(new DateTime(2021, 6, 6), 1500),
                        new DateTimePoint(new DateTime(2021, 6, 7), 1500),
                        new DateTimePoint(new DateTime(2021, 6, 10), 1500)
                    },
                    LineSmoothness = 0
                },
                new StackedAreaSeries
                {
                    Title = "摄入-消耗",
                    Values = new ISeriesView<DateTimePoint>
                    {
                        new DateTimePoint(new DateTime(2021, 6, 1), 300),
                        new DateTimePoint(new DateTime(2021, 6, 2), 200),
                        new DateTimePoint(new DateTime(2021, 6, 3), 100),
                        new DateTimePoint(new DateTime(2021, 6, 4), 300),
                        new DateTimePoint(new DateTime(2021, 6, 5), 250),
                        new DateTimePoint(new DateTime(2021, 6, 6), 400),
                        new DateTimePoint(new DateTime(2021, 6, 7), 500),
                        new DateTimePoint(DateTime.Now, 300)
                    },
                    LineSmoothness = 0
                }
            };

            XFormatter = val => new DateTime((long) val).ToString("yyyy-MM-dd");
            YFormatter = val => val.ToString("N") + " KCal";

            DataContext = this;
        }

        public SeriesCollection SeriesCollection { get; set; }
        public Func<double, string> XFormatter { get; set; }

        public Func<double, string> YFormatter
        {
            get { return _yFormatter; }
            set
            {
                _yFormatter = value;
                OnPropertyChanged();
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            if (PropertyChanged != null) PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
