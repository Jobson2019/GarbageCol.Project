using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GarbageCollectProject.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }
    }
}