/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Collections.Generic;
using System.Text;
using AppDynamics.Community.AppDRestApi.Net.Resources;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>

    public class Backends
    {
        private List<Backend> _backend = new List<Backend>();

        public virtual List<Backend> Backend
        {
            get
            {
                return _backend;
            }
            set
            {
                _backend = value;
            }
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.Backends);
            foreach (Backend bc in _backend)
            {
                builder.Append(bc);
            }
            return builder.ToString();
        }
    }
}