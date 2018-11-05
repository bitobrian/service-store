using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ServiceStore.Models;

namespace ServiceStore.Pages
{
    public class CreateStoreModel : PageModel
    {
        private readonly ServiceStore.Models.ServiceStoreContext _context;

        public CreateStoreModel(ServiceStore.Models.ServiceStoreContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public ServiceTeam ServiceTeam { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            ServiceTeam.ServiceItems = new ServiceItem().PreloadServiceItems();

            _context.Add(ServiceTeam);
            _context.SaveChanges();

            return RedirectToPage("./Index");
        }
    }
}