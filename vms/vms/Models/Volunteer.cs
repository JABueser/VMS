using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vms.Models
{
    public class Volunteer
    {
        public Guid Id { get; set; }
        //[Required]
        public string FirstName { get; set; }
        //[Required]
        public string LastName { get; set; }
        //[Required]
        public string Username { get; set; }
        //[Required]
        public string Password { get; set; }
        //[Required]
        public string Centers { get; set; }
        //[Required]
        public string Skills { get; set; }
        //[Required]
        public string AvailableTimes { get; set; }
        //[Required]
        public string Address { get; set; }
        //[Required]
        public int PhoneNumbers { get; set; }
        //[Required]
        public string Email { get; set; }
        //[Required]
        public string EducationalBackground { get; set; }
        //[Required]
        public string CurrentLicenses { get; set; }
        //[Required]
        public string EmerContactName { get; set; }
        //[Required]
        public int EmerPhoneNum { get; set; }
        //[Required]
        public string EmerEmail { get; set; }
        //[Required]
        public string EmerAddress { get; set; }
        //[Required]
        public bool IsDrivLicense { get; set; }
        //[Required]
        public bool IsSocSec { get; set; }
        //[Required]
        public bool IsApproved { get; set; }
    }
}
