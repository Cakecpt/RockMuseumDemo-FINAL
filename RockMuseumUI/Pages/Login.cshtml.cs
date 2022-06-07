using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System.ComponentModel.DataAnnotations;
using RockMuseumUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockMuseumUI.Pages
{
    public class LoginModel : PageModel
    {
        private readonly ILogger<LoginModel> _logger;

        public LoginModel(ILogger<LoginModel> logger)
        {
            _logger = logger;
        }
        [BindProperty]
        public LoginDetails Details { get; set; }
        public void OnGet()
        {
        }
        public class LoginDetails
        {
            [Required]
            public string username { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string password { get; set; }
        }
        public IActionResult OnPost()
        {
            if(Details.username == "admin" && Details.password == "admin")
            {
                return RedirectToPage("./AdminTerminal");
            }
            
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("./Index", new { Details.username});
        }
    }
}
