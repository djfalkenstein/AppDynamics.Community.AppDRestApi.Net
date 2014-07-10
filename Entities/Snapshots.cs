using System.Collections.Generic;
using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>

    public class Snapshots
    {
        private List<Snapshot> _requestDatas = new List<Snapshot>();

        public virtual List<Snapshot> RequestDatas
        {
            get
            {
                return _requestDatas;
            }
            set
            {
                _requestDatas = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.RequestSegmentDatas);
            foreach (Snapshot ss in _requestDatas)
            {
                builder.Append(ss);
            }
            return builder.ToString();
        }
    }
}