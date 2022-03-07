using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ahram_Clinic.Models;

namespace Ahram_Clinic.Models
{
    public class AhramClinicDBContext : DbContext
    {
        public  AhramClinicDBContext(DbContextOptions<AhramClinicDBContext> options): base (options)
            {

            }
        public DbSet<Doctors> Doc { get; set; }
        public DbSet<Nurses> Nur { get; set; }
        public DbSet<Patients> Pat { get; set; }

    }
}
