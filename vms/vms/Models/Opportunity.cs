using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace vms.Models
{
    public class Opportunity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Center { get; set; }
        public string City { get; set; }
        public DateTime Time { get; set; }
    }
}
