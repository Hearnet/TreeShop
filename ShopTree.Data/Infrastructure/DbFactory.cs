using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopTree.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private ShopTreeDbContext dbContext;

        public ShopTreeDbContext Init()
        {
            return dbContext ?? (dbContext = new ShopTreeDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
