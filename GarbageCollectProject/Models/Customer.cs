using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GarbageCollectProject.Models
{

    //public enum DayOfTheWeek
    //{
    //    Monday;
    //    Tuesday;
    //    Wednesday;
    //    Thursday;
    //    Friday;

    //}
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        [Display(Name = "City")]
        public string City { get; set; }
        [Display(Name = "State")]
        public string State { get; set; }
        [Display(Name = "Zip Code")]
        public int ZipCode { get; set; }
        [Display(Name = "Pick Up Day")]
        public DateTime? PickUpDay { get; set; }
        [Display(Name = "Balance")]
        public double Balance { get; set; }
        [Display(Name = "Monthly Charge")]
        public double MonthlyCharge { get; set; }
        [Display(Name = "Pickup Confirmed")]
        public bool PickupConfirmed { get; set; }
        [Display(Name = "Start")]
        public DateTime? StartDate { get; set; }
        [Display(Name = "End")]
        public DateTime? EndDate { get; set; }

        [Display(Name = "Extra Pickup Day")]
        public string ExtraPickupDay { get; set; } = null;
        
        [Display(Name = "Change Pickup Day")] 
        public DateTime? ChangeDay { get; set; }
        [Display(Name = "User Name")]
        public string UserName { get; set; }


        

    }
}