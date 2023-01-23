using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Utils
{
    public static class DateUtils
    {
        public static string ToJalai(this DateTime date )
        {
            var pc = new PersianCalendar();
            var year = pc.GetYear( date );
            var month = pc.GetMonth( date );
            var day = pc.GetDayOfMonth( date );
            return $"{year}/{month}/{day}";

        }
    }
}
