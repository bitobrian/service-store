using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceStore.Pages
{
    public class ContactModel : PageModel
    {
        public string Message { get; set; }

        public void OnGet()
        {
            Message = "This application is supported by the development community. You can get help by utilizing Gitlab Issues or the Mattermost channel.";
        }
    }
}
