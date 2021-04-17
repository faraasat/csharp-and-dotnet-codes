using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BulkyBook.Models
{

    public class ApplicationUser : IdentityUser  // This will add new columns to ASP .NET Users(which have created by selecting single user in authentication)
    {

        [Required]
        public string Name { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }


        public int? CompanyId { get; set; }  // To make nullable field

        [ForeignKey("CompanyId")]
        public Company Company { get; set; }
        

        [NotMapped]  // It is not mapped (pushed) in database
        public string Role { get; set; }

    }
}
