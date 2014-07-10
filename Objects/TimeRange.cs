using System;
using System.Globalization;
using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Objects
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class TimeRange
    {
        public string TrName { get; set; }

        public long TrStart { get; set; }

        public long TrEnd { get; set; }

        public TimeRange()
        {
        }

        public TimeRange(string name)
        {
            TrName = ValidateTrName(name);
        }

        //TODO: validate time range
        public TimeRange(long start, long end)
        {
            TrStart = start;
            TrEnd = end;
        }

        //TODO: validate time range
        public TimeRange(string name, long start, long end)
        {
            TrName = ValidateTrName(name);
            TrStart = start;
            TrEnd = end;
        }

        private static string ValidateTrName(string name)
        {
            //TODO: validate time range name
            return name;
        }

        public virtual bool IsWithIn(long time)
        {
            return time >= TrStart && time <= TrEnd;
        }

        //public virtual bool IsWithIn(TimeRange time)
        //{
        //    if (time >= TrStart && time.end <= end)
        //    {
        //        return true;
        //    }
        //    return false;
        //}

        public virtual string GetDate(long val)
        {
            //DateTime cal = new DateTime();
            //cal = (DateTime)val;

            //return cal.ToString();
            // Date date = new Date(time);
            //Format format = new SimpleDateFormat("yyyy MM dd HH:mm:ss");
            return val.ToString(CultureInfo.InvariantCulture); //format.format(date).toString());
        }

        public virtual string CreateName()
        {
            DateTime cal1 = new DateTime();
            DateTime cal2 = new DateTime();
            //cal1.TimeInMillis = start;
            //.TimeInMillis = end;

            StringBuilder builder = new StringBuilder();
            builder.Append(cal1).Append(" thru ").Append(cal2);
            return builder.ToString();
        }

        public virtual string ColumnName
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                DateTime cal = new DateTime();
                //cal.TimeInMillis = start;
                builder.Append(cal.Month + 1).Append("/");
                builder.Append(cal.Day).Append("/").Append(cal.Year);
                return builder.ToString();
            }
        }

        public virtual string HourColumnName
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                DateTime cal = new DateTime();
                //cal.TimeInMillis = TrStart;
                builder.Append(cal.Month + 1).Append("/");
                builder.Append(cal.Day).Append("/").Append(cal.Year);
                //builder.Append(" ").Append(cal.get(DateTime.HOUR_OF_DAY)).Append(":00");
                return builder.ToString();
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Time range\n");
            builder.Append("\t\tStart time ").Append(GetDate(TrStart)).Append(" :: ").Append(TrStart).Append("\n");
            builder.Append("\t\tEnd time ").Append(GetDate(TrEnd)).Append(" :: ").Append(TrEnd).Append("\n");

            return builder.ToString();
        }
    }
}