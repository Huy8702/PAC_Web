using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PAC_Web.Data.Infrastructure
{
    public interface IDbFactory : IDisposable
    {
        PAC_WebDbContext Init();
    }
}
