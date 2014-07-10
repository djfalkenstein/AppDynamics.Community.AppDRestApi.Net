using System;
using System.Collections.Generic;

namespace AppDynamics.Community.AppDRestApi.Net.Objects
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class TimeRangeHelper
    {
        public List<TimeRange> GetTimeRanges(int interval)
        {
            // First we are going to zero out the time 0000
            DateTime cal1 = new DateTime(0, 0, 0, 0, 0, 0, 0);

            //cal1.set(DateTime.HOUR_OF_DAY, 0);
            //cal1.set(DateTime.SECOND,0);
            //cal1.set(DateTime.MINUTE, 0);
            DateTime cal2 = cal1;
            cal2.AddHours(-24);

            List<TimeRange> value = new List<TimeRange> { new TimeRange(cal2.Ticks, cal1.Ticks) };

            for (int i = 1; i < interval; i++)
            {
                cal1.AddHours(-24);
                cal2.AddHours(-24);
                value.Add(new TimeRange(cal2.Ticks, cal1.Ticks));
            }
            value.Reverse();
            return value;
        }

        public TimeRange GetTimeRange(int interval)
        {
            DateTime cal1 = new DateTime();
            // First we are going to zero out the time 0000
            //cal1.set(DateTime.HOUR_OF_DAY, 0);
            //cal1.set(DateTime.SECOND,0);
            //cal1.set(DateTime.MINUTE, 0);
            //cal1.set(DateTime.MILLISECOND, 0);
            DateTime cal2 = new DateTime();
            //cal2.TimeInMillis = cal1.Ticks;
            //cal2.AddHours(-24);

            for (int i = 1; i < interval; i++)
            {
                cal2.AddHours(-24);
            }

            return new TimeRange(cal2.Ticks, cal1.Ticks);
        }

        /*
         *  In this example cal2 points to the start and cal1 points to the end.
         */

        public TimeRange GetTimeRange(long start, long end)
        {
            return new TimeRange(start, end);
        }

        public List<TimeRange> GetTimeRanges(long start, long end)
        {
            DateTime cal1 = new DateTime();
            DateTime cal2 = new DateTime();
            //cal1.TimeInMillis = end;
            //cal2.TimeInMillis = start;
            bool createOne = true;
            int count = 0;
            List<TimeRange> value = new List<TimeRange>();
            while (createOne)
            {
                DateTime cal3 = new DateTime();
                //cal3.TimeInMillis = cal2.Ticks;
                cal3.AddHours(24);
                if (count == 0 && (cal3.Ticks > cal1.Ticks))
                {
                    // This case will cover when the time stamp is smaller than 24 hours
                    value.Add(new TimeRange(cal2.Ticks, cal1.Ticks));
                    createOne = false;
                    count++;
                }
                else
                {
                    if (cal3.Ticks > cal1.Ticks && cal1.Ticks > cal2.Ticks)
                    {
                        value.Add(new TimeRange(cal2.Ticks, cal1.Ticks));
                        count++;
                        createOne = false;
                    }
                    else
                    {
                        value.Add(new TimeRange(cal2.Ticks, cal3.Ticks));
                        //cal2.TimeInMillis = cal3.Ticks;
                        count++;
                    }
                }
            }

            return value;
        }

        public List<TimeRange> GetHourlyTimeRanges(long start, long end)
        {
            List<TimeRange> value = new List<TimeRange>();
            DateTime cal1 = new DateTime();
            DateTime cal2 = new DateTime();

            // We are going to zero out the seconds and minutes
            //cal1.TimeInMillis = start;
            //cal1.set(DateTime.SECOND,0);
            //cal1.set(DateTime.MINUTE, 0);
            //cal1.set(DateTime.MILLISECOND, 0);
            //cal2.TimeInMillis = end;
            //cal2.set(DateTime.SECOND,0);
            //cal2.set(DateTime.MINUTE, 0);
            //cal2.set(DateTime.MILLISECOND, 0);
            //logger.log(Level.INFO,new StringBuilder().append("Start with ").append(cal1.getTime().toString()).append(" ending ").append(cal2.getTime()).toString());
            int count = 0;
            bool createOne = true;
            while (createOne)
            {
                DateTime cal3 = new DateTime();
                //cal3.TimeInMillis = cal1.Ticks;
                cal3.AddHours(1);
                if (count == 0 && (cal3.Ticks > cal2.Ticks))
                {
                    // This case will cover when the time stamp is smaller than 24 hours
                    value.Add(new TimeRange(cal1.Ticks, cal2.Ticks));
                    createOne = false;
                    count++;
                }
                else
                {
                    if (cal3.Ticks >= cal2.Ticks && cal2.Ticks > cal1.Ticks)
                    {
                        value.Add(new TimeRange(cal1.Ticks, cal2.Ticks));
                        count++;
                        createOne = false;
                    }
                    else
                    {
                        value.Add(new TimeRange(cal1.Ticks, cal3.Ticks));
                        //cal1.TimeInMillis = cal3.Ticks;

                        count++;
                    }
                }
            }
            return value;
        }
    }
}