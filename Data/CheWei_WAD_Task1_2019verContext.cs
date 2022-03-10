using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CheWei_WAD_Task1_2019ver.Models
{
    public class CheWei_WAD_Task1_2019verContext : DbContext
    {
        public CheWei_WAD_Task1_2019verContext (DbContextOptions<CheWei_WAD_Task1_2019verContext> options)
            : base(options)
        {
        }

        public DbSet<CheWei_WAD_Task1_2019ver.Models.Movie> Movie { get; set; }
    }
}
