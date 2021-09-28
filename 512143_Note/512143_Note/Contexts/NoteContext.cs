using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _512143_Note.Models;

namespace _512143_Note.Contexts
{
    public class NoteContext : DbContext
    {
        public NoteContext (DbContextOptions<NoteContext> options)
            : base(options)
        {
        }

        public DbSet<Notes> Notes { get; set; }
    }
}
