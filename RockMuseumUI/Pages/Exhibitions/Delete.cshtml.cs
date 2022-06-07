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
    public class DeleteModel : PageModel
    {
        private readonly RockMuseumUI.Data.RockMuseumUIContext _context;

        public DeleteModel(RockMuseumUI.Data.RockMuseumUIContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            ExhibitionCollection = await _context.ExhibitionCollection.FindAsync(id);

            if (ExhibitionCollection != null)
            {
                _context.ExhibitionCollection.Remove(ExhibitionCollection);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
