using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceStore.Pages
{
    public class AboutModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "This application is built using ASP.NET Core 2.1 and Razor frameworks. It is an open repository, continuously delivered, and served on Cloud Foundry.";
        }
    }
}
