using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vms.Data;
using vms.Models;

namespace vms.Services
{
    public class OpportunitiesService : IOpportunityService
    {
        private readonly ApplicationDbContext _context;

        public OpportunitiesService(ApplicationDbContext context)
            {
                 _context = context;
            }

        public async Task<Opportunity[]> GetIncompleteOpportunitesAsync()
        {
            return await _context.Opportunities.ToArrayAsync();
        }

        public void Save(Opportunity opportunity)
        {
            if(opportunity.Id == Guid.Empty)
            {
                _context.Opportunities.Add(opportunity);
            }
            else
            {
                Opportunity dbEntry = _context.Opportunities.FirstOrDefault(v => v.Id == opportunity.Id);
                if(dbEntry != null)
                {
                    dbEntry.Name = opportunity.Name;
                    dbEntry.Description = opportunity.Description;
                    dbEntry.Center = opportunity.Center;
                    dbEntry.City = opportunity.City;
                    dbEntry.Time = opportunity.Time;
                
                }
            }
            _context.SaveChanges();
        }
        public Opportunity Delete(Guid Id)
        {
            Opportunity dbEntry = _context.Opportunities.FirstOrDefault(v => v.Id == Id);
            if(dbEntry != null)
            {
                _context.Opportunities.Remove(dbEntry);
                _context.SaveChanges();
            }
            return dbEntry;
        }
    }
}
