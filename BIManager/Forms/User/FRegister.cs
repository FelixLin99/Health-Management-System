using DAL;
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
using DAL.DBUtility;

namespace BIManager
{
    public partial class FRegister : Form
    {
        private UserService objUserService = new UserService();//创建数据访问类对象
        public FRegister()
        {
            InitializeComponent();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            string loginId = txtLoginId.Text.Trim();
            if (loginId.Length == 0)
            {
                MessageBox.Show("请输入账号!", "修改提示");
                this.txtLoginId.Focus();
                return;
            }
            //新密码是否与确认密码相同
            string loginPwd = txtLoginPwd.Text.Trim();
            if (loginPwd.Length == 0)
            {
                MessageBox.Show("请输入密码!", "修改提示");
                txtLoginPwd.Focus();
                return;
            }
            if (loginPwd.Length < 6 || loginPwd.Length > 18)
            {
                MessageBox.Show("密码长度必须在6到18位之间!", "修改提示");
                txtLoginPwd.Focus();
                txtLoginPwd.SelectAll();
                return;
            }
            string pwdConfirm = txtPwdConfirm.Text.Trim();
            if (pwdConfirm.Length == 0)
            {
                MessageBox.Show("请确认密码!", "修改提示");
                txtPwdConfirm.Focus();
                return;
            }
            if (pwdConfirm != loginPwd)
            {
                MessageBox.Show("两次输入的密码不一致!");
                txtPwdConfirm.Focus();
                txtPwdConfirm.SelectAll();
                return;
            }
            string userName = txtUserName.Text.Trim();
            if (userName.Length == 0)
            {
                MessageBox.Show("请输入用户名!", "修改提示");
                txtUserName.Focus();
                return;
            }
            //查重
            string sql1 = "select count(*) from userAccount where UserId='" + loginId+"'";
            int res = 0;
            res = Convert.ToInt32(DBHelper.GetSingleResult(sql1));
            if (res > 0)
            {
                MessageBox.Show("该账号已存在!", "修改提示");
                txtLoginId.Focus();
                return;
            }
            string sql2 = "select count(*) from userAccount where UserName='" + userName+"'";
            res = Convert.ToInt32(DBHelper.GetSingleResult(sql2));
            if (res > 0)
            {
                MessageBox.Show("该用户名已存在!", "修改提示");
                txtUserName.Focus();
                return;
            }
            //将注册信息提交到数据库
            User objUser = new User()
            {
                UserId = loginId,
                UserPwd=loginPwd,
                UserName=userName
            };
            res = objUserService.addUser(objUser);
            if (res == 1)
            {
                MessageBox.Show("注册成功,请登录!", "提示");
                this.Close();
            }
            else
            {
                MessageBox.Show("注册失败!");
            }
        }
    }
}
