using DAL;
using Model.User;
using Model.Health;
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

namespace BIManager
{
    /// <summary>
    /// 2021/6/11修改：在login成功后，进行多个全局变量的赋值
    /// </summary>
    public partial class FLogin : Form
    {
        private UserService objUserService = new UserService();//创建数据访问类对象
        private HealthService objHealthService = new HealthService();//创建数据访问类对象

        public FLogin()
        {
            InitializeComponent();
            // 引入一个wpf界面(不打开),让界面显示更高清并且使得主界面居中显示(暂时不清楚原理)
            Wpf.Window1 wpfwindow = new Wpf.Window1();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            //数据验证
            if (this.txtLoginId.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入登录账号！", "登录提示");
                this.txtLoginId.Focus();
                return;
            }

            if (this.txtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("请输入登录密码！", "登录提示");
                this.txtLoginPwd.Focus();
                return;
            }
            //封装用户信息到用户对象
            User objAdmin = new User()
            {
                UserId = this.txtLoginId.Text.Trim(),
                UserPwd = this.txtLoginPwd.Text.Trim()
            };
            try
            {
                //提交用户信息

                objAdmin = objUserService.AdminLogin(objAdmin);
                if (objAdmin == null)
                {
                    MessageBox.Show("登录账号或密码错误！", "登录提示");
                }
                else
                {
                    Program.currentAdmin = objAdmin; //保存用户对象
                    Program.userCurrHealth = objHealthService.getUserCurrHealth(objAdmin.UserId);// 加载用户健康数据
                    this.DialogResult = DialogResult.OK;//设置登录成功信息提示
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "登录失败！");
            }
        }

        private void uiSymbolButton3_Click(object sender, EventArgs e)
        {

        }

        private void uiSymbolButton25_Click(object sender, EventArgs e)
        {
            FRegister fRegister = new FRegister();
            fRegister.ShowDialog();
        }
    }
}
