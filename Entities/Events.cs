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

    public class Events
    {
        private List<Event> _events = new List<Event>();

        public virtual List<Event> GetEvents()
        {
            return _events;
        }

        public virtual void SetEvents(List<Event> events)
        {
            _events = events;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.Events);
            foreach (Event ev in _events)
            {
                builder.Append(ev);
            }
            return builder.ToString();
        }
    }
}