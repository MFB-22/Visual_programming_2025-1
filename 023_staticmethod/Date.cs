using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _023_staticmethod
{
    class Date
    {
        public int year, month, day;

        public static bool IsLeapyear(int year)
        {
            //윤년 4로 나누어지고 100으로는 나누어지지 않는 해 또는 400으로 나누어지는 해
            return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
        }

        static int[] days = { 0, 31, 59, 90, 120, 151, 181, 212, 243, 273, 304, 334 };

        public int DayOfYear()
        {
            return days[month - 1] + day + (month > 2 && IsLeapyear(year) ? 1 : 0);
            //if (month > 2 && IsLeapyear(year))
            //{
            //    return days[month - 1] + day + 1;
            //}
            //else
            //    return days[month - 1] + day;
        }
    }
}
