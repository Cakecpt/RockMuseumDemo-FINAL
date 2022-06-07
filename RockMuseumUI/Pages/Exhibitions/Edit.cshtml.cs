using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RockMuseumUI.Data;
using RockMuseumUI.Models;

namespace RockMuseumUI.Pages.Exhibitions
{
    public class EditModel : PageModel
    {
        private readonly RockMuseumUI.Data.RockMuseumUIContext _context;

        public EditModel(RockMuseumUI.Data.RockMuseumUIContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(ExhibitionCollection).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ExhibitionCollectionExists(ExhibitionCollection.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ExhibitionCollectionExists(int id)
        {
            return _context.ExhibitionCollection.Any(e => e.ID == id);
        }
    }
}
