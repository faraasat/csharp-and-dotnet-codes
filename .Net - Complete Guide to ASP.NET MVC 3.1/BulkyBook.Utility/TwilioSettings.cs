using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.Utility
{
    public class TwilioSettings
    {
        // Done setting of this class in Startup.cs
        public string PhoneNumber { get; set; }
        public string AuthToken { get; set; }
        public string AccountSid { get; set; }

    }
}
