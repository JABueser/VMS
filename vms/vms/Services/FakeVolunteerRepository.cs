using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using vms.Models;

namespace vms.Services
{
    public class FakeVolunteerRepository /*: IVolunteerService*/
    {
        public Task<Volunteer[]> GetIncompleteVolunteersAsync()
        {
            var item1 = new Volunteer
            {
                FirstName = "Alice",
                LastName = "Aubrey",
            };

            var item2 = new Volunteer
            {
                FirstName = "Bob",
                LastName = "Blue",
            };

            return Task.FromResult(new[] { item1, item2 });
        }
    }
}
