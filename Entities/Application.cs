using System;
using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@AppDynamics.com
    /// </summary>
    public class Application
    {
        private int _id;
        private string _name;
        private string _description;

        public Application(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            internal set
            {
                _id = Convert.ToInt32(value);
            }
        }

        public string Name
        {
            get
            {
                return _name;
            }
            internal set
            {
                _name = value;
            }
        }

       public string Description
        {
            get
            {
                return _description;
            }
            internal set
            {
                _description = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("\tid = ").Append(_id).Append("\n");
            builder.Append("\tname = ").Append(_name).Append("\n");
            builder.Append("\tdescription = ").Append(_description).Append("\n\n");
            return builder.ToString();
        }
    }
}
