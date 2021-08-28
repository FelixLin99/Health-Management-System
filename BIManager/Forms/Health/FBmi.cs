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
using System.Data;
using System.Data.SqlClient;
using LiveCharts;

namespace BIManager
{
    public partial class FBmi : UITitlePage
    {
        List<Data> datas = new List<Data>();
        public static HealthService objHealthService = new HealthService();
        public FBmi()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            ///<summary>
            /// BMI折线图数据
            /// 以月为单位展示BMI数据变动
            /// </summary>

            //判断 用户是否有健康数据，没有则置0
            double arg_CurBMI = 0;
            if (Program.userCurrHealth != null)
            {
                arg_CurBMI = Program.userCurrHealth.BMI;
            }

            double arg_BestBMI = objHealthService.getBestBMI(Program.currentAdmin.UserId);
            // 默认数据为0
            ISeriesView<double> values = new ISeriesView<double> { 0, 0, 0, 0, 0, 0 };
            int tmp = 5;
            SqlDataReader reader = objHealthService.getUserMonthHealth(Program.currentAdmin.UserId);
            if (reader != null)
            {
                while (reader.Read())
                {
                    if (tmp < 0)
                        break;
                    else
                    {
                        values[tmp] = Convert.ToDouble(reader["BMI"].ToString());
                        tmp -= 1;
                    }
                }
            }
            Wpf.BmiLineChart bmiLineChart = new Wpf.BmiLineChart()
            {
                Values = values,
                CurBMI = arg_CurBMI.ToString(),
                BestBMI = arg_BestBMI.ToString()
            };

            this.elementHost1.Child = bmiLineChart;

            ///<summary>
            /// BMI表格数据
            /// 以月为单位展示BMI数据变动
            /// </summary>
            this.uiDataGridView1.AddColumn("年月", "Date").SetFixedMode(150);
            this.uiDataGridView1.AddColumn("身高", "Height").SetFixedMode(150);
            this.uiDataGridView1.AddColumn("月均体重", "Weight").SetFixedMode(150);
            this.uiDataGridView1.AddColumn("月均BMI", "BMI").SetFixedMode(150);
            this.uiDataGridView1.AddColumn("月均状态", "State").SetFixedMode(150);
            this.uiDataGridView1.ReadOnly = true;

            // 清空datas
            datas.Clear();
            reader = objHealthService.getUserMonthHealth(Program.currentAdmin.UserId);
            if (reader != null)
            {
                while (reader.Read())
                {
                    Data data = new Data();
                    data.Date = reader["Month"].ToString().Left(7);
                    data.Height = Convert.ToDouble(reader["Height"].ToString());
                    data.Weight = Convert.ToDouble(reader["Weight"].ToString());
                    data.BMI = Math.Round(Convert.ToDouble(reader["BMI"].ToString()), 1);
                    if (data.BMI <= 18.4)
                        data.State = "偏瘦";
                    else if (data.BMI < 24)
                        data.State = "正常";
                    else if (data.BMI < 28)
                        data.State = "过重";
                    else
                        data.State = "肥胖";
                    datas.Add(data);
                }
            }
            
            // 防止修改原有列名和生成无关列
            this.uiDataGridView1.AutoGenerateColumns = false;
            // 先清空DGV的旧数据源,否则不会更新
            this.uiDataGridView1.DataSource = null;
            this.uiDataGridView1.DataSource = datas;
        }

        /// <summary>
        /// 用于绘制健康表格的样例类
        /// </summary>
        public class Data
        {
            public String Date { get; set; }

            public double Height { get; set; }

            public double Weight { get; set; }

            public double BMI { get; set; }

            public string State { get; set; }
        }

        /// <summary>
        /// 按照BMI降序排列
        /// </summary>
        class BmiDESC : IComparer<Data>
        {
            public int Compare(Data x, Data y)
            {
                return y.BMI.CompareTo(x.BMI);
            }
        }

        /// <summary>
        /// 按照BMI升序排列
        /// </summary>
        class BmiASC : IComparer<Data>
        {
            public int Compare(Data x, Data y)
            {
                return x.BMI.CompareTo(y.BMI);
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
