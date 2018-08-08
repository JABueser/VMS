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
                EmerContactName = "Joh",
                EmerEmail = "joh@gmail.com",
                EmerAddress = "101 Maple S",
                IsDrivLicense = true,
                IsSocSec = true,
                IsApproved = false,
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
                EmerAddress = "ffj@gmail.com",
                IsDrivLicense = true,
                IsSocSec = true,
                IsApproved = true,
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
                CurrentLicenses = "",
                EmerContactName = "",
                EmerEmail = "@gmail.com",
                EmerAddress = "",
                IsDrivLicense = true,
                IsSocSec = true,
                IsApproved = true,
                IsInactive = true,
            };

            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
