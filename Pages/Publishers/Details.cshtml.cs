using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cosa_Cristina_lab8.Data;
using Cosa_Cristina_lab8.Models;

namespace Cosa_Cristina_lab8.Pages.Publishers
{
    public class DetailsModel : PageModel
    {
        private readonly Cosa_Cristina_lab8.Data.Cosa_Cristina_lab8Context _context;

        public DetailsModel(Cosa_Cristina_lab8.Data.Cosa_Cristina_lab8Context context)
        {
            _context = context;
        }

        public Publisher Publisher { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Publisher = await _context.Publisher.FirstOrDefaultAsync(m => m.ID == id);

            if (Publisher == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
