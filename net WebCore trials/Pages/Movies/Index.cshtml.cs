using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using net_WebCore_trials.Data;
using net_WebCore_trials.Models;

namespace net_WebCore_trials.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly net_WebCore_trials.Data.net_WebCore_trialsContext _context;

        public IndexModel(net_WebCore_trials.Data.net_WebCore_trialsContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
