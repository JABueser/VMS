using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vms.Data;
using vms.Models;

namespace vms.Services
{
    public class VolunteersService : IVolunteerService
    {
        private readonly ApplicationDbContext _context;

        public VolunteersService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Volunteer[]> GetIncompleteVolunteersAsync()
        {
            return await _context.Volunteers.ToArrayAsync();
        }

        public void Save(Volunteer volunteer)
        {
            if (volunteer.Id == Guid.Empty)
            {
                _context.Volunteers.Add(volunteer);
            }
            else
            {
                Volunteer dbEntry = _context.Volunteers.FirstOrDefault(v => v.Id == volunteer.Id);
                if(dbEntry != null)
                {
                    dbEntry.FirstName = volunteer.FirstName;
                    dbEntry.LastName = volunteer.LastName;
                    dbEntry.Username = volunteer.Username;
                    dbEntry.Password = volunteer.Password;
                    dbEntry.Centers = volunteer.Centers;
                    dbEntry.Skills = volunteer.Skills;
                    dbEntry.AvailableTimes = volunteer.AvailableTimes;
                    dbEntry.Address = volunteer.Address;
                    dbEntry.PhoneNumbers = volunteer.PhoneNumbers;
                    dbEntry.Email = volunteer.Email;
                    dbEntry.EducationalBackground = volunteer.EducationalBackground;
                    dbEntry.CurrentLicenses = volunteer.CurrentLicenses;
                    dbEntry.EmerContactName = volunteer.EmerContactName;
                    dbEntry.EmerPhoneNum = volunteer.EmerPhoneNum;
                    dbEntry.EmerAddress = volunteer.EmerAddress;
                    dbEntry.EmerEmail = volunteer.EmerEmail;
                    dbEntry.IsApproved = volunteer.IsApproved;
                    dbEntry.IsDrivLicense = volunteer.IsDrivLicense;
                    dbEntry.IsSocSec = dbEntry.IsSocSec;
                    dbEntry.IsPending = dbEntry.IsPending;
                    dbEntry.IsInactive = dbEntry.IsInactive;
                }
            }
            _context.SaveChanges();
        }

        public Volunteer Delete(Guid Id)
        {
            Volunteer dbEntry = _context.Volunteers.FirstOrDefault(v => v.Id == Id);
            if(dbEntry != null)
            {
                _context.Volunteers.Remove(dbEntry);
                _context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
