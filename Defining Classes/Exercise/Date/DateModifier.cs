using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateModifier
{
    public static class DateModifier
    {
        public static int GetDifference(string start, string end)
        {
            DateTime startDate = DateTime.Parse(start);
            DateTime endDate = DateTime.Parse(end);
            TimeSpan span = endDate - startDate;
            return Math.Abs(span.Days);
        }

    }
}
