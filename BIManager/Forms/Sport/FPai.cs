using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using DAL;
using LiveCharts;

namespace BIManager
{
    public partial class FPai : UITitlePage
    {
        private static SportService objSportService = new SportService();
        List<Data> datas = new List<Data>();
        public FPai()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            string userId = Program.currentAdmin.UserId;
            string today = DateTime.Now.ToString("yyyy-MM-dd");
            ISeriesView<double> paiValues = new ISeriesView<double> { 0, 0, 0, 0, 0, 0, 0 };
            double bestPai = 0;
            double curPai = 0;

            ///<summary>
            /// 准备数据
            /// </summary>
            for (int i = 0; i >= -6; i--)
            {
                DateTime date = DateTime.Now.AddDays(i);
                List<int> dailyData = objSportService.getFPaiData(userId, date.ToString("yyyy-MM-dd"));

                // 准备画图数据
                paiValues[6 + i] = dailyData[2];
                bestPai = dailyData[2] > bestPai ? dailyData[2] : bestPai;
                curPai = i == 0 ? dailyData[2] : curPai;

                // 准备表格数据
                Data data = new Data();
                data.Date = date.Date;
                data.Duration = dailyData[0];
                data.Consuming = dailyData[1];
                data.PAI = dailyData[2];
                data.State = data.PAI > 100 ? "是" : "否";
                datas.Add(data);
            }

            ///<summary>
            /// 填充表格数据
            /// </summary>
            /// // 防止修改原有列名和生成无关列
            this.uiDataGridView1.AutoGenerateColumns = false;
            // 先清空DGV的旧数据源,否则不会更新
            this.uiDataGridView1.DataSource = null;
            uiDataGridView1.AddColumn("日期", "Date").SetFixedMode(150);
            uiDataGridView1.AddColumn("运动时间", "Duration").SetFixedMode(150);
            uiDataGridView1.AddColumn("运动消耗", "Consuming").SetFixedMode(150);
            uiDataGridView1.AddColumn("机能指数", "PAI").SetFixedMode(150);
            uiDataGridView1.AddColumn("是否达标", "State").SetFixedMode(150);
            uiDataGridView1.ReadOnly = true;
            this.uiDataGridView1.DataSource = datas;


            ///<summary>
            /// 填充pai折线图数据
            /// </summary>
            Wpf.PaiLineChart paiLineChart = new Wpf.PaiLineChart();
            paiLineChart.CurPai = curPai.ToString();
            paiLineChart.BestPai = bestPai.ToString();
            paiLineChart.Values = paiValues;
            this.elementHost1.Child = paiLineChart;
        }

        public class Data
        {
            public DateTime Date { get; set; }

            public double Duration { get; set; }

            public double Consuming { get; set; }

            public double PAI { get; set; }

            public string State { get; set; }
        }

        /// <summary>
        /// 按照PAI降序排列
        /// </summary>
        class BmiDESC : IComparer<Data>
        {
            public int Compare(Data x, Data y)
            {
                return y.PAI.CompareTo(x.PAI);
            }
        }

        /// <summary>
        /// 按照BMI升序排列
        /// </summary>
        class BmiASC : IComparer<Data>
        {
            public int Compare(Data x, Data y)
            {
                return x.PAI.CompareTo(y.PAI);
            }
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            if (datas != null && this.uiDataGridView1.RowCount != 0)
            {
                this.datas.Sort(new BmiASC());// 使用比较器对其进行排序
                this.uiDataGridView1.DataSource = null;
                this.uiDataGridView1.DataSource = datas;
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            if (datas != null && this.uiDataGridView1.RowCount != 0)
            {
                this.datas.Sort(new BmiDESC());// 使用比较器对其进行排序
                this.uiDataGridView1.DataSource = null;
                this.uiDataGridView1.DataSource = datas;
            }
        }
    }
}
