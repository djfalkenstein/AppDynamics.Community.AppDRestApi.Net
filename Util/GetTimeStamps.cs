using System;
using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Util
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class GetTimeStamps
    {
        ///// <summary>
        ///// This will return a set of timestamps that can be used to help with the use
        ///// of the RESTAPI API.
        ///// </summary>
        ///// <param name="args"> None required </param>
        //public void Main(string[] args)
        //{
        //    StringBuilder builder = new StringBuilder();
        //    DateTime cal = new DateTime();
        //    builder.Append("Now  : ").Append(getStringTime(cal));
        //    cal.set(DateTime.MINUTE, 0);
        //    cal.set(DateTime.SECOND,0);
        //    builder.Append("Hour : ").Append(getStringTime(cal));
        //    builder.Append("-----------------------Hours-----------------------\n");
        //    for (int i = 1; i < 12 ;i++)
        //    {
        //        cal.AddHours(-1);
        //        builder.Append("Time : ").Append(getStringTime(cal));
        //    }

        //    cal.set(DateTime.HOUR_OF_DAY, 0);
        //    builder.Append("-----------------------Days-----------------------\n");
        //    for (int i = 1; i < 45;i++)
        //    {
        //        int a = 24 * -1;
        //        cal.AddHours(a);
        //        builder.Append("Days : ").Append(getStringTime(cal));
        //    }
        //    Console.WriteLine(builder.ToString());
        //}

        public string GetStringTime(DateTime cal)
        {
            return (new StringBuilder()).Append(cal).Append(" : ").Append(cal.Ticks).Append("\n").ToString();
        }
    }
}