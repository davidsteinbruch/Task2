using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Task2.Models
{
    public class Person
    {
        [StringLength(50)]        
        public string FirstName { get; set; }
        [StringLength(50)]
        public string LastName { get; set; }
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }
        public string Region { get; set; }
        public string Country { get; set; }
    }
}
