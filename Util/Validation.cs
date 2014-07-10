using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Numerics;
using System.Text.RegularExpressions;

namespace AppDynamics.Community.AppDRestApi.Net.Util
{
    public class Validation
    {
        public string ValidatePassword(string password)
        {
            return password;
        }

        public string ValidateUsername(string username)
        {
            //Usernames that contain the following characters are not authenticated for REST API calls:
            //  \ / " [ ] : | < > + = ; , ? * @, ' tab space
            Regex regex = new Regex(@"^[A-z][A-z|0-9|\.|\s]+$");
            bool valid = regex.IsMatch(username);
            if (valid)
            {
                return username;
            }
            throw new FormatException("ValidateUsername: Invalid format for a user name. Must be letters, numbers, or a period.");
        }

        public string ValidateAccount(string account)
        {

            Regex regex = new Regex(@"^[A-z][A-z|0-9|\.|\s]+$");
            bool valid = regex.IsMatch(account);
            if (valid)
            {
                return account;
            }
            throw new FormatException("ValidateAccount: Invalid format for a account name. Must be letters, numbers, or a period.");
        }

        public string ValidatePort(string port)
        {
            if (string.IsNullOrEmpty(port))
            {
                return null;
            }
            int number;
            bool result = Int32.TryParse(port, out number);
            if (result)
            {
                return port;
            }
            throw new InvalidDataException("ValidatePort: Invalid port number.  Must be an integer.");
        }

        public string ValidaleDns(string controllerName)
        {
            //Should be a valid DNS: myController.company.com
            IPHostEntry host = Dns.GetHostEntry(controllerName);
            if (host.HostName.Length > 5) { return controllerName; }
            throw new FormatException("ValidaleDNS: Controller name is not valid.");
        }

        public bool IsGloballyUsableWebMailorFtpUrl(string urlString)
        {
            Uri uri;
            if (!Uri.TryCreate(urlString, UriKind.Absolute, out uri))
                return false;
            if (uri.Scheme != Uri.UriSchemeHttp
                && uri.Scheme != Uri.UriSchemeHttps
                && uri.Scheme != Uri.UriSchemeFtp
                && uri.Scheme != Uri.UriSchemeMailto)
                return false;
            string host = uri.Host;
            IPAddress ip;
            if (!IPAddress.TryParse(host, out ip)) //if we don't have an IP address in the host part.
                return host.Contains('.') && !host.EndsWith(".local", StringComparison.OrdinalIgnoreCase);
            // Does the domain have at least one period
            // And not the "local" binding used on many
            // Private networks
            var octets = ip.GetAddressBytes();
            if (octets.Length == 4)
                switch (octets[0]) //We've an IPv4 IP address, check it's not reserved.
                {
                    case 0:
                    case 10:
                    case 127:
                        return false;
                    case 128:
                    case 191:
                        return octets[1] != 0;
                    case 169:
                        return octets[1] != 254;
                    case 172:
                        return octets[1] < 16 || octets[1] > 31;
                    case 192:
                        return octets[1] != 168 && (octets[1] != 0 || octets[2] != 0);
                    case 223:
                        return octets[1] != 255 && octets[2] != 255;
                    default:
                        return true;
                }
            //We've an IPv6 IP address, check it's not reserved.
            if (IPAddress.HostToNetworkOrder(1) != 1)
                octets = octets.Reverse().ToArray();
            var ipInt = new BigInteger(octets);
            //Not the neatest approach, but serves
            if (ipInt < 0)
                return true;
            if (ipInt < 2)
                return false;
            if (ipInt < 281470681743360)
                return true;
            if (ipInt < 281474976710656)
                return false;
            if (ipInt < BigInteger.Parse("524413980667603649783483181312245760"))
                return true;
            if (ipInt < BigInteger.Parse("524413980667603649783483185607213056"))
                return false;
            if (ipInt < BigInteger.Parse("42540488161975842760550356425300246528"))
                return true;
            if (ipInt < BigInteger.Parse("42540488241204005274814694018844196864"))
                return false;
            if (ipInt < BigInteger.Parse("42540489429626442988779757922003451904"))
                return true;
            if (ipInt < BigInteger.Parse("42540490697277043217009159418706657280"))
                return false;
            if (ipInt < BigInteger.Parse("42540766411282592856903984951653826560"))
                return true;
            if (ipInt < BigInteger.Parse("42540766490510755371168322545197776896"))
                return false;
            if (ipInt < BigInteger.Parse("42545680458834377588178886921629466624"))
                return true;
            if (ipInt < BigInteger.Parse("42550872755692912415807417417958686720"))
                return false;
            if (ipInt < BigInteger.Parse("334965454937798799971759379190646833152"))
                return true;
            if (ipInt < BigInteger.Parse("337623910929368631717566993311207522304"))
                return false;
            if (ipInt < BigInteger.Parse("338288524927261089654018896841347694592"))
                return true;
            if (ipInt < BigInteger.Parse("338620831926207318622244848606417780736"))
                return false;
            if (ipInt < BigInteger.Parse("338953138925153547590470800371487866880"))
                return true;
            if (ipInt < BigInteger.Parse("340282366920938463463374607431768211456"))
                return false;
            return true;
        }
    }
}
