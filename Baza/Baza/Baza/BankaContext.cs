
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baza.Baza
{
    public class BankaContext : DbContext
    {

        public DbSet<BankaKrvi> BankeKrvi { get; set; }
        public DbSet<Donor> Donori { get; set; }
        public DbSet<Pacijent> Pacijenti { get; set; }
        public DbSet<JedinicaTransfuzije> JediniceTransfuzije { get; set; }
        
    }
}
