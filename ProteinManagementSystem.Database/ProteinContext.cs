using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProteinManagementSystem.Database
{
    public class ProteinContext : DbContext
    {
        public DbSet<Protein> Proteins { get; set; }
    }
}
