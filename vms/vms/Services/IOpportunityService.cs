using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vms.Models;

namespace vms.Services
{
    public interface IOpportunityService
    {
        Task<Opportunity[]> GetIncompleteOpportunitesAsync();
        void Save(Opportunity opportunity);
        Opportunity Delete(Guid Id);
    }
}
