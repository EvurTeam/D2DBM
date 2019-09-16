using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace D2DBM
{
    public class HeroContext : DbContext
    {
        public DbSet<HeroModel> Heroes { set; get; } 

        public HeroContext() : base(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=D2DB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {

        }


    }
}
