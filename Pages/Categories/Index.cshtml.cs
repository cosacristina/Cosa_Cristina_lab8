using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Cosa_Cristina_lab8.Data;
using Cosa_Cristina_lab8.Models;

namespace Cosa_Cristina_lab8.Pages.Categories
{
    public class IndexModel : PageModel
    {
        private readonly Cosa_Cristina_lab8.Data.Cosa_Cristina_lab8Context _context;

        public IndexModel(Cosa_Cristina_lab8.Data.Cosa_Cristina_lab8Context context)
        {
            _context = context;
        }

        public IList<Category> Category { get;set; }

        public async Task OnGetAsync()
        {
            Category = await _context.Category.ToListAsync();
        }
    }
}
