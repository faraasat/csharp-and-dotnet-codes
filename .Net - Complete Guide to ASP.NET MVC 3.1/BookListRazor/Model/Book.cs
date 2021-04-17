using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookListRazor.Model
{
    public class Book
    {
        [Key]  // Key refers to Identity and we do not have to pass a value this will a auto number
        public int Id { get; set; }

        [Required]  // Means this field cannot be null
        public string Name { get; set; }
        public string Author { get; set; }
        public string ISBN { get; set; }
    }
}
