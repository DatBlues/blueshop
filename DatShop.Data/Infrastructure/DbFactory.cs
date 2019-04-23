using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatShop.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        DatShopDbContext dbContext;
        public DatShopDbContext Init()
        {
            return dbContext ?? (dbContext = new DatShopDbContext());

        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
