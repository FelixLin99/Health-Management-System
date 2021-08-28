using DAL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BIManager
{
    /// <summary>
    /// 我的徽章
    /// </summary>
    public partial class FMetal : UITitlePage
    {
        public static HealthService objHealthService = new HealthService();
        public FMetal()
        {
            InitializeComponent();
            GetData();
        }

        public void GetData()
        {
            int sumExp = 0;// 总经验值
            SqlDataReader reader = objHealthService.GetUserMetal(Program.currentAdmin.UserId, "1");
            if (reader != null && reader.Read())
            {
                this.uiLedLabel1.Text = reader["Number"].ToString();
                sumExp += Convert.ToInt32(reader["TotalExp"]);
            }
            else
            {
                this.uiLedLabel1.Text = "0";
            }
            reader = objHealthService.GetUserMetal(Program.currentAdmin.UserId, "2");
            if (reader != null && reader.Read())
            {
                this.uiLedLabel2.Text = reader["Number"].ToString();
                sumExp += Convert.ToInt32(reader["TotalExp"]);
            }
            else
            {
                this.uiLedLabel2.Text = "0";
            }
            reader = objHealthService.GetUserMetal(Program.currentAdmin.UserId,"3");
            if (reader != null && reader.Read())
            {
                this.uiLedLabel3.Text = reader["Number"].ToString();
                sumExp += Convert.ToInt32(reader["TotalExp"]);
            }
            else
            {
                this.uiLedLabel3.Text = "0";
            }
            this.uiBreadcrumb1.ItemIndex = sumExp / 500;
            this.uiProcessBar1.Value = (sumExp % 500) / 5;
        }
    }
}
