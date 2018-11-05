using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ServiceStore.Models;

namespace ServiceStore.Pages
{
    public class StoreModel : PageModel
    {
        private readonly ServiceStoreContext _context;

        public StoreModel(ServiceStoreContext context)
        {
            _context = context;
        }

        public ServiceTeam ServiceTeam { get;set; }
        public int ServicesCount { get; set; }

        public async Task<IActionResult> OnGetAsync(string StoreName)
        {
            //ServiceTeam = await _context.ServiceTeam.FindAsync(id);
            ServiceTeam = new ServiceTeam();
            ServicesCount = ServiceTeam.ServiceItems.Count;

            return Page();
        }
    }
}
