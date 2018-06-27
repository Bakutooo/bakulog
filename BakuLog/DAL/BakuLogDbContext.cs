using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BakuLog.Models;

namespace BakuLog.DAL
{
    public class BakuLogDbContext : DbContext
    {
        public DbSet<Post> Posts { get; set; }

        public BakuLogDbContext() : base("BakuLogDbContext")
        {
        }
    }
}