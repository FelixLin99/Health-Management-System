using Sunny.UI;
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using System.Drawing;
using DAL;
using System.Collections.Generic;
using System;
using System.Data.SqlClient;

namespace BIManager
{
    /// <summary>
    /// 运动分布图表
    /// </summary>
    public partial class FDistribution : UITitlePage
    {

        public static SportService objSportService = new SportService();
        public FDistribution()
        {
            InitializeComponent();
            GetData();
        }
        public void GetData()
        {
            string userId = Program.currentAdmin.UserId;
            Wpf.DistriSport distriSport = null;
            Wpf.DistriTime distriTime = null;
            Wpf.DistriAccount distriAccount = null;

            // 判断用户有无运动记录
            // 用户无运动记录，则全部图形对象采用默认构造函数
            if (!objSportService.hasRecord(userId))
            {
                distriSport = new Wpf.DistriSport();
                distriTime = new Wpf.DistriTime();
                distriAccount = new Wpf.DistriAccount();
            }
            // 用户有运动记录
            else
            {
                ///<part>
                /// 1. distriSport
                /// </part>
                //拿到用户在V_SportAggr表的数据
                distriSport = new Wpf.DistriSport();
                SqlDataReader reader = objSportService.getSportAggr(userId);
                if (reader != null)
                {
                    int row = 0;
                    List<string> titles = new List<string>();
                    List<double> pieValues = new List<double>();
                    while (reader.Read())
                    {
                        // sql查询的结果，已将最喜爱的运动放在第一行。
                        if (row == 0)
                        {
                            distriSport.FavoriteSport = reader["SportType"].ToString();
                            distriSport.Time = reader["Total_Duration"].ToString();
                            distriSport.Cal = reader["Total_Consuming"].ToString();
                        }
                        titles.Add(reader["SportType"].ToString());
                        pieValues.Add(Convert.ToDouble(reader["cnt"].ToString()));
                        row += 1;
                    }
                    distriSport.GetPieSeriesData(titles, pieValues);
                }

                ///<part>
                /// 2. distriTime
                /// </part>
                distriTime = new Wpf.DistriTime();
                // 拿到用户运动时常分布数据
                List<double> Time_pieValues = objSportService.getSportTimeDistribute(userId);
                if (Time_pieValues != null)
                {
                    List<string> Time_title = new List<string> { "0-30 min", "30-60 min", "60+ min" };
                    distriTime.GetPieSeriesData(Time_title, Time_pieValues);
                }
                // 获得最长一次运动时间
                string longestTime = objSportService.getLongestSportTime(userId);
                distriTime.LongestTime = longestTime + " Min";
                // 获得平均每次运动时间
                string avgtTime = objSportService.getAvgUnitSportTime(userId);
                distriTime.AvgTime = avgtTime;
                // 获得平均每天运动时间
                string dailyTime = objSportService.getAvgDailySportTime(userId);
                distriTime.DailyTime = dailyTime;

                ///<part>
                /// 3. distriAccount
                /// </part>

                distriAccount = new Wpf.DistriAccount();
                // 获得运动强度分布数据   
                List<double> intensity_pievalues = objSportService.getIntensityDistrubute(userId);
                if (intensity_pievalues != null)
                {
                    List<string> intensity_titles = new List<string> { "低强度", "中强度", "高强度" };
                    distriAccount.GetPieSeriesData(intensity_titles, intensity_pievalues);
                }
                // 获得最高一次消耗卡路里数据
                string highestCal = objSportService.getHighestCal(userId) + " KCal";
                distriAccount.HighestCal = highestCal;
                // 获得平均每天消耗卡路里数据
                string dailyCal = objSportService.getDailyCal(userId);
                distriAccount.DailyCal = dailyCal;
                // 获得平均每次运动消耗卡路里数据
                string avgCal = objSportService.getAvgUnitSportCal(userId);
                distriAccount.AvgCal = avgCal;
            }

            this.elementHost1.Child = distriSport;
            this.elementHost2.Child = distriTime;
            this.elementHost3.Child = distriAccount;
        }
    }
}