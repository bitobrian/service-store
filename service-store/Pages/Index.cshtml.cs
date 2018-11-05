using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ServiceStore.Pages
{
    public class IndexModel : PageModel
    {
        public string WelcomeTitle { get; set; }
        public List<string> welcomeList = new List<string>()
        {
            "Welcome",
            "welkom",
            "benvinguts",
            "bienvenue",
            "benvido",
            "willkommen",
            "e komo mai",
            "namaste",
            "witaj",
            "wöikomme",
            "ยินดีต้อนรับ",
            "Ласкаво просимо",
            "croeso",
            "dobrodošli",
            "fàilte",
            "Табуафси"
        };
        public void OnGet()
        {
            WelcomeTitle = welcomeList[new Random().Next(welcomeList.Count)];
        }
    }
}
