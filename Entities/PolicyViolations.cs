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
    public class PolicyViolations
    {
        private List<PolicyViolation> _policyViolations = new List<PolicyViolation>();

        public virtual List<PolicyViolation> GetPolicyViolations()
        {
            return _policyViolations;
        }

        public virtual void SetPolicyViolations(List<PolicyViolation> policyViolations)
        {
            _policyViolations = policyViolations;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(Dictionary.PolicyViolations);
            foreach (PolicyViolation pv in _policyViolations)
            {
                builder.Append(pv);
            }
            return builder.ToString();
        }
    }
}