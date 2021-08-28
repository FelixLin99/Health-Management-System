using LiveCharts;
using LiveCharts.Wpf;
using System;
using System.Collections.Generic;

namespace Wpf
{
    public class ChartModel
    {

        SeriesCollection lineSeriesCollection = new SeriesCollection();
        SeriesCollection colunmSeriesCollection = new SeriesCollection();
        SeriesCollection pieSeriesCollection = new SeriesCollection();
        List<string> _lineXLabels = new List<string>();
        List<string> _columnXLabels = new List<string>();

        public ChartModel()
        {
            GetLineSeriesData();
            GetColunmSeriesData();
            GetPieSeriesData();
        }

        public List<int> ConsumeColumn
        {
            get
            {
                return new List<int> { 9, 9, 8, 6, 1, 5, 7, 3, 6, 3 };
            }
        }

        #region 属性
        /// <summary>
        /// 折线图集合
        /// </summary>
        public SeriesCollection LineSeriesCollection
        {
            get
            {
                return lineSeriesCollection;
            }

            set
            {
                lineSeriesCollection = value;
            }
        }

        /// <summary>
        /// 柱状图集合
        /// </summary>
        public SeriesCollection ColunmSeriesCollection
        {
            get
            {
                return colunmSeriesCollection;
            }

            set
            {
                colunmSeriesCollection = value;
            }
        }

        /// <summary>
        /// 饼图图集合
        /// </summary>
        public SeriesCollection PieSeriesCollection
        {
            get
            {
                return pieSeriesCollection;
            }

            set
            {
                pieSeriesCollection = value;
            }
        }

        /// <summary>
        /// 折线图X坐标
        /// </summary>
        public List<string> LineXLabels
        {
            get
            {
                return _lineXLabels;
            }

            set
            {
                _lineXLabels = value;
            }
        }

        /// <summary>
        /// 柱状图X坐标
        /// </summary>
        public List<string> ColumnXLabels
        {
            get
            {
                return _columnXLabels;
            }

            set
            {
                _columnXLabels = value;
            }
        }
        #endregion

        #region 方法
        void GetLineSeriesData()
        {
            List<string> titles = new List<string> { "苹果", "香蕉", "梨" };
            List<List<double>> values = new List<List<double>>
            {
                new List<double> { 30, 40, 60 },
                new List<double> { 20, 10, 50 },
                new List<double> { 10, 50, 30 }
            };
            List<string> _dates = new List<string>();
            _dates = GetCurrentMonthDates();
            for (int i = 0; i < titles.Count; i++)
            {
                LineSeries lineseries = new LineSeries();
                lineseries.DataLabels = true;
                lineseries.Title = titles[i];
                lineseries.Values = new ISeriesView<double>(values[i]);
                LineXLabels.Add(_dates[i]);
                LineSeriesCollection.Add(lineseries);
            }
        }

        void GetColunmSeriesData()
        {
            List<string> titles = new List<string> { "Edge", "Chrome", "Firefox", "Other" };
            List<double> columnValues = new List<double> { 4, 3, 1, 5};

            for (int i = 0; i < titles.Count; i++)
            {
                ColumnXLabels.Add(titles[i]);
            }
            ColumnSeries colunmseries = new ColumnSeries();
            colunmseries.DataLabels = true;
            colunmseries.Title = "浏览器份额";
            colunmseries.Values = new ISeriesView<double>(columnValues);
            ColunmSeriesCollection.Add(colunmseries);

        }


        void GetPieSeriesData()
        {
            List<string> titles = new List<string> { "跑步", "游泳", "骑行" };
            List<double> pieValues = new List<double> { 60, 30, 10 };
            ISeriesView<double> chartvalue = new ISeriesView<double>();
            for (int i = 0; i < titles.Count; i++)
            {
                chartvalue = new ISeriesView<double>();
                chartvalue.Add(pieValues[i]);
                PieSeries series = new PieSeries();
                series.DataLabels = true;
                series.Title = titles[i];
                series.Values = chartvalue;
                PieSeriesCollection.Add(series);
            }
        }

        void ThreeColumnData()
        {
            List<string> titles = new List<string> { "苹果", "香蕉", "梨" };
            //三列示例数据
            List<List<double>> threeColunmValues = new List<List<double>>
            {
                new List<double> { 30, 40, 60 },
                new List<double> { 20, 10, 50 },
                new List<double> { 10, 50, 30 }
            };


            for (int i = 0; i < titles.Count; i++)
            {
                ColumnSeries colunmseries = new ColumnSeries();
                colunmseries.DataLabels = true;
                colunmseries.Title = titles[i];
                colunmseries.Values = new ISeriesView<double>(threeColunmValues[i]);

                ColunmSeriesCollection.Add(colunmseries);
            }
        }

        /// <summary>
        /// 获取当前月的每天的日期
        /// </summary>
        /// <returns>日期集合</returns>
        List<string> GetCurrentMonthDates()
        {
            List<string> dates = new List<string>();
            DateTime dt = DateTime.Now;
            int year = dt.Year;
            int mouth = dt.Month;
            int days = DateTime.DaysInMonth(year, mouth);
            //本月第一天时间      
            DateTime dt_First = dt.AddDays(1 - (dt.Day));
            dates.Add(String.Format("{0:d}", dt_First.Date));

            for (int i = 1; i < days; i++)
            {
                DateTime temp = dt_First.AddDays(i);
                dates.Add(String.Format("{0:d}", temp.Date));
            }
            return dates;
        }
        #endregion
    }
}