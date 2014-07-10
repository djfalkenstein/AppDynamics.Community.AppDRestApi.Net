using System;

namespace AppDynamics.Community.AppDRestApi.Net.Util
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class StringNumConv
    {
        //Depreciated
        public int GetIntFromString(string number, int defaultVal)
        {
            //return Convert.ToInt32(Number);
            throw new NotImplementedException("GetIntFromString");
        }

        public double GetDoubleFromString(string number, double defaultVal)
        {
            //return (int)(Convert.ToDouble(Number));
            throw new NotImplementedException("GetDoubleFromString");
        }
    }
}