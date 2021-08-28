using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Health
{
    /// <summary>
    /// 用户当前进行的健康计划
    /// </summary>
    public class UserCurPlan
    {
        // 计划名称
        public string PlanName { get; set; }
        // 计划开始时间
        public DateTime StartDate { get; set; }
        // 计划进度
        public int Progress { get; set; }
    }
}
