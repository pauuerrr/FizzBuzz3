using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FizzBuzz3.Models;

namespace FizzBuzz3.Data
{
    public class FizzBuzzContext : DbContext
    {
        public FizzBuzzContext(DbContextOptions options) : base(options) { }
        public DbSet<FizzBuzz> FizzBuzz { get; set; }
    }
}
