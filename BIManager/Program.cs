using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using BIManager;
using Model.User;
using Model.Health;


namespace BIManager
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //显示登录窗体
            FLogin objFLogin = new FLogin();
            DialogResult reuslt = objFLogin.ShowDialog();

            //判断登录是否成功
            if (reuslt == DialogResult.OK)
                Application.Run(new FMain());
            else
                Application.Exit();//退出整个应用程序
        }


        /// <summary>
        /// 全局变量
        /// </summary>
        //用户
        public static User currentAdmin = null;
       //运动种类
        public static string sporttype = "";
        //食物种类
        public static string foodtype = ""; 
        //健康数据
        public static UserCurrHealth userCurrHealth = null;
        //当前健康计划
        public static UserCurPlan curPlan = null;
        // 实时更新窗体部分
        // Sport
        public static FConsume fConsume = null;
        public static FPai fPai = null;
        public static FDistribution fDistribution = null;
        // Dite
        public static FAddDite fAddDite = null;
        public static FConstru fConstru = null;
        public static FDiteRecom fDiteRecom = null;
        public static FNutri fNutri = null;
        // Health
        public static FBmi fBmi = null;
        public static FPlan fPlan = null;
        public static FMetal fMetal = null;
    }
}

