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
using BIManager;
using LiveCharts;
using DAL;

namespace BIManager
{
    public partial class FAddDite : UIPage
    {
        public static SportService objSportService = new SportService();
        
        /// <summary>
        /// 用于获取运动消耗、糖原消耗、脂肪消耗数据的函数
        /// </summary>
        /// <returns></returns>
        public Wpf.FoodConsume getDailyFoodConsumingData()
        {
            string userId = Program.currentAdmin.UserId;
            string date = DateTime.Now.ToString("yyyy-MM-dd");
            List<double> list = objSportService.getDailyIntakeAndConsuming(userId, date);

            if (list == null)
            {
                return new Wpf.FoodConsume();
            }
            else
            {
                // 总摄入
                double total = list[0];
                // 基础代谢后剩余
                double reduce = list[0] - 1500 > 0 ? list[0] - 1500  : 0;
                // 运动消耗后剩余
                double final = list[0] - 1500 - list[1] > 0 ? list[0] - 1500 - list[1] : 0;
                return new Wpf.FoodConsume()
                {
                    Total = total.ToString() + " KCal",
                    Reduce = reduce.ToString() + " KCal",
                    Final = final.ToString() + " KCal",
                    DataSeries_up = new ISeriesView<double> { 95, 95*0.85, 95 * reduce / total,95 * reduce * 0.85 / total , 95 * final / total , 95 * final * 0.7 / total },
                    DataSeries_down = new ISeriesView<double> { -95, -95*0.85, -95 * reduce / total, -95 * reduce * 0.85 / total, -95 * final / total, -95 * final * 0.7 / total },
                    Shadow_1_up = new ISeriesView<double> { 105, 105*0.85, 105 * reduce / total+5, 105 * reduce * 0.85 / total+4, 105 * final / total+3, 105 * final * 0.7 / total+2 },
                    Shadow_1_down = new ISeriesView<double> { -105, -105*0.85, -105 * reduce / total-5, -105 * reduce * 0.85 / total-4, -105 * final / total-3, -105 * final * 0.7 / total-2 },
                    Shadow_2_up = new ISeriesView<double> { 115, 115*0.85, 115 * reduce / total+10, 115 * reduce * 0.85 / total+8, 115 * final / total+6, 115 * final * 0.7 / total+4 },
                    Shadow_2_down = new ISeriesView<double> { -115, -115*0.85, -115 * reduce / total-10, -115 * reduce * 0.85 / total-8, -115 * final / total-6, -115 * final * 0.7 / total-4 }
                };
            }
        }


        public FAddDite()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            Wpf.FoodConsume foodConsume = getDailyFoodConsumingData();
            this.elementHost1.Child = foodConsume;
        }

        private void FAddSport_Initialize(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 显示饮食添加窗口
        /// </summary>
        /// <param name="sporttype"></param>
        public void ShowEdit(string foodtype)
        {
            Program.foodtype = foodtype;
            FDiteEdit fDiteEdit = new FDiteEdit(foodtype);
            fDiteEdit.ShowDialog();
            GetData();
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
            ShowEdit("谷物米面");
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ShowEdit("面包烘焙");
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            ShowEdit("兽禽肉类");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            ShowEdit("鱼虾海鲜");
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            ShowEdit("蛋类");
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            ShowEdit("蔬菜");
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            ShowEdit("水果");
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            ShowEdit("牛奶");
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            ShowEdit("甜品");
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            ShowEdit("油脂");
        }
    }
}
