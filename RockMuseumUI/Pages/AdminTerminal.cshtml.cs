using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace RockMuseumUI.Pages
{
    public class AdminTerminalModel : PageModel
    {
        public void OnGet()
        {
        }
        public IActionResult OnPostVideo1()
        {

            return RedirectToPage("./Videodump/VideoPage1");
        }
        public IActionResult OnPostVideo2()
        {

            return RedirectToPage("./Videodump/VideoPage2");
        }
    }
}
