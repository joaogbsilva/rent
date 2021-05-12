using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace RentWebMvc.Models
{
    public class RentWebMvcContext : DbContext
    {
        public RentWebMvcContext (DbContextOptions<RentWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<RentWebMvc.Models.Imovel> Imovel { get; set; }
    }
}
