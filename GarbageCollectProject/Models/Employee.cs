using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarbageCollectProject.Models
{
    public class Employee
    {
        [Key]
        public int id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Zip Code")]
        public string ZipCode { get; set; }
        
        [Display(Name = "Title")]
        public string Title { get; set; }
    }
}