using IChipo.Repository.EF.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace IChipo.Repository.EF
{
   public class GodContext : DbContext
    {
        public GodContext(DbContextOptions<GodContext> options)
            : base(options)
        {
        }

        public DbSet<God> TodoItems { get; set; }
    }
}