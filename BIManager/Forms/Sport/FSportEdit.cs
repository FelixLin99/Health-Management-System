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
using Model.Sport;
using DAL.DBUtility;

namespace BIManager
{
    public partial class FSportEdit : Form
    {
        
        private SportService objSportervice = new SportService();//创建数据访问类对象
        public FSportEdit(string sportName)
        {
            InitializeComponent();
            this.uiLabel1.Text = sportName;
        }

        private void uiSymbolButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // 提交运动记录
        private void uiSymbolButton1_Click(object sender, EventArgs e)
        {
            int dur = Duration.Value;

            //数据校验
            if (dur < 5)
            {
                MessageBox.Show("锻炼时间不应小于5分钟！", "提示");
                return;
            }
            string feeling = Feeling.Text;
            double tension = 0;
            if (feeling.Equals("一般"))
                tension = 1;
            else if (feeling.Equals("轻松"))
                tension = 0.7;
            else if (feeling.Equals("疲累"))
                tension = 1.3;
            else
            {
                MessageBox.Show("请正确选择运动强度！", "提示");
                return;
            }

            //writeInDate = DateTime.Now.ToString("yyyy-MM-dd"),

            SportRecord record = new SportRecord()
            {
                UserId = Program.currentAdmin.UserId,
                SportType = Program.sporttype,
                writeInDate = DateTime.Now.ToString("yyyy-MM-dd"),
                duration = dur,
                tensity = tension
            };

            // 查重
            string sql = "SELECT COUNT(*) FROM UserSportTrack WHERE UserId = '{0}' AND SportType = '{1}' AND WriteInDate = '{2}'";
            sql = string.Format(sql, record.UserId, record.SportType, record.writeInDate);
            int judg = 0;
            judg = Convert.ToInt32(DBHelper.GetSingleResult(sql));
            int res=-1;
            if (judg > 0)
            {
                res = objSportervice.UpdateRecord(record);
            }
            else
            {
                res = objSportervice.InsertNewRecord(record);
            }
            if (res == 1)
            {
                // 更新运动消耗统计页面
                Program.fConsume.GetData();
                // 更新运动分布界面
                Program.fDistribution.GetData();
                // 更新机能指数界面
                Program.fPai.GetData();
                // 更新添加饮食界面
                Program.fAddDite.GetData();
                // 更新摄入与消耗界面
                Program.fNutri.GetData();
                // 更新健康计划界面
                Program.fPlan.GetPlan();
                MessageBox.Show("运动记录提交!", "提示");
                this.Close();
            }
            else
            {
                MessageBox.Show("提交失败!");
            }
        }
    }
}
