using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Health
{
    /// <summary>
    /// 用户徽章及数量
    /// </summary>
    public class UserMetal
    {
        // 徽章ID
        public int MetalId { get; set; }
        // 徽章数量
        public int Number { get; set; }
        // 经验值
        public int Experience { get; set; }
    }
}
