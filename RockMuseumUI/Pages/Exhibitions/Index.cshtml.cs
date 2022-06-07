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
    public class IndexModel : PageModel
    {
        private readonly RockMuseumUI.Data.RockMuseumUIContext _context;

        public IndexModel(RockMuseumUI.Data.RockMuseumUIContext context)
        {
            _context = context;
        }

        public IList<ExhibitionCollection> ExhibitionCollection { get;set; }

        public async Task OnGetAsync()
        {
            ExhibitionCollection = await _context.ExhibitionCollection.ToListAsync();
        }
    }
}
