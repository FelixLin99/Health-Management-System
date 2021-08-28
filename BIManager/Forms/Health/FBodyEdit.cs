using DAL;
using Model.Health;
using Model.User;
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
using DAL.DBUtility;

namespace BIManager
{
    public partial class FBodyEdit : Form
    {
        private UserService objUserService = new UserService();//创建数据访问类对象
        private HealthService objHealthService = new HealthService();//创建数据访问类对象
        public FBodyEdit()
        {
            InitializeComponent();
            if (Program.userCurrHealth != null)
            {
                this.txtHeightBox.Value = Program.userCurrHealth.height;
                this.txtWeightBox.Value = Program.userCurrHealth.weight;
                this.txtFatBox.Value = Program.userCurrHealth.fatRate;
            }
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 提交饮食记录
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {

            int height = txtHeightBox.Value;
            int weight = txtWeightBox.Value;
            int fatRate = txtFatBox.Value;

            // 数据校验
            if (height<=0 || height > 250)
            {
                MessageBox.Show("身高范围应在0-250cm之间!", "修改提示");
                txtHeightBox.Focus();
                return;
            }

            if(weight<=0 || weight>1000)
            {
                MessageBox.Show("体重范围应在0-1000kg之间!", "修改提示");
                txtHeightBox.Focus();
                return;
            }

            if (fatRate<= 0 || fatRate > 100)
            {
                MessageBox.Show("体脂率范围应在0-100之间!", "修改提示");
                txtHeightBox.Focus();
                return;
            }


            UserHealth tmp_userHealth = new UserHealth()
            {
                userId = Program.currentAdmin.UserId,
                writeInDate = DateTime.Now.ToString("yyyy-MM-dd"),
                height = height,
                weight = weight,
                fatRate = fatRate
            };

            int res = 0;
            int judg = 0;
            //判断该用户改天是否已经有数据
            string sql1 = "SELECT COUNT(*) FROM UserInfo WHERE userId = '{0}' AND WriteInDate = '{1}'";
            sql1 = string.Format(sql1, tmp_userHealth.userId, tmp_userHealth.writeInDate);
            judg = Convert.ToInt32(DBHelper.GetSingleResult(sql1));
            //新增数据
            if (judg == 0)
            {
                res = objHealthService.insertUserHealth(tmp_userHealth);
            }
            // 更新数据
            else
            {
                res = objHealthService.updateUserHealth(tmp_userHealth);
            }

            //判断是否新增、更新成功
            if (res == 1)
            {
                MessageBox.Show("数据更新成功!", "修改提示");
                Program.userCurrHealth = objHealthService.getUserCurrHealth(Program.currentAdmin.UserId);// 加载用户健康数据
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败!");
            }


        }
    }
}
