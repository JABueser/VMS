using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vms.Models;

namespace vms.Services
{
    public class FakeOpportunityRepositiory 
    {
        public Task<Opportunity[]> GetIncompleteOpportunitesAsync()
        {
            var item1 = new Opportunity
            {
                Name = "1",
                Description = "abc",
                Center = "def",
                City = "Jacksonville",
            };

            var item2 = new Opportunity
            { 
                Name = "2",
                Description = "abc",
                Center = "def",
                City = "Jacksonville",
            };
            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
