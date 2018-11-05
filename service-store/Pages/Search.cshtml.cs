using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceStore.Models;

namespace ServiceStore.Pages
{
    public class SearchModel : PageModel
    {
        private readonly ServiceStore.Models.ServiceStoreContext _context;

        public SearchModel(ServiceStore.Models.ServiceStoreContext context)
        {
            _context = context;
        }

        public IList<ServiceTeam> ServiceTeam { get;set; }

        public void OnGet()
        {
            var trash = _context.ServiceItems.ToList();
            ServiceTeam = _context.ServiceTeam.ToList();
        }
    }
}
