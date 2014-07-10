using System.Collections.Generic;
using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class Applications
    {

        private List<Application> _applications = new List<Application>();

        public virtual List<Application> GetApplications()
        {
            return _applications;
        }

        public virtual void SetApplications(List<Application> applications)
        {
            _applications = applications;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (Application app in _applications)
            {
                builder.Append(app);
            }
            return builder.ToString();
        }

        public virtual List<Application> ToApplicationList()
        {
            return _applications;
        }

    }
}
