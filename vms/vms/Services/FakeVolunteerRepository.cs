using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vms.Models;

namespace vms.Services
{
    public class FakeVolunteerRepository : IVolunteerService
    {
        public Task<Volunteer[]> GetIncompleteVolunteersAsync()
        {
            var item1 = new Volunteer
            {

                FirstName = "Abby",
                LastName = "Ash",
                Username = "aAsh",
                Password = "watermelon",
                Centers = "Kids",
                Skills = "Singing",
                AvailableTimes = "Morning",
                Address = "100 Maple St",
                PhoneNumbers = "9042754738",
                Email = "abbyash@gmail.com",
                EducationalBackground = "High School Diploma",
                CurrentLicenses = "none",
                EmerContactName = "Joh Sua",
                EmerEmail = "joh@gmail.com",
                EmerAddress = "101 Maple S",
                IsDrivLicense = true,
                IsSocSec = true,
                IsApproved = false,
                IsPending = false,
                IsInactive = false,

            };

            var item2 = new Volunteer
            {
                FirstName = "Bob",
                LastName = "Burger",
                Username = "bBurger",
                Password = "watermelon",
                Centers = "Pets",
                Skills = "Dancing",
                AvailableTimes = "Nights",
                Address = "800 Dancing St",
                PhoneNumbers = "9042857739",
                Email = "bBurger@gmail.com",
                EducationalBackground = "Degree",
                CurrentLicenses = "None",
                EmerContactName = "Amy Ames",
                EmerEmail = "aAmes@gmail.com",
                EmerAddress = "448 Turn St",
                IsDrivLicense = true,
                IsSocSec = true,
                IsApproved = true,
                IsPending = true,
                IsInactive = false,
            };

            var item3 = new Volunteer
            {
                FirstName = "Carley",
                LastName = "Coss",
                Username = "cCoss",
                Password = "watermelon",
                Centers = "Main",
                Skills = "Budgeting",
                AvailableTimes = "Everyday",
                Address = "930 Hald Ave",
                PhoneNumbers = "9047284482",
                Email = "cCoss@gmail.com",
                EducationalBackground = "Masters",
                CurrentLicenses = "None",
                EmerContactName = "Dez",
                EmerEmail = "@gmail.com",
                EmerAddress = "338 Urals Ave",
                IsDrivLicense = false,
                IsSocSec = true,
                IsApproved = false,
                IsPending = false,
                IsInactive = true,
            };

            var item4 = new Volunteer
            {
                FirstName = "Dustin",
                LastName = "Smith",
                Username = "dSmith",
                Password = "watermelon",
                Centers = "Dog",
                Skills = "Grooming",
                AvailableTimes = "Weekends",
                Address = "884 Head Ave",
                PhoneNumbers = "9573385638",
                Email = "dSmith@gmail.com",
                EducationalBackground = "High School",
                CurrentLicenses = "Grooming",
                EmerContactName = "Ezy Bend",
                EmerEmail = "eBend@gmail.com",
                EmerAddress = "947 Bear Ave",
                IsDrivLicense = false,
                IsSocSec = true,
                IsApproved = false,
                IsPending = false,
                IsInactive = false,
            };

            var item5 = new Volunteer
            {
                FirstName = "Evan",
                LastName = "Turn",
                Username = "eTurn",
                Password = "watermelon",
                Centers = "Hair",
                Skills = "Cutting Hair",
                AvailableTimes = "Weekdays",
                Address = "2379 Harring St",
                PhoneNumbers = "3849957263",
                Email = "eTurn@gmail.com",
                EducationalBackground = "AA Degree",
                CurrentLicenses = "Hair",
                EmerContactName = "Jason Menjivar",
                EmerEmail = "jMenjivar@gmail.com",
                EmerAddress = "994 Haris Ave",
                IsDrivLicense = false,
                IsSocSec = true,
                IsApproved = true,
                IsPending = false,
                IsInactive = false,
            };

            var item6 = new Volunteer
            {
                FirstName = "Michael",
                LastName = "Herbert",
                Username = "mHerbert",
                Password = "watermelon",
                Centers = "Finance",
                Skills = "Accounting",
                AvailableTimes = "Weekdays",
                Address = "2948 Main Ave",
                PhoneNumbers = "9473478836",
                Email = "mHerbert@gmail.com",
                EducationalBackground = "Masters",
                CurrentLicenses = "none",
                EmerContactName = "kane Jax",
                EmerEmail = "kJax@gmail.com",
                EmerAddress = "1939 Sand st",
                IsDrivLicense = true,
                IsSocSec = true,
                IsApproved = false,
                IsPending = false,
                IsInactive = false,
            };

            var item7 = new Volunteer
            {
                FirstName = "Kane",
                LastName = "Amsi",
                Username = "kAmsi",
                Password = "watermelon",
                Centers = "Kids",
                Skills = "none",
                AvailableTimes = "everyday",
                Address = "2948 Gold Way",
                PhoneNumbers = "3947752993",
                Email = "kAmsi@gmail.com",
                EducationalBackground = "High School Diploma",
                CurrentLicenses = "none",
                EmerContactName = "Wen Karry",
                EmerEmail = "wKarry@gmail.com",
                EmerAddress = "2984 Jery Ave",
                IsDrivLicense = true,
                IsSocSec = true,
                IsApproved = true,
                IsPending = false,
                IsInactive = false,
            };

            var item8 = new Volunteer
            {
                FirstName = "Edgar",
                LastName = "Poe",
                Username = "ePoe",
                Password = "watermelon",
                Centers = "Main",
                Skills = "none",
                AvailableTimes = "Mornings",
                Address = "2948 Insice Ave",
                PhoneNumbers = "9947263517",
                Email = "ePoe@gmail.com",
                EducationalBackground = "Bachelor",
                CurrentLicenses = "none",
                EmerContactName = "Bach Kers",
                EmerEmail = "bKers@gmail.com",
                EmerAddress = "448 Jane Ave",
                IsDrivLicense = false,
                IsSocSec = false,
                IsApproved = false,
                IsPending = false,
                IsInactive = false,
            };
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
