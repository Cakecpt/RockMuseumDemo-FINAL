using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RockMuseumUI.Data;
using RockMuseumUI.Models;

namespace RockMuseumUI.Pages.Exhibitions
{
    public class DetailsModel : PageModel
    {
        private readonly RockMuseumUI.Data.RockMuseumUIContext _context;

        public DetailsModel(RockMuseumUI.Data.RockMuseumUIContext context)
        {
            _context = context;
        }

        public ExhibitionCollection ExhibitionCollection { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ExhibitionCollection = await _context.ExhibitionCollection.FirstOrDefaultAsync(m => m.ID == id);

            if (ExhibitionCollection == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
