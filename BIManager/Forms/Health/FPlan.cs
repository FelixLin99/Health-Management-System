using Model.Health;
using DAL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIManager
{
    /// <summary>
    /// 健康计划
    /// </summary>
    public partial class FPlan : UITitlePage
    {
        HealthService objHealthService = new HealthService();
        SportService objSportService = new SportService();
        public FPlan()
        {
            InitializeComponent();
            Wpf.BIManager.Health.PlanSport planSport = new Wpf.BIManager.Health.PlanSport();
            this.elementHost1.Child = planSport;
            Wpf.BIManager.Health.PlanPMI planPMI = new Wpf.BIManager.Health.PlanPMI();
            this.elementHost2.Child = planPMI;
            Wpf.BIManager.Health.PlanDite planDite = new Wpf.BIManager.Health.PlanDite();
            this.elementHost3.Child = planDite;
            
        }
        // 实时更新计划进度
        public void GetPlan()
        {
            if (Program.curPlan == null)
                return;
            if (Program.curPlan.PlanName.Equals("始于足下"))
            {
                // 如果超时就显示失败
                TimeSpan ts = DateTime.Now - Program.curPlan.StartDate;
                int days = ts.Days;
                if (days >= 3)
                {
                    this.uiRoundProcess1.Text = "失败";
                    this.uiButton1.Text = "重试";
                    this.uiButton2.Enabled = true;
                    this.uiButton3.Enabled = true;
                    this.uiButton1.Enabled = true;
                    Program.curPlan = null;
                }
                double Cal = objHealthService.GetRunCalForPlan(Program.currentAdmin.UserId, "跑步", Program.curPlan.StartDate.ToString("yyyy-MM-dd"));
                int progress = Convert.ToInt32(Cal * 0.1);
                if (progress >= 100)
                {
                    this.uiRoundProcess1.Value = 100;
                    this.uiRoundProcess1.Text = "已完成";
                    this.uiButton1.Text = "GO";
                    this.uiButton2.Enabled = true;
                    this.uiButton3.Enabled = true;
                    this.uiButton1.Enabled = true;
                    Program.curPlan = null;
                    objHealthService.UpdateUserMetal(Program.currentAdmin.UserId, "1");
                    // 更新徽章页面
                    Program.fMetal.GetData();
                }
                else
                {
                    this.uiRoundProcess1.Value = progress;
                    Program.curPlan.Progress = progress;
                }
            }
            else if (Program.curPlan.PlanName.Equals("心血来潮"))
            {
                // 如果超时就显示失败
                TimeSpan ts = DateTime.Now - Program.curPlan.StartDate;
                int days = ts.Days;
                if (days >= 3)
                {
                    this.uiRoundProcess2.Text = "失败";
                    this.uiButton2.Text = "重试";
                    this.uiButton2.Enabled = true;
                    this.uiButton3.Enabled = true;
                    this.uiButton1.Enabled = true;
                    Program.curPlan = null;
                }
                DateTime today = DateTime.Now;
                // 今日PAI
                List<int> todayData = objSportService.getFPaiData(Program.currentAdmin.UserId, today.ToString("yyyy-MM-dd"));
                double todayPAI = todayData[2];
                // 计划开始日的前一日PAI
                List<int> startData = objSportService.getFPaiData(Program.currentAdmin.UserId, Program.curPlan.StartDate.AddDays(-1).ToString("yyyy-MM-dd"));
                double startPAI = startData[2];
                if (todayPAI - startPAI >= 200)
                {
                    this.uiRoundProcess2.Value = 100;
                    this.uiRoundProcess2.Text = "已完成";
                    this.uiButton2.Text = "GO";
                    this.uiButton2.Enabled = true;
                    this.uiButton3.Enabled = true;
                    this.uiButton1.Enabled = true;
                    Program.curPlan = null;
                    objHealthService.UpdateUserMetal(Program.currentAdmin.UserId, "2");
                    // 更新徽章页面
                    Program.fMetal.GetData();
                }
                else
                {
                    this.uiRoundProcess2.Value = todayPAI > startPAI ? Convert.ToInt32((todayPAI - startPAI) / 2) : 0;
                    Program.curPlan.Progress = this.uiRoundProcess1.Value;
                }
            }
            else if (Program.curPlan.PlanName.Equals("毫无保留"))
            {
                TimeSpan ts = DateTime.Now - Program.curPlan.StartDate;
                int days = ts.Days;
                if (days == 0)
                {
                    this.uiRoundProcess3.Value = 0;
                }
                else
                {
                    bool flag = objHealthService.GetDailyCalSurplus(Program.currentAdmin.UserId, DateTime.Today.AddDays(-1).ToString("yyyy-MM-dd"));
                    if (!flag)
                    {
                        this.uiRoundProcess3.Text = "失败";
                        this.uiButton3.Text = "重试";
                        this.uiButton2.Enabled = true;
                        this.uiButton3.Enabled = true;
                        this.uiButton1.Enabled = true;
                        Program.curPlan = null;
                    }
                    else if (days == 1)
                    {
                        this.uiRoundProcess3.Value = 33;
                        Program.curPlan.Progress = 33;
                    }
                    else if (days == 2)
                    {
                        this.uiRoundProcess3.Value = 66;
                        Program.curPlan.Progress = 66;
                    }
                    else if (days == 3)
                    {
                        this.uiRoundProcess3.Value = 100;
                        this.uiRoundProcess3.Text = "已完成";
                        this.uiButton3.Text = "GO";
                        this.uiButton2.Enabled = true;
                        this.uiButton3.Enabled = true;
                        this.uiButton1.Enabled = true;
                        Program.curPlan = null;
                        objHealthService.UpdateUserMetal(Program.currentAdmin.UserId, "3");
                        // 更新徽章页面
                        Program.fMetal.GetData();
                    }
                }
            }
        }

        private void uiButton17_Click(object sender, EventArgs e)
        {
            this.uiButton1.Text = "进行中";
            this.uiRoundProcess1.Visible = true;
            this.uiButton2.Enabled = false;
            this.uiButton3.Enabled = false;
            this.uiButton1.Enabled = false;
            Program.curPlan = null;
            Program.curPlan = new UserCurPlan()
            {
                PlanName = "始于足下",
                StartDate = DateTime.Now
            };
            GetPlan();
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            this.uiButton2.Text = "进行中";
            this.uiRoundProcess2.Visible = true;
            this.uiButton1.Enabled = false;
            this.uiButton3.Enabled = false;
            this.uiButton2.Enabled = false;
            Program.curPlan = null;
            Program.curPlan = new UserCurPlan()
            {
                PlanName = "心血来潮",
                StartDate = DateTime.Now
            };
            GetPlan();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.uiButton3.Text = "进行中";
            this.uiRoundProcess3.Visible = true;
            this.uiButton1.Enabled = false;
            this.uiButton2.Enabled = false;
            this.uiButton3.Enabled = false;
            Program.curPlan = null;
            Program.curPlan = new UserCurPlan()
            {
                PlanName = "毫无保留",
                StartDate = DateTime.Now
            };
            GetPlan();
        }
    }
}
