using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Sunny.UI;
using System;
using System.Drawing;
using DAL;
using System.Collections.Generic;

namespace BIManager
{
    /// <summary>
    /// 摄入与消耗
    /// </summary>
    public partial class FNutri : UITitlePage
    {
        private static SportService objSportService = new SportService();
        private static DiteService objDiteService = new DiteService();
        public FNutri()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            string userId = Program.currentAdmin.UserId;

            // 需要为SeriesCollection赋值，核心数据为三个StackedAreaSeries对象。
            StackedAreaSeries stackSport = new StackedAreaSeries()
            {
                Title = "运动消耗",
                Values = null,
                LineSmoothness = 1
            };
            StackedAreaSeries stackMeta = new StackedAreaSeries()
            {
                Title = "基础代谢",
                Values = null,
                LineSmoothness = 1
            };
            StackedAreaSeries stackLoss = new StackedAreaSeries()
            {
                Title = "摄入-消耗",
                Values = null,
                LineSmoothness = 1
            };
            // 判断是否有身高体重数据来计算基础代谢
            //计算基础代谢
            int meta = 1500;
            if (Program.userCurrHealth != null)
            {
                meta = 1500;
                ISeriesView<DateTimePoint> meta_values = new ISeriesView<DateTimePoint> { };
                for (int i = -7; i <= 0; i++)
                {
                    DateTime date = DateTime.Now.AddDays(i).Date;
                    meta_values.Add(new DateTimePoint(date, meta));
                }
                stackMeta.Values = meta_values;
            };

            // 计算近8日每日 运动消耗 和 摄入-消耗
            ISeriesView<DateTimePoint> sport_values = new ISeriesView<DateTimePoint> { };
            ISeriesView<DateTimePoint> loss_values = new ISeriesView<DateTimePoint> { };
            for (int i = -7; i <= 0; i++)
            {
                DateTime date = DateTime.Now.AddDays(i).Date;
                string selectedDate = date.ToString("yyyy-MM-dd");
                List<double> DailySport = objSportService.getDailyConsuming(userId, selectedDate);
                List<double> DailyDite = objDiteService.getDailyDite(userId, selectedDate);
                //如果当天没有饮食记录，则摄入=0
                int intake = 0;
                //如果当天没有运动记录，则运动消耗=0
                int consuming = 0;
                //摄入-消耗 初始化
                int loss = 0;

                if (DailySport != null)
                    consuming = (int)Math.Round(DailySport[0], 0);
                if (DailyDite != null)
                    intake = (int)Math.Round(DailyDite[0], 0);

                sport_values.Add(new DateTimePoint(date, consuming));
                // 增强图的鲁棒性
                loss = (intake - consuming - meta) > 0 ? intake - consuming - meta : 0;
                loss_values.Add(new DateTimePoint(date, loss));
            }
            stackSport.Values = sport_values;
            stackLoss.Values = loss_values;

            Wpf.NutriStackedArea nutriStackedArea = new Wpf.NutriStackedArea() { };
            nutriStackedArea.SeriesCollection = new SeriesCollection { stackSport, stackMeta, stackLoss };
            this.elementHost1.Child = nutriStackedArea;
        }
    }
}