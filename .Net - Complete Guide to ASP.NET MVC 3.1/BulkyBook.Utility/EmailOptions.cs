using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.Utility
{
    public class EmailOptions
    {
        // Done setting of this class in Startup.cs
        public string SendGridKey { get; set; }
        public string SendGridUser { get; set; }

    }
}
