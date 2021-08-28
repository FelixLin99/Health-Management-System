using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Health;
using DAL.DBUtility;
using System.Data.SqlClient;
using System.Data;
using LiveCharts;

namespace DAL
{
    public class HealthService
    {
        /// <summary>
        ///  获取用户最新健康数据
        /// </summary>
        /// <param name="userid"></param>
        /// <returns></returns>
        public UserCurrHealth getUserCurrHealth(String userid)
        {
            String sql = "SELECT * FROM V_UserCurrHealth WHERE UserId = '{0}' ";
            sql = String.Format(sql, userid);
            DataTable dataTable = DBHelper.SearchSql(sql);
            if (dataTable == null)
            {
                return null;
            }
            else
            {
                UserCurrHealth userCurrHealth = new UserCurrHealth()
                {
                    userId = dataTable.Rows[0]["UserId"].ToString(),
                    height = Int32.Parse(dataTable.Rows[0]["Height"].ToString()),
                    weight = Int32.Parse(dataTable.Rows[0]["Weight"].ToString()),
                    fatRate = Int32.Parse(dataTable.Rows[0]["BodyFatRate"].ToString()),
                    BMI = double.Parse(dataTable.Rows[0]["BMI"].ToString())
                };
                return userCurrHealth;
            }
        }
        /// <summary>
        /// 更新用户健康数据
        /// </summary>
        /// <param name="userHealth"></param>
        /// <returns></returns>
        public int updateUserHealth(UserHealth userHealth)
        {
            string sql = "UPDATE UserInfo SET Height={2},Weight={3},BodyFatRate={4} WHERE UserId = '{0}' AND WriteInDate = '{1}'";
            sql = string.Format(sql, userHealth.userId,userHealth.writeInDate,userHealth.height,userHealth.weight,userHealth.fatRate);
            return DBHelper.Update(sql);
        }
        /// <summary>
        /// 新增用户健康数据
        /// </summary>
        /// <param name="userHealth"></param>
        /// <returns></returns>
        public int insertUserHealth(UserHealth userHealth)
        {
            string sql = "INSERT INTO UserInfo (UserId,WriteInDate,Height,Weight,BodyFatRate) VALUES ('{0}','{1}',{2},{3},{4})";
            sql = string.Format(sql, userHealth.userId, userHealth.writeInDate, userHealth.height, userHealth.weight, userHealth.fatRate);
            return DBHelper.Update(sql);
        }

        /// <summary>
        /// 获取用户的月度健康数据
        /// 没有则该月数据置0
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public SqlDataReader getUserMonthHealth(String userId)
        {
            string sql = "SELECT * FROM V_UserMonthHealth WHERE userId = '{0}' ORDER BY Month DESC";
            sql = string.Format(sql, userId);

            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql);
                
                if (reader.HasRows)
                { 
                    return reader;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("数据访问发生异常：" + ex.Message);
            }
        }
        
        /// <summary>
        /// 拿到最低的BMI
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public double getBestBMI(string userId)
        {
            string sql = "SELECT MIN(BMI) FROM V_UserMonthHealth WHERE userId = '{0}'";
            sql = string.Format(sql, userId);
            Object obj = DBHelper.GetSingleResult(sql);
            if (obj == null)
                return 0;
            else
                return Convert.ToDouble(obj);
        }

        /// <summary>
        /// 获取指定日期后三天内跑步消耗的卡路里
        /// </summary>
        /// <returns></returns>
        public double GetRunCalForPlan(string userId,string sportName,string startDate)
        {
            string sql = "SELECT SUM(AvgConsuming*Duration*Tensity) " +
                         "FROM UserSportTrack x LEFT JOIN Sport y " +
                         "ON x.SportType = y.SportType and x.SportType = '{1}' and " +
                         "UserId = '{0}' and DATEDIFF(day,'{2}',WriteInDate)<= 3 and " +
                         "DATEDIFF(day, '{2}', WriteInDate) >= 0";
            sql = string.Format(sql, userId, sportName, startDate);
            Object obj = DBHelper.GetSingleResult(sql);
            if (obj == null)
                return 0;
            else
                return Convert.ToDouble(obj);
        }

        /// <summary>
        /// 获取每日富余卡路里
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="Date"></param>
        /// <returns></returns>
        public bool GetDailyCalSurplus(string UserId, string Date)
        {
            string sql = "SELECT Daily_Energy-Daily_Consuming-1500 " +
                        "FROM V_DiteDaily x RIGHT JOIN V_UserDailySport y " +
                        "ON x.UserId = y.UserId " +
                        "WHERE WriteInDate = IntakeDate AND " +
                        "y.UserId = '{0}' AND IntakeDate = '{1}'";
            sql = string.Format(sql, UserId, Date);
            Object obj = DBHelper.GetSingleResult(sql);
            if (obj == null)
                return false;
            else
                return Convert.ToInt32(obj) > 0 ? false : true;
        }

        /// <summary>
        /// 获取用户徽章和经验值记录
        /// </summary>
        /// <param name="UserId"></param>
        /// <param name="MetalId"></param>
        /// <returns></returns>
        public SqlDataReader GetUserMetal(string UserId, string MetalId)
        {
            string sql = "SELECT Number,Experience*Number AS TotalExp " +
                         "FROM UserMetal x INNER JOIN Metal y " +
                         "ON x.MetalId = y.MetalId " +
                         "WHERE UserId = '{0}' AND x.MetalId = {1}";
            sql = string.Format(sql, UserId, MetalId);
            try
            {
                SqlDataReader reader = DBHelper.GetReader(sql);

                if (reader.HasRows)
                {
                    return reader;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("数据访问发生异常：" + ex.Message);
            }
        }
        /// <summary>
        /// 更新用户徽章表
        /// </summary>
        /// <param name="MetalId"></param>
        /// <returns></returns>
        public int UpdateUserMetal(string UserId,string MetalId)
        {
            // 如果该用户为新注册则添加徽章记录
            string sql0 = "SELECT COUNT(*)  FROM UserMetal WHERE UserId={0}";
            sql0 = string.Format(sql0, UserId);
            if (Convert.ToInt32(DBHelper.GetSingleResult(sql0)) == 0)
            {
                string sql1 = "INSERT INTO UserMetal Values " +
                              "('{0}', 1, 0, null), " +
                              "('{0}', 2, 0, null), " +
                              "('{0}', 3, 0, null)";
                sql1 = string.Format(sql1, UserId);
                DBHelper.Update(sql1);
            }
            string sql2 = "SELECT COUNT(*)  FROM UserMetal WHERE UserId={0} AND MetalId={1} AND WriteInDate='{2}'";
            sql2 = string.Format(sql2, UserId, MetalId, DateTime.Today.ToString("yyyy-MM-dd"));
            // 如果当天已有该勋章写入则直接返回
            if (Convert.ToInt32(DBHelper.GetSingleResult(sql2)) > 0) return -1;
            string sql3 = "UPDATE UserMetal SET Number=Number+1, WriteInDate='{2}'" +
                          "WHERE UserId={0} AND MetalId = {1}";
            sql3 = string.Format(sql3, UserId, MetalId, DateTime.Today.ToString("yyyy-MM-dd"));
            return DBHelper.Update(sql3);
        }
    }
}
