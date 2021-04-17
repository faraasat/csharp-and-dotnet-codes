using System;
using System.Collections.Generic;
using System.Text;

namespace BulkyBook.Models
{
    // This class is not added to db
    // This class is the model for custom tag helper which is added to TagHelper > PageLinkTagHelper
    public class PagingInfo
    {
       
        public int TotalItem { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public string UrlParam { get; set; }
        public int Totalpages => (int)Math.Ceiling((decimal)TotalItem / ItemsPerPage);

    }
}
