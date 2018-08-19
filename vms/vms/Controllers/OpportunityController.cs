using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using vms.Models;
using vms.Services;

namespace vms.Controllers
{
    public class OpportunityController : Controller
    {
        private readonly IOpportunityService _opportunityService;
        
        public OpportunityController(IOpportunityService opportunityService)
        {
            _opportunityService = opportunityService;
        }


        public async Task<IActionResult> Index()
        {
            var opportunities = await _opportunityService.GetIncompleteOpportunitesAsync();

            var model = new OpportunityViewModel()
            {
                Opportunities = opportunities
            };

            return View(model);
        }

        [HttpGet]
        public async Task<ViewResult> Edit(Guid Id)
        {

            var opportunities = await _opportunityService.GetIncompleteOpportunitesAsync();

            var model = new OpportunityViewModel()
            {
                Opportunities = opportunities
            };
            return View(model.Opportunities.FirstOrDefault(v => v.Id == Id));
        }

        [HttpPost] 
        public IActionResult Edit(Opportunity opportunity)
        {
            if(ModelState.IsValid)
            {
                _opportunityService.Save(opportunity);
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }

        public ViewResult Create() => View("Edit", new Opportunity());

        [HttpPost]
        public IActionResult Delete(Guid Id)
        {
            Opportunity deletedOpportunity = _opportunityService.Delete(Id);
            if(deletedOpportunity != null)
            {
                TempData["message"] = $"{deletedOpportunity.Name} was deleted";
            }
            return Redirect("Index");
        }
    }
}