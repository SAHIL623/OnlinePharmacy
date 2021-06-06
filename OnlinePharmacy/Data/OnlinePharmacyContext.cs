using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlinePharmacy.Models;

namespace OnlinePharmacy.Data
{
    public class OnlinePharmacyContext : DbContext
    {
        public OnlinePharmacyContext (DbContextOptions<OnlinePharmacyContext> options)
            : base(options)
        {
        }

        public DbSet<OnlinePharmacy.Models.Medicine> Medicine { get; set; }

        public DbSet<OnlinePharmacy.Models.OrderMedicine> OrderMedicine { get; set; }

        public DbSet<OnlinePharmacy.Models.Feedback> Feedback { get; set; }
    }
}
