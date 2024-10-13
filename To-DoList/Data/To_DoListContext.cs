using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using To_DoList.Models;

namespace To_DoList.Data
{
    public class To_DoListContext : DbContext
    {
        public To_DoListContext (DbContextOptions<To_DoListContext> options)
            : base(options)
        {
        }

        public DbSet<To_DoList.Models.Task> Task { get; set; } = default!;
    }
}
