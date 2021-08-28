using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Model.Health
{
    /// <summary>
    /// 用户健康记录，对应数据库UserInfo表
    /// </summary>
    public class UserHealth
    {
        public String userId { get; set; }

        public String writeInDate { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public int fatRate { get; set; }

    }
}