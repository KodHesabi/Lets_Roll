using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lets_Roll
{
    class KarekterlerContext:DbContext

    {
        public DbSet<Waifu> Waifu { get; set; }
        public DbSet<Husband> Husband { get; set; }

        public DbSet<MixTablosu> MixTablosu { get; set; }
        public DbSet<DateSayac> DateSayac { get; set; }
    }
}
