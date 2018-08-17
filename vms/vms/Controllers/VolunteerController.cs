using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vms.Models;
using vms.Services;

namespace vms.Controllers
{
    public class VolunteerController : Controller
    {
        private readonly IVolunteerService _volunteerService;

        public VolunteerController (IVolunteerService volunteerService)
        {
            _volunteerService = volunteerService;
        }

        public async Task<IActionResult> Index()
        {
            var volunteers = await _volunteerService.GetIncompleteVolunteersAsync();

            var model = new VolunteerViewModel()
            {
                Volunteers = volunteers
            };

            return View(model);
        }


        public async Task<IActionResult> Search(int status, string LastName)
        {
            bool IsApproved = false;
            bool IsPending = false;
            //bool IsDisapproved = false;
            bool IsInactive = false;
            switch (status)
            {
                case 1:
                    IsApproved = true;
                    IsPending = true;
                    break;
                case 2:
                    IsApproved = true;
                    break;
                case 3:
                    IsPending = true;
                    break;
                case 4:
                    IsApproved = false;
                    break;
                case 5:
                    IsInactive = true;
                    break;
            }
            var volunteers = await _volunteerService.GetIncompleteVolunteersAsync();

            var model = new VolunteerViewModel()
            {
                Volunteers = volunteers.Where(i => ((i.LastName == LastName) || (i.IsApproved == IsApproved && i.IsPending == IsPending && i.IsInactive == IsInactive))
                            //Volunteers = volunteers.Where(i => (i.LastName == LastName && i.IsApproved == IsApproved && i.IsPending && IsPending && i.IsInactive == IsInactive)
                            //        (i.LastName == LastName && i.IsApproved == IsApproved  && i.IsPending == IsPending) ||
                            //        (i.LastName == LastName && i.IsApproved == IsApproved) ||
                            //        (i.LastName == LastName && i.IsPending == IsPending) ||
                            //        (i.LastName == LastName && i.IsApproved == IsApproved && i.IsPending == IsPending) ||
                            //        (i.LastName == LastName && i.IsInactive == IsInactive)

                            ).Cast<Volunteer>().ToArray()
            };

            return View(model);
        }
    }
}