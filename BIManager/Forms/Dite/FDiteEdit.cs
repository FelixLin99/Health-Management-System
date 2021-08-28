using DAL;
using Model;
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
using Model.Dite;
using DAL.DBUtility;

namespace BIManager
{
    public partial class FDiteEdit : Form
    {
        private DiteService objDiteService = new DiteService();
        public FDiteEdit(string foodType)
        {
            InitializeComponent();
            this.uiLabel1.Text = foodType;
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 提交饮食记录
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            int intakeAmount = intakeAmountBox.Value;
            string sugarAmount = sugarRateBox.Text.Trim();

            //数据校验
            if (intakeAmount < 1 || intakeAmount > 10000)
            {
                MessageBox.Show("摄入量不应超过10Kg！", "提示");
                return;
            }

            double sugarRate = 0;
            if (sugarAmount.Equals("不含糖"))
                sugarRate = 0;
            else if (sugarAmount.Equals("少量糖"))
                sugarRate = 0.1;
            else if (sugarAmount.Equals("中等糖"))
                sugarRate = 0.2;
            else if (sugarAmount.Equals("大量糖"))
                sugarRate = 0.3;
            else
            {
                MessageBox.Show("请正确选择含糖量！", "提示");
                return;
            }

            UserDite userDite = new UserDite()
            {
                userId = Program.currentAdmin.UserId,
                foodName = Program.foodtype,
                intakeDate = DateTime.Now.ToString("yyyy-MM-dd"),
                intakeAmount = intakeAmount,
                sugarRate = sugarRate
            };

            // 查重
            string sql = "SELECT COUNT(*) FROM UserDite WHERE UserId = '{0}' AND FoodName = '{1}' AND IntakeDate = '{2}'";
            sql = string.Format(sql, userDite.userId, userDite.foodName, userDite.intakeDate);
            int judg = 0;
            judg = Convert.ToInt32(DBHelper.GetSingleResult(sql));
            int res = -1;
            if (judg > 0)
            {
                res = objDiteService.UpdateRecord(userDite);
            }
            else
            {
                res = objDiteService.InsertNewRecord(userDite);
            }
            if (res == 1)
            {
                MessageBox.Show("提交成功!", "提示");
                // 更新营养结构界面
                Program.fConstru.GetData();
                // 更新摄入与消耗界面
                Program.fNutri.GetData();
                // 更新饮食特点分析界面
                Program.fDiteRecom.GetData();
                this.Close();
            }
            else
            {
                MessageBox.Show("提交失败!");
            }


        }
    }
}
