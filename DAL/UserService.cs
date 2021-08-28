using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL.DBUtility;
using System.Data;
using System.Data.SqlClient;
using Model.User;


namespace DAL
{
    public class UserService
    {
        /// <summary>
        /// 根据用户名或密码登录
        /// </summary>
        /// <param name="objAdmin"></param>
        /// <returns></returns>
        public User AdminLogin(User objAdmin)
        {
            string sql = "select UserName from userAccount where UserId = '{0}' AND UserPwd= '{1}' ";
            sql = string.Format(sql, objAdmin.UserId, objAdmin.UserPwd);
            
            try
            {
                SqlDataReader objReader = DBHelper.GetReader(sql);
                if (objReader.Read())
                {
                    objAdmin.UserName = objReader["UserName"].ToString();
                }
                else
                {
                    objAdmin = null;
                }
                objReader.Close();
                return objAdmin;
            }
            catch (Exception ex)
            {
                throw new Exception("数据访问发生异常：" + ex.Message);
            }
        }

        /// <summary>
        /// 根据登录账号修改登录密码
        /// </summary>
        /// <param name="loginId"></param>
        /// <param name="newPwd"></param>
        /// <returns></returns>
        public int ModifyPwd(string loginId, string newPwd)
        {
            string sql = "update useraccount set UserPwd='{0}' where UserId='{1}'";
            sql = string.Format(sql, newPwd, loginId);
            return DBHelper.Update(sql);
        }

        /// <summary>
        /// 向数据库中注册用户
        /// </summary>
        /// <param name="objUser"></param>
        /// <returns></returns>
        public int addUser(User objUser)
        {
            string sql = "INSERT INTO userAccount (UserId,UserPwd,UserName) VALUES ('{0}','{1}','{2}')";
            sql = string.Format(sql,objUser.UserId,
                                     objUser.UserPwd,
                                     objUser.UserName);
            return DBHelper.Update(sql);
        }
    }
}