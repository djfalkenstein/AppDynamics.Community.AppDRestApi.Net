/*
 * To change this template, choose Tools | Templates
 * and open the template in the editor.
 */

using System.Collections.Generic;
using System.Text;

namespace AppDynamics.Community.AppDRestApi.Net.Entities
{
    ///
    /// <summary>
    /// @author david.falkenstein@appdynamics.com
    /// </summary>

    public class BusinessTransactions
    {
        private List<BusinessTransaction> _businessTransactions = new List<BusinessTransaction>();

        public virtual List<BusinessTransaction> GetBusinessTransactions()
        {
            return _businessTransactions;
        }

        public virtual void SetBusinessTransactions(List<BusinessTransaction> businessTransactions)
        {
            _businessTransactions = businessTransactions;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            foreach (BusinessTransaction bt in _businessTransactions)
            {
                builder.Append(bt);
            }
            return builder.ToString();
        }
    }
}