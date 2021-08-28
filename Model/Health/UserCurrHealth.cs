using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Health
{
    public class UserCurrHealth
    {
        public String userId { get; set; }
        public int height { get; set; }
        public int weight { get; set; }
        public int fatRate { get; set; }

        public double BMI { get; set; }
    }
}
