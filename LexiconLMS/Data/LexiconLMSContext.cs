using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LexiconLMS.Models;

namespace LexiconLMS.Data
{
    public class LexiconLMSContext : DbContext
    {
        public LexiconLMSContext (DbContextOptions<LexiconLMSContext> options)
            : base(options)
        {
        }

        public DbSet<LexiconLMS.Models.Activities> Activities { get; set; }

        public DbSet<LexiconLMS.Models.Course> Course { get; set; }

        public DbSet<LexiconLMS.Models.Group> Group { get; set; }
    }
}
