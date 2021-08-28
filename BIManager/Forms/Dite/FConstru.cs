using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;
using Sunny.UI;
using System;
using System.Drawing;
using DAL;
using System.Collections.Generic;
using Wpf;

namespace BIManager
{
    /// <summary>
    /// 营养结构
    /// </summary>
    public partial class FConstru : UITitlePage
    {
        private static DiteService objDiteService = new DiteService();
        public FConstru()
        {
            InitializeComponent();
            GetData();
        }
        public void GetData()
        {
            string userId = Program.currentAdmin.UserId;
            ISeriesView<ObservableValue> proterin_values = new ISeriesView<ObservableValue>();
            ISeriesView<ObservableValue> carb_values = new ISeriesView<ObservableValue>();
            ISeriesView<ObservableValue> fat_values = new ISeriesView<ObservableValue>();

            for (int i = -7; i <= 0; i++)
            {
                DateTime date = DateTime.Now.AddDays(i).Date;
                string selectedDate = date.ToString("yyyy-MM-dd");
                List<double> DailyDite = objDiteService.getDailyDite(userId, selectedDate);
                int protein = 0;
                int carb = 0;
                int fat = 0;
                if (DailyDite != null)
                {
                    protein = (int)Math.Round(DailyDite[2], 0);
                    carb = (int)Math.Round(DailyDite[3], 0);
                    fat = (int)Math.Round(DailyDite[4], 0);
                }

                proterin_values.Add(new ObservableValue(protein));
                carb_values.Add(new ObservableValue(carb));
                fat_values.Add(new ObservableValue(fat));
            }



            FoodConstruction foodConstruction = new FoodConstruction();
            foodConstruction.SeriesCollection = new SeriesCollection
            {
                new StackedRowSeries
                {
                    Title ="蛋白质",
                    Values =proterin_values,
                    DataLabels = true
                },
                new StackedRowSeries
                {
                    Title ="碳水化合物",
                    Values =carb_values,
                    DataLabels = true
                },
                new StackedRowSeries
                {
                    Title ="脂肪",
                    Values =fat_values,
                    DataLabels = true
                }
            };
            this.elementHost1.Child = foodConstruction;
        }
    }
}