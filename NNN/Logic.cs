using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NNN
{
    public static class Logic
    {
        public static double x, ans;
        public static string CH(string ch, string c)
        {
            double y = Convert.ToDouble(c);
            if (x == 0)
            {
                return $"{c}";
            }
            else
            {
                return ch switch
                {
                    "+" => Convert.ToString(ans = x + y),
                    "-" => Convert.ToString(ans = x - y),
                    "*" => Convert.ToString(ans = x * y),
                    "/" => Convert.ToString(ans = x / y),
                    "=" => Convert.ToString(ans)
                };
            }
        }
        public static void Set(string n) { x = Convert.ToDouble(n); }
        public static string Get() { if (ans != 0.00) return Convert.ToString(ans); else return "0"; }
    }
}
