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

namespace BIManager
{
    public partial class FAddSport : UIPage
    {
        public static SportService objSportService = new SportService();

        /// <summary>
        /// 获取当日运动总消耗量、糖原消耗量、脂肪消耗量
        /// </summary>
        /// <returns></returns>
        public Wpf.SportConsume getDailyConsumingData()
        {
            string userId = Program.currentAdmin.UserId;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            List<double> list = objSportService.getDailyConsuming(userId, date);
            if (list == null)
            {
                return new Wpf.SportConsume();
            }
            else
            {
                list[1] = list[1] < list[0] * 0.3 ? 0.3 * list[0] : list[1];
                list[2] = list[2] > list[0] * 0.7 ? 0.7 * list[0] : list[2];
                double sugar_rate = list[1] / list[0] * 100;
                double fat_rate = list[2] / list[0] * 100;
                return new Wpf.SportConsume()
                {
                    Total = list[0].ToString() + " KCal",
                    Sugar = list[1].ToString() + " KCal",
                    Fat = list[2].ToString() + " KCal",
                    DataSeries_up = new ISeriesView<double> { sugar_rate * 0.7, sugar_rate, 95, 95, fat_rate, fat_rate * 0.7 },
                    DataSeries_down = new ISeriesView<double> { -sugar_rate * 0.7, -sugar_rate, -95, -95, -fat_rate, -fat_rate * 0.7 },
                    Shadow_1_up = new ISeriesView<double> { (sugar_rate + 10) * 0.66, sugar_rate + 10, 105, 105, fat_rate + 10, (fat_rate + 10) * 0.66 },
                    Shadow_1_down = new ISeriesView<double> { -(sugar_rate + 10) * 0.66, -sugar_rate - 10, -105, -105, -fat_rate - 10, -(fat_rate + 10) * 0.66 },
                    Shadow_2_up = new ISeriesView<double> { (sugar_rate + 20) * 0.7, sugar_rate + 20, 115, 115, fat_rate + 20, (fat_rate + 20) * 0.7 },
                    Shadow_2_down = new ISeriesView<double> { -(sugar_rate + 20) * 0.7, -sugar_rate - 20, -115, -115, -fat_rate - 20, -(fat_rate + 20) * 0.7 },
                };
            }
        }
        /// <summary>
        /// 初始化方法
        /// </summary>
        public FAddSport()
        {
            InitializeComponent();
            Wpf.SportConsume sportConsume = getDailyConsumingData();
            this.elementHost1.Child = sportConsume;
        }

        public void ShowEdit(string sporttype)
        {
            Program.sporttype = sporttype;
            FSportEdit fSportEdit = new FSportEdit(sporttype);
            fSportEdit.ShowDialog();
            Wpf.SportConsume sportConsume = getDailyConsumingData();
            this.elementHost1.Child = sportConsume;
        }

        private void FAddSport_Initialize(object sender, EventArgs e)
        {

        }

        // 图片点击效果
        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox1.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox1.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.BorderStyle = BorderStyle.None;
        }

        private void pictureBox2_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox2.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox2_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox2.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox3.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox3.BorderStyle = BorderStyle.None;
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox3.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox3_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox3.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox4.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.BorderStyle = BorderStyle.None;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox4.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox4.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBox5_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox5.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox5.BorderStyle = BorderStyle.None;
        }

        private void pictureBox5_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox5.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox5_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox5.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBox6_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox6_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox6.BorderStyle = BorderStyle.None;
        }

        private void pictureBox6_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox6.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox6_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox6.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBox7_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox7.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox7_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox7.BorderStyle = BorderStyle.None;
        }

        private void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox7.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox7_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox7.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBox8_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox8.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox8.BorderStyle = BorderStyle.None;
        }

        private void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox8.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox8_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox8.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBox9_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox9.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox9_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox9.BorderStyle = BorderStyle.None;
        }

        private void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox9.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox9_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox9.BorderStyle = BorderStyle.FixedSingle;
        }
        private void pictureBox10_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox10.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox10_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox10.BorderStyle = BorderStyle.None;
        }

        private void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            this.pictureBox10.BorderStyle = BorderStyle.Fixed3D;
        }

        private void pictureBox10_MouseUp(object sender, MouseEventArgs e)
        {
            this.pictureBox10.BorderStyle = BorderStyle.FixedSingle;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ShowEdit("跑步");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowEdit("骑行");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowEdit("游泳");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowEdit("篮球");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowEdit("足球");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ShowEdit("排球");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowEdit("羽毛球");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ShowEdit("网球");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ShowEdit("乒乓球");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ShowEdit("自由活动");
        }
    }
}
