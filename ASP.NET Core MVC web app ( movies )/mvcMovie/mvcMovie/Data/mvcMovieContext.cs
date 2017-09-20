using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mvcMovie.Model;

namespace mvcMovie.Models
{
    public class mvcMovieContext : DbContext
    {
        public mvcMovieContext (DbContextOptions<mvcMovieContext> options)
            : base(options)
        {
        }

        public DbSet<mvcMovie.Model.Movie> Movie { get; set; }
    }
}
