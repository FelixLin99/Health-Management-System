using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Sunny.UI;
using System.Drawing;
using DAL;
using System.Collections.Generic;
using System;

namespace BIManager
{
    /// <summary>
    /// 运动消耗图表
    /// </summary>
    public partial class FConsume : UITitlePage
    {
        public static SportService objSportService = new SportService();
        public FConsume()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            string userId = Program.currentAdmin.UserId;
            List<double> tmp = objSportService.getUserWeeklyConsumingAndDuration(userId);

            // 7日内用户无运动记录，使用默认构造函数
            if (tmp == null)
            {
                Wpf.ConsumeCards consumeCards = new Wpf.ConsumeCards();
                this.elementHost1.Child = consumeCards;
            }
            // 7日内用户有运动记录
            else
            {
                string arg_TotalTime = tmp[0].ToString();
                string arg_TotalCal = tmp[1].ToString();
                ISeriesView<double> arg_CalSeries = new ISeriesView<double>();
                ISeriesView<ObservableValue> arg_ValuesOfTime = new ISeriesView<ObservableValue>();
                double maxCal = 0;


                for (int i = -6; i <= 0; i++)
                {
                    string selectedDate = DateTime.Now.AddDays(i).Date.ToString("yyyy-MM-dd");
                    List<double> userDailyRecord = objSportService.getDailyConsuming(userId, selectedDate);

                    // 如果无当天记录，则：运动时长=0  运动消耗=0
                    if (userDailyRecord == null)
                    {
                        arg_CalSeries.Add(0);
                        arg_ValuesOfTime.Add(new ObservableValue(0));
                    }
                    // 如果当天有运动记录：
                    else
                    {
                        arg_CalSeries.Add(userDailyRecord[0]);
                        arg_ValuesOfTime.Add(new ObservableValue(userDailyRecord[3]));
                        // 取出七天内最大的单天卡路里消耗，用于调试成画图数据的量级（0-10）
                        maxCal = maxCal < userDailyRecord[0] ? userDailyRecord[0] : maxCal;
                    }
                }

                // 将CalSeries中的数据转化为百分比
                for (int j = 0; j < 7; j++)
                {
                    arg_CalSeries[j] = arg_CalSeries[j] / maxCal * 10;
                }

                Wpf.ConsumeCards consumeCards = new Wpf.ConsumeCards()
                {
                    TotalTime = arg_TotalTime,
                    TotalCal = arg_TotalCal,
                    CalSeries = arg_CalSeries,
                    TimeSeries = new SeriesCollection {
                        new LineSeries
                        {
                            AreaLimit = -10,
                            Values = arg_ValuesOfTime
                        }
                    }
                };
                this.elementHost1.Child = consumeCards;

            }
        }
    }
}