using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SneakerSellSystem.Class
{
    public static class Utils
    {
        // 不同等级会员的打折
        public static double[] discount = { 1.0, 0.8, 0.7 };

        // 不同等级会员的积分转换
        public static double[] cvtPoints = { 0.2, 0.3, 0.4 };

    }
}
