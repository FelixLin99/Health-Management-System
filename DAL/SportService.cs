using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Sport;
using DAL.DBUtility;
using System.Data.SqlClient;
using System.Data;
using DAL.DBUtility;


namespace DAL
{
    public class SportService
    {
        /// <summary>
        /// 判断用户是否有运动记录
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public bool hasRecord(string userId)
        {
            string sql = "SELECT COUNT(*) FROM UserSportTrack WHERE UserId = '{0}'";
            sql = string.Format(sql, userId);
            int res = Convert.ToInt32(DBHelper.GetSingleResult(sql));
            if (res == 0)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 添加当日运动记录
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public int InsertNewRecord(SportRecord record)
        {
            string sql = "INSERT INTO UserSportTrack (UserId, SportType, WriteInDate, Duration, Tensity) VALUES ('{0}','{1}','{2}',{3},{4})";
            sql = string.Format(sql, record.UserId, record.SportType, record.writeInDate, record.duration, record.tensity);
            int res = DBHelper.Update(sql);
            return res;
        }

        /// <summary>
        /// 当表中存在当天运动记录时,运动时间累加
        /// </summary>
        /// <param name="record"></param>
        /// <returns></returns>
        public int UpdateRecord(SportRecord record)
        {
            string sql = "Update UserSportTrack SET Duration = Duration + {3},Tensity={4} " +
                         "WHERE UserId = '{0}' AND SportType = '{1}' AND WriteInDate = '{2}'";
            sql = string.Format(sql, record.UserId, record.SportType, record.writeInDate, record.duration, record.tensity);
            int res = DBHelper.Update(sql);
            return res;
        }
        /// <summary>
        /// 查的指定一天的消耗数据
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="date"></param>
        /// <returns> List(当日运动总消耗，糖原消耗，脂肪消耗，当日运动总时长) </returns>
        public List<double> getDailyConsuming(string userId, string date)
        {
            string sql = "SELECT * FROM V_UserDailySport WHERE UserId = '{0}' AND WriteInDate = '{1}' ";
            sql = string.Format(sql, userId, date);
            SqlDataReader reader = DBHelper.GetReader(sql);
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    return new List<double>
                    {
                        Convert.ToDouble(reader["Daily_Consuming"]),
                        Convert.ToDouble(reader["Daily_SugarConsuming"]),
                        Convert.ToDouble(reader["Daily_FatConsuming"]),
                        Convert.ToDouble(reader["Daily_Duration"]),

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
        /// 获取用户当日摄入和消耗
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="date"></param>
        /// <returns></returns>
        public List<double> getDailyIntakeAndConsuming(string userId, string date)
        {
            string sql = "SELECT Daily_Energy,Daily_Consuming " +
                         "FROM V_DiteDaily x LEFT JOIN V_UserDailySport y " +
                         "ON x.UserId = y.UserId " +
                         "WHERE WriteInDate = IntakeDate AND " +
                         "y.UserId = '{0}' AND IntakeDate = '{1}'";
            sql = string.Format(sql, userId, date);
            SqlDataReader reader = DBHelper.GetReader(sql);
            if (reader.HasRows)
            {
                if (reader.Read())
                {
                    return new List<double>
                    {
                        Convert.ToDouble(reader["Daily_Energy"]),
                        Convert.ToDouble(reader["Daily_Consuming"]),
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
        ///  获得用户7日内的总消耗和总运动时常
        /// </summary>
        /// <param name="userId"></param>
        /// <returns> List<double>(总运动时长, 总消耗能量) </returns>
        public List<double> getUserWeeklyConsumingAndDuration(string userId)
        {
            string sql = "SELECT * FROM V_UserWeeklySport WHERE UserId = '{0}'";
            sql = string.Format(sql, userId);

            DataTable dataTable = DBHelper.SearchSql(sql);

            // 如果没有7日内记录，返回null
            if (dataTable == null)
                return null;
            else
            {
                double weekly_consuming = Convert.ToDouble(dataTable.Rows[0]["Weekly_Consuming"]);
                double weekly_duration = Convert.ToDouble(dataTable.Rows[0]["Weekly_Duration"]);
                return new List<double> { weekly_duration, weekly_consuming };
            }
        }

        /// <summary>
        /// 拿到该用户对于每项运动的统计值
        /// 并且，第一行为最喜爱运动
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public SqlDataReader getSportAggr(string userId)
        {
            string sql = "SELECT * FROM V_SportAggr WHERE userId = '{0}' ORDER BY cnt DESC";
            sql = string.Format(sql, userId);
            SqlDataReader reader = DBHelper.GetReader(sql);
            if (reader.HasRows)
                return reader;
            else
                return null;
        }

        /// <summary>
        /// 获得 0-30, 30-60, 60+ 三个时常区间对应的次数
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<double> getSportTimeDistribute(string userId)
        {
            SqlParameter param1 = new SqlParameter("@SelectId", userId);
            SqlParameter[] param = new SqlParameter[]{param1};
            DataTable dataTable = DBHelper.Pro_search("GetSportTimeDistribute", param);
            // 未查询到数据
            if (dataTable == null)
                return null;
            else
            {
                List<double> list = new List<double> { 0, 0, 0 };
                for(int i=0; i<dataTable.Rows.Count; i++)
                {
                    string timeZone = dataTable.Rows[i]["TimeZone"].ToString();
                    double cnt = Convert.ToDouble(dataTable.Rows[i]["cnt"].ToString());
                    if (timeZone == "0-30")
                        list[0] = cnt;
                    else if (timeZone == "30-60")
                        list[1] = cnt;
                    else
                        list[2] = cnt;
                }
                return list;
            }
        }
        /// <summary>
        /// 获得最长一次运动时间
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string getLongestSportTime(string userId)
        {
            string sql = "SELECT MAX(Duration) FROM UserSportTrack WHERE UserId = '{0}'";
            sql = string.Format(sql, userId);
            Object value = DBHelper.GetSingleResult(sql);
            if (value == null)
                return "";
            else
                return value.ToString();
        }

        /// <summary>
        /// 获得平均每次运动时间
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string getAvgUnitSportTime(string userId)
        {
            string sql = "SELECT CAST(AVG(Duration) AS INT) FROM UserSportTrack WHERE UserId = '{0}'";
            sql = string.Format(sql, userId);
            Object value = DBHelper.GetSingleResult(sql);
            if (value == null)
                return "";
            else
                return value.ToString();
        }

        /// <summary>
        /// 获得平均每天运动时间
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string getAvgDailySportTime(string userId)
        {
            string sql = "SELECT CAST(AVG(Daily_Duration) AS INT) FROM V_UserDailySport WHERE UserId = '{0}'";
            sql = string.Format(sql, userId);
            Object value = DBHelper.GetSingleResult(sql);
            if (value == null)
                return "";
            else
                return value.ToString();
        }

        /// <summary>
        ///  获取运动强度分布
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public List<double> getIntensityDistrubute(string userId)
        {
            SqlParameter param1 = new SqlParameter("@SelectedId", userId);
            SqlParameter[] param = new SqlParameter[] { param1 };
            DataTable dataTable = DBHelper.Pro_search("GetSportIntensityDistribute", param);
            // 未查询到数据
            if (dataTable == null)
                return null;
            else
            {
                List<double> list = new List<double> { 0, 0, 0 };
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    string intensity = dataTable.Rows[i]["Tensity"].ToString();
                    double cnt = Convert.ToDouble(dataTable.Rows[i]["cnt"].ToString());
                    if (intensity == "0.7")
                        list[0] = cnt;
                    else if (intensity == "1")
                        list[1] = cnt;
                    else
                        list[2] = cnt;
                }
                return list;
            }
        }

        /// <summary>
        /// 获得最高一次消耗卡路里
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string getHighestCal(string userId)
        {
            string sql = "SELECT CAST(MAX(Tensity * AvgConsuming * Duration) AS INT) FROM UserSportTrack x LEFT JOIN Sport y ON x.SportType = y.SportType WHERE UserId = '{0}'";
            sql = string.Format(sql, userId);
            Object value = DBHelper.GetSingleResult(sql);
            if (value == null)
                return "";
            else
                return value.ToString();
        }

        /// <summary>
        /// 获得平均每天运动消耗
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string getDailyCal(string userId)
        {
            string sql = "SELECT CAST(AVG(Daily_Consuming) AS INT) FROM V_UserDailySport WHERE UserId = '{0}'";
            sql = string.Format(sql, userId);
            Object value = DBHelper.GetSingleResult(sql);
            if (value == null)
                return "";
            else
                return value.ToString();
        }

        /// <summary>
        /// 获得平均每次运动消耗
        /// </summary>
        /// <param name="userId"></param>
        /// <returns></returns>
        public string getAvgUnitSportCal(string userId)
        {
            string sql = "SELECT CAST(AVG(Tensity * AvgConsuming * Duration) AS INT) FROM UserSportTrack x LEFT JOIN Sport y ON x.SportType = y.SportType WHERE UserId = '{0}'";
            sql = string.Format(sql, userId);
            Object value = DBHelper.GetSingleResult(sql);
            if (value == null)
                return "";
            else
                return value.ToString();
        }
        
        /// <summary>
        ///  返回每天的运动时间，运动消耗，机能指数
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="today"></param>
        /// <returns></returns>
        public List<int> getFPaiData(string userId, string today)
        {
            List<int> list = new List<int> { 0, 0, 0};

            // 获得当天消耗
            string sql = "SELECT * FROM V_UserDailySport WHERE Userid ='{0}' AND WriteInDate = '{1}'";
            sql = string.Format(sql, userId, today);
            DataTable dataTable1 = DBHelper.SearchSql(sql);
                // 如果当天存在运动消耗
            if (dataTable1 != null)
            {
                // 先转换为字符串,再转化为Double,最后才能转化为Int
                list[0] = Convert.ToInt32(Convert.ToDouble(dataTable1.Rows[0]["Daily_Duration"].ToString()));
                list[1] = Convert.ToInt32(Convert.ToDouble(dataTable1.Rows[0]["Daily_Consuming"].ToString()));
            }

            // 获得近7日平均消耗、近7日中高强度运动次数、近7日中低强度运动次数
            SqlParameter param1 = new SqlParameter("@SelectedId", userId);
            SqlParameter param2 = new SqlParameter("@SelectedDate", today);
            SqlParameter[] param = new SqlParameter[] { param1, param2 };
            DataTable dataTable2 = DBHelper.Pro_search("GetPaiAggr", param);

            if (dataTable2 != null && dataTable2.Rows.Count > 0)
            {
                int arg1 = Convert.ToInt32(dataTable2.Rows[0]["Latest7DaysAvgConcuming"].ToString());
                int arg2 = Convert.ToInt32(dataTable2.Rows[0]["中高强度"].ToString());
                int arg3 = Convert.ToInt32(dataTable2.Rows[0]["中低强度"].ToString());
                int pai = (int)Math.Round((list[1] * 0.1 + arg1 * 0.1) * 
                    (((arg2 + 1) / (arg3 + 1) - 0.125) / (8 - 0.125) * (1.5 - 0.5) +0.5) , 0);
                list[2] = pai;
            }
            return list;
        }

    }

}
