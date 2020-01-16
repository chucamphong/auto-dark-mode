using System;

namespace AutoDarkMode.Core
{
    public static class DateTimeExtensions
    {
        public static bool IsMorning(this DateTime dateTime)
        {
            int hour = dateTime.Hour;

            return hour > 5 && hour < 18;
        }

        public static bool IsNight(this DateTime dateTime)
        {
            int hour = DateTime.Now.Hour;

            return hour < 6 && hour > 17;
        }
    }
}
