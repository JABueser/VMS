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

        [HttpGet]
        public async Task<ViewResult> Edit(Guid Id)
        {
            var volunteers = await _volunteerService.GetIncompleteVolunteersAsync();

            var model = new VolunteerViewModel()
            {
                Volunteers = volunteers
            };

            return View(model.Volunteers.FirstOrDefault(v => v.Id == Id));
        }

        [HttpPost]
        public IActionResult Edit(Volunteer volunteer)
        {
            if (ModelState.IsValid)
            {
                _volunteerService.Save(volunteer);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ViewResult Create() => View("Edit", new Volunteer());

        [HttpPost]
        public IActionResult Delete(Guid Id)
        {
            Volunteer deletedVolunteer = _volunteerService.Delete(Id);
            if (deletedVolunteer != null)
            {
                TempData["message"] = $"{deletedVolunteer.LastName} was deleted";
            }
            return Redirect("Index");
        }

    }
}