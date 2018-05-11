using System;

namespace TDD_S1.Domian.Utility
{
    public static class DatetimeExtensions
    {
        public static bool IsPast(this DateTime date)
        {
            return date <= DateTime.Now;
        }

        public static bool IsBefore(this DateTime target, DateTime otherDateTime)
        {
            return target < otherDateTime;
        }
    }
}
