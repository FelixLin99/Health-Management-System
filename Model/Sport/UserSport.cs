using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Sport
{
    /// <summary>
    /// 用户运动记录
    /// </summary>
    public class SportRecord
    {
        public string UserId { get; set; }
        public string SportType { get; set; }
        public String writeInDate { get; set; }
        public int duration { get; set; }
        public double tensity { get; set; }
    }
}
