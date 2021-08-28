using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL.DBUtility;
using Model;
using Model.Dite;

namespace DAL
{
    public class DiteService
    {
        /// <summary>
        /// 判断数据库中是否有该用户的饮食记录
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool hasRecord(string userId)
        {
            string sql = "SELECT COUNT(*) FROM UserDite WHERE UserId = '{0}'";
            sql = string.Format(sql, userId);
            int res = Convert.ToInt32(DBHelper.GetSingleResult(sql));
            if (res == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        ///  插入饮食记录
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public int InsertNewRecord(UserDite record)
        {
            string sql = "INSERT INTO UserDite VALUES ('{0}','{1}','{2}',{3},{4});";
            sql = string.Format(sql, record.userId, record.foodName, record.intakeDate, record.intakeAmount, record.sugarRate);
            int res = DBHelper.Update(sql);
            return res;
        }

        /// <summary>
        /// 当表中存在当天饮食记录时,摄入量累加
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public int UpdateRecord(UserDite record)
        {
            string sql = "Update UserDite SET IntakeAmount = IntakeAmount + {3},SugarRate={4} " +
                         "WHERE UserId = '{0}' AND FoodName = '{1}' AND IntakeDate = '{2}'";
            sql = string.Format(sql, record.userId, record.foodName, record.intakeDate, record.intakeAmount, record.sugarRate);
            int res = DBHelper.Update(sql);
            return res;
        }

        /// <summary>
        /// 查的指定一天的饮食数据
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="date"></param>
        /// <returns> List(每天摄入总能量(KCal)、总克数(g)、总蛋白质(g)、总碳水(g)、总脂肪(g)) </returns>
        public List<double> getDailyDite(string userId, string date)
        {
            string sql = "SELECT * FROM V_DiteDaily WHERE UserId = '{0}' AND IntakeDate = '{1}'";
            sql = string.Format(sql, userId, date);
            SqlDataReader reader = DBHelper.GetReader(sql);
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    return new List<double>
                    {
                        Convert.ToDouble(reader["Daily_Energy"]),
                        Convert.ToDouble(reader["Daily_Amt"]),
                        Convert.ToDouble(reader["Daily_Protein"]),
                        Convert.ToDouble(reader["Daily_carb"]),
                        Convert.ToDouble(reader["Daily_Fat"])
                    };
                }
                else
                    return null;
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 获得平均每100g食物热量
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string getAvgDiteEnergyPer100g(string userId)
        {
            string sql = "SELECT CAST(SUM(Daily_Energy) / SUM(Daily_Amt) * 100  AS INT ) FROM V_DiteDaily WHERE UserId = '{0}'";
            sql = string.Format(sql, userId);
            Object obj = DBHelper.GetSingleResult(sql);
            if (obj == null)
                return "0";
            else
                return obj.ToString();
        }

        /// <summary>
        /// 获取平均每天摄入热量
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string getDailyDiteEnergy(string userId)
        {
            string sql = "SELECT CAST(AVG(Daily_Energy) AS INT ) FROM V_DiteDaily WHERE UserId = '{0}'";
            sql = string.Format(sql, userId);
            Object obj = DBHelper.GetSingleResult(sql);
            if (obj == null)
                return "0";
            else
                return obj.ToString();
        }
        /// <summary>
        /// 获得热量分布数据
        /// </summary>
        /// <param name="userId"></param>
        /// <returns>list('高热量', "高热量值"，"中热量值"，"低热量值")</returns>
        public List<string> getDiteEnergyDistribute(string userId)
        {
            SqlParameter param1 = new SqlParameter("@SelectedId", userId);
            SqlParameter[] param = new SqlParameter[] { param1 };
            DataTable dataTable = DBHelper.Pro_search("GetDiteEnergyDistribute", param);
            // 未查询到数据
            List<string> list = new List<string>{"","0","0","0"};
            if (dataTable != null)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if (i == 0)
                        list[0] = dataTable.Rows[0]["EnergyZone"].ToString();
                    string energyZone = dataTable.Rows[i]["EnergyZone"].ToString();
                    string cnt = dataTable.Rows[i]["cnt"].ToString();
                    if (energyZone == "高热量")
                        list[1] = cnt;
                    else if (energyZone == "中热量")
                        list[2] = cnt;
                    else
                        list[3] = cnt;
                }
            }
            return list;
        }

        /// <summary>
        ///  获得各营养成分摄入总量(g)
        /// </summary>
        /// <param name="userId"></param>
        /// <returns> List<double> (蛋白质，脂肪，碳水) </returns>
        public List<int> getDiteNutriDistribute(string userId)
        {
            SqlParameter param1 = new SqlParameter("@SelectedId", userId);
            SqlParameter[] param = new SqlParameter[] { param1 };
            DataTable dataTable = DBHelper.Pro_search("GetDiteNutriDistribute", param);
            // 未查询到数据
            if (dataTable == null)
                return null;
            else
            {
               return  new List<int>
               {
                   (int)Math.Round(Convert.ToDouble(dataTable.Rows[0]["Total_Protein"]), 0),
                   (int)Math.Round(Convert.ToDouble(dataTable.Rows[0]["Total_Fat"]), 0),
                   (int)Math.Round(Convert.ToDouble(dataTable.Rows[0]["Total_Carb"]), 0)
               };
            }
        }

        public DataTable getDiteTypeDistribute(string userId)
        {
            SqlParameter param1 = new SqlParameter("@SelectedId", userId);
            SqlParameter[] param = new SqlParameter[] { param1 };
            DataTable dataTable = DBHelper.Pro_search("GetDiteTypeDistribute", param);
            // 未查询到数据
            if (dataTable == null)
                return null;
            else
            {
                return dataTable;
            }
        }
    }
}
