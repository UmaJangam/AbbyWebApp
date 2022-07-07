using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abby.Utility
{
    public class StripeSettings
    {
        public string SecretKey { get; set; }       //secret key
        public string PublishableKey { get; set; } //publishable key     //we store them in the appsettings
    }
}
