using System;
using System.Collections.Generic;

namespace AppDynamics.Community.AppDRestApi.Net.Objects

{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>
    public sealed class AgentEnum
    {
        public readonly AgentEnum JavaAgent, DotNet, Php, NodeJs, Machine = new AgentEnum();
        private static readonly IList<AgentEnum> ValueList = new List<AgentEnum>();

        AgentEnum(InnerEnum innerEnumValue, AgentEnum php, AgentEnum nodeJs, AgentEnum dotNet, AgentEnum javaAgent)
        {
            _innerEnumValue = innerEnumValue;
            Php = php;
            NodeJs = nodeJs;
            DotNet = dotNet;
            JavaAgent = javaAgent;
            ValueList.Add(JavaAgent);
            ValueList.Add(DotNet);
            ValueList.Add(Php);
            ValueList.Add(NodeJs);
            ValueList.Add(Machine);
        }

        public enum InnerEnum
        {
            JavaAgent, DotNet, Php, NodeJs, Machine
        }

        private readonly string nameValue = "";
        private readonly int ordinalValue = 0;
        private readonly InnerEnum _innerEnumValue;

        private AgentEnum()
        {
            throw new NotImplementedException();
        }

        //private static int nextOrdinal = 0;

        public IList<AgentEnum> Values()
        {
            return ValueList;
        }

        public InnerEnum InnerEnumValue()
        {
            return _innerEnumValue;
        }

        public int Ordinal()
        {
            return ordinalValue;
        }

        public override string ToString()
        {
            return nameValue;
        }

        public AgentEnum ValueOf(string name)
        {
            foreach (AgentEnum enumInstance in Values())
            {
                if (enumInstance.nameValue == name)
                {
                    return enumInstance;
                }
            }
            throw new ArgumentException(name);
        }
    }
}