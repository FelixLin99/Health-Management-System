using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.Defaults;

namespace BIManager
{
    /// <summary>
    /// 饮食特点
    /// </summary>
    public partial class FDiteRecom : UITitlePage
    {
        private static DiteService objDiteService = new DiteService();
        public FDiteRecom()
        {
            InitializeComponent();
            GetData();
        }
        public void GetData()
        {
            string userId = Program.currentAdmin.UserId;


            ///<part>
            /// 1. DistriFood数据准备
            /// </part>
            Wpf.DistriFood distriFood = new Wpf.DistriFood();
            SeriesCollection foodSeriesCollection = new SeriesCollection() { };
            DataTable dataTable = objDiteService.getDiteTypeDistribute(userId);
            // 存在饮食记录，才自定义初始化参数
            if (dataTable != null)
            {
                int count = dataTable.Rows.Count;
                int range = count > 4 ? 4 : count;
                // 只取前四种
                for (int i = 0; i < range; i++)
                {
                    // 由于ORDER BY操作，第一行已经是摄入量最多的食物
                    if (i == 0)
                    {
                        distriFood.FavoriteFood = dataTable.Rows[0]["FoodName"].ToString();
                        distriFood.Amount = dataTable.Rows[0]["Total_IntakeAmt"].ToString();
                        distriFood.Cal = dataTable.Rows[0]["Total_Energy"].ToString();
                    }
                    // 绘图数据
                    foodSeriesCollection.Add(new PieSeries
                    {
                        Title = dataTable.Rows[i]["FoodName"].ToString(),
                        Values = new ISeriesView<ObservableValue> { new ObservableValue(Convert.ToDouble(dataTable.Rows[i]["Total_IntakeAmt"])) },
                        DataLabels = true
                    });
                }
                distriFood.SeriesCollection = foodSeriesCollection;

            }
            this.elementHost1.Child = distriFood;

            ///<part>
            /// 2. DistriNutri数据准备
            /// </part>
            Wpf.DistriNutri distriNutri = new Wpf.DistriNutri();
            List<int> nutriList = objDiteService.getDiteNutriDistribute(userId);
            // 存在饮食记录，才自定义初始化参数
            if (nutriList != null)
            {
                // 绘图数据
                SeriesCollection nutriSeriesCollection = new SeriesCollection();
                nutriSeriesCollection.Add(new PieSeries
                {
                    Title = "蛋白质",
                    Values = new ISeriesView<ObservableValue> { new ObservableValue(nutriList[0]) },
                    DataLabels = true
                });
                nutriSeriesCollection.Add(new PieSeries
                {
                    Title = "脂肪",
                    Values = new ISeriesView<ObservableValue> { new ObservableValue(nutriList[1]) },
                    DataLabels = true
                });
                nutriSeriesCollection.Add(new PieSeries
                {
                    Title = "碳水",
                    Values = new ISeriesView<ObservableValue> { new ObservableValue(nutriList[2]) },
                    DataLabels = true
                });
                distriNutri.SeriesCollection = nutriSeriesCollection;
                // 比例数据
                string nutriProportion = "1 : "
                    + Math.Round((double)nutriList[1] / nutriList[0], 1).ToString()
                    + " : "
                    + Math.Round((double)nutriList[2] / nutriList[0], 1).ToString();
                distriNutri.Proportion = nutriProportion;
                //建议
                string[] tmpList = new string[] { "蛋白质", "脂肪", "碳水" };
                int idxOfMin = nutriList.IndexOf(nutriList.Min());
                int idxOfMax = nutriList.IndexOf(nutriList.Max());
                distriNutri.Reduce = tmpList[idxOfMax];
                distriNutri.Add = tmpList[idxOfMin];
            }
            this.elementHost2.Child = distriNutri;


            ///<part>
            /// 3. DistriHeat数据准备
            /// </part>
            Wpf.DistriHeat distriHeat = new Wpf.DistriHeat();
            SeriesCollection heatSeriesCollection = new SeriesCollection();
            string DailyHeat = objDiteService.getDailyDiteEnergy(userId);
            string AvgHeat = objDiteService.getAvgDiteEnergyPer100g(userId);
            List<string> list = objDiteService.getDiteEnergyDistribute(userId);
            string HeatLevel = list[0];

            heatSeriesCollection.Add(new PieSeries
            {
                Title = "高热量",
                Values = new ISeriesView<ObservableValue> { new ObservableValue(int.Parse(list[1])) },
                DataLabels = true
            });
            heatSeriesCollection.Add(new PieSeries
            {
                Title = "中热量",
                Values = new ISeriesView<ObservableValue> { new ObservableValue(int.Parse(list[2])) },
                DataLabels = true
            });
            heatSeriesCollection.Add(new PieSeries
            {
                Title = "低热量",
                Values = new ISeriesView<ObservableValue> { new ObservableValue(int.Parse(list[3])) },
                DataLabels = true
            });

            distriHeat.HeatLevel = HeatLevel;
            distriHeat.AvgHeat = AvgHeat;
            distriHeat.DailyHeat = DailyHeat;
            distriHeat.SeriesCollection = heatSeriesCollection;
            this.elementHost3.Child = distriHeat;
        }


        private void PagePanel_Click(object sender, EventArgs e)
        {

        }
    }
}
