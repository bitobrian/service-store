using System.Collections.Generic;
using System.Linq;
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
            var trash = _context.ServiceItems.ToList();
            ServiceTeam = await _context.ServiceTeam.Where(b => b.Name == StoreName).FirstOrDefaultAsync();

            ServicesCount = ServiceTeam.ServiceItems.Count;

            return Page();
        }
    }
}
