using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAC_Web.Data.Infrastructure
{
    public class DbFactory : Disposable, IDbFactory
    {
        private PAC_WebDbContext dbContext;      

        public PAC_WebDbContext Init()
        {
            return dbContext ?? (dbContext = new PAC_WebDbContext());
        }

        protected override void DisposeCore()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }
    }
}
