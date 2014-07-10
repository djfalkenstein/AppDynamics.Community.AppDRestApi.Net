using System.Collections.Generic;
using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class Nodes
    {
        private List<Node> _node = new List<Node>();
        public virtual List<Node> GetNodes()
        {
            return _node;
        }

        public virtual List<Node> Node
        {
            set
            {
                _node = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            builder.Append("\tNode\n").Append(_node);

            return builder.ToString();
        }
    }
}