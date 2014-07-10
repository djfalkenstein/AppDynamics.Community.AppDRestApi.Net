using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Objects
{
    public class RestAuth
    {
        ///  https://help.AppDynamics.com/entries/511702-AppDynamics.Community.AppDRestApi-REST-API#ListofAPI
        /// <summary>
        /// @author david.falkenstein@AppDynamics.com
        /// </summary>
        public string Name { get; set; }
        public string Password { get; set; }
        public string CustName { get; set; }
        public bool IsMultiTenant { get; set; }

        public RestAuth(string name, string password)
        {
            CustName = "customer1";
            Name = name;
            Password = password;
        }

        public RestAuth(string name, string password, string custName, bool isMultiTenant)
        {
            Name = name;
            Password = password;
            CustName = custName;
            IsMultiTenant = isMultiTenant;
        }

        public virtual string UserNameForAuth
        {
            get
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(Name).Append("@").Append(CustName);
                return builder.ToString();
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("\n\tUser ").Append(UserNameForAuth).Append("\n");
            builder.Append("\tPasswd ").Append(Password).Append("\n");
            return builder.ToString();
        }
    }

}
