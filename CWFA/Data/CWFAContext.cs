using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CWFA.Model;

namespace CWFA.Data
{
    public class CWFAContext : DbContext
    {
        public CWFAContext (DbContextOptions<CWFAContext> options)
            : base(options)
        {
        }

        public DbSet<CWFA.Model.user> user { get; set; } = default!;
    }
}
