using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASP.NETCORE.Models;

namespace ASP.NETCORE.Repositoty
{
    public class BrandRepository
    {
        private GlobalToyzContext _ctx = null;

        public BrandRepository(GlobalToyzContext ctx)
        {
            _ctx = ctx;
        }
        public List<ToyBrand> getAllBrands()
        {
            return _ctx.ToyBrands.ToList();
        }
    }
}
