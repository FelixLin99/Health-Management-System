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

namespace BIManager
{
    public partial class FModifyPwd : Form
    {
        private UserService objUserService = new UserService();//创建数据访问类对象
        public FModifyPwd()
        {
            InitializeComponent();
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 修改密码
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            //校验用户输入的原密码是否正确
            string oldPwd = txtOldPwd.Text.Trim();
            if (oldPwd.Length == 0)
            {
                MessageBox.Show("请输入原密码!", "修改提示");
                this.txtOldPwd.Focus();
                return;
            }
            if (oldPwd != Program.currentAdmin.UserPwd)
            {
                MessageBox.Show("原密码错误,请重新输入!", "修改提示");
                this.txtOldPwd.Focus();
                this.txtOldPwd.SelectAll();
                return;
            }
            //新密码是否与确认密码相同
            string newPwd = txtNewPwd.Text.Trim();
            if (newPwd.Length == 0)
            {
                MessageBox.Show("请输入新密码!", "修改提示");
                txtNewPwd.Focus();
                return;
            }
            if (newPwd.Length < 6 || newPwd.Length > 18)
            {
                MessageBox.Show("密码长度必须在6到18位之间!", "修改提示");
                txtNewPwd.Focus();
                txtNewPwd.SelectAll();
                return;
            }
            string pwdConfirm = txtNewPwdConfirm.Text.Trim();
            if (pwdConfirm.Length == 0)
            {
                MessageBox.Show("请确认新密码!", "修改提示");
                txtNewPwdConfirm.Focus();
                return;
            }
            if (pwdConfirm != newPwd)
            {
                MessageBox.Show("两次输入的密码不一致!");
                txtNewPwdConfirm.Focus();
                txtNewPwdConfirm.SelectAll();
                return;
            }
            if (newPwd == oldPwd)
            {
                MessageBox.Show("新密码不能与旧密码相同!", "修改提示");
                txtNewPwd.Focus();
                txtNewPwd.SelectAll();
                return;
            }
            //将新密码提交到数据库
            string loginId = Program.currentAdmin.UserId;
            int res = objUserService.ModifyPwd(loginId, newPwd);
            if (res == 1)
            {
                MessageBox.Show("密码修改成功,请妥善保存!", "修改提示");
                Program.currentAdmin.UserPwd = newPwd;
                this.Close();
            }
            else
            {
                MessageBox.Show("密码修改失败!");
            }
        }

        private void FModifyPwd_Load(object sender, EventArgs e)
        {

        }
    }
}
