using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using net_WebCore_trials.Models;

namespace net_WebCore_trials.Data
{
    public class net_WebCore_trialsContext : DbContext
    {
        public net_WebCore_trialsContext (DbContextOptions<net_WebCore_trialsContext> options)
            : base(options)
        {
        }

        public DbSet<net_WebCore_trials.Models.Movie> Movie { get; set; }
    }
}
